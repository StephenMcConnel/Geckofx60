// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPermissionManager.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPermissionManager.idl
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
	
	
	/// <summary>nsIPermissionManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0b83f9d5-3f96-41b6-91aa-ff3a7e4880d7")]
	public interface nsIPermissionManager
	{
		
		/// <summary>Member Add </summary>
		/// <param name='uri'> </param>
		/// <param name='type'> </param>
		/// <param name='permission'> </param>
		/// <param name='expireType'> </param>
		/// <param name='expireTime'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Add([MarshalAs(UnmanagedType.Interface)] nsIURI  uri, [MarshalAs(UnmanagedType.LPStr)] System.String  type, System.UInt32  permission, System.UInt32  expireType, System.Int64  expireTime);
		
		/// <summary>Member Remove </summary>
		/// <param name='host'> </param>
		/// <param name='type'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove([MarshalAs(UnmanagedType.LPStruct)] nsAString  host, [MarshalAs(UnmanagedType.LPStr)] System.String  type);
		
		/// <summary>Member RemoveAll </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAll();
		
		/// <summary>Member TestPermission </summary>
		/// <param name='uri'> </param>
		/// <param name='type'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestPermission([MarshalAs(UnmanagedType.Interface)] nsIURI  uri, [MarshalAs(UnmanagedType.LPStr)] System.String  type);
		
		/// <summary>Member TestExactPermission </summary>
		/// <param name='uri'> </param>
		/// <param name='type'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestExactPermission([MarshalAs(UnmanagedType.Interface)] nsIURI  uri, [MarshalAs(UnmanagedType.LPStr)] System.String  type);
		
		/// <summary>Member GetEnumeratorAttribute </summary>
		/// <returns>A nsISimpleEnumerator </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator  GetEnumeratorAttribute();
	}
}
