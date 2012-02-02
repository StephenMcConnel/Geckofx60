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
// Generated by IDLImporter from file nsICookieManager.idl
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
    /// An optional interface for accessing or removing the cookies
    /// that are in the cookie list
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AAAB6710-0F2C-11d5-A53B-0010A401EB10")]
	public interface nsICookieManager
	{
		
		/// <summary>
        /// Called to remove all cookies from the cookie list
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAll();
		
		/// <summary>
        /// Called to enumerate through each cookie in the cookie list.
        /// The objects enumerated over are of type nsICookie
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetEnumeratorAttribute();
		
		/// <summary>
        /// Called to remove an individual cookie from the cookie list, specified
        /// by host, name, and path. If the cookie cannot be found, no exception
        /// is thrown. Typically, the arguments to this method will be obtained
        /// directly from the desired nsICookie object.
        ///
        /// @param aHost The host or domain for which the cookie was set. @see
        /// nsICookieManager2::add for a description of acceptable host
        /// strings. If the target cookie is a domain cookie, a leading
        /// dot must be present.
        /// @param aName The name specified in the cookie
        /// @param aPath The path for which the cookie was set
        /// @param aBlocked Indicates if cookies from this host should be permanently blocked
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aHost, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aPath, [MarshalAs(UnmanagedType.Bool)] bool aBlocked);
	}
}
