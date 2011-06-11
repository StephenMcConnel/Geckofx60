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
// Generated by IDLImporter from file nsIXULBrowserWindow.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// The nsIXULBrowserWindow supplies the methods that may be called from the
    /// internals of the browser area to tell the containing xul window to update
    /// its ui.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("67a601df-f091-4894-a2e2-2e6cfebb35ea")]
	public interface nsIXULBrowserWindow
	{
		
		/// <summary>
        /// Sets the status according to JS' version of status.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetJSStatus([MarshalAs(UnmanagedType.LPStruct)] nsAString status);
		
		/// <summary>
        /// Sets the default status according to JS' version of default status.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetJSDefaultStatus([MarshalAs(UnmanagedType.LPStruct)] nsAString status);
		
		/// <summary>
        /// Tells the object implementing this function what link we are currently
        /// over.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOverLink([MarshalAs(UnmanagedType.LPStruct)] nsAString link, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement  element);
		
		/// <summary>
        /// Determines the appropriate target for a link.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString OnBeforeLinkTraversal([MarshalAs(UnmanagedType.LPStruct)] nsAString originalTarget, [MarshalAs(UnmanagedType.Interface)] nsIURI  linkURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  linkNode, System.Boolean  isAppTab);
	}
}
