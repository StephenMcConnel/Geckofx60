// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIStringBundleOverride.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIStringBundleOverride.idl
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
	
	
	/// <summary>nsIStringBundleOverride </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("965eb278-5678-456b-82a7-20a0c86a803c")]
	public interface nsIStringBundleOverride
	{
		
		/// <summary>Member GetStringFromName </summary>
		/// <param name='url'> </param>
		/// <param name='key'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetStringFromName([MarshalAs(UnmanagedType.LPStruct)] nsAString  url, [MarshalAs(UnmanagedType.LPStruct)] nsAString  key);
		
		/// <summary>Member EnumerateKeysInBundle </summary>
		/// <param name='url'> </param>
		/// <returns>A nsISimpleEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateKeysInBundle([MarshalAs(UnmanagedType.LPStruct)] nsAString  url);
	}
}
