// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIObjectLoadingContent.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIObjectLoadingContent.idl
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
	
	
	/// <summary>nsIObjectLoadingContent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9558649a-7255-4b00-afb4-1171e9cdcead")]
	public interface nsIObjectLoadingContent
	{
		
		/// <summary>Member GetActualTypeAttribute </summary>
		/// <param name='aActualType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetActualTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aActualType);
		
		/// <summary>Member GetDisplayedTypeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetDisplayedTypeAttribute();
		
		/// <summary>Member GetContentTypeForMIMEType </summary>
		/// <param name='aMimeType'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetContentTypeForMIMEType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aMimeType);
		
		/// <summary>Member GetPluginInstanceAttribute </summary>
		/// <returns>A nsIPluginInstance </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPluginInstance  GetPluginInstanceAttribute();
		
		/// <summary>Member EnsureInstantiation </summary>
		/// <returns>A nsIPluginInstance</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPluginInstance EnsureInstantiation();
		
		/// <summary>Member HasNewFrame </summary>
		/// <param name='aFrame'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HasNewFrame(System.IntPtr aFrame);
		
		/// <summary>Member SetAbsoluteScreenPosition </summary>
		/// <param name='element'> </param>
		/// <param name='position'> </param>
		/// <param name='clip'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAbsoluteScreenPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMElement  element, [MarshalAs(UnmanagedType.Interface)] nsIDOMClientRect  position, [MarshalAs(UnmanagedType.Interface)] nsIDOMClientRect  clip);
		
		/// <summary>Member GetPrintFrame </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPrintFrame();
		
		/// <summary>Member PluginCrashed </summary>
		/// <param name='pluginTag'> </param>
		/// <param name='pluginDumpID'> </param>
		/// <param name='browserDumpID'> </param>
		/// <param name='submittedCrashReport'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PluginCrashed([MarshalAs(UnmanagedType.Interface)] nsIPluginTag  pluginTag, [MarshalAs(UnmanagedType.LPStruct)] nsAString pluginDumpID, [MarshalAs(UnmanagedType.LPStruct)] nsAString browserDumpID, System.Boolean  submittedCrashReport);
	}
}
