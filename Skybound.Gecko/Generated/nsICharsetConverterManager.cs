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
// Generated by IDLImporter from file nsICharsetConverterManager.idl
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
    ///
    /// Here Charsets are identified by ASCII strings. Charset alias
    /// resolution is provided by default in most methods. "Raw"
    /// versions that do not need this resolution are also provided.
    ///
    /// @created         21/Feb/2000
    /// @author  Catalin Rotaru [CATA]
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6aba73aa-be22-46a9-bf81-c117557f65b5")]
	public interface nsICharsetConverterManager
	{
		
		/// <summary>
        /// Get the Unicode decoder for the given charset.
        /// The "Raw" version skips charset alias resolution
        /// The "Internal" version will return a decoder for any charset; the others
        /// will return NS_ERROR_UCONV_NOCONV if the requested charsets is
        /// vulnerable to XSS attacks and should not be used with untrusted input
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeDecoder([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeDecoderRaw([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeDecoderInternal([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeDecoderRawInternal([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		/// <summary>
        /// Get the Unicode encoder for the given charset.
        /// The "Raw" version skips charset alias resolution
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeEncoder([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeEncoderRaw([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		/// <summary>
        /// A shortcut to calling nsICharsetAlias to do alias resolution
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetCharsetAlias([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		/// <summary>
        /// Get the complete list of available decoders.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator GetDecoderList();
		
		/// <summary>
        /// Get the complete list of available encoders.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator GetEncoderList();
		
		/// <summary>
        /// Get the complete list of available charset detectors.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator GetCharsetDetectorList();
		
		/// <summary>
        /// Get the human-readable name for the given charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetCharsetTitle([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		/// <summary>
        /// Get some data about the given charset. This includes whether the
        /// character encoding may be used for certain purposes, if it is
        /// multi-byte, and the language code for it. See charsetData.properties
        /// for the source of this data. Some known property names:
        /// notForBrowser  - not to be used in the browser.
        /// notForOutgoing - not to be used for exporting files.
        /// LangGroup      - language code for charset, e.g. 'he' and 'zh-CN'.
        /// isMultibyte    - is this a multi-byte charset?
        /// isXSSVulnerable - not to be used in untrusted web content
        ///
        /// @param charset name of the character encoding, e.g. 'iso-8859-15'.
        /// @param prop property desired for the character encoding.
        /// @return the value of the property, for the character encoding.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetCharsetData([MarshalAs(UnmanagedType.LPStr)] System.String  charset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string prop);
		
		/// <summary>
        /// Get the language group for the given charset. This is similar to
        /// calling <tt>getCharsetData</tt> with the <tt>prop</tt> "LangGroup".
        ///
        /// @param charset name of the character encoding, e.g. 'iso-8859-15'.
        /// @return the language code for the character encoding.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAtom GetCharsetLangGroup([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAtom GetCharsetLangGroupRaw([MarshalAs(UnmanagedType.LPStr)] System.String  charset);
	}
}
