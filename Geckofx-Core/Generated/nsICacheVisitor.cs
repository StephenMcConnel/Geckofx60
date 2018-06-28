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
// Generated by IDLImporter from file nsICacheVisitor.idl
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
    ///XXX we should define device and entry info as well (stats, etc) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f8c08c4b-d778-49d1-a59b-866fdc500d95")]
	public interface nsICacheVisitor
	{
		
		/// <summary>
        /// Called to provide information about a cache device.
        ///
        /// @param deviceID - specifies the device being visited.
        /// @param deviceInfo - specifies information about this device.
        ///
        /// @return true to start visiting all entries for this device.
        /// @return false to advance to the next device.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool VisitDevice([MarshalAs(UnmanagedType.LPStr)] string deviceID, [MarshalAs(UnmanagedType.Interface)] nsICacheDeviceInfo deviceInfo);
		
		/// <summary>
        /// Called to provide information about a cache entry.
        ///
        /// @param deviceID - specifies the device being visited.
        /// @param entryInfo - specifies information about this entry.
        ///
        /// @return true to visit the next entry on the current device, or if the
        /// end of the device has been reached, advance to the next device.
        /// @return false to advance to the next device.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool VisitEntry([MarshalAs(UnmanagedType.LPStr)] string deviceID, [MarshalAs(UnmanagedType.Interface)] nsICacheEntryInfo entryInfo);
	}
	
	/// <summary>nsICacheDeviceInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("31d1c294-1dd2-11b2-be3a-c79230dca297")]
	public interface nsICacheDeviceInfo
	{
		
		/// <summary>
        /// Get a human readable description of the cache device.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aDescription);
		
		/// <summary>
        /// Get a usage report, statistics, miscellaneous data about
        /// the cache device.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsageReportAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUsageReport);
		
		/// <summary>
        /// Get the number of stored cache entries.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetEntryCountAttribute();
		
		/// <summary>
        /// Get the total size of the stored cache entries.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTotalSizeAttribute();
		
		/// <summary>
        /// Get the upper limit of the size of the data the cache can store.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMaximumSizeAttribute();
	}
	
	/// <summary>nsICacheEntryInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fab51c92-95c3-4468-b317-7de4d7588254")]
	public interface nsICacheEntryInfo
	{
		
		/// <summary>
        /// Get the client id associated with this cache entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClientIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aClientID);
		
		/// <summary>
        /// Get the id for the device that stores this cache entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDeviceIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aDeviceID);
		
		/// <summary>
        /// Get the key identifying the cache entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);
		
		/// <summary>
        /// Get the number of times the cache entry has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFetchCountAttribute();
		
		/// <summary>
        /// Get the last time the cache entry was opened (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLastFetchedAttribute();
		
		/// <summary>
        /// Get the last time the cache entry was modified (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLastModifiedAttribute();
		
		/// <summary>
        /// Get the expiration time of the cache entry (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetExpirationTimeAttribute();
		
		/// <summary>
        /// Get the cache entry data size.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDataSizeAttribute();
		
		/// <summary>
        /// Find out whether or not the cache entry is stream based.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsStreamBased();
	}
}
