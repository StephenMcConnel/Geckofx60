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
// Generated by IDLImporter from file nsIProxiedProtocolHandler.idl
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
	
	
	/// <summary>nsIProxiedProtocolHandler </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0a24fed4-1dd2-11b2-a75c-9f8b9a8f9ba7")]
	public interface nsIProxiedProtocolHandler : nsIProtocolHandler
	{
		
		/// <summary>
        /// The scheme of this protocol (e.g., "file").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aScheme);
		
		/// <summary>
        /// The default port is the port that this protocol normally uses.
        /// If a port does not make sense for the protocol (e.g., "about:")
        /// then -1 will be returned.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetDefaultPortAttribute();
		
		/// <summary>
        /// Returns the protocol specific flags (see flag definitions below).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetProtocolFlagsAttribute();
		
		/// <summary>
        /// Makes a URI object that is suitable for loading by this protocol,
        /// where the URI string is given as an UTF-8 string.  The caller may
        /// provide the charset from which the URI string originated, so that
        /// the URI string can be translated back to that charset (if necessary)
        /// before communicating with, for example, the origin server of the URI
        /// string.  (Many servers do not support UTF-8 IRIs at the present time,
        /// so we must be careful about tracking the native charset of the origin
        /// server.)
        ///
        /// @param aSpec          - the URI string in UTF-8 encoding. depending
        /// on the protocol implementation, unicode character
        /// sequences may or may not be %xx escaped.
        /// @param aOriginCharset - the charset of the document from which this URI
        /// string originated.  this corresponds to the
        /// charset that should be used when communicating
        /// this URI to an origin server, for example.  if
        /// null, then UTF-8 encoding is assumed (i.e.,
        /// no charset transformation from aSpec).
        /// @param aBaseURI       - if null, aSpec must specify an absolute URI.
        /// otherwise, aSpec may be resolved relative
        /// to aBaseURI, depending on the protocol.
        /// If the protocol has no concept of relative
        /// URI aBaseURI will simply be ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aSpec, [MarshalAs(UnmanagedType.LPStr)] System.String  aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI  aBaseURI);
		
		/// <summary>
        /// Constructs a new channel from the given URI for this protocol handler.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIChannel NewChannel([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>
        /// Allows a protocol to override blacklisted ports.
        ///
        /// This method will be called when there is an attempt to connect to a port
        /// that is blacklisted.  For example, for most protocols, port 25 (Simple Mail
        /// Transfer) is banned.  When a URI containing this "known-to-do-bad-things"
        /// port number is encountered, this function will be called to ask if the
        /// protocol handler wants to override the ban.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool AllowPort(System.Int32  port, [MarshalAs(UnmanagedType.LPStr)] System.String  scheme);
		
		/// <summary>
        ///Create a new channel with the given proxyInfo
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewProxiedChannel([MarshalAs(UnmanagedType.Interface)] nsIURI  uri, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo  proxyInfo);
	}
}
