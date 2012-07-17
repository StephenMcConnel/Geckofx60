// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIAndroidBridge.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIBrowserTab </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0843f3c1-043e-4c64-9d8c-091370548c05")]
	public interface nsIBrowserTab
	{
		
		/// <summary>Member GetWindowAttribute </summary>
		/// <returns>A nsIDOMWindow</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetWindowAttribute();
		
		/// <summary>Member GetScaleAttribute </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetScaleAttribute();
	}
	
	/// <summary>nsIAndroidBrowserApp </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d10377b4-1c90-493a-a532-63cb3f16ee2b")]
	public interface nsIAndroidBrowserApp
	{
		
		/// <summary>Member GetBrowserTab </summary>
		/// <param name='tabId'> </param>
		/// <returns>A nsIBrowserTab</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIBrowserTab GetBrowserTab(int tabId);
	}
	
	/// <summary>nsIAndroidBridge </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bbb8e0d7-5cca-4ad0-88be-538ce6d04f63")]
	public interface nsIAndroidBridge
	{
		
		/// <summary>Member HandleGeckoMessage </summary>
		/// <param name='message'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleGeckoMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase message, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>Member GetBrowserAppAttribute </summary>
		/// <returns>A nsIAndroidBrowserApp</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAndroidBrowserApp GetBrowserAppAttribute();
		
		/// <summary>Member SetBrowserAppAttribute </summary>
		/// <param name='aBrowserApp'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBrowserAppAttribute([MarshalAs(UnmanagedType.Interface)] nsIAndroidBrowserApp aBrowserApp);
	}
}
