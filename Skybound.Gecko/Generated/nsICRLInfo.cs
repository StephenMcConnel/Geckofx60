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
// Generated by IDLImporter from file nsICRLInfo.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// Information on a Certificate Revocation List (CRL)
    /// issued by a Aertificate Authority (CA).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c185d920-4a3e-11d5-ba27-00108303b117")]
	public interface nsICRLInfo
	{
		
		/// <summary>
        /// The issuing CA's organization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrganizationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrganization);
		
		/// <summary>
        /// The issuing CA's organizational unit.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrganizationalUnitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrganizationalUnit);
		
		/// <summary>
        /// The time this CRL was created at.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastUpdateAttribute();
		
		/// <summary>
        /// The time the suggested next update for this CRL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetNextUpdateAttribute();
		
		/// <summary>
        /// lastUpdate formatted as a human readable string
        /// formatted according to the environment locale.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLastUpdateLocaleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLastUpdateLocale);
		
		/// <summary>
        /// nextUpdate formatted as a human readable string
        /// formatted according to the environment locale.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNextUpdateLocaleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNextUpdateLocale);
		
		/// <summary>
        /// The key identifying the CRL in the database.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameInDbAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNameInDb);
		
		/// <summary>
        /// The URL this CRL was last fetched from.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLastFetchURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aLastFetchURL);
	}
}
