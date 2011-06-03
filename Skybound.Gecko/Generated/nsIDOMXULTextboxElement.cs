// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMXULTextboxElement.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMXULTextboxElement.idl
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
	
	
	/// <summary>nsIDOMXULTextBoxElement </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("806a706e-2bae-4aec-a53e-5432eb4a7025")]
	public interface nsIDOMXULTextBoxElement : nsIDOMXULControlElement
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
		
		/// <summary>Member GetClassNameAttribute </summary>
		/// <param name='aClassName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
		
		/// <summary>Member SetClassNameAttribute </summary>
		/// <param name='aClassName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
		
		/// <summary>Member GetAlignAttribute </summary>
		/// <param name='aAlign'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAlignAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAlign);
		
		/// <summary>Member SetAlignAttribute </summary>
		/// <param name='aAlign'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAlignAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAlign);
		
		/// <summary>Member GetDirAttribute </summary>
		/// <param name='aDir'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		/// <summary>Member SetDirAttribute </summary>
		/// <param name='aDir'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		/// <summary>Member GetFlexAttribute </summary>
		/// <param name='aFlex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFlexAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlex);
		
		/// <summary>Member SetFlexAttribute </summary>
		/// <param name='aFlex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFlexAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlex);
		
		/// <summary>Member GetFlexGroupAttribute </summary>
		/// <param name='aFlexGroup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFlexGroupAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlexGroup);
		
		/// <summary>Member SetFlexGroupAttribute </summary>
		/// <param name='aFlexGroup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFlexGroupAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlexGroup);
		
		/// <summary>Member GetOrdinalAttribute </summary>
		/// <param name='aOrdinal'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetOrdinalAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrdinal);
		
		/// <summary>Member SetOrdinalAttribute </summary>
		/// <param name='aOrdinal'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOrdinalAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrdinal);
		
		/// <summary>Member GetOrientAttribute </summary>
		/// <param name='aOrient'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetOrientAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrient);
		
		/// <summary>Member SetOrientAttribute </summary>
		/// <param name='aOrient'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOrientAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrient);
		
		/// <summary>Member GetPackAttribute </summary>
		/// <param name='aPack'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPackAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPack);
		
		/// <summary>Member SetPackAttribute </summary>
		/// <param name='aPack'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPackAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPack);
		
		/// <summary>Member GetHiddenAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetHiddenAttribute();
		
		/// <summary>Member SetHiddenAttribute </summary>
		/// <param name='aHidden'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHiddenAttribute(System.Boolean  aHidden);
		
		/// <summary>Member GetCollapsedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetCollapsedAttribute();
		
		/// <summary>Member SetCollapsedAttribute </summary>
		/// <param name='aCollapsed'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCollapsedAttribute(System.Boolean  aCollapsed);
		
		/// <summary>Member GetObservesAttribute </summary>
		/// <param name='aObserves'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetObservesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aObserves);
		
		/// <summary>Member SetObservesAttribute </summary>
		/// <param name='aObserves'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetObservesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aObserves);
		
		/// <summary>Member GetMenuAttribute </summary>
		/// <param name='aMenu'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMenuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMenu);
		
		/// <summary>Member SetMenuAttribute </summary>
		/// <param name='aMenu'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetMenuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMenu);
		
		/// <summary>Member GetContextMenuAttribute </summary>
		/// <param name='aContextMenu'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetContextMenuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContextMenu);
		
		/// <summary>Member SetContextMenuAttribute </summary>
		/// <param name='aContextMenu'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContextMenuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContextMenu);
		
		/// <summary>Member GetTooltipAttribute </summary>
		/// <param name='aTooltip'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltip);
		
		/// <summary>Member SetTooltipAttribute </summary>
		/// <param name='aTooltip'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltip);
		
		/// <summary>Member GetWidthAttribute </summary>
		/// <param name='aWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aWidth);
		
		/// <summary>Member SetWidthAttribute </summary>
		/// <param name='aWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aWidth);
		
		/// <summary>Member GetHeightAttribute </summary>
		/// <param name='aHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHeight);
		
		/// <summary>Member SetHeightAttribute </summary>
		/// <param name='aHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHeight);
		
		/// <summary>Member GetMinWidthAttribute </summary>
		/// <param name='aMinWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMinWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMinWidth);
		
		/// <summary>Member SetMinWidthAttribute </summary>
		/// <param name='aMinWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetMinWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMinWidth);
		
		/// <summary>Member GetMinHeightAttribute </summary>
		/// <param name='aMinHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMinHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMinHeight);
		
		/// <summary>Member SetMinHeightAttribute </summary>
		/// <param name='aMinHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetMinHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMinHeight);
		
		/// <summary>Member GetMaxWidthAttribute </summary>
		/// <param name='aMaxWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMaxWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMaxWidth);
		
		/// <summary>Member SetMaxWidthAttribute </summary>
		/// <param name='aMaxWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetMaxWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMaxWidth);
		
		/// <summary>Member GetMaxHeightAttribute </summary>
		/// <param name='aMaxHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMaxHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMaxHeight);
		
		/// <summary>Member SetMaxHeightAttribute </summary>
		/// <param name='aMaxHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetMaxHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMaxHeight);
		
		/// <summary>Member GetPersistAttribute </summary>
		/// <param name='aPersist'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPersistAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPersist);
		
		/// <summary>Member SetPersistAttribute </summary>
		/// <param name='aPersist'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPersistAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPersist);
		
		/// <summary>Member GetLeftAttribute </summary>
		/// <param name='aLeft'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLeftAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeft);
		
		/// <summary>Member SetLeftAttribute </summary>
		/// <param name='aLeft'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLeftAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeft);
		
		/// <summary>Member GetTopAttribute </summary>
		/// <param name='aTop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTopAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTop);
		
		/// <summary>Member SetTopAttribute </summary>
		/// <param name='aTop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTopAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTop);
		
		/// <summary>Member GetDatasourcesAttribute </summary>
		/// <param name='aDatasources'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDatasourcesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDatasources);
		
		/// <summary>Member SetDatasourcesAttribute </summary>
		/// <param name='aDatasources'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDatasourcesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDatasources);
		
		/// <summary>Member GetRefAttribute </summary>
		/// <param name='aRef'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRef);
		
		/// <summary>Member SetRefAttribute </summary>
		/// <param name='aRef'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRef);
		
		/// <summary>Member GetTooltipTextAttribute </summary>
		/// <param name='aTooltipText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTooltipTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltipText);
		
		/// <summary>Member SetTooltipTextAttribute </summary>
		/// <param name='aTooltipText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTooltipTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltipText);
		
		/// <summary>Member GetStatusTextAttribute </summary>
		/// <param name='aStatusText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStatusText);
		
		/// <summary>Member SetStatusTextAttribute </summary>
		/// <param name='aStatusText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStatusText);
		
		/// <summary>Member GetAllowEventsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetAllowEventsAttribute();
		
		/// <summary>Member SetAllowEventsAttribute </summary>
		/// <param name='aAllowEvents'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAllowEventsAttribute(System.Boolean  aAllowEvents);
		
		/// <summary>Member GetDatabaseAttribute </summary>
		/// <returns>A nsIRDFCompositeDataSource </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIRDFCompositeDataSource  GetDatabaseAttribute();
		
		/// <summary>Member GetBuilderAttribute </summary>
		/// <returns>A nsIXULTemplateBuilder </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIXULTemplateBuilder  GetBuilderAttribute();
		
		/// <summary>Member GetResourceAttribute </summary>
		/// <returns>A nsIRDFResource </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIRDFResource  GetResourceAttribute();
		
		/// <summary>Member GetControllersAttribute </summary>
		/// <returns>A nsIControllers </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIControllers  GetControllersAttribute();
		
		/// <summary>Member GetBoxObjectAttribute </summary>
		/// <returns>A nsIBoxObject </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIBoxObject  GetBoxObjectAttribute();
		
		/// <summary>Member Focus </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Focus();
		
		/// <summary>Member Blur </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Blur();
		
		/// <summary>Member Click </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Click();
		
		/// <summary>Member DoCommand </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void DoCommand();
		
		/// <summary>Member GetElementsByAttribute </summary>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member GetElementsByAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member GetDisabledAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetDisabledAttribute();
		
		/// <summary>Member SetDisabledAttribute </summary>
		/// <param name='aDisabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDisabledAttribute(System.Boolean  aDisabled);
		
		/// <summary>Member GetTabIndexAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetTabIndexAttribute();
		
		/// <summary>Member SetTabIndexAttribute </summary>
		/// <param name='aTabIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTabIndexAttribute(System.Int32  aTabIndex);
		
		/// <summary>Member GetInputFieldAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetInputFieldAttribute();
		
		/// <summary>Member GetTextLengthAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetTextLengthAttribute();
		
		/// <summary>Member GetMaxLengthAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetMaxLengthAttribute();
		
		/// <summary>Member SetMaxLengthAttribute </summary>
		/// <param name='aMaxLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMaxLengthAttribute(System.Int32  aMaxLength);
		
		/// <summary>Member GetSizeAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSizeAttribute();
		
		/// <summary>Member SetSizeAttribute </summary>
		/// <param name='aSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSizeAttribute(System.Int32  aSize);
		
		/// <summary>Member GetSelectionStartAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSelectionStartAttribute();
		
		/// <summary>Member SetSelectionStartAttribute </summary>
		/// <param name='aSelectionStart'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionStartAttribute(System.Int32  aSelectionStart);
		
		/// <summary>Member GetSelectionEndAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSelectionEndAttribute();
		
		/// <summary>Member SetSelectionEndAttribute </summary>
		/// <param name='aSelectionEnd'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionEndAttribute(System.Int32  aSelectionEnd);
		
		/// <summary>Member GetValueAttribute </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		/// <summary>Member SetValueAttribute </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member SetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member Select </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Select();
		
		/// <summary>Member SetSelectionRange </summary>
		/// <param name='selectionStart'> </param>
		/// <param name='selectionEnd'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionRange(System.Int32  selectionStart, System.Int32  selectionEnd);
	}
}
