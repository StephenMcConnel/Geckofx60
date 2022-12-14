#region ***** BEGIN LICENSE BLOCK *****

/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */

#endregion END LICENSE BLOCK

using System;
using System.Collections;
using System.Runtime.InteropServices;
using Gecko.Interop;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Gecko
{
    /// <summary>
    /// Creates a scoped, fake "system principal" security context.  This class is used primarly to work around bugs in gecko
    /// which prevent methods on nsIDOMCSSStyleSheet from working outside of javascript.
    /// </summary>
    public class AutoJSContext : IDisposable
    {
        #region fields

        private static Stack<AutoJSContext> _contextStack = new Stack<AutoJSContext>();

        private readonly IntPtr _cx;
        private readonly nsISupports _window;
        private readonly IntPtr _windowPtrNonRefCounted;
        private JSAutoCompartment _defaultCompartment;
        private nsIXPCComponents _nsIXPCComponents;
        private IntPtr _globalJSObject;

        /// <summary>
        /// These static fields allow AutoJSContext(IntPtr context) to work.
        /// </summary>
        private static Dictionary<IntPtr, IntPtr> _contextToGlobalDictionary = new Dictionary<IntPtr, IntPtr>();

        private static IntPtr _safeContext;

        /// <summary>
        /// Store all the COM objects, that we have addrefed, before using WrapNative to create JSObjects wrappers.
        /// We keep track of this on a per window basis, using the IUnknown values for the window, as the dictionary key.
        /// The HashSet contains the IUnknown for each object that we have wrapped with a JSOBject, for a given window.
        /// </summary>
        private static Dictionary<IntPtr, HashSet<IntPtr>> _wrappedComObjectsReferences = new Dictionary<IntPtr, HashSet<IntPtr>>();

        private bool _suspendGC;

        #endregion

        #region Properties

        public static AutoJSContext Current
        {
            get
            {
                if (_contextStack.Count == 0)
                    return null;

                return _contextStack.Peek();
            }
        }

        public IntPtr ContextPointer
        {
            get { return _cx; }
        }

        #endregion

        #region Connstructors

        public AutoJSContext(GeckoWindow window, bool suspendGC = false) :
            this((nsIGlobalObject)window.DomWindow, suspendGC)
        {
        }

        public AutoJSContext(mozIDOMWindowProxy window, bool suspendGC = false) :
            this((nsIGlobalObject) window, suspendGC)
        {
        }

        public AutoJSContext(nsISupports window, bool suspendGC = false) :
            this((nsIGlobalObject)window, suspendGC)
        {
        }

        public AutoJSContext(mozIDOMWindow window, bool suspendGC = false) :
        this((nsIGlobalObject)window, suspendGC)
        {
        }

        public AutoJSContext(nsIGlobalObject window, bool suspendGC = false)
        {
            var context = SafeJSContext;
            var go = (nsIGlobalObject) window;

            using (var xpc = new ComPtr<nsIGlobalObject>(go, false))
            {
                int slot = xpc.GetSlotOfComMethod(new Func<IntPtr>(go.GetGlobalJSObject));
                var getGlobalJSObject = xpc.GetComMethod<GetGlobalJSObject>(Xpcom.IsLinux ? 3 : slot);
                _globalJSObject = getGlobalJSObject(go);
                if (_globalJSObject == IntPtr.Zero)
                    throw new ArgumentException(
                        "Window does not have a global JSObject. Purhaps the window doesn't have an initalized document?");

                _contextToGlobalDictionary[context] = _globalJSObject;
                _defaultCompartment = new JSAutoCompartment(SafeJSContext, _globalJSObject);
                _cx = context;
                _window = (nsISupports)window;
                // Store the non refcounted IUnknown Ptr. 
                // We use this as a unique key to the COM object, rather than as a ptr.
                _windowPtrNonRefCounted  = Marshal.GetIUnknownForObject(_window);
                Marshal.Release(_windowPtrNonRefCounted);
            }

            _contextStack.Push(this);

            _suspendGC = suspendGC;
            if (_suspendGC)
                SpiderMonkey.JS_SuspendGC();
        }        
#endregion

#region EvaluateScriptMethods

        /// <summary>
        /// Evaluate javascript in the current context, in the global scope.
        /// </summary>
        /// <param name="jsScript"></param>
        /// <param name="result"></param>
        /// <returns>result of javascript as string.</returns>
        public bool EvaluateScript(string jsScript, out string result)
        {
            var ptr = new JsVal();
            bool ret = SpiderMonkey.JS_EvaluateScript(ContextPointer, jsScript, (uint) jsScript.Length, "script", 1,
                ref ptr);

            result = ret ? ConvertValueToString(ptr) : null;
            return ret;
        }

        /// <summary>
        /// Evaluate javascript in specified window.
        /// Throws GeckoJavaScriptException on error.
        /// </summary>
        /// <param name="javascript"></param>
        /// <param name="window"></param>
        /// <returns>result of javascript as JsVal</returns>
        public JsVal EvaluateScript(string javascript, mozIDOMWindow window)
        {
            return EvaluateScript(javascript, (nsISupports) window, (nsISupports) window);
        }

        public JsVal EvaluateScript(string javascript, nsISupports window)
        {
            return EvaluateScript(javascript, window, window);
        }

        /// <summary>
        /// Evaluate JavaScript in specified window, and with specified scope.
        /// Throws GeckoJavaScriptException on error.
        /// </summary>
        /// <param name="javascript">The javascript to run.</param>
        /// <param name="window">The window to execuate javascript in. (ie. the global object)</param>
        /// <param name="scope">object to use as scope.</param>
        /// <returns>The return value of the script as a JsVal</returns>
        public JsVal EvaluateScript(string javascript, nsISupports window, nsISupports scope)
        {
            string msg = String.Empty;
            JsVal exceptionJsVal = default(JsVal);
            
            using (var globalObject = ConvertCOMObjectToJSObject(window))
            using (new JSAutoCompartment(ContextPointer, globalObject.JSObject))
            {
                var retJsVal = new JsVal();
                bool ret;
                // If not running in window scope.
                if (window != scope)
                {
                    using (var scopeObject = ConvertCOMObjectToJSObject(scope))
                    {
                        var scopeJSVal = JsVal.FromPtr(scopeObject.JSObject);
                        var go = globalObject.JSObject;
                        if (!SpiderMonkey.JS_SetProperty(ContextPointer, ref go, "__RequestedScope",
                                ref scopeJSVal))
                            throw new GeckoException("Failed to set __RequestedScope Property.");

                        javascript = InsertReturnStatement(javascript);
                        string s = "(function() { " + javascript + " }).call(this.__RequestedScope)";

                        ret = SpiderMonkey.JS_EvaluateScript(ContextPointer, s, (uint) s.Length, "script", 1,
                            ref retJsVal);
                    }
                }
                else
                {
                    ret = SpiderMonkey.JS_EvaluateScript(ContextPointer, javascript, (uint) javascript.Length,
                        "script", 1, ref retJsVal);
                }

                if (ret) 
                    return retJsVal;

                var exception = SpiderMonkey.JS_GetPendingException(ContextPointer);
                if (exception != IntPtr.Zero)
                    exceptionJsVal = JsVal.FromPtr(exception);
                msg += exceptionJsVal.ToString();
                msg += SpiderMonkey.GetStackTrace(ContextPointer, globalObject.JSObject, exceptionJsVal);
                throw new GeckoJavaScriptException($"JSError : {msg}");
            }
        }

        /// <summary>
        /// Evaluate JavaScript in the current context, in the global scope.
        /// Throws GeckoJavaScriptException on error.
        /// </summary>
        /// <param name="javaScript"></param>
        /// <returns></returns>
        public JsVal EvaluateScript(string javaScript)
        {
            return EvaluateScript(javaScript, _window);
        }


        /// <summary>
        /// Evaluate javascript in the current context, using specified scope.
        /// </summary>
        /// <param name="jsScript"></param>
        /// <param name="thisObject">a nsISupports com object that this (the scope) is set too.</param>
        /// <param name="result">The result of the operation as a string.</param>
        /// <returns>true on success, false on failure.</returns>
        public bool EvaluateScript(string jsScript, nsISupports thisObject, out string result)
        {
            result = null;
            try
            {
                result = ConvertValueToString(EvaluateScript(jsScript, (nsISupports) _window, thisObject));
            }
            catch (GeckoJavaScriptException exception)
            {
                return false;
            }

            return true;
        }

#endregion

#region static methods

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        private static extern IntPtr NS_GetSafeJSContext();

        public static IntPtr SafeJSContext
        {
            get
            {
                if (_safeContext == IntPtr.Zero)
                {
                    _safeContext = NS_GetSafeJSContext();
                }
                return _safeContext;
            }
        }

        public nsISupports Window
        {
            get { return _window; }
        }

        /// <summary>
        /// Helper method which attempts to find the global object in a Context.
        /// </summary>
        /// <returns>the Global object ptr or Null/Zero ptr if not found.</returns>
        internal static IntPtr GetGlobalFromContext(IntPtr context)
        {
            IntPtr globalObject = IntPtr.Zero;
            if (globalObject == IntPtr.Zero)
            {
                if (_contextToGlobalDictionary.ContainsKey(context))
                    return _contextToGlobalDictionary[context];
            }

            return globalObject;
        }

#endregion

#region Non Public methods

        /// <summary>
        /// Helper method for EvaluateScript.
        /// Tries to insert a return statement into a set of js statements that are going to be embeded into a function.
        /// </summary>
        /// <param name="js"></param>
        private string InsertReturnStatement(string js)
        {
            js = js.TrimEnd(' ', ';');
            var semiColons = js.Count(x => x == ';');
            if (semiColons == 0 && !js.Contains("return"))
                return "return " + js + ";";

            var index = Math.Max(js.LastIndexOf(';'), js.LastIndexOf('}'));
            var sub = js.Substring(index + 1);
            if (sub.Contains("return"))
                return js;

            return js.Substring(0, index + 1) + " return " + js.Substring(index + 1) + ";";
        }

        internal string ConvertValueToString(JsVal value)
        {
            // OLD SLOW CODE
            // if (value.IsString)
            // {
            //    var v = Xpcom.XPConnect.Instance.JSValToVariant(ContextPointer, ref value);
            //    return nsString.Get(v.GetAsAString);
            //}

            return SpiderMonkey.JsValToString(this._cx, value);
        }

        // TODO: move to own class + file.
        public sealed class JSObjectWrapper : IDisposable
        {
            private readonly IntPtr _iunknown;
            private bool disposed;

            internal JSObjectWrapper(IntPtr iunknown)
            {
                _iunknown = iunknown;
            }

            public IntPtr JSObject { get; internal set; }

            public void Dispose()
            {
                disposed = true;
                GC.SuppressFinalize(this);

                if (_iunknown == IntPtr.Zero)
                    return;

                Marshal.Release(_iunknown);
            }

            ~JSObjectWrapper()
            {
                if (disposed)
                    return;

                Debug.Fail("Missing dispose!");
                Dispose();

            }
        }

        /// <summary>
        /// The first time we convert a COMObject instance to a JSObject, we need to addref it.
        /// When the browser is destoryed or the page is reloaded then we need to release all these references
        /// to prevent memory leaks. (Cycle collect quickly gets very slow)
        /// </summary>
        public void ReleaseWrapedNativeReferences()
        {
            var list = GetWrappedComObjectsList();
            if (list == null)
                return;
            
            var copies = list.ToArray();
            list.Clear();
            foreach (var c in copies)
                Marshal.Release(c);
        }

        /// <summary>
        /// Returns the current list of wrapped COM objects for this JS context current window.
        /// </summary>
        /// <returns>The lost or null if one doesn't exist.</returns>
        private HashSet<IntPtr> GetWrappedComObjectsList()
        {
            if (_windowPtrNonRefCounted == IntPtr.Zero || !_wrappedComObjectsReferences.ContainsKey(_windowPtrNonRefCounted))
                return null;

            return _wrappedComObjectsReferences[_windowPtrNonRefCounted];
        }

        private void EnsureWrappedComObjectListExistsForThisWindow()
        {
            if (!_wrappedComObjectsReferences.ContainsKey(_windowPtrNonRefCounted))
                _wrappedComObjectsReferences[_windowPtrNonRefCounted] = new HashSet<IntPtr>();
        }

        internal JSObjectWrapper ConvertCOMObjectToJSObject(nsISupports obj)
        {
            Guid guid = typeof (nsISupports).GUID;

            IntPtr globalObject = GetGlobalFromContext(ContextPointer);
            if (obj is nsIXPConnectWrappedJS)
                throw new GeckoException("Can't call WrapNative on Wrapped JSObject.");

            // Calling GetIUnknownForObject for the addref.
            IntPtr ptr = IntPtr.Zero;
            ptr = Marshal.GetIUnknownForObject(obj);
            EnsureWrappedComObjectListExistsForThisWindow();
            var list = GetWrappedComObjectsList();
            if (list.Contains(ptr))
                Marshal.Release(ptr);
            else
                list.Add(ptr);

            var jsObject = Xpcom.XPConnect.Instance.WrapNative(ContextPointer, globalObject, obj, ref guid);

            var ret = new JSObjectWrapper(Marshal.GetIUnknownForObject(obj))
            {
                JSObject = jsObject
            };

            var js = ret.JSObject;

            return ret;
        }

        /// <summary>
        /// Gets the nsIXPCComponents which is the javascript 'Components' objects
        /// The Components objects is the main object XPConnect object.        
        /// </summary>
        /// <returns></returns>
        internal nsIXPCComponents GetComponentsObject()
        {
            if (_nsIXPCComponents == null)
            {
                var jsValue = new JsVal();
                SpiderMonkey.JS_ExecuteScript(ContextPointer, "this.myfunc = function(p1) { return Components; };",
                    out jsValue);

                jsValue = SpiderMonkey.JS_CallFunctionName(ContextPointer, _globalJSObject, "myfunc", new[] {jsValue});

                _nsIXPCComponents = Xpcom.QueryInterface<nsIXPCComponents>(jsValue.ToObject());
                if (_nsIXPCComponents == null)
                    throw new GeckoException(String.Format(
                        "Components object does not implement nsIXPCComponents. {0}", jsValue));
            }

            return _nsIXPCComponents;
        }        

#endregion

#region IDisposable implementation.

        public void Dispose()
        {
#if DEBUG
            if (_contextStack.Peek() != this)
                throw new Exception("Missing dispose.");
#endif
            if (_suspendGC)
                SpiderMonkey.JS_ResumeGC();

            _contextStack.Pop();

            if (_defaultCompartment != null)
                _defaultCompartment.Dispose();
            _defaultCompartment = null;

            GC.SuppressFinalize(this);
        }

#endregion
    }
}
