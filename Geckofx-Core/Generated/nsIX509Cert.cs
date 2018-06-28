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
// Generated by IDLImporter from file nsIX509Cert.idl
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
    /// This represents a X.509 certificate.
    ///
    /// NOTE: Service workers persist x.509 certs in object form on disk.  If you
    /// change this uuid you probably need a hack in nsBinaryInputStream to
    /// read the old uuid.  If you change the format of the object
    /// serialization then more complex changes will be needed.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bdc3979a-5422-4cd5-8589-696b6e96ea83")]
	public interface nsIX509Cert
	{
		
		/// <summary>
        /// The primary email address of the certificate, if present.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEmailAddressAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEmailAddress);
		
		/// <summary>
        /// Did this certificate ship with the platform as a built-in root?
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsBuiltInRootAttribute();
		
		/// <summary>
        /// Obtain a list of all email addresses
        /// contained in the certificate.
        ///
        /// @param length The number of strings in the returned array.
        /// @return An array of email addresses.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEmailAddresses(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] addresses);
		
		/// <summary>
        /// Check whether a given address is contained in the certificate.
        /// The comparison will convert the email address to lowercase.
        /// The behaviour for non ASCII characters is undefined.
        ///
        /// @param aEmailAddress The address to search for.
        ///
        /// @return True if the address is contained in the certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ContainsEmailAddress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEmailAddress);
		
		/// <summary>
        /// The subject owning the certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSubjectNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSubjectName);
		
		/// <summary>
        /// The subject's common name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommonNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCommonName);
		
		/// <summary>
        /// The subject's organization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrganizationAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOrganization);
		
		/// <summary>
        /// The subject's organizational unit.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrganizationalUnitAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOrganizationalUnit);
		
		/// <summary>
        /// The fingerprint of the certificate's DER encoding,
        /// calculated using the SHA-256 algorithm.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSha256FingerprintAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSha256Fingerprint);
		
		/// <summary>
        /// The fingerprint of the certificate's DER encoding,
        /// calculated using the SHA1 algorithm.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSha1FingerprintAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSha1Fingerprint);
		
		/// <summary>
        /// A human readable name identifying the hardware or
        /// software token the certificate is stored on.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTokenNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTokenName);
		
		/// <summary>
        /// The subject identifying the issuer certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIssuerNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIssuerName);
		
		/// <summary>
        /// The serial number the issuer assigned to this certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSerialNumberAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSerialNumber);
		
		/// <summary>
        /// The issuer subject's common name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIssuerCommonNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIssuerCommonName);
		
		/// <summary>
        /// The issuer subject's organization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIssuerOrganizationAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIssuerOrganization);
		
		/// <summary>
        /// The issuer subject's organizational unit.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIssuerOrganizationUnitAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIssuerOrganizationUnit);
		
		/// <summary>
        /// The certificate used by the issuer to sign this certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509Cert GetIssuerAttribute();
		
		/// <summary>
        /// This certificate's validity period.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509CertValidity GetValidityAttribute();
		
		/// <summary>
        /// A unique identifier of this certificate within the local storage.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDbKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aDbKey);
		
		/// <summary>
        /// A human readable identifier to label this certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName);
		
		/// <summary>
        /// Type of this certificate
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCertTypeAttribute();
		
		/// <summary>
        /// True if the certificate is self-signed. CA issued
        /// certificates are always self-signed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSelfSignedAttribute();
		
		/// <summary>
        /// Obtain a list of certificates that contains this certificate
        /// and the issuing certificates of all involved issuers,
        /// up to the root issuer.
        ///
        /// @return The chain of certifficates including the issuers.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetChain();
		
		/// <summary>
        /// A comma separated list of localized strings representing the contents of
        /// the certificate's key usage extension, if present. The empty string if the
        /// certificate doesn't have the key usage extension, or has an empty extension.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeyUsagesAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeyUsages);
		
		/// <summary>
        /// This is the attribute which describes the ASN1 layout
        /// of the certificate.  This can be used when doing a
        /// "pretty print" of the certificate's ASN1 structure.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIASN1Object GetASN1StructureAttribute();
		
		/// <summary>
        /// Obtain a raw binary encoding of this certificate
        /// in DER format.
        ///
        /// @param length The number of bytes in the binary encoding.
        /// @param data The bytes representing the DER encoded certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRawDER(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref byte[] data);
		
		/// <summary>
        /// Test whether two certificate instances represent the
        /// same certificate.
        ///
        /// @return Whether the certificates are equal
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIX509Cert other);
		
		/// <summary>
        /// The base64 encoding of the DER encoded public key info using the specified
        /// digest.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSha256SubjectPublicKeyInfoDigestAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSha256SubjectPublicKeyInfoDigest);
		
		/// <summary>
        /// Obtain the certificate wrapped in a PKCS#7 SignedData structure,
        /// with or without the certificate chain
        ///
        /// @param chainMode Whether to include the chain (with or without the root),
        ///                       see CMS_CHAIN_MODE constants.
        /// @param length The number of bytes of the PKCS#7 data.
        /// @param data The bytes representing the PKCS#7 wrapped certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExportAsCMS(uint chainMode, ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref byte[] data);
		
		/// <summary>
        /// Retrieves the NSS certificate object wrapped by this interface
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetCert();
		
		/// <summary>
        /// Either delete the certificate from all cert databases,
        /// or mark it as untrusted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkForPermDeletion();
	}
	
	/// <summary>nsIX509CertConsts </summary>
	public class nsIX509CertConsts
	{
		
		// <summary>
        // Constants to classify the type of a certificate.
        // </summary>
		public const ulong UNKNOWN_CERT = 0;
		
		// 
		public const ulong CA_CERT = 1<<0;
		
		// 
		public const ulong USER_CERT = 1<<1;
		
		// 
		public const ulong EMAIL_CERT = 1<<2;
		
		// 
		public const ulong SERVER_CERT = 1<<3;
		
		// 
		public const ulong ANY_CERT = 0xffff;
		
		// <summary>
        // Constants for specifying the chain mode when exporting a certificate
        // </summary>
		public const ulong CMS_CHAIN_MODE_CertOnly = 1;
		
		// 
		public const ulong CMS_CHAIN_MODE_CertChain = 2;
		
		// 
		public const ulong CMS_CHAIN_MODE_CertChainWithRoot = 3;
	}
}
