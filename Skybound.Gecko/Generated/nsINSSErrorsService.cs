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
// Generated by IDLImporter from file nsINSSErrorsService.idl
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

	
	
	/// <summary>nsINSSErrorsService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3a5c7a0f-f5da-4a8b-a748-d7c5a528f33b")]
	public interface nsINSSErrorsService
	{
		
		/// <summary>
        /// @param aNSPRCode An error code obtained using PR_GetError()
        /// @return True if it is error code defined by the NSS library
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsNSSErrorCode(int aNSPRCode);
		
		/// <summary>
        /// Function will fail if aNSPRCode is not an NSS error code.
        /// @param aNSPRCode An error code obtained using PR_GetError()
        /// @return The result of the conversion, an XPCOM error code
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetXPCOMFromNSSError(int aNSPRCode);
		
		/// <summary>
        /// Function will fail if aXPCOMErrorCode is not an NSS error code.
        /// @param aXPCOMErrorCode An error code obtain using getXPCOMFromNSSError
        /// return A localized human readable error explanation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetErrorMessage(int aXPCOMErrorCode, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Function will fail if aXPCOMErrorCode is not an NSS error code.
        /// @param aXPCOMErrorCode An error code obtain using getXPCOMFromNSSError
        /// return the
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetErrorClass(int aXPCOMErrorCode);
	}
	
	/// <summary>nsINSSErrorsServiceConsts </summary>
	public class nsINSSErrorsServiceConsts
	{
		
		// 
		public const ulong ERROR_CLASS_SSL_PROTOCOL = 1;
		
		// 
		public const ulong ERROR_CLASS_BAD_CERT = 2;
		
		// <summary>
        // The following values define the range of NSPR error codes used by NSS.
        // NSS remains the authorative source for these numbers, as a result,
        // the values might change in the future.
        // The security module will perform a runtime check and assertion
        // to ensure the values are in synch with NSS.
        // </summary>
		public const long NSS_SEC_ERROR_BASE = -(0x2000);
		
		// 
		public const long NSS_SEC_ERROR_LIMIT = (NSS_SEC_ERROR_BASE+1000);
		
		// 
		public const long NSS_SSL_ERROR_BASE = -(0x3000);
		
		// 
		public const long NSS_SSL_ERROR_LIMIT = (NSS_SSL_ERROR_BASE+1000);
	}
}
