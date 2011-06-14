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
// Generated by IDLImporter from file nsIPhoneSupport.idl
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
	
	
	/// <summary>nsIPhoneSupport </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c75982d6-811b-4321-980d-46490e1a6703")]
	public interface nsIPhoneSupport
	{
		
		/// <summary>
        /// This method attempts to make a telephone call.
        ///
        /// @param telephoneNumber this is the telephone to dial.
        /// @param telephoneDescription this is an optional
        /// description of the telephone number.
        /// @param aPrompt this indicates whether to display the confirm call dialog
        /// before dialing
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MakeCall([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string telephoneNumber, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string telephoneDescription, [MarshalAs(UnmanagedType.Bool)] bool aPrompt);
		
		/// <summary>
        /// This method displays a UI to switch to (or launch) a different task
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SwitchTask();
		
		/// <summary>
        /// Determines whether or not Fennec is the "Default Browser".
        /// This is simply whether or not Fennec is registered to handle http links.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDefaultBrowser();
		
		/// <summary>
        /// Registers Fennec as the "Default Browser".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultBrowser();
		
		/// <summary>
        /// Restores previous "Default Browser".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RestoreDefaultBrowser();
	}
}
