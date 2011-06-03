// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: txINodeSet.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file txINodeSet.idl
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
	
	
	/// <summary>txINodeSet </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("15d424c0-6b47-11d9-9791-000a95dc234c")]
	public interface txINodeSet
	{
		
		/// <summary>Member Item </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(System.UInt32  index);
		
		/// <summary>Member ItemAsNumber </summary>
		/// <param name='index'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double ItemAsNumber(System.UInt32  index);
		
		/// <summary>Member ItemAsString </summary>
		/// <param name='index'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString ItemAsString(System.UInt32  index);
		
		/// <summary>Member GetLengthAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLengthAttribute();
		
		/// <summary>Member Add </summary>
		/// <param name='node'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Add([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  node);
	}
}
