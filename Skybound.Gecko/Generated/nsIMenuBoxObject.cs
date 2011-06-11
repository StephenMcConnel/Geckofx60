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
// Generated by IDLImporter from file nsIMenuBoxObject.idl
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
	
	
	/// <summary>nsIMenuBoxObject </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F5099746-5049-4e81-A03E-945D5110FEE2")]
	public interface nsIMenuBoxObject
	{
		
		/// <summary>Member OpenMenu </summary>
		/// <param name='openFlag'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenMenu(System.Boolean  openFlag);
		
		/// <summary>Member GetActiveChildAttribute </summary>
		/// <returns>A nsIDOMElement </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement  GetActiveChildAttribute();
		
		/// <summary>Member SetActiveChildAttribute </summary>
		/// <param name='aActiveChild'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActiveChildAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement  aActiveChild);
		
		/// <summary>Member HandleKeyPress </summary>
		/// <param name='keyEvent'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleKeyPress([MarshalAs(UnmanagedType.Interface)] nsIDOMKeyEvent  keyEvent);
	}
	
	/// <summary>
    /// be implemented by menubars
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D03150F6-92A3-4307-A73C-864C8DAD3F22")]
	public interface nsIMenuBoxObject_MOZILLA_2_0_BRANCH
	{
		
		/// <summary>
        /// true if the menu or menubar was opened via a keypress.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetOpenedWithKeyAttribute();
	}
}
