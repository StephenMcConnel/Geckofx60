// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIJumpListBuilder.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIJumpListBuilder.idl
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
	
	
	/// <summary>nsIJumpListBuilder </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1FE6A9CD-2B18-4dd5-A176-C2B32FA4F683")]
	public interface nsIJumpListBuilder
	{
		
		/// <summary>Member GetAvailableAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetAvailableAttribute();
		
		/// <summary>Member GetIsListCommittedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsListCommittedAttribute();
		
		/// <summary>Member GetMaxListItemsAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetMaxListItemsAttribute();
		
		/// <summary>Member InitListBuild </summary>
		/// <param name='removedItems'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool InitListBuild([MarshalAs(UnmanagedType.Interface)] nsIMutableArray  removedItems);
		
		/// <summary>Member AddListToBuild </summary>
		/// <param name='aCatType'> </param>
		/// <param name='items'> </param>
		/// <param name='catName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AddListToBuild(short aCatType, [MarshalAs(UnmanagedType.Interface)] nsIArray  items, [MarshalAs(UnmanagedType.LPStruct)] nsAString catName);
		
		/// <summary>Member AbortListBuild </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AbortListBuild();
		
		/// <summary>Member CommitListBuild </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CommitListBuild();
		
		/// <summary>Member DeleteActiveList </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DeleteActiveList();
	}
}
