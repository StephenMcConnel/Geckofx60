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
// Generated by IDLImporter from file nsITimedChannel.idl
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
	[Guid("c2d9e95b-9cc9-4f47-9ef6-1de0cf7ebc75")]
	public interface nsIServerTiming
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDurationAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aDescription);
	}
	
	/// <summary>
    /// All properties return zero if the value is not available
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ca63784d-959c-4c3a-9a59-234a2a520de0")]
	public interface nsITimedChannel
	{
		
		/// <summary>
        /// false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetTimingEnabledAttribute();
		
		/// <summary>
        /// false.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aTimingEnabled);
		
		/// <summary>
        /// The number of redirects
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		byte GetRedirectCountAttribute();
		
		/// <summary>
        /// The number of redirects
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRedirectCountAttribute(byte aRedirectCount);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		byte GetInternalRedirectCountAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInternalRedirectCountAttribute(byte aInternalRedirectCount);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetChannelCreationAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetAsyncOpenAttribute();
		
		/// <summary>
        /// worker no matter the response is synthesized.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetLaunchServiceWorkerStartAttribute();
		
		/// <summary>
        /// worker no matter the response is synthesized.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLaunchServiceWorkerStartAttribute(ulong aLaunchServiceWorkerStart);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetLaunchServiceWorkerEndAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLaunchServiceWorkerEndAttribute(ulong aLaunchServiceWorkerEnd);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetDispatchFetchEventStartAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDispatchFetchEventStartAttribute(ulong aDispatchFetchEventStart);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetDispatchFetchEventEndAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDispatchFetchEventEndAttribute(ulong aDispatchFetchEventEnd);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetHandleFetchEventStartAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHandleFetchEventStartAttribute(ulong aHandleFetchEventStart);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetHandleFetchEventEndAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHandleFetchEventEndAttribute(ulong aHandleFetchEventEnd);
		
		/// <summary>
        /// cache
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetDomainLookupStartAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetDomainLookupEndAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetConnectStartAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTcpConnectEndAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetSecureConnectionStartAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetConnectEndAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetRequestStartAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetResponseStartAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetResponseEndAttribute();
		
		/// <summary>
        /// the data from one channel to the redirected channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetRedirectStartAttribute();
		
		/// <summary>
        /// the data from one channel to the redirected channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRedirectStartAttribute(ulong aRedirectStart);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetRedirectEndAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRedirectEndAttribute(ulong aRedirectEnd);
		
		/// <summary>
        /// The initiator type
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInitiatorTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInitiatorType);
		
		/// <summary>
        /// The initiator type
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInitiatorTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInitiatorType);
		
		/// <summary>
        /// This flag should be set to false only if a cross-domain redirect occurred
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllRedirectsSameOriginAttribute();
		
		/// <summary>
        /// This flag should be set to false only if a cross-domain redirect occurred
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllRedirectsSameOriginAttribute([MarshalAs(UnmanagedType.U1)] bool aAllRedirectsSameOrigin);
		
		/// <summary>
        /// This flag is set to false if the timing allow check fails
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllRedirectsPassTimingAllowCheckAttribute();
		
		/// <summary>
        /// This flag is set to false if the timing allow check fails
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllRedirectsPassTimingAllowCheckAttribute([MarshalAs(UnmanagedType.U1)] bool aAllRedirectsPassTimingAllowCheck);
		
		/// <summary>
        /// timing info for the resourceTiming object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool TimingAllowCheck([MarshalAs(UnmanagedType.Interface)] nsIPrincipal origin);
		
		/// <summary>
        /// cache
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetCacheReadStartAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetCacheReadEndAttribute();
		
		/// <summary>
        /// All following are PRTime versions of the above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetChannelCreationTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetAsyncOpenTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLaunchServiceWorkerStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLaunchServiceWorkerEndTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDispatchFetchEventStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDispatchFetchEventEndTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetHandleFetchEventStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetHandleFetchEventEndTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDomainLookupStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDomainLookupEndTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetConnectStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetTcpConnectEndTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetSecureConnectionStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetConnectEndTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetRequestStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetResponseStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetResponseEndTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetCacheReadStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetCacheReadEndTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetRedirectStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetRedirectEndTimeAttribute();
		
		/// <summary>
        /// If this attribute is false, this resource MUST NOT be reported in resource timing.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReportResourceTimingAttribute();
		
		/// <summary>
        /// If this attribute is false, this resource MUST NOT be reported in resource timing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReportResourceTimingAttribute([MarshalAs(UnmanagedType.U1)] bool aReportResourceTiming);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetServerTimingAttribute();
	}
}
