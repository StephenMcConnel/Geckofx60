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
// Generated by IDLImporter from file nsIDOMHTMLAnchorElement.idl
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
    /// The nsIDOMHTMLAnchorElement interface is the interface to a [X]HTML
    /// a element.
    ///
    /// This interface is trying to follow the DOM Level 2 HTML specification:
    /// http://www.w3.org/TR/DOM-Level-2-HTML/
    ///
    /// with changes from the work-in-progress WHATWG HTML specification:
    /// http://www.whatwg.org/specs/web-apps/current-work/
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("768bfb39-f0ce-4f17-bad7-f0f722dc293a")]
	public interface nsIDOMHTMLAnchorElement : nsIDOMHTMLElement
	{
		
		/// <summary>
        /// The nsIDOMNode interface is the primary datatype for the entire
        /// Document Object Model.
        /// It represents a single node in the document tree.
        ///
        /// For more information on this interface please see
        /// http://dvcs.w3.org/hg/domcore/raw-file/tip/Overview.html
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeTypeAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNodeAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChildAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChildAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSiblingAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSiblingAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributesAttribute();
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocumentAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode([MarshalAs(UnmanagedType.Bool)] bool deep);
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		/// <summary>
        /// Modified in DOM Core
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		/// <summary>
        /// The nsIDOMElement interface represents an element in an HTML or
        /// XML document.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Core/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTagNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTagName);
		
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNode([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr newAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr RemoveAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr oldAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNodeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNodeNS([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr newAttr);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// The nsIDOMHTMLElement interface is the primary [X]HTML element
        /// interface. It represents a single [X]HTML element in the document
        /// tree.
        ///
        /// This interface is trying to follow the DOM Level 2 HTML specification:
        /// http://www.w3.org/TR/DOM-Level-2-HTML/
        ///
        /// with changes from the work-in-progress WHATWG HTML specification:
        /// http://www.whatwg.org/specs/web-apps/current-work/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		/// <summary>
        /// The nsIDOMHTMLElement interface is the primary [X]HTML element
        /// interface. It represents a single [X]HTML element in the document
        /// tree.
        ///
        /// This interface is trying to follow the DOM Level 2 HTML specification:
        /// http://www.w3.org/TR/DOM-Level-2-HTML/
        ///
        /// with changes from the work-in-progress WHATWG HTML specification:
        /// http://www.whatwg.org/specs/web-apps/current-work/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLangAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLangAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAccessKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAccessKey);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAccessKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAccessKey);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Blur();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Focus();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Click();
		
		/// <summary>
        /// The nsIDOMHTMLAnchorElement interface is the interface to a [X]HTML
        /// a element.
        ///
        /// This interface is trying to follow the DOM Level 2 HTML specification:
        /// http://www.w3.org/TR/DOM-Level-2-HTML/
        ///
        /// with changes from the work-in-progress WHATWG HTML specification:
        /// http://www.whatwg.org/specs/web-apps/current-work/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHrefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		/// <summary>
        /// The nsIDOMHTMLAnchorElement interface is the interface to a [X]HTML
        /// a element.
        ///
        /// This interface is trying to follow the DOM Level 2 HTML specification:
        /// http://www.w3.org/TR/DOM-Level-2-HTML/
        ///
        /// with changes from the work-in-progress WHATWG HTML specification:
        /// http://www.whatwg.org/specs/web-apps/current-work/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHrefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPing);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPing);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRelAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRel);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRelAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRel);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHreflangAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHreflang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHreflangAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHreflang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>
        /// An alias for the textContent attribute.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aText);
		
		/// <summary>
        /// An alias for the textContent attribute.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aText);
		
		/// <summary>
        /// URL decomposition IDL attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aProtocol);
		
		/// <summary>
        /// URL decomposition IDL attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aProtocol);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHost);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHost);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPort);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPort);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPathnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPathname);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPathnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPathname);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearch);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearch);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHashAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHash);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHashAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHash);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCharset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCharset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCoordsAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCoords);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCoordsAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCoords);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRevAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRev);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRevAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRev);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetShapeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aShape);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShapeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aShape);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTabIndexAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTabIndexAttribute(int aTabIndex);
		
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString ToString();
	}
}
