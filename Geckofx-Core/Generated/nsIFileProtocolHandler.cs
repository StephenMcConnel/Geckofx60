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
// Generated by IDLImporter from file nsIFileProtocolHandler.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1fb25bd5-4354-4dcd-8d97-621b7b3ed2e4")]
	public interface nsIFileProtocolHandler : nsIProtocolHandler
	{
		
		/// <summary>
        /// The scheme of this protocol (e.g., "file").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);
		
		/// <summary>
        /// The default port is the port that this protocol normally uses.
        /// If a port does not make sense for the protocol (e.g., "about:")
        /// then -1 will be returned.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetDefaultPortAttribute();
		
		/// <summary>
        /// Returns the protocol specific flags (see flag definitions below).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetProtocolFlagsAttribute();
		
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
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// Constructs a new channel from the given URI for this protocol handler and
        /// sets the loadInfo for the constructed channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIChannel NewChannel2([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadinfo);
		
		/// <summary>
        /// Constructs a new channel from the given URI for this protocol handler.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIChannel NewChannel([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Allows a protocol to override blacklisted ports.
        ///
        /// This method will be called when there is an attempt to connect to a port
        /// that is blacklisted.  For example, for most protocols, port 25 (Simple Mail
        /// Transfer) is banned.  When a URI containing this "known-to-do-bad-things"
        /// port number is encountered, this function will be called to ask if the
        /// protocol handler wants to override the ban.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool AllowPort(int port, [MarshalAs(UnmanagedType.LPStr)] string scheme);
		
		/// <summary>
        /// This method constructs a new file URI
        ///
        /// @param aFile nsIFile
        /// @return reference to a new nsIURI object
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewFileURI([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
		
		/// <summary>
        /// This method constructs a new file URI, and returns a URI mutator
        /// that has not yet been finalized, allowing the URI to be changed without
        /// being cloned.
        ///
        /// @param aFile nsIFile
        /// @return reference to a new nsIURIMutator object
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator NewFileURIMutator([MarshalAs(UnmanagedType.Interface)] nsIFile file);
		
		/// <summary>
        /// Converts the nsIFile to the corresponding URL string.  NOTE: under
        /// some platforms this is a lossy conversion (e.g., Mac Carbon build).
        /// If the nsIFile is a local file, then the result will be a file://
        /// URL string.
        ///
        /// The resulting string may contain URL-escaped characters.
        /// NOTE: Callers should use getURLSpecFromActualFile or
        /// getURLSpecFromDirFile if possible, for performance reasons.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURLSpecFromFile([MarshalAs(UnmanagedType.Interface)] nsIFile file, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Converts the nsIFile to the corresponding URL string. Should
        /// only be called on files which are not directories. Otherwise
        /// identical to getURLSpecFromFile, but is usually more efficient.
        /// WARNING: This restriction may not be enforced at runtime!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURLSpecFromActualFile([MarshalAs(UnmanagedType.Interface)] nsIFile file, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Converts the nsIFile to the corresponding URL string. Should
        /// only be called on files which are directories. Otherwise
        /// identical to getURLSpecFromFile, but is usually more efficient.
        /// WARNING: This restriction may not be enforced at runtime!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURLSpecFromDir([MarshalAs(UnmanagedType.Interface)] nsIFile file, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Converts the URL string into the corresponding nsIFile if possible.
        /// A local file will be created if the URL string begins with file://.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetFileFromURLSpec([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase url);
		
		/// <summary>
        /// Takes a local file and tries to interpret it as an internet shortcut
        /// (e.g. .url files on windows).
        /// @param file The local file to read
        /// @return The URI the file refers to
        ///
        /// @throw NS_ERROR_NOT_AVAILABLE if the OS does not support such files.
        /// @throw NS_ERROR_NOT_AVAILABLE if this file is not an internet shortcut.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI ReadURLFile([MarshalAs(UnmanagedType.Interface)] nsIFile file);
	}
}
