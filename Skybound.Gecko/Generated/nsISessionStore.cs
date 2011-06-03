// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISessionStore.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISessionStore.idl
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
	
	
	/// <summary>nsISessionStore </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("59bfaf00-e3d8-4728-b4f0-cc0b9dfb4806")]
	public interface nsISessionStore
	{
		
		/// <summary>Member Init </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow);
		
		/// <summary>Member GetCanRestoreLastSessionAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetCanRestoreLastSessionAttribute();
		
		/// <summary>Member SetCanRestoreLastSessionAttribute </summary>
		/// <param name='aCanRestoreLastSession'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCanRestoreLastSessionAttribute(System.Boolean  aCanRestoreLastSession);
		
		/// <summary>Member RestoreLastSession </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RestoreLastSession();
		
		/// <summary>Member GetBrowserState </summary>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetBrowserState();
		
		/// <summary>Member SetBrowserState </summary>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBrowserState([MarshalAs(UnmanagedType.LPStruct)] nsAString aState);
		
		/// <summary>Member GetWindowState </summary>
		/// <param name='aWindow'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetWindowState([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow);
		
		/// <summary>Member SetWindowState </summary>
		/// <param name='aWindow'> </param>
		/// <param name='aState'> </param>
		/// <param name='aOverwrite'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindowState([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow, [MarshalAs(UnmanagedType.LPStruct)] nsAString aState, System.Boolean  aOverwrite);
		
		/// <summary>Member GetTabState </summary>
		/// <param name='aTab'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetTabState([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aTab);
		
		/// <summary>Member SetTabState </summary>
		/// <param name='aTab'> </param>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTabState([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aTab, [MarshalAs(UnmanagedType.LPStruct)] nsAString aState);
		
		/// <summary>Member DuplicateTab </summary>
		/// <param name='aWindow'> </param>
		/// <param name='aTab'> </param>
		/// <param name='aDelta'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode DuplicateTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aTab, System.Int32  aDelta);
		
		/// <summary>Member GetClosedTabCount </summary>
		/// <param name='aWindow'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetClosedTabCount([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow);
		
		/// <summary>Member GetClosedTabData </summary>
		/// <param name='aWindow'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetClosedTabData([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow);
		
		/// <summary>Member UndoCloseTab </summary>
		/// <param name='aWindow'> </param>
		/// <param name='aIndex'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode UndoCloseTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow, System.UInt32  aIndex);
		
		/// <summary>Member ForgetClosedTab </summary>
		/// <param name='aWindow'> </param>
		/// <param name='aIndex'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ForgetClosedTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow, System.UInt32  aIndex);
		
		/// <summary>Member GetClosedWindowCount </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetClosedWindowCount();
		
		/// <summary>Member GetClosedWindowData </summary>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetClosedWindowData();
		
		/// <summary>Member UndoCloseWindow </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsIDOMWindow</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow UndoCloseWindow(System.UInt32  aIndex);
		
		/// <summary>Member ForgetClosedWindow </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ForgetClosedWindow(System.UInt32  aIndex);
		
		/// <summary>Member GetWindowValue </summary>
		/// <param name='aWindow'> </param>
		/// <param name='aKey'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetWindowValue([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey);
		
		/// <summary>Member SetWindowValue </summary>
		/// <param name='aWindow'> </param>
		/// <param name='aKey'> </param>
		/// <param name='aStringValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindowValue([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey, [MarshalAs(UnmanagedType.LPStruct)] nsAString aStringValue);
		
		/// <summary>Member DeleteWindowValue </summary>
		/// <param name='aWindow'> </param>
		/// <param name='aKey'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteWindowValue([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey);
		
		/// <summary>Member GetTabValue </summary>
		/// <param name='aTab'> </param>
		/// <param name='aKey'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aTab, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey);
		
		/// <summary>Member SetTabValue </summary>
		/// <param name='aTab'> </param>
		/// <param name='aKey'> </param>
		/// <param name='aStringValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aTab, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey, [MarshalAs(UnmanagedType.LPStruct)] nsAString aStringValue);
		
		/// <summary>Member DeleteTabValue </summary>
		/// <param name='aTab'> </param>
		/// <param name='aKey'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aTab, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey);
		
		/// <summary>Member PersistTabAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PersistTabAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
	}
}
