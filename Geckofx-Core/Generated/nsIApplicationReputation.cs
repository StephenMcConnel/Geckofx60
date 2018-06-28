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
// Generated by IDLImporter from file nsIApplicationReputation.idl
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
    /// A service for asynchronously querying an application reputation service
    /// based on metadata of the downloaded file.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c9f03479-fd68-4393-acb2-c88d4f563174")]
	public interface nsIApplicationReputationService
	{
		
		/// <summary>
        /// Start querying the application reputation service.
        ///
        /// @param aQuery
        /// The nsIApplicationReputationQuery containing metadata of the
        /// downloaded file.
        ///
        /// @param aCallback
        /// The callback for receiving the results of the query.
        ///
        /// @remarks aCallback may not be null.  onComplete is guaranteed to be called
        /// on aCallback. This function may not be called more than once with
        /// the same query object. If any of the attributes of aQuery have
        /// not been set or have been set with empty data (with the exception
        /// of sourceURI), then a valid request can still be constructed and
        /// will solicit a valid response, but won't produce any useful
        /// information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void QueryReputation([MarshalAs(UnmanagedType.Interface)] nsIApplicationReputationQuery aQuery, [MarshalAs(UnmanagedType.Interface)] nsIApplicationReputationCallback aCallback);
	}
	
	/// <summary>nsIApplicationReputationServiceConsts </summary>
	public class nsIApplicationReputationServiceConsts
	{
		
		// <summary>
        // Indicates the reason for the application reputation block.
        // </summary>
		public const ulong VERDICT_SAFE = 0;
		
		// 
		public const ulong VERDICT_DANGEROUS = 1;
		
		// 
		public const ulong VERDICT_UNCOMMON = 2;
		
		// 
		public const ulong VERDICT_POTENTIALLY_UNWANTED = 3;
		
		// 
		public const ulong VERDICT_DANGEROUS_HOST = 4;
	}
	
	/// <summary>
    /// A single-use, write-once interface for recording the metadata of the
    /// downloaded file. nsIApplicationReputationService.Start() may only be called
    /// once with a single query.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("812d7509-a9a3-446e-a66f-3ed8cc91ebd0")]
	public interface nsIApplicationReputationQuery
	{
		
		/// <summary>
        /// The nsIURI from which the file was downloaded. This may not be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetSourceURIAttribute();
		
		/// <summary>
        /// The reference, if any.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetReferrerURIAttribute();
		
		/// <summary>
        /// The target filename for the downloaded file, as inferred from the source
        /// URI or provided by the Content-Disposition attachment file name. If this
        /// is not set by the caller, it will be passed as an empty string but the
        /// query won't produce any useful information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSuggestedFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSuggestedFileName);
		
		/// <summary>
        /// The size of the downloaded file in bytes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFileSizeAttribute();
		
		/// <summary>
        /// The SHA256 hash of the downloaded file in raw bytes. If this is not set by
        /// the caller, it will be passed as an empty string but the query won't
        /// produce any useful information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSha256HashAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSha256Hash);
		
		/// <summary>
        /// The nsIArray of nsIX509CertList of nsIX509Cert that verify for this
        /// binary, if it is signed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetSignatureInfoAttribute();
		
		/// <summary>
        /// The nsIArray of nsIPrincipal of redirects that lead to this download. The
        /// most recent redirect is the last element.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetRedirectsAttribute();
	}
	
	/// <summary>nsIApplicationReputationCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9a228470-cfe5-11e2-8b8b-0800200c9a66")]
	public interface nsIApplicationReputationCallback
	{
		
		/// <summary>
        /// Callback for the result of the application reputation query.
        /// @param aStatus
        /// NS_OK if and only if the query succeeded. If it did, then
        /// shouldBlock is meaningful (otherwise it defaults to false). This
        /// may be NS_ERROR_FAILURE if the response cannot be parsed, or
        /// NS_ERROR_NOT_AVAILABLE if the service has been disabled or is not
        /// reachable.
        /// @param aShouldBlock
        /// Whether or not the download should be blocked.
        /// @param aVerdict
        /// Indicates the result of the lookup that determines whether the
        /// download should be blocked, according to the "VERDICT_" constants.
        /// This may be set to a value different than "VERDICT_SAFE" even if
        /// aShouldBlock is false, so you should always check aShouldBlock.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnComplete([MarshalAs(UnmanagedType.U1)] bool aShouldBlock, int aStatus, uint aVerdict);
	}
}
