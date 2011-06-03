// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsICertPickDialogs.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsICertPickDialogs.idl
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
	
	
	/// <summary>nsICertPickDialogs </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("51d59b08-1dd2-11b2-ad4a-a51b92f8a184")]
	public interface nsICertPickDialogs
	{
		
		/// <summary>Member PickCertificate </summary>
		/// <param name='ctx'> </param>
		/// <param name='certNickList'> </param>
		/// <param name='certDetailsList'> </param>
		/// <param name='count'> </param>
		/// <param name='selectedIndex'> </param>
		/// <param name='canceled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PickCertificate([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor  ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=3)] string certNickList, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=3)] string certDetailsList, System.UInt32  count, ref System.Int32  selectedIndex, out System.Boolean  canceled);
	}
}
