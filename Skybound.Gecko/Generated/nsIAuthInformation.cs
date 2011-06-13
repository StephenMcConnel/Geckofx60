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
// Generated by IDLImporter from file nsIAuthInformation.idl
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
    /// A object that hold authentication information. The caller of
    /// nsIAuthPrompt2::promptUsernameAndPassword or
    /// nsIAuthPrompt2::promptPasswordAsync provides an object implementing this
    /// interface; the prompt implementation can then read the values here to prefill
    /// the dialog. After the user entered the authentication information, it should
    /// set the attributes of this object to indicate to the caller what was entered
    /// by the user.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0d73639c-2a92-4518-9f92-28f71fea5f20")]
	public interface nsIAuthInformation
	{
		
		/// <summary>
        /// Flags describing this dialog. A bitwise OR of the flag values
        /// above.
        ///
        /// It is possible that neither #AUTH_HOST nor #AUTH_PROXY are set.
        ///
        /// Auth prompts should ignore flags they don't understand; especially, they
        /// should not throw an exception because of an unsupported flag.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFlagsAttribute();
		
		/// <summary>
        /// The server-supplied realm of the authentication as defined in RFC 2617.
        /// Can be the empty string if the protocol does not support realms.
        /// Otherwise, this is a human-readable string like "Secret files".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRealmAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRealm);
		
		/// <summary>
        /// The authentication scheme used for this request, if applicable. If the
        /// protocol for this authentication does not support schemes, this will be
        /// the empty string. Otherwise, this will be a string such as "basic" or
        /// "digest". This string will always be in lowercase.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAuthenticationSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aAuthenticationScheme);
		
		/// <summary>
        /// The initial value should be used to prefill the dialog or be shown
        /// in some other way to the user.
        /// On return, this parameter should contain the username entered by
        /// the user.
        /// This field can only be changed if the #ONLY_PASSWORD flag is not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername);
		
		/// <summary>
        /// The initial value should be used to prefill the dialog or be shown
        /// in some other way to the user.
        /// On return, this parameter should contain the username entered by
        /// the user.
        /// This field can only be changed if the #ONLY_PASSWORD flag is not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername);
		
		/// <summary>
        /// The initial value should be used to prefill the dialog or be shown
        /// in some other way to the user.
        /// The password should not be shown in clear.
        /// On return, this parameter should contain the password entered by
        /// the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword);
		
		/// <summary>
        /// The initial value should be used to prefill the dialog or be shown
        /// in some other way to the user.
        /// The password should not be shown in clear.
        /// On return, this parameter should contain the password entered by
        /// the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword);
		
		/// <summary>
        /// The initial value should be used to prefill the dialog or be shown
        /// in some other way to the user.
        /// On return, this parameter should contain the domain entered by
        /// the user.
        /// This attribute is only used if flags include #NEED_DOMAIN.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDomainAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDomain);
		
		/// <summary>
        /// The initial value should be used to prefill the dialog or be shown
        /// in some other way to the user.
        /// On return, this parameter should contain the domain entered by
        /// the user.
        /// This attribute is only used if flags include #NEED_DOMAIN.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDomainAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDomain);
	}
}
