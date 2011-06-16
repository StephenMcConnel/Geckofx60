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
// Generated by IDLImporter from file nsIFeedTextConstruct.idl
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
    /// nsIFeedTextConstructs represent feed text fields that can contain
    /// one of text, HTML, or XHTML. Some extension elements also have "type"
    /// parameters, and this interface could be used there as well.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fc97a2a9-d649-4494-931e-db81a156c873")]
	public interface nsIFeedTextConstruct
	{
		
		/// <summary>
        /// If the text construct contains (X)HTML, relative references in
        /// the content should be resolved against this base URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetBaseAttribute();
		
		/// <summary>
        /// If the text construct contains (X)HTML, relative references in
        /// the content should be resolved against this base URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBase);
		
		/// <summary>
        /// The language of the text. For example, "en-US" for US English.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLangAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLang);
		
		/// <summary>
        /// The language of the text. For example, "en-US" for US English.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLangAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLang);
		
		/// <summary>
        /// One of "text", "html", or "xhtml". If the type is (x)html, a '<'
        /// character represents markup. To display that character, an escape
        /// such as &lt; must be used. If the type is "text", the '<'
        /// character represents the character itself, and such text should
        /// not be embedded in markup without escaping it first.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>
        /// One of "text", "html", or "xhtml". If the type is (x)html, a '<'
        /// character represents markup. To display that character, an escape
        /// such as &lt; must be used. If the type is "text", the '<'
        /// character represents the character itself, and such text should
        /// not be embedded in markup without escaping it first.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>
        /// The content of the text construct.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aText);
		
		/// <summary>
        /// The content of the text construct.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aText);
		
		/// <summary>
        /// Returns the text of the text construct, with all markup stripped
        /// and all entities decoded. If the type attribute's value is "text",
        /// this function returns the value of the text attribute unchanged.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PlainText([MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Return an nsIDocumentFragment containing the text and markup.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocumentFragment CreateDocumentFragment([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);
	}
}
