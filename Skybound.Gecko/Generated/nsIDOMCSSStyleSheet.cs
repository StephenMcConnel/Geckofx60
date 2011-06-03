// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMCSSStyleSheet.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMCSSStyleSheet.idl
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
	
	
	/// <summary>nsIDOMCSSStyleSheet </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6cf90c2-15b3-11d2-932e-00805f8add32")]
	public interface nsIDOMCSSStyleSheet : nsIDOMStyleSheet
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member GetDisabledAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetDisabledAttribute();
		
		/// <summary>Member SetDisabledAttribute </summary>
		/// <param name='aDisabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDisabledAttribute(System.Boolean  aDisabled);
		
		/// <summary>Member GetOwnerNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetOwnerNodeAttribute();
		
		/// <summary>Member GetParentStyleSheetAttribute </summary>
		/// <returns>A nsIDOMStyleSheet </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMStyleSheet  GetParentStyleSheetAttribute();
		
		/// <summary>Member GetHrefAttribute </summary>
		/// <param name='aHref'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetHrefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		/// <summary>Member GetTitleAttribute </summary>
		/// <param name='aTitle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		/// <summary>Member GetMediaAttribute </summary>
		/// <returns>A nsIDOMMediaList </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMMediaList  GetMediaAttribute();
		
		/// <summary>Member GetOwnerRuleAttribute </summary>
		/// <returns>A nsIDOMCSSRule </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule  GetOwnerRuleAttribute();
		
		/// <summary>Member GetCssRulesAttribute </summary>
		/// <returns>A nsIDOMCSSRuleList </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRuleList  GetCssRulesAttribute();
		
		/// <summary>Member InsertRule </summary>
		/// <param name='rule'> </param>
		/// <param name='index'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint InsertRule([MarshalAs(UnmanagedType.LPStruct)] nsAString rule, System.UInt32  index);
		
		/// <summary>Member DeleteRule </summary>
		/// <param name='index'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteRule(System.UInt32  index);
	}
}
