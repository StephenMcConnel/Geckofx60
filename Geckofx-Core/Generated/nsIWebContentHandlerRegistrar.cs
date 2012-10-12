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
// Generated by IDLImporter from file nsIWebContentHandlerRegistrar.idl
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
    /// nsIWebContentHandlerRegistrar
    ///
    /// Applications wishing to use web content handlers need to implement this
    /// interface. Typically they will prompt the user to confirm adding an entry
    /// to the local list.
    ///
    /// The component must have the contract id defined below so that nsNavigator
    /// can invoke it.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e6a75410-c93e-42bf-84ca-a5c3ec34a2f1")]
	public interface nsIWebContentHandlerRegistrar
	{
		
		/// <summary>
        /// See documentation in nsIDOMClientInformation.idl
        /// The additional contentWindow param for both methods represents the dom
        /// content window from which the method has been called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterContentHandler([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase mimeType, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase title, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow contentWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterProtocolHandler([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase protocol, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase title, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow contentWindow);
	}
}
