// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISocketProviderService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISocketProviderService.idl
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
	
	
	/// <summary>nsISocketProviderService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8f8a23d0-5472-11d3-bbc8-0000861d1237")]
	public interface nsISocketProviderService
	{
		
		/// <summary>Member GetSocketProvider </summary>
		/// <param name='socketType'> </param>
		/// <returns>A nsISocketProvider</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISocketProvider GetSocketProvider([MarshalAs(UnmanagedType.LPStr)] System.String  socketType);
	}
}
