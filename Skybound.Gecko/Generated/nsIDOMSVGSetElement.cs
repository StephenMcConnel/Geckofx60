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
// Generated by IDLImporter from file nsIDOMSVGSetElement.idl
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
	
	
	/// <summary>nsIDOMSVGSetElement </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("11e4330d-fb38-4ab8-b580-3c2ff5228e6d")]
	public interface nsIDOMSVGSetElement : nsIDOMSVGAnimationElement
	{
		
		/// <summary>Member GetNodeNameAttribute </summary>
		/// <param name='aNodeName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeName);
		
		/// <summary>Member GetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeValue);
		
		/// <summary>Member SetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeValue);
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeTypeAttribute();
		
		/// <summary>Member GetParentNodeAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNodeAttribute();
		
		/// <summary>Member GetParentElementAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetParentElementAttribute();
		
		/// <summary>Member GetChildNodesAttribute </summary>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodesAttribute();
		
		/// <summary>Member GetFirstChildAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChildAttribute();
		
		/// <summary>Member GetLastChildAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChildAttribute();
		
		/// <summary>Member GetPreviousSiblingAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSiblingAttribute();
		
		/// <summary>Member GetNextSiblingAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSiblingAttribute();
		
		/// <summary>Member GetAttributesAttribute </summary>
		/// <returns>A nsIDOMNamedNodeMap</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributesAttribute();
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocumentAttribute();
		
		/// <summary>Member InsertBefore </summary>
		/// <param name='newChild'> </param>
		/// <param name='refChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode refChild);
		
		/// <summary>Member ReplaceChild </summary>
		/// <param name='newChild'> </param>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		/// <summary>Member RemoveChild </summary>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		/// <summary>Member AppendChild </summary>
		/// <param name='newChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild);
		
		/// <summary>Member HasChildNodes </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		/// <summary>Member CloneNode </summary>
		/// <param name='deep'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode([MarshalAs(UnmanagedType.U1)] bool deep);
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase feature, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase version);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNamespaceURI);
		
		/// <summary>
        /// Modified in DOM Core
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLocalName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		/// <summary>
        /// nsINode::GetBaseURI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBaseURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBaseURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint CompareDocumentPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMNode other);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTextContent);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTextContent);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LookupPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDefaultNamespace([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LookupNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prefix, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsEqualNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode arg);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant SetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key, [MarshalAs(UnmanagedType.Interface)] nsIVariant data, [MarshalAs(UnmanagedType.Interface)] nsIDOMUserDataHandler handler);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant GetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key);
		
		/// <summary>Member Contains </summary>
		/// <param name='aOther'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Contains([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aOther);
		
		/// <summary>
        /// The nsIDOMElement interface represents an element in an HTML or
        /// XML document.
        ///
        /// For more information on this interface please see
        /// http://dvcs.w3.org/hg/domcore/raw-file/tip/Overview.html#interface-element
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTagNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTagName);
		
		/// <summary>
        /// Returns a DOMTokenList object reflecting the class attribute.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDOMTokenList GetClassListAttribute();
		
		/// <summary>Member GetAttribute </summary>
		/// <param name='name'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>Member GetAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>Member SetAttribute </summary>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase value);
		
		/// <summary>Member SetAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='qualifiedName'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase qualifiedName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase value);
		
		/// <summary>Member RemoveAttribute </summary>
		/// <param name='name'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>Member RemoveAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		/// <summary>Member HasAttribute </summary>
		/// <param name='name'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>Member HasAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		/// <summary>
        /// Obsolete methods.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNode([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>Member SetAttributeNode </summary>
		/// <param name='newAttr'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr newAttr);
		
		/// <summary>Member RemoveAttributeNode </summary>
		/// <param name='oldAttr'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr RemoveAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr oldAttr);
		
		/// <summary>Member GetAttributeNodeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNodeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		/// <summary>Member SetAttributeNodeNS </summary>
		/// <param name='newAttr'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNodeNS([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr newAttr);
		
		/// <summary>Member GetElementsByTagName </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>Member GetElementsByTagNameNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		/// <summary>
        /// Retrieve elements matching all classes listed in a
        /// space-separated string.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase classes);
		
		/// <summary>
        /// Returns a live nsIDOMNodeList of the current child elements.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildrenAttribute();
		
		/// <summary>
        /// Similar as the attributes on nsIDOMNode, but navigates just elements
        /// rather than all nodes.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetFirstElementChildAttribute();
		
		/// <summary>Member GetLastElementChildAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetLastElementChildAttribute();
		
		/// <summary>Member GetPreviousElementSiblingAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetPreviousElementSiblingAttribute();
		
		/// <summary>Member GetNextElementSiblingAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetNextElementSiblingAttribute();
		
		/// <summary>
        /// Returns the number of child nodes that are nsIDOMElements.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetChildElementCountAttribute();
		
		/// <summary>
        /// HTML
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new Gecko.JsVal GetOnmouseenterAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// HTML
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnmouseenterAttribute(Gecko.JsVal aOnmouseenter, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmouseleaveAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new Gecko.JsVal GetOnmouseleaveAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmouseleaveAttribute </summary>
		/// <param name='aOnmouseleave'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnmouseleaveAttribute(Gecko.JsVal aOnmouseleave, System.IntPtr jsContext);
		
		/// <summary>
        /// Retrieve a list of rectangles, one for each CSS border-box associated with
        /// the element. The coordinates are in CSS pixels, and relative to
        /// the top-left of the document's viewport, unless the document
        /// has an SVG foreignobject ancestor, in which case the coordinates are
        /// relative to the top-left of the content box of the nearest SVG foreignobject
        /// ancestor. The coordinates are calculated as if every scrollable element
        /// is scrolled to its default position.
        ///
        /// Note: the boxes of overflowing children do not affect these rectangles.
        /// Note: some elements have empty CSS boxes. Those return empty rectangles,
        /// but the coordinates may still be meaningful.
        /// Note: some elements have no CSS boxes (including display:none elements,
        /// HTML AREA elements, and SVG elements that do not render). Those return
        /// an empty list.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMClientRectList GetClientRects();
		
		/// <summary>
        /// Returns the union of all rectangles in the getClientRects() list. Empty
        /// rectangles are ignored, except that if all rectangles are empty,
        /// we return an empty rectangle positioned at the top-left of the first
        /// rectangle in getClientRects().
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMClientRect GetBoundingClientRect();
		
		/// <summary>
        /// The vertical scroll position of the element, or 0 if the element is not
        /// scrollable. This property may be assigned a value to change the
        /// vertical scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollTopAttribute();
		
		/// <summary>
        /// The vertical scroll position of the element, or 0 if the element is not
        /// scrollable. This property may be assigned a value to change the
        /// vertical scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetScrollTopAttribute(int aScrollTop);
		
		/// <summary>
        /// The horizontal scroll position of the element, or 0 if the element is not
        /// scrollable. This property may be assigned a value to change the
        /// horizontal scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollLeftAttribute();
		
		/// <summary>
        /// The horizontal scroll position of the element, or 0 if the element is not
        /// scrollable. This property may be assigned a value to change the
        /// horizontal scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetScrollLeftAttribute(int aScrollLeft);
		
		/// <summary>
        /// The width of the scrollable area of the element. If the element is not
        /// scrollable, scrollWidth is equivalent to the offsetWidth.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollWidthAttribute();
		
		/// <summary>
        /// The height of the scrollable area of the element. If the element is not
        /// scrollable, scrollHeight is equivalent to the offsetHeight.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollHeightAttribute();
		
		/// <summary>
        /// The height in CSS pixels of the element's top border.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientTopAttribute();
		
		/// <summary>
        /// The width in CSS pixels of the element's left border and scrollbar
        /// if it is present on the left side.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientLeftAttribute();
		
		/// <summary>
        /// The height in CSS pixels of the element's padding box. If the element is
        /// scrollable, the scroll bars are included inside this width.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientWidthAttribute();
		
		/// <summary>
        /// The width in CSS pixels of the element's padding box. If the element is
        /// scrollable, the scroll bars are included inside this height.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientHeightAttribute();
		
		/// <summary>
        /// Returns whether this element would be selected by the given selector
        /// string.
        ///
        /// See <http://dev.w3.org/2006/webapi/selectors-api2/#matchesselector>
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool MozMatchesSelector([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase selector);
		
		/// <summary>
        /// Set this during a mousedown event to grab and retarget all mouse events
        /// to this element until the mouse button is released or releaseCapture is
        /// called. If retargetToElement is true, then all events are targetted at
        /// this element. If false, events can also fire at descendants of this
        /// element.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCapture([MarshalAs(UnmanagedType.U1)] bool retargetToElement);
		
		/// <summary>
        /// If this element has captured the mouse, release the capture. If another
        /// element has captured the mouse, this method has no effect.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ReleaseCapture();
		
		/// <summary>Member GetIdAttribute </summary>
		/// <param name='aId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aId);
		
		/// <summary>Member SetIdAttribute </summary>
		/// <param name='aId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aId);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGSVGElement GetOwnerSVGElementAttribute();
		
		/// <summary>Member GetViewportElementAttribute </summary>
		/// <returns>A nsIDOMSVGElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGElement GetViewportElementAttribute();
		
		/// <summary>
        ///The SVG DOM makes use of multiple interface inheritance.
        ///        Since XPCOM only supports single interface inheritance,
        ///        the best thing that we can do is to promise that whenever
        ///        an object implements _this_ interface it will also
        ///        implement the following interfaces. (We then have to QI to
        ///        hop between them.)
        ///
        ///    nsIDOMSVGTests,
        ///    nsIDOMSVGExternalResourcesRequired,
        ///    smil::nsIDOMElementTimeControl,
        ///    events::nsIDOMEventTarget </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGElement GetTargetElementAttribute();
		
		/// <summary>Member GetStartTime </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new float GetStartTime();
		
		/// <summary>
        /// raises ( DOMException )
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new float GetCurrentTime();
		
		/// <summary>Member GetSimpleDuration </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new float GetSimpleDuration();
	}
}
