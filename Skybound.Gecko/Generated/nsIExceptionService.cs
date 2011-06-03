// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIExceptionService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIExceptionService.idl
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
	
	
	/// <summary>nsIExceptionProvider </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0577744c-c1d2-47f2-8bcc-ce7a9e5a88fc")]
	public interface nsIExceptionProvider
	{
		
		/// <summary>Member GetException </summary>
		/// <param name='result'> </param>
		/// <param name='defaultException'> </param>
		/// <returns>A nsIException</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIException GetException(System.Int32  result, [MarshalAs(UnmanagedType.Interface)] nsIException  defaultException);
	}
	
	/// <summary>nsIExceptionManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("efc9d00b-231c-4feb-852c-ac017266a415")]
	public interface nsIExceptionManager
	{
		
		/// <summary>Member SetCurrentException </summary>
		/// <param name='error'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentException([MarshalAs(UnmanagedType.Interface)] nsIException  error);
		
		/// <summary>Member GetCurrentException </summary>
		/// <returns>A nsIException</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIException GetCurrentException();
		
		/// <summary>Member GetExceptionFromProvider </summary>
		/// <param name='rc'> </param>
		/// <param name='defaultException'> </param>
		/// <returns>A nsIException</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIException GetExceptionFromProvider(System.Int32  rc, [MarshalAs(UnmanagedType.Interface)] nsIException  defaultException);
	}
	
	/// <summary>nsIExceptionService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("35A88F54-F267-4414-92A7-191F6454AB52")]
	public interface nsIExceptionService : nsIExceptionManager
	{
		
		/// <summary>Member SetCurrentException </summary>
		/// <param name='error'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCurrentException([MarshalAs(UnmanagedType.Interface)] nsIException  error);
		
		/// <summary>Member GetCurrentException </summary>
		/// <returns>A nsIException</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIException GetCurrentException();
		
		/// <summary>Member GetExceptionFromProvider </summary>
		/// <param name='rc'> </param>
		/// <param name='defaultException'> </param>
		/// <returns>A nsIException</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIException GetExceptionFromProvider(System.Int32  rc, [MarshalAs(UnmanagedType.Interface)] nsIException  defaultException);
		
		/// <summary>Member GetCurrentExceptionManagerAttribute </summary>
		/// <returns>A nsIExceptionManager </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIExceptionManager  GetCurrentExceptionManagerAttribute();
		
		/// <summary>Member RegisterExceptionProvider </summary>
		/// <param name='provider'> </param>
		/// <param name='moduleCode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterExceptionProvider([MarshalAs(UnmanagedType.Interface)] nsIExceptionProvider  provider, System.UInt32  moduleCode);
		
		/// <summary>Member UnregisterExceptionProvider </summary>
		/// <param name='provider'> </param>
		/// <param name='moduleCode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterExceptionProvider([MarshalAs(UnmanagedType.Interface)] nsIExceptionProvider  provider, System.UInt32  moduleCode);
	}
}
