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
// Generated by IDLImporter from file nsIContentSecurityManager.idl
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
    /// nsIContentSecurityManager
    /// Describes an XPCOM component used to perform security checks.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3a9a1818-2ae8-4ec5-a340-8b29d31fca3b")]
	public interface nsIContentSecurityManager
	{
		
		/// <summary>
        /// Checks whether a channel is allowed to access the given URI and
        /// whether the channel should be openend or should be blocked consulting
        /// internal security checks like Same Origin Policy, Content Security
        /// Policy, Mixed Content Blocker, etc.
        ///
        /// If security checks within performSecurityCheck fail, the function
        /// throws an exception.
        ///
        /// @param aChannel
        /// The channel about to be openend
        /// @param aStreamListener
        /// The Streamlistener of the channel potentially wrapped
        /// into CORSListenerProxy.
        /// @return
        /// The StreamListener of the channel wrapped into CORSListenerProxy.
        ///
        /// @throws NS_ERROR_DOM_BAD_URI
        /// If accessing the URI is not allowed (e.g. prohibted by SOP)
        /// @throws NS_ERROR_CONTENT_BLOCKED
        /// If any of the security policies (CSP, Mixed content) is violated
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStreamListener PerformSecurityCheck([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener aStreamListener);
		
		/// <summary>
        /// Implementation of
        /// https://w3c.github.io/webappsec-secure-contexts/#is-origin-trustworthy
        ///
        /// The value returned by this method feeds into the the Secure Context
        /// algorithm that determins the value of Window.isSecureContext and
        /// WorkerGlobalScope.isSecureContext.
        ///
        /// This method returns false instead of throwing upon errors.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsOriginPotentiallyTrustworthy([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
	}
}
