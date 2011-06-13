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
// Generated by IDLImporter from file mozIPlacesAutoComplete.idl
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
    /// This interface provides some constants used by the Places AutoComplete
    /// search provider as well as methods to track opened pages for AutoComplete
    /// purposes.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3bf895a0-d6d9-4ba7-b8db-f2f0e0f32d23")]
	public interface mozIPlacesAutoComplete
	{
		
		/// <summary>
        /// Mark a page as being currently open.
        ///
        /// @note Pages will not be automatically unregistered when Private Browsing
        /// mode is entered or exited.  Therefore, consumers MUST unregister or
        /// register themselves.
        ///
        /// @param aURI
        /// The URI to register as an open page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterOpenPage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Mark a page as no longer being open (either by closing the window or tab,
        /// or by navigating away from that page).
        ///
        /// @note Pages will not be automatically unregistered when Private Browsing
        /// mode is entered or exited.  Therefore, consumers MUST unregister or
        /// register themselves.
        ///
        /// @param aURI
        /// The URI to unregister as an open page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterOpenPage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
	}
}
