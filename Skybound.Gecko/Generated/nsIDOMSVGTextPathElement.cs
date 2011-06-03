// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMSVGTextPathElement.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMSVGTextPathElement.idl
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
	
	
	/// <summary>nsIDOMSVGTextPathElement </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5c29a76c-3489-48fe-b9ea-ea0f5b196dff")]
	public interface nsIDOMSVGTextPathElement : nsIDOMSVGTextContentElement
	{
		
		/// <summary>Member GetNodeNameAttribute </summary>
		/// <param name='aNodeName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		/// <summary>Member GetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>Member SetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>Member GetNodeTypeAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeTypeAttribute();
		
		/// <summary>Member GetParentNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetParentNodeAttribute();
		
		/// <summary>Member GetChildNodesAttribute </summary>
		/// <returns>A nsIDOMNodeList </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList  GetChildNodesAttribute();
		
		/// <summary>Member GetFirstChildAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetFirstChildAttribute();
		
		/// <summary>Member GetLastChildAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetLastChildAttribute();
		
		/// <summary>Member GetPreviousSiblingAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetPreviousSiblingAttribute();
		
		/// <summary>Member GetNextSiblingAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetNextSiblingAttribute();
		
		/// <summary>Member GetAttributesAttribute </summary>
		/// <returns>A nsIDOMNamedNodeMap </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap  GetAttributesAttribute();
		
		/// <summary>Member GetOwnerDocumentAttribute </summary>
		/// <returns>A nsIDOMDocument </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument  GetOwnerDocumentAttribute();
		
		/// <summary>Member InsertBefore </summary>
		/// <param name='newChild'> </param>
		/// <param name='refChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  refChild);
		
		/// <summary>Member ReplaceChild </summary>
		/// <param name='newChild'> </param>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  oldChild);
		
		/// <summary>Member RemoveChild </summary>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  oldChild);
		
		/// <summary>Member AppendChild </summary>
		/// <param name='newChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild);
		
		/// <summary>Member HasChildNodes </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		/// <summary>Member CloneNode </summary>
		/// <param name='deep'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(System.Boolean  deep);
		
		/// <summary>Member Normalize </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>Member IsSupported </summary>
		/// <param name='feature'> </param>
		/// <param name='version'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		/// <summary>Member GetNamespaceURIAttribute </summary>
		/// <param name='aNamespaceURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		/// <summary>Member GetPrefixAttribute </summary>
		/// <param name='aPrefix'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>Member SetPrefixAttribute </summary>
		/// <param name='aPrefix'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>Member GetLocalNameAttribute </summary>
		/// <param name='aLocalName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		/// <summary>Member HasAttributes </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		/// <summary>Member GetTagNameAttribute </summary>
		/// <param name='aTagName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTagNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTagName);
		
		/// <summary>Member GetAttribute </summary>
		/// <param name='name'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member SetAttribute </summary>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member RemoveAttribute </summary>
		/// <param name='name'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member GetAttributeNode </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNode([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member SetAttributeNode </summary>
		/// <param name='newAttr'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr  newAttr);
		
		/// <summary>Member RemoveAttributeNode </summary>
		/// <param name='oldAttr'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr RemoveAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr  oldAttr);
		
		/// <summary>Member GetElementsByTagName </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member GetAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>Member SetAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='qualifiedName'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member RemoveAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>Member GetAttributeNodeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNodeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>Member SetAttributeNodeNS </summary>
		/// <param name='newAttr'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNodeNS([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr  newAttr);
		
		/// <summary>Member GetElementsByTagNameNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>Member HasAttribute </summary>
		/// <param name='name'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member HasAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>Member GetIdAttribute </summary>
		/// <param name='aId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		/// <summary>Member SetIdAttribute </summary>
		/// <param name='aId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		/// <summary>Member GetOwnerSVGElementAttribute </summary>
		/// <returns>A nsIDOMSVGSVGElement </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGSVGElement  GetOwnerSVGElementAttribute();
		
		/// <summary>Member GetViewportElementAttribute </summary>
		/// <returns>A nsIDOMSVGElement </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGElement  GetViewportElementAttribute();
		
		/// <summary>Member GetTextLengthAttribute </summary>
		/// <returns>A nsIDOMSVGAnimatedLength </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGAnimatedLength  GetTextLengthAttribute();
		
		/// <summary>Member GetLengthAdjustAttribute </summary>
		/// <returns>A nsIDOMSVGAnimatedEnumeration </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGAnimatedEnumeration  GetLengthAdjustAttribute();
		
		/// <summary>Member GetNumberOfChars </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetNumberOfChars();
		
		/// <summary>Member GetComputedTextLength </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new double GetComputedTextLength();
		
		/// <summary>Member GetSubStringLength </summary>
		/// <param name='charnum'> </param>
		/// <param name='nchars'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new double GetSubStringLength(System.UInt32  charnum, System.UInt32  nchars);
		
		/// <summary>Member GetStartPositionOfChar </summary>
		/// <param name='charnum'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGPoint GetStartPositionOfChar(System.UInt32  charnum);
		
		/// <summary>Member GetEndPositionOfChar </summary>
		/// <param name='charnum'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGPoint GetEndPositionOfChar(System.UInt32  charnum);
		
		/// <summary>Member GetExtentOfChar </summary>
		/// <param name='charnum'> </param>
		/// <returns>A nsIDOMSVGRect</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGRect GetExtentOfChar(System.UInt32  charnum);
		
		/// <summary>Member GetRotationOfChar </summary>
		/// <param name='charnum'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new double GetRotationOfChar(System.UInt32  charnum);
		
		/// <summary>Member GetCharNumAtPosition </summary>
		/// <param name='point'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetCharNumAtPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPoint  point);
		
		/// <summary>Member SelectSubString </summary>
		/// <param name='charnum'> </param>
		/// <param name='nchars'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SelectSubString(System.UInt32  charnum, System.UInt32  nchars);
		
		/// <summary>Member GetStartOffsetAttribute </summary>
		/// <returns>A nsIDOMSVGAnimatedLength </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGAnimatedLength  GetStartOffsetAttribute();
		
		/// <summary>Member GetMethodAttribute </summary>
		/// <returns>A nsIDOMSVGAnimatedEnumeration </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGAnimatedEnumeration  GetMethodAttribute();
		
		/// <summary>Member GetSpacingAttribute </summary>
		/// <returns>A nsIDOMSVGAnimatedEnumeration </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGAnimatedEnumeration  GetSpacingAttribute();
	}
}
