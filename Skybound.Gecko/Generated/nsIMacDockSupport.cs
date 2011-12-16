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
// Generated by IDLImporter from file nsIMacDockSupport.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// Allow applications to interface with the Mac OS X Dock.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("CBC8A835-0733-470B-A51D-B7EBBFA88689")]
	public interface nsIMacDockSupport
	{
		
		/// <summary>
        /// Menu to use for application-specific dock menu items.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStandaloneNativeMenu GetDockMenuAttribute();
		
		/// <summary>
        /// Menu to use for application-specific dock menu items.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDockMenuAttribute([MarshalAs(UnmanagedType.Interface)] nsIStandaloneNativeMenu aDockMenu);
		
		/// <summary>
        /// Activate the application. This should be used by an application to
        /// activate itself when a dock menu is selected as selection of a dock menu
        /// item does not automatically activate the application.
        ///
        /// @param aIgnoreOtherApplications If false, the application is activated
        /// only if no other application is currently active. If true, the
        /// application activates regardless.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActivateApplication([MarshalAs(UnmanagedType.Bool)] bool aIgnoreOtherApplications);
	}
}
