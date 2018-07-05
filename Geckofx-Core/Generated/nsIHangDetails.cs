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
// Generated by IDLImporter from file nsIHangDetails.idl
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
    /// A scriptable interface for getting information about a BHR detected hang.
    /// This is the type of the subject of the "bhr-thread-hang" observer topic.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("23d63fff-38d6-4003-9c57-2c90aca1180a")]
	public interface nsIHangDetails
	{
		
		/// <summary>
        /// The detected duration of the hang.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDurationAttribute();
		
		/// <summary>
        /// The name of the thread which hung.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetThreadAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aThread);
		
		/// <summary>
        /// The name of the runnable which hung if it hung on the main thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRunnableNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRunnableName);
		
		/// <summary>
        /// The type of process which produced the hang. This should be either:
        /// "default", "content", or "gpu".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProcessAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProcess);
		
		/// <summary>
        /// The remote type of the content process which produced the hang.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRemoteTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRemoteType);
		
		/// <summary>
        /// Returns the stack which was captured by BHR. The offset is encoded as a hex
        /// string, as it can contain numbers larger than JS can hold losslessly.
        ///
        /// This value takes the following form:
        /// [ [moduleIndex, offset], ... ]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetStackAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// Returns the modules which were captured by BHR.
        ///
        /// This value takes the following form:
        /// [ ["fileName", "BreakpadId"], ... ]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetModulesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// The hang annotations which were captured when the hang occured. This
        /// attribute is a JS object of key-value pairs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetAnnotationsAttribute(System.IntPtr jsContext);
	}
}