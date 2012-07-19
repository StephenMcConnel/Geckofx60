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
// Generated by IDLImporter from file nsICertOverrideService.idl
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
    /// This represents the global list of triples
    /// {host:port, cert-fingerprint, allowed-overrides}
    /// that the user wants to accept without further warnings.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("31738d2a-77d3-4359-84c9-4be2f38fb8c5")]
	public interface nsICertOverrideService
	{
		
		/// <summary>
        /// The given cert should always be accepted for the given hostname:port,
        /// regardless of errors verifying the cert.
        /// Host:Port is a primary key, only one entry per host:port can exist.
        /// The implementation will store a fingerprint of the cert.
        /// The implementation will decide which fingerprint alg is used.
        ///
        /// @param aHostName The host (punycode) this mapping belongs to
        /// @param aPort The port this mapping belongs to, if it is -1 then it
        /// is internaly treated as 443
        /// @param aCert The cert that should always be accepted
        /// @param aOverrideBits The errors we want to be overriden
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RememberValidityOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert, uint aOverrideBits, [MarshalAs(UnmanagedType.U1)] bool aTemporary);
		
		/// <summary>
        /// The given cert should always be accepted for the given hostname:port,
        /// regardless of errors verifying the cert.
        /// Host:Port is a primary key, only one entry per host:port can exist.
        /// The implementation will store a fingerprint of the cert.
        /// The implementation will decide which fingerprint alg is used.
        ///
        /// @param aHostName The host (punycode) this mapping belongs to
        /// @param aPort The port this mapping belongs to, if it is -1 then it
        /// is internaly treated as 443
        /// @param aCert The cert that should always be accepted
        /// @param aOverrideBits The errors that are currently overriden
        /// @return whether an override entry for aHostNameWithPort is currently on file
        /// that matches the given certificate
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMatchingOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert, ref uint aOverrideBits, [MarshalAs(UnmanagedType.U1)] ref bool aIsTemporary);
		
		/// <summary>
        /// Retrieve the stored override for the given hostname:port.
        ///
        /// @param aHostName The host (punycode) whose entry should be tested
        /// @param aPort The port whose entry should be tested, if it is -1 then it
        /// is internaly treated as 443
        /// @param aHashAlg On return value True, the fingerprint hash algorithm
        /// as an OID value in dotted notation.
        /// @param aFingerprint On return value True, the stored fingerprint
        /// @param aOverrideBits The errors that are currently overriden
        /// @return whether a matching override entry for aHostNameWithPort
        /// and aFingerprint is currently on file
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetValidityOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHashAlg, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFingerprint, ref uint aOverrideBits, [MarshalAs(UnmanagedType.U1)] ref bool aIsTemporary);
		
		/// <summary>
        /// Remove a override for the given hostname:port.
        ///
        /// @param aHostName The host (punycode) whose entry should be cleared.
        /// @param aPort The port whose entry should be cleared.
        /// If it is -1, then it is internaly treated as 443.
        /// If it is 0 and aHostName is "all:temporary-certificates",
        /// then all temporary certificates should be cleared.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearValidityOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort);
		
		/// <summary>
        /// Obtain the full list of hostname:port for which overrides are known.
        ///
        /// @param aCount The number of host:port entries returned
        /// @param aHostsWithPortsArray The array of host:port entries returned
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAllOverrideHostsWithPorts(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aHostsWithPortsArray);
		
		/// <summary>
        /// Is the given cert used in rules?
        ///
        /// @param aCert The cert we're looking for
        /// @return how many override entries are currently on file
        /// for the given certificate
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint IsCertUsedForOverrides([MarshalAs(UnmanagedType.Interface)] nsIX509Cert aCert, [MarshalAs(UnmanagedType.U1)] bool aCheckTemporaries, [MarshalAs(UnmanagedType.U1)] bool aCheckPermanents);
	}
	
	/// <summary>nsICertOverrideServiceConsts </summary>
	public class nsICertOverrideServiceConsts
	{
		
		// <summary>
        // Override Untrusted
        // </summary>
		public const int ERROR_UNTRUSTED = 1;
		
		// <summary>
        // Override hostname Mismatch
        // </summary>
		public const int ERROR_MISMATCH = 2;
		
		// <summary>
        // Override Time error
        // </summary>
		public const int ERROR_TIME = 4;
	}
}
