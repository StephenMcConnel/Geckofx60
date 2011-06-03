// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIRDFXMLParser.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIRDFXMLParser.idl
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
	
	
	/// <summary>nsIRDFXMLParser </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1831dd2e-1dd2-11b2-bdb3-86b7b50b70b5")]
	public interface nsIRDFXMLParser
	{
		
		/// <summary>Member ParseAsync </summary>
		/// <param name='aSink'> </param>
		/// <param name='aBaseURI'> </param>
		/// <returns>A nsIStreamListener</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStreamListener ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource  aSink, [MarshalAs(UnmanagedType.Interface)] nsIURI  aBaseURI);
		
		/// <summary>Member ParseString </summary>
		/// <param name='aSink'> </param>
		/// <param name='aBaseURI'> </param>
		/// <param name='aSource'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseString([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource  aSink, [MarshalAs(UnmanagedType.Interface)] nsIURI  aBaseURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aSource);
	}
}
