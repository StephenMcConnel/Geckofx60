// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMSVGPointList.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMSVGPointList.idl
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
	
	
	/// <summary>nsIDOMSVGPointList </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4c12af24-0fc2-4fe7-b71d-5d6b41d463c1")]
	public interface nsIDOMSVGPointList
	{
		
		/// <summary>Member GetNumberOfItemsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetNumberOfItemsAttribute();
		
		/// <summary>Member Clear </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
		
		/// <summary>Member Initialize </summary>
		/// <param name='newItem'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPoint Initialize([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPoint  newItem);
		
		/// <summary>Member GetItem </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPoint GetItem(System.UInt32  index);
		
		/// <summary>Member InsertItemBefore </summary>
		/// <param name='newItem'> </param>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPoint InsertItemBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPoint  newItem, System.UInt32  index);
		
		/// <summary>Member ReplaceItem </summary>
		/// <param name='newItem'> </param>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPoint ReplaceItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPoint  newItem, System.UInt32  index);
		
		/// <summary>Member RemoveItem </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPoint RemoveItem(System.UInt32  index);
		
		/// <summary>Member AppendItem </summary>
		/// <param name='newItem'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPoint AppendItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPoint  newItem);
	}
}
