// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIKeyModule.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIKeyModule.idl
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
	
	
	/// <summary>nsIKeyObject </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4b31f4ed-9424-4710-b946-79b7e33cf3a8")]
	public interface nsIKeyObject
	{
		
		/// <summary>Member InitKey </summary>
		/// <param name='aAlgorithm'> </param>
		/// <param name='aKey'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitKey(short aAlgorithm, System.IntPtr  aKey);
		
		/// <summary>Member GetKeyObj </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetKeyObj();
		
		/// <summary>Member GetType </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetType();
	}
	
	/// <summary>nsIKeyObjectFactory </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("264eb54d-e20d-49a0-890c-1a5986ea81c4")]
	public interface nsIKeyObjectFactory
	{
		
		/// <summary>Member LookupKeyByName </summary>
		/// <param name='aName'> </param>
		/// <returns>A nsIKeyObject</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIKeyObject LookupKeyByName([MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member UnwrapKey </summary>
		/// <param name='aAlgorithm'> </param>
		/// <param name='aWrappedKey'> </param>
		/// <param name='aWrappedKeyLen'> </param>
		/// <returns>A nsIKeyObject</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIKeyObject UnwrapKey(short aAlgorithm, System.IntPtr  aWrappedKey, System.UInt32  aWrappedKeyLen);
		
		/// <summary>Member KeyFromString </summary>
		/// <param name='aAlgorithm'> </param>
		/// <param name='aKey'> </param>
		/// <returns>A nsIKeyObject</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIKeyObject KeyFromString(short aAlgorithm, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aKey);
	}
}
