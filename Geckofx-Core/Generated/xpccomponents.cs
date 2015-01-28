// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file xpccomponents.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// interface of Components.interfacesByID
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c99cffac-5aed-4267-ad2f-f4a4c9d4a081")]
	public interface nsIXPCComponents_InterfacesByID
	{
	}
	
	/// <summary>
    /// interface of Components.interfaces
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b8c31bba-79db-4a1d-930d-4cdd68713f9e")]
	public interface nsIXPCComponents_Interfaces
	{
	}
	
	/// <summary>
    /// interface of Components.classes
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("978ff520-d26c-11d2-9842-006008962422")]
	public interface nsIXPCComponents_Classes
	{
	}
	
	/// <summary>
    /// interface of Components.classesByID
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("336a9590-4d19-11d3-9893-006008962422")]
	public interface nsIXPCComponents_ClassesByID
	{
	}
	
	/// <summary>
    /// interface of Components.results
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2fc229a0-5860-11d3-9899-006008962422")]
	public interface nsIXPCComponents_Results
	{
	}
	
	/// <summary>
    /// interface of Components.ID
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7994a6e0-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_ID
	{
	}
	
	/// <summary>
    /// interface of Components.Exception
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5bf039c0-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_Exception
	{
	}
	
	/// <summary>
    /// interface of Components.Constructor
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("88655640-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_Constructor
	{
	}
	
	/// <summary>
    /// interface of object returned by Components.Constructor
    /// (additional interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c814ca20-e0dc-11d3-8f5f-0010a4e73d9a")]
	public interface nsIXPCConstructor
	{
		
		/// <summary>
        /// interface of object returned by Components.Constructor
        /// (additional interesting stuff only reflected into JavaScript) </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIJSCID GetClassIDAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIJSIID GetInterfaceIDAttribute();
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetInitializerAttribute();
	}
	
	/// <summary>
    /// interface of object returned by Components.utils.Sandbox. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4f8ae0dc-d266-4a32-875b-6a9de71a8ce9")]
	public interface nsIXPCComponents_utils_Sandbox
	{
	}
	
	/// <summary>
    /// interface for callback to be passed to Cu.schedulePreciseGC
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("71000535-b0fd-44d1-8ce0-909760e3953c")]
	public interface ScheduledGCCallback
	{
		
		/// <summary>
        /// interface for callback to be passed to Cu.schedulePreciseGC
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Callback();
	}
	
	/// <summary>
    /// interface of Components.utils </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("45b80e00-fb0d-439e-b7bf-54f24af0c4a6")]
	public interface nsIXPCComponents_Utils
	{
		
		/// <summary>
        ///reportError is designed to be called from JavaScript only.
        ///
        /// It will report a JS Error object to the JS console, and return. It
        /// is meant for use in exception handler blocks which want to "eat"
        /// an exception, but still want to report it to the console.
        ///
        /// It must be called with one param, usually an object which was caught by
        /// an exception handler.  If it is not a JS error object, the parameter
        /// is converted to a string and reported as a new error.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReportError(Gecko.JsVal error, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_utils_Sandbox GetSandboxAttribute();
		
		/// <summary>
        /// evalInSandbox is designed to be called from JavaScript only.
        ///
        /// evalInSandbox evaluates the provided source string in the given sandbox.
        /// It returns the result of the evaluation to the caller.
        ///
        /// var s = new C.u.Sandbox("http://www.mozilla.org");
        /// var res = C.u.evalInSandbox("var five = 5; 2 + five", s);
        /// var outerFive = s.five;
        /// s.seven = res;
        /// var thirtyFive = C.u.evalInSandbox("five * seven", s);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal EvalInSandbox([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase source, Gecko.JsVal sandbox, Gecko.JsVal version, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase filename, int lineNo, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// getSandboxMetadata is designed to be called from JavaScript only.
        ///
        /// getSandboxMetadata retrieves the metadata associated with
        /// a sandbox object. It will return undefined if there
        /// is no metadata attached to the sandbox.
        ///
        /// var s = C.u.Sandbox(..., { metadata: "metadata" });
        /// var metadata = C.u.getSandboxMetadata(s);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetSandboxMetadata(Gecko.JsVal sandbox, System.IntPtr jsContext);
		
		/// <summary>
        /// setSandboxMetadata is designed to be called from JavaScript only.
        ///
        /// setSandboxMetadata sets the metadata associated with
        /// a sandbox object.
        ///
        /// Note that the metadata object will be copied before being used.
        /// The copy will be performed using the structured clone algorithm.
        /// Note that this algorithm does not support reflectors and
        /// it will throw if it encounters them.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSandboxMetadata(Gecko.JsVal sandbox, Gecko.JsVal metadata, System.IntPtr jsContext);
		
		/// <summary>
        /// import is designed to be called from JavaScript only.
        ///
        /// Synchronously loads and evaluates the js file located at
        /// 'registryLocation' with a new, fully privileged global object.
        ///
        /// If 'targetObj' is specified and equal to null, returns the
        /// module's global object. Otherwise (if 'targetObj' is not
        /// specified, or 'targetObj' is != null) looks for a property
        /// 'EXPORTED_SYMBOLS' on the new global object. 'EXPORTED_SYMBOLS'
        /// is expected to be an array of strings identifying properties on
        /// the global object.  These properties will be installed as
        /// properties on 'targetObj', or, if 'targetObj' is not specified,
        /// on the caller's global object. If 'EXPORTED_SYMBOLS' is not
        /// found, an error is thrown.
        ///
        /// @param resourceURI A resource:// URI string to load the module from.
        /// @param targetObj  the object to install the exported properties on.
        /// If this parameter is a primitive value, this method throws
        /// an exception.
        /// @returns the module code's global object.
        ///
        /// The implementation maintains a hash of registryLocation->global obj.
        /// Subsequent invocations of importModule with 'registryLocation'
        /// pointing to the same file will not cause the module to be re-evaluated,
        /// but the symbols in EXPORTED_SYMBOLS will be exported into the
        /// specified target object and the global object returned as above.
        ///
        /// (This comment is duplicated from xpcIJSModuleLoader.)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal Import([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aResourceURI, Gecko.JsVal targetObj, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// Unloads the JS module at 'registryLocation'. Existing references to the
        /// module will continue to work but any subsequent import of the module will
        /// reload it and give new reference. If the JS module hasn't yet been
        /// imported then this method will do nothing.
        ///
        /// @param resourceURI A resource:// URI string to unload the module from.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unload([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase registryLocation);
		
		/// <summary>
        /// Imports global properties (like DOM constructors) into the scope, defining
        /// them on the caller's global. aPropertyList should be an array of property
        /// names.
        ///
        /// See xpc::GlobalProperties::Parse for the current list of supported
        /// properties.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ImportGlobalProperties(Gecko.JsVal aPropertyList, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Return a weak reference for the given JS object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		xpcIJSWeakReference GetWeakReference(Gecko.JsVal obj, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Force an immediate garbage collection cycle.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceGC();
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Force an immediate cycle collection cycle.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceCC();
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Force an immediate shrinking garbage collection cycle.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceShrinkingGC();
		
		/// <summary>
        /// Schedule a garbage collection cycle for a point in the future when no JS
        /// is running. Call the provided function once this has occurred.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SchedulePreciseGC(ScheduledGCCallback callback);
		
		/// <summary>
        /// Schedule a shrinking garbage collection cycle for a point in the future
        /// when no JS is running. Call the provided function once this has occured.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SchedulePreciseShrinkingGC(ScheduledGCCallback callback);
		
		/// <summary>
        /// In a debug build, unlink any ghost windows. This is only for debugging
        /// leaks, and can cause bad things to happen if called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlinkGhostWindows();
		
		/// <summary>
        /// Return the keys in a weak map.  This operation is
        /// non-deterministic because it is affected by the scheduling of the
        /// garbage collector and the cycle collector.
        ///
        /// This should only be used to write tests of the interaction of
        /// the GC and CC with weak maps.
        ///
        /// @param aMap weak map or other JavaScript value
        /// @returns If aMap is a weak map object, return the keys of the weak
        ///                map as an array.  Otherwise, return undefined.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal NondeterministicGetWeakMapKeys(Gecko.JsVal aMap, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetJSTestingFunctions(System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Returns the global object with which the given object is associated.
        ///
        /// @param obj The JavaScript object whose global is to be gotten.
        /// @return the corresponding global.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetGlobalForObject(ref Gecko.JsVal obj, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Returns the true if the object is a (scripted) proxy.
        /// NOTE: Security wrappers are unwrapped first before the check.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsProxy(Gecko.JsVal vobject, System.IntPtr jsContext);
		
		/// <summary>
        /// Similar to evalInSandbox except this one is used to eval a script in the
        /// scope of a window. Also note, that the return value and the possible exceptions
        /// in the script are structured cloned, unless they are natives (then they are just
        /// wrapped).
        /// Principal of the caller must subsume the target's.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal EvalInWindow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase source, ref Gecko.JsVal window, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Instead of simply wrapping a function into another compartment,
        /// this helper function creates a native function in the target
        /// compartment and forwards the call to the original function.
        /// That call will be different than a regular JS function call in
        /// that, the |this| is left unbound, and all the non-native JS
        /// object arguments will be cloned using the structured clone
        /// algorithm.
        /// The return value is the new forwarder function, wrapped into
        /// the caller's compartment.
        /// The 3rd argument is an optional options object:
        /// - defineAs: the name of the property that will
        /// be set on the target scope, with
        /// the forwarder function as the value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal ExportFunction(Gecko.JsVal vfunction, Gecko.JsVal vscope, Gecko.JsVal voptions, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Returns an object created in |vobj|'s compartment.
        /// If defineAs property on the options object is a non-null ID,
        /// the new object will be added to vobj as a property. Also, the
        /// returned new object is always automatically waived (see waiveXrays).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal CreateObjectIn(Gecko.JsVal vobj, Gecko.JsVal voptions, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Ensures that all functions come from vobj's scope (and aren't cross
        /// compartment wrappers).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MakeObjectPropsNormal(Gecko.JsVal vobj, System.IntPtr jsContext);
		
		/// <summary>
        /// Determines whether this object is backed by a DeadObjectProxy.
        ///
        /// Dead-wrapper objects hold no other objects alive (they have no outgoing
        /// reference edges) and will throw if you touch them (e.g. by
        /// reading/writing a property).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDeadWrapper(Gecko.JsVal obj);
		
		/// <summary>
        /// To be called from JS only. This is for Gecko internal use only, and may
        /// disappear at any moment.
        ///
        /// Forces a recomputation of all wrappers in and out of the compartment
        /// containing |vobj|. If |vobj| is not an object, all wrappers system-wide
        /// are recomputed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RecomputeWrappers(Gecko.JsVal vobj, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only. This is for Gecko internal use only, and may
        /// disappear at any moment.
        ///
        /// Enables Xray vision for same-compartment access for the compartment
        /// indicated by |vscope|. All outgoing wrappers are recomputed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWantXrays(Gecko.JsVal vscope, System.IntPtr jsContext);
		
		/// <summary>
        /// Forces the usage of a privileged |Components| object for a potentially-
        /// unprivileged scope. This will crash if used outside of automation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForcePrivilegedComponentsForScope(Gecko.JsVal vscope, System.IntPtr jsContext);
		
		/// <summary>
        /// This seemingly-paradoxical API allows privileged code to explicitly give
        /// unprivileged code a reference to its own Components object (whereas it's
        /// normally hidden away on a scope chain visible only to XBL methods). See
        /// also SpecialPowers.getComponents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetComponentsForScope(Gecko.JsVal vscope, System.IntPtr jsContext);
		
		/// <summary>
        /// Dispatches a runnable to the current/main thread. If |scope| is passed,
        /// the runnable will be dispatch in the compartment of |scope|, which
        /// affects which error reporter gets called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Dispatch(Gecko.JsVal runnable, Gecko.JsVal scope, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// These are the set of JSContext options that privileged script
        /// is allowed to control for the purposes of testing.  These
        /// options should be kept in sync with what's controllable in the
        /// jsshell and by setting prefs in nsJSEnvironment.
        ///
        /// NB: Assume that getting any of these attributes is relatively
        /// cheap, but setting any of them is relatively expensive.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStrictAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// These are the set of JSContext options that privileged script
        /// is allowed to control for the purposes of testing.  These
        /// options should be kept in sync with what's controllable in the
        /// jsshell and by setting prefs in nsJSEnvironment.
        ///
        /// NB: Assume that getting any of these attributes is relatively
        /// cheap, but setting any of them is relatively expensive.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStrictAttribute([MarshalAs(UnmanagedType.U1)] bool aStrict, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetWerrorAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWerrorAttribute([MarshalAs(UnmanagedType.U1)] bool aWerror, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStrict_modeAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStrict_modeAttribute([MarshalAs(UnmanagedType.U1)] bool aStrict_mode, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIonAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIonAttribute([MarshalAs(UnmanagedType.U1)] bool aIon, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGCZeal(int zeal, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NukeSandbox(Gecko.JsVal obj, System.IntPtr jsContext);
		
		/// <summary>
        /// API to dynamically block script for a given global. This takes effect
        /// immediately, unlike other APIs that only affect newly-created globals.
        ///
        /// The machinery here maintains a counter, and allows script only if each
        /// call to blockScriptForGlobal() has been matched with a call to
        /// unblockScriptForGlobal(). The caller _must_ make sure never to call
        /// unblock() more times than it calls block(), since that could potentially
        /// interfere with another consumer's script blocking.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BlockScriptForGlobal(Gecko.JsVal global, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnblockScriptForGlobal(Gecko.JsVal global, System.IntPtr jsContext);
		
		/// <summary>
        /// Check whether the given object is an XrayWrapper.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsXrayWrapper(ref Gecko.JsVal obj);
		
		/// <summary>
        /// Waive Xray on a given value. Identity op for primitives.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        Gecko.JsVal WaiveXrays(ref Gecko.JsVal aVal, System.IntPtr jsContext);
		
		/// <summary>
        /// Strip off Xray waivers on a given value. Identity op for primitives.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal UnwaiveXrays(ref Gecko.JsVal aVal, System.IntPtr jsContext);
		
		/// <summary>
        /// Gets the name of the JSClass of the object.
        ///
        /// if |aUnwrap| is true, all wrappers are unwrapped first. Unless you're
        /// specifically trying to detect whether the object is a proxy, this is
        /// probably what you want.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetClassName(Gecko.JsVal aObj, [MarshalAs(UnmanagedType.U1)] bool aUnwrap, System.IntPtr jsContext);
		
		/// <summary>
        /// Get a DOM classinfo for the given classname.  Only some class
        /// names are supported.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIClassInfo GetDOMClassInfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aClassName);
		
		/// <summary>
        /// Gets the incument global for the execution of this function. For internal
        /// and testing use only.
        ///
        /// If |callback| is passed, it is invoked with the incumbent global as its
        /// sole argument. This allows the incumbent global to be measured in callback
        /// environments with no scripted frames on the stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetIncumbentGlobal(Gecko.JsVal callback, System.IntPtr jsContext);
		
		/// <summary>
        /// Forces the generation of an XPCWrappedJS for a given object. For internal
        /// and testing use only. This is only useful to set up wrapper map conditions
        /// for a testcase. The return value is not an XPCWrappedJS itself, but an
        /// opaque nsISupports holder that keeps the underlying XPCWrappedJS alive.
        ///
        /// if |scope| is passed, the XPCWrappedJS is generated in the scope of that object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GenerateXPCWrappedJS(Gecko.JsVal obj, Gecko.JsVal scope, System.IntPtr jsContext);
		
		/// <summary>
        /// Retrieve the last time, in microseconds since epoch, that a given
        /// watchdog-related event occured.
        ///
        /// Valid categories:
        /// "RuntimeStateChange"      - Runtime switching between active and inactive states
        /// "WatchdogWakeup"          - Watchdog waking up from sleeping
        /// "WatchdogHibernateStart"  - Watchdog begins hibernating
        /// "WatchdogHibernateStop"   - Watchdog stops hibernating
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetWatchdogTimestamp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCategory);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetJSEngineTelemetryValue(System.IntPtr jsContext);
		
		/// <summary>
        /// Clone an object into a scope.
        /// The 3rd argument is an optional options object:
        /// - cloneFunction: boolean. If true, any function in the value is are
        /// wrapped in a function forwarder that appears to be a native function in
        /// the content scope.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal CloneInto(Gecko.JsVal value, Gecko.JsVal scope, Gecko.JsVal options, System.IntPtr jsContext);
		
		/// <summary>
        /// When C++-Implemented code does security checks, it can generally query
        /// the subject principal (i.e. the principal of the most-recently-executed
        /// script) in order to determine the responsible party. However, when an API
        /// is implemented in JS, this doesn't work - the most-recently-executed
        /// script is always the System-Principaled API implementation. So we need
        /// another mechanism.
        ///
        /// Hence the notion of the "WebIDL Caller". If the current Entry Script on
        /// the Script Settings Stack represents the invocation of JS-implemented
        /// WebIDL, this API returns the principal of the caller at the time
        /// of invocation. Otherwise (i.e. outside of JS-implemented WebIDL), this
        /// function throws. If it throws, you probably shouldn't be using it.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetWebIDLCallerPrincipal();
		
		/// <summary>
        /// Gets the principal of a script object, after unwrapping any cross-
        /// compartment wrappers.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetObjectPrincipal(Gecko.JsVal obj, System.IntPtr jsContext);
	}
	
	/// <summary>
    /// Interface for the 'Components' object.
    ///
    /// The first interface contains things that are available to non-chrome XBL code
    /// that runs in a scope with an nsExpandedPrincipal. The second interface
    /// includes members that are only exposed to chrome. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("eeeada2f-86c0-4609-b2bf-4bf2351b1ce6")]
	public interface nsIXPCComponentsBase
	{
		
		/// <summary>
        /// Interface for the 'Components' object.
        ///
        /// The first interface contains things that are available to non-chrome XBL code
        /// that runs in a scope with an nsExpandedPrincipal. The second interface
        /// includes members that are only exposed to chrome. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_Interfaces GetInterfacesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_InterfacesByID GetInterfacesByIDAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetResultsAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSuccessCode(int result);
	}
	
	/// <summary>nsIXPCComponents </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("aa28aaf6-70ce-4b03-9514-afe43c7dfda8")]
	public interface nsIXPCComponents : nsIXPCComponentsBase
	{
		
		/// <summary>
        /// Interface for the 'Components' object.
        ///
        /// The first interface contains things that are available to non-chrome XBL code
        /// that runs in a scope with an nsExpandedPrincipal. The second interface
        /// includes members that are only exposed to chrome. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIXPCComponents_Interfaces GetInterfacesAttribute();
		
		/// <summary>Member GetInterfacesByIDAttribute </summary>
		/// <returns>A nsIXPCComponents_InterfacesByID</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIXPCComponents_InterfacesByID GetInterfacesByIDAttribute();
		
		/// <summary>Member GetResultsAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetResultsAttribute();
		
		/// <summary>Member IsSuccessCode </summary>
		/// <param name='result'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSuccessCode(int result);
		
		/// <summary>Member GetClassesAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassesAttribute();
		
		/// <summary>Member GetClassesByIDAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassesByIDAttribute();
		
		/// <summary>Member GetStackAttribute </summary>
		/// <returns>A nsIStackFrame</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStackFrame GetStackAttribute();
		
		/// <summary>Member GetManagerAttribute </summary>
		/// <returns>A nsIComponentManager</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIComponentManager GetManagerAttribute();
		
		/// <summary>Member GetUtilsAttribute </summary>
		/// <returns>A nsIXPCComponents_Utils</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_Utils GetUtilsAttribute();
		
		/// <summary>Member GetIDAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIDAttribute();
		
		/// <summary>Member GetExceptionAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetExceptionAttribute();
		
		/// <summary>Member GetConstructorAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetConstructorAttribute();
		
		/// <summary>Member GetLastResultAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetLastResultAttribute(System.IntPtr jsContext);
		
		/// <summary>Member GetReturnCodeAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetReturnCodeAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetReturnCodeAttribute </summary>
		/// <param name='aReturnCode'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReturnCodeAttribute(Gecko.JsVal aReturnCode, System.IntPtr jsContext);
		
		/// <summary>
        ///@deprecated Use Components.utils.reportError instead. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReportError(Gecko.JsVal error, System.IntPtr jsContext);
	}
}
