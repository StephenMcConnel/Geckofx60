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
// Generated by IDLImporter from file nsIUrlClassifierStreamUpdater.idl
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
    /// This is a class to manage large table updates from the server.  Rather than
    /// downloading the whole update and then updating the sqlite database, we
    /// update tables as the data is streaming in.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("daf3038a-556c-47d3-a3d2-36caa9a762a0")]
	public interface nsIUrlClassifierStreamUpdater
	{
		
		/// <summary>
        /// The Url to download from.  Should be plain ascii text.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUpdateUrlAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUpdateUrl);
		
		/// <summary>
        /// The Url to download from.  Should be plain ascii text.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUpdateUrlAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUpdateUrl);
		
		/// <summary>
        /// Try to download updates from updateUrl.  Only one instance of this
        /// runs at a time, so we return false if another instance is already
        /// running.
        /// @param aRequestTables Comma-separated list of tables included in this
        /// update.
        /// @param aRequestBody The body for the request.
        /// @param aClientKey The client key for checking the update's MAC.
        /// @param aSuccessCallback Called after a successful update.
        /// @param aUpdateErrorCallback Called for problems applying the update
        /// @param aDownloadErrorCallback Called if we get an http error or a
        /// connection refused error.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DownloadUpdates([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRequestTables, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRequestBody, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aClientKey, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback aSuccessCallback, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback aUpdateErrorCallback, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback aDownloadErrorCallback);
	}
}
