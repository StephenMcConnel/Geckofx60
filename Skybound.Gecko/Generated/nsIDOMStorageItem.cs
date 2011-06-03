// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMStorageItem.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMStorageItem.idl
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
	
	
	/// <summary>nsIDOMStorageItem </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0CC37C78-4C5F-48E1-ADFC-7480B8FE9DC4")]
	public interface nsIDOMStorageItem
	{
		
		/// <summary>Member GetSecureAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetSecureAttribute();
		
		/// <summary>Member SetSecureAttribute </summary>
		/// <param name='aSecure'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecureAttribute(System.Boolean  aSecure);
		
		/// <summary>Member GetValueAttribute </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		/// <summary>Member SetValueAttribute </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
	}
}
