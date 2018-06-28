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
// Generated by IDLImporter from file nsIScriptLoaderObserver.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7b787204-76fb-4764-96f1-fb7a666db4f4")]
	public interface nsIScriptLoaderObserver
	{
		
		/// <summary>
        /// The script is available for evaluation. For inline scripts, this
        /// method will be called synchronously. For externally loaded scripts,
        /// this method will be called when the load completes.
        ///
        /// @param aResult A result code representing the result of loading
        /// a script. If this is a failure code, script evaluation
        /// will not occur.
        /// @param aElement The element being processed.
        /// @param aIsInline Is this an inline classic script (as opposed to an
        /// externally loaded classic script or module script)?
        /// @param aURI What is the URI of the script (the document URI if
        /// it is inline).
        /// @param aLineNo At what line does the script appear (generally 1
        /// if it is a loaded script).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScriptAvailable(int aResult, System.IntPtr aElement, [MarshalAs(UnmanagedType.U1)] bool aIsInlineClassicScript, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aLineNo);
		
		/// <summary>
        /// The script has been evaluated.
        ///
        /// @param aResult A result code representing the success or failure of
        /// the script evaluation.
        /// @param aElement The element being processed.
        /// @param aIsInline Is this an inline script or externally loaded?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScriptEvaluated(int aResult, System.IntPtr aElement, [MarshalAs(UnmanagedType.U1)] bool aIsInline);
	}
}
