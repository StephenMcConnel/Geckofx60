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
// Generated by IDLImporter from file nsIDNSListener.idl
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
	
	
	/// <summary>
    /// nsIDNSListener
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("41466a9f-f027-487d-a96c-af39e629b8d2")]
	public interface nsIDNSListener
	{
		
		/// <summary>
        /// called when an asynchronous host lookup completes.
        ///
        /// @param aRequest
        /// the value returned from asyncResolve.
        /// @param aRecord
        /// the DNS record corresponding to the hostname that was resolved.
        /// this parameter is null if there was an error.
        /// @param aStatus
        /// if the lookup failed, this parameter gives the reason.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnLookupComplete([MarshalAs(UnmanagedType.Interface)] nsICancelable  aRequest, [MarshalAs(UnmanagedType.Interface)] nsIDNSRecord  aRecord, System.Int32  aStatus);
	}
}
