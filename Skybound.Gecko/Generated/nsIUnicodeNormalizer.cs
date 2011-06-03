// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIUnicodeNormalizer.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIUnicodeNormalizer.idl
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
	
	
	/// <summary>nsIUnicodeNormalizer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B43A461F-1BCF-4329-820B-66E48C979E14")]
	public interface nsIUnicodeNormalizer
	{
		
		/// <summary>Member NormalizeUnicodeNFD </summary>
		/// <param name='aSrc'> </param>
		/// <param name='aDest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NormalizeUnicodeNFD([MarshalAs(UnmanagedType.LPStruct)] nsAString aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsAString aDest);
		
		/// <summary>Member NormalizeUnicodeNFC </summary>
		/// <param name='aSrc'> </param>
		/// <param name='aDest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NormalizeUnicodeNFC([MarshalAs(UnmanagedType.LPStruct)] nsAString aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsAString aDest);
		
		/// <summary>Member NormalizeUnicodeNFKD </summary>
		/// <param name='aSrc'> </param>
		/// <param name='aDest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NormalizeUnicodeNFKD([MarshalAs(UnmanagedType.LPStruct)] nsAString aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsAString aDest);
		
		/// <summary>Member NormalizeUnicodeNFKC </summary>
		/// <param name='aSrc'> </param>
		/// <param name='aDest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NormalizeUnicodeNFKC([MarshalAs(UnmanagedType.LPStruct)] nsAString aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsAString aDest);
	}
}
