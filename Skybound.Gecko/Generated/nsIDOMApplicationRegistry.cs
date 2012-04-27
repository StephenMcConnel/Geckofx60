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
// Generated by IDLImporter from file nsIDOMApplicationRegistry.idl
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
	
	
	/// <summary>mozIDOMApplicationRegistryError </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0c271cb-266b-48c9-a7e4-96590b445c26")]
	public interface mozIDOMApplicationRegistryError
	{
		
		/// <summary>Member GetCodeAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetCodeAttribute();
	}
	
	/// <summary>mozIDOMApplication </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6856a3d-dece-43ce-89b9-72dba07f4246")]
	public interface mozIDOMApplication
	{
		
		/// <summary>Member GetManifestAttribute </summary>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetManifestAttribute();
		
		/// <summary>Member GetReceiptAttribute </summary>
		/// <param name='aReceipt'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReceiptAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReceipt);
		
		/// <summary>Member GetOriginAttribute </summary>
		/// <param name='aOrigin'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aOrigin);
		
		/// <summary>Member GetInstallOriginAttribute </summary>
		/// <param name='aInstallOrigin'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInstallOriginAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aInstallOrigin);
		
		/// <summary>Member GetInstallTimeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetInstallTimeAttribute();
	}
	
	/// <summary>mozIDOMApplicationRegistryEnumerateCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("be170df5-9154-463b-9197-10a6195eba52")]
	public interface mozIDOMApplicationRegistryEnumerateCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		/// <param name='apps'> </param>
		/// <param name='count'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent(mozIDOMApplication apps, uint count);
	}
	
	/// <summary>mozIDOMApplicationRegistryErrorCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ae0ed33d-35cf-443a-837b-a6cebf16bd49")]
	public interface mozIDOMApplicationRegistryErrorCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		/// <param name='error'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent(mozIDOMApplicationRegistryError error);
	}
	
	/// <summary>mozIDOMApplicationRegistry </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ac63c0ba-1f33-4e3e-b9aa-6a3243a9adba")]
	public interface mozIDOMApplicationRegistry
	{
		
		/// <summary>
        /// Install a web app. onerror can be used to report errors,
        /// and oninstall if the caller is privileged.
        ///
        /// @param manifestUrl : the URL of the webapps manifest
        /// @param receipt : An opaque string used to track payment status
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Install([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase manifestUrl, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase receipt);
		
		/// <summary>
        /// This call is only accessible to privileged callers.
        ///
        /// @param origin : the origin of the application to uninstall.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uninstall([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase origin);
		
		/// <summary>
        /// Enumerate apps : either return itself if caller is an app, or
        /// apps installed from a store if caller is a store
        ///
        /// @param success: the callback that will get the array of applications
        /// @param error: optional error callback
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Enumerate(mozIDOMApplicationRegistryEnumerateCallback success, mozIDOMApplicationRegistryErrorCallback error);
		
		/// <summary>
        /// Enumerate all apps installed from all stores.
        /// Only usable by privileged callers.
        ///
        /// @param success: the callback that will get the array of applications
        /// @param error: optional error callback
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnumerateAll(mozIDOMApplicationRegistryEnumerateCallback success, mozIDOMApplicationRegistryErrorCallback error);
		
		/// <summary>
        /// launch a webapp. Behavior is application dependant.
        ///
        /// @param origin : the origin of the application to launch
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Launch([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase origin);
		
		/// <summary>
        /// event listener to get notified of application installs. Only settable by
        /// privileged callers
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOninstallAttribute();
		
		/// <summary>
        /// event listener to get notified of application installs. Only settable by
        /// privileged callers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOninstallAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOninstall);
		
		/// <summary>
        /// event listener to get notified of application uninstalls. Only settable by
        /// privileged callers
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnuninstallAttribute();
		
		/// <summary>
        /// event listener to get notified of application uninstalls. Only settable by
        /// privileged callers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnuninstallAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnuninstall);
		
		/// <summary>
        /// event listener to get notified of errors.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnerrorAttribute();
		
		/// <summary>
        /// event listener to get notified of errors.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnerror);
	}
}
