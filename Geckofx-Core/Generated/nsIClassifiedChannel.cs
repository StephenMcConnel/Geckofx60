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
// Generated by IDLImporter from file nsIClassifiedChannel.idl
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
    /// nsIClassifiedChannel
    ///
    /// A channel may optionally implement this interface if it carries classified
    /// result information of channel classifier. The information contains, for
    /// example, the name of matched table and the name of matched provider.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("70cf6091-a1de-4aa8-8224-058f8964be31")]
	public interface nsIClassifiedChannel
	{
		
		/// <summary>
        /// Sets matched info of the classified channel.
        ///
        /// @param aList
        /// Name of the Safe Browsing list that matched (e.g. goog-phish-shavar).
        /// @param aProvider
        /// Name of the Safe Browsing provider that matched (e.g. google)
        /// @param aFullHash
        /// Full hash of URL that matched Safe Browsing list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMatchedInfo([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aList, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProvider, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFullHash);
		
		/// <summary>
        /// Name of the list that matched
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMatchedListAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMatchedList);
		
		/// <summary>
        /// Name of provider that matched
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMatchedProviderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMatchedProvider);
		
		/// <summary>
        /// Full hash of URL that matched
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMatchedFullHashAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMatchedFullHash);
	}
}