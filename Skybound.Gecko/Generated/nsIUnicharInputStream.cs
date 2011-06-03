// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIUnicharInputStream.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIUnicharInputStream.idl
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
	
	
	/// <summary>nsIUnicharInputStream </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d5e3bd80-6723-4b92-b0c9-22f6162fd94f")]
	public interface nsIUnicharInputStream
	{
		
		/// <summary>Member Read </summary>
		/// <param name='aBuf'> </param>
		/// <param name='aCount'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Read([MarshalAs(UnmanagedType.LPWStr, SizeParamIndex=1)] System.String  aBuf, System.UInt32  aCount);
		
		/// <summary>Member ReadSegments </summary>
		/// <param name='aWriter'> </param>
		/// <param name='aClosure'> </param>
		/// <param name='aCount'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint ReadSegments(System.IntPtr aWriter, System.IntPtr  aClosure, System.UInt32  aCount);
		
		/// <summary>Member ReadString </summary>
		/// <param name='aCount'> </param>
		/// <param name='aString'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint ReadString(System.UInt32  aCount, [MarshalAs(UnmanagedType.LPStruct)] nsAString aString);
		
		/// <summary>Member Close </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
	}
}
