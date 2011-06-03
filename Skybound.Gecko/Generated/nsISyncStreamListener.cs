// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISyncStreamListener.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISyncStreamListener.idl
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
	
	
	/// <summary>nsISyncStreamListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7e1aa658-6e3f-4521-9946-9685a169f764")]
	public interface nsISyncStreamListener : nsIStreamListener
	{
		
		/// <summary>Member OnStartRequest </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext);
		
		/// <summary>Member OnStopRequest </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aStatusCode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, System.Int32  aStatusCode);
		
		/// <summary>Member OnDataAvailable </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aInputStream'> </param>
		/// <param name='aOffset'> </param>
		/// <param name='aCount'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream  aInputStream, System.UInt32  aOffset, System.UInt32  aCount);
		
		/// <summary>Member GetInputStreamAttribute </summary>
		/// <returns>A nsIInputStream </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream  GetInputStreamAttribute();
	}
}
