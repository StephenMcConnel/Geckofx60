// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISSLErrorListener.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISSLErrorListener.idl
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
	
	
	/// <summary>nsISSLErrorListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("99f8d972-bae4-414c-b39b-47587d3ded68")]
	public interface nsISSLErrorListener
	{
		
		/// <summary>Member NotifySSLError </summary>
		/// <param name='socketInfo'> </param>
		/// <param name='error'> </param>
		/// <param name='targetSite'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NotifySSLError([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor  socketInfo, System.Int32  error, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  targetSite);
	}
}
