// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMRect.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMRect.idl
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
	
	
	/// <summary>nsIDOMRect </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("71735f62-ac5c-4236-9a1f-5ffb280d531c")]
	public interface nsIDOMRect
	{
		
		/// <summary>Member GetTopAttribute </summary>
		/// <returns>A nsIDOMCSSPrimitiveValue </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSPrimitiveValue  GetTopAttribute();
		
		/// <summary>Member GetRightAttribute </summary>
		/// <returns>A nsIDOMCSSPrimitiveValue </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSPrimitiveValue  GetRightAttribute();
		
		/// <summary>Member GetBottomAttribute </summary>
		/// <returns>A nsIDOMCSSPrimitiveValue </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSPrimitiveValue  GetBottomAttribute();
		
		/// <summary>Member GetLeftAttribute </summary>
		/// <returns>A nsIDOMCSSPrimitiveValue </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSPrimitiveValue  GetLeftAttribute();
	}
}
