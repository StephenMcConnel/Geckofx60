// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIAccessNode.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIAccessNode.idl
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
	
	
	/// <summary>nsIAccessNode </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ef16ff42-0256-4b48-ae87-b18a95b7f7d6")]
	public interface nsIAccessNode
	{
		
		/// <summary>Member GetDOMNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetDOMNodeAttribute();
		
		/// <summary>Member GetDocumentAttribute </summary>
		/// <returns>A nsIAccessibleDocument </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleDocument  GetDocumentAttribute();
		
		/// <summary>Member GetRootDocumentAttribute </summary>
		/// <returns>A nsIAccessibleDocument </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleDocument  GetRootDocumentAttribute();
		
		/// <summary>Member GetInnerHTMLAttribute </summary>
		/// <param name='aInnerHTML'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInnerHTMLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aInnerHTML);
		
		/// <summary>Member ScrollTo </summary>
		/// <param name='aScrollType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollTo(System.UInt32  aScrollType);
		
		/// <summary>Member ScrollToPoint </summary>
		/// <param name='aCoordinateType'> </param>
		/// <param name='aX'> </param>
		/// <param name='aY'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollToPoint(System.UInt32  aCoordinateType, System.Int32  aX, System.Int32  aY);
		
		/// <summary>Member GetOwnerWindowAttribute </summary>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  GetOwnerWindowAttribute();
		
		/// <summary>Member GetUniqueIDAttribute </summary>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  GetUniqueIDAttribute();
		
		/// <summary>Member GetComputedStyleValue </summary>
		/// <param name='pseudoElt'> </param>
		/// <param name='propertyName'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetComputedStyleValue([MarshalAs(UnmanagedType.LPStruct)] nsAString pseudoElt, [MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName);
		
		/// <summary>Member GetComputedStyleCSSValue </summary>
		/// <param name='pseudoElt'> </param>
		/// <param name='propertyName'> </param>
		/// <returns>A nsIDOMCSSPrimitiveValue</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSPrimitiveValue GetComputedStyleCSSValue([MarshalAs(UnmanagedType.LPStruct)] nsAString pseudoElt, [MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName);
		
		/// <summary>Member GetLanguageAttribute </summary>
		/// <param name='aLanguage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLanguageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLanguage);
	}
}
