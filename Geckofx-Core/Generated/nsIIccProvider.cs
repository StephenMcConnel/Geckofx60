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
// Generated by IDLImporter from file nsIIccProvider.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f383a42b-0961-4bb0-b45e-dbc345d59237")]
	public interface nsIIccListener
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
        /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyStkCommand([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyStkSessionEnd();
	}
	
	/// <summary>
    /// XPCOM component (in the content process) that provides the ICC information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c74b434a-fb2a-4e22-a6cd-1ac353e3f4ce")]
	public interface nsIIccProvider
	{
		
		/// <summary>
        /// Called when a content process registers receiving unsolicited messages from
        /// RadioInterfaceLayer in the chrome process. Only a content process that has
        /// the 'mobileconnection' permission is allowed to register.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterIccMsg([MarshalAs(UnmanagedType.Interface)] nsIIccListener listener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterIccMsg([MarshalAs(UnmanagedType.Interface)] nsIIccListener listener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendStkResponse([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, Gecko.JsVal command, Gecko.JsVal response);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendStkMenuSelection([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, ushort itemIdentifier, [MarshalAs(UnmanagedType.U1)] bool helpRequested);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendStkTimerExpiration([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, Gecko.JsVal timer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendStkEventDownload([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, Gecko.JsVal @event);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest UpdateContact([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase contactType, [MarshalAs(UnmanagedType.Interface)] nsIDOMContact contact, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase pin2);
		
		/// <summary>
        /// Secure Card Icc communication channel
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest IccOpenChannel([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aid);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest IccExchangeAPDU([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, int channel, Gecko.JsVal apdu);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest IccCloseChannel([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, int channel);
	}
}
