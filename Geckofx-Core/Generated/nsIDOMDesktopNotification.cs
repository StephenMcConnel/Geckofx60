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
// Generated by IDLImporter from file nsIDOMDesktopNotification.idl
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
	[Guid("CCEA6185-0A3D-45AB-9058-1004DD4B8C50")]
	public interface nsIDOMDesktopNotificationCenter
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDesktopNotification CreateNotification([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase title, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase description, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase iconURL);
	}
	
	/// <summary>nsIDOMDesktopNotification </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("77bc6adc-77d6-4b29-9844-7eaac25e995d")]
	public interface nsIDOMDesktopNotification
	{
		
		/// <summary>Member Show </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Show();
		
		/// <summary>Member GetOnclickAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnclickAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnclickAttribute </summary>
		/// <param name='aOnclick'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnclickAttribute(Gecko.JsVal aOnclick, System.IntPtr jsContext);
		
		/// <summary>Member GetOncloseAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncloseAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOncloseAttribute </summary>
		/// <param name='aOnclose'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncloseAttribute(Gecko.JsVal aOnclose, System.IntPtr jsContext);
	}
	
	/// <summary>
    /// Notification service that also provides the manifest URL
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7fb4f0f9-ff5b-4620-8e1b-d82d723605af")]
	public interface nsIAppNotificationService
	{
		
		/// <summary>
        /// Notification service that also provides the manifest URL
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowAppNotification([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase imageUrl, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase title, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase text, [MarshalAs(UnmanagedType.U1)] bool textClickable, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase manifestURL, [MarshalAs(UnmanagedType.Interface)] nsIObserver alertListener);
	}
}
