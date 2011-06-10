// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIProtocolProxyService2.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIProtocolProxyService2.idl
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
	
	
	/// <summary>nsIProtocolProxyService2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dbd9565d-29b1-437a-bff5-2fc339e2c5df")]
	public interface nsIProtocolProxyService2 : nsIProtocolProxyService
	{
		
		/// <summary>Member Resolve </summary>
		/// <param name='aURI'> </param>
		/// <param name='aFlags'> </param>
		/// <returns>A nsIProxyInfo</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIProxyInfo Resolve([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, System.UInt32  aFlags);
		
		/// <summary>Member AsyncResolve </summary>
		/// <param name='aURI'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aCallback'> </param>
		/// <returns>A nsICancelable</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsICancelable AsyncResolve([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, System.UInt32  aFlags, [MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyCallback  aCallback);
		
		/// <summary>Member NewProxyInfo </summary>
		/// <param name='aType'> </param>
		/// <param name='aHost'> </param>
		/// <param name='aPort'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aFailoverTimeout'> </param>
		/// <param name='aFailoverProxy'> </param>
		/// <returns>A nsIProxyInfo</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIProxyInfo NewProxyInfo([MarshalAs(UnmanagedType.LPStruct)] nsAString  aType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aHost, System.Int32  aPort, System.UInt32  aFlags, System.UInt32  aFailoverTimeout, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo  aFailoverProxy);
		
		/// <summary>Member GetFailoverForProxy </summary>
		/// <param name='aProxyInfo'> </param>
		/// <param name='aURI'> </param>
		/// <param name='aReason'> </param>
		/// <returns>A nsIProxyInfo</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIProxyInfo GetFailoverForProxy([MarshalAs(UnmanagedType.Interface)] nsIProxyInfo  aProxyInfo, [MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, System.Int32  aReason);
		
		/// <summary>Member RegisterFilter </summary>
		/// <param name='aFilter'> </param>
		/// <param name='aPosition'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RegisterFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyFilter  aFilter, System.UInt32  aPosition);
		
		/// <summary>Member UnregisterFilter </summary>
		/// <param name='aFilter'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void UnregisterFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyFilter  aFilter);
		
		/// <summary>Member GetProxyConfigTypeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetProxyConfigTypeAttribute();
		
		/// <summary>Member ReloadPAC </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReloadPAC();
	}
}
