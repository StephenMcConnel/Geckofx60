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
// Generated by IDLImporter from file nsIBidiKeyboard.idl
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

	
	
	/// <summary>nsIBidiKeyboard </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("99957506-f21b-4a61-ad64-5b641cf508e2")]
	public interface nsIBidiKeyboard
	{
		
		/// <summary>
        /// Determines if the current keyboard language is right-to-left
        /// @throws NS_ERROR_FAILURE if no right-to-left keyboards are installed
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsLangRTL();
		
		/// <summary>
        /// Sets the keyboard language to left-to-right or right-to-left
        /// @param aLevel - if odd set the keyboard to RTL, if even set LTR
        /// @throws NS_ERROR_FAILURE if no right-to-left keyboards are installed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLangFromBidiLevel(byte aLevel);
		
		/// <summary>
        /// Determines whether the system has at least one keyboard of each direction
        /// installed.
        ///
        /// @throws NS_ERROR_NOT_IMPLEMENTED if the widget layer does not provide this
        /// information.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHaveBidiKeyboardsAttribute();
	}
}
