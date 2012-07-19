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
// Generated by IDLImporter from file nsISmsRequestManager.idl
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
	[Guid("1638b963-3a45-4937-b6a9-280c1bfb166c")]
	public interface nsISmsRequestManager
	{
		
		/// <summary>
        /// Create a new request object.
        ///
        /// @return the request ID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CreateRequest([MarshalAs(UnmanagedType.Interface)] nsIDOMMozSmsManager aManager, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMMozSmsRequest aRequest);
		
		/// <summary>
        /// Track an already existing request object.
        ///
        /// @return the request ID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int AddRequest([MarshalAs(UnmanagedType.Interface)] nsIDOMMozSmsRequest aRequest);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySmsSent(int aRequestId, [MarshalAs(UnmanagedType.Interface)] nsIDOMMozSmsMessage aMessage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySmsSendFailed(int aRequestId, int aError);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGotSms(int aRequestId, [MarshalAs(UnmanagedType.Interface)] nsIDOMMozSmsMessage aMessage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetSmsFailed(int aRequestId, int aError);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySmsDeleted(int aRequestId, [MarshalAs(UnmanagedType.U1)] bool aDeleted);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySmsDeleteFailed(int aRequestId, int aError);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyNoMessageInList(int aRequestId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCreateMessageList(int aRequestId, int aListId, [MarshalAs(UnmanagedType.Interface)] nsIDOMMozSmsMessage aMessage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGotNextMessage(int aRequestId, [MarshalAs(UnmanagedType.Interface)] nsIDOMMozSmsMessage aMessage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyReadMessageListFailed(int aRequestId, int aError);
	}
	
	/// <summary>nsISmsRequestManagerConsts </summary>
	public class nsISmsRequestManagerConsts
	{
		
		// <summary>
        // All SMS related errors that could apply to SmsRequest objects.
        // Make sure to keep this list in sync with the list in:
        // embedding/android/GeckoSmsManager.java
        // </summary>
		public const ulong SUCCESS_NO_ERROR = 0;
		
		// 
		public const ulong NO_SIGNAL_ERROR = 1;
		
		// 
		public const ulong NOT_FOUND_ERROR = 2;
		
		// 
		public const ulong UNKNOWN_ERROR = 3;
		
		// 
		public const ulong INTERNAL_ERROR = 4;
	}
}
