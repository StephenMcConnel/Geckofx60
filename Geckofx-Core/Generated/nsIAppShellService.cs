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
// Generated by IDLImporter from file nsIAppShellService.idl
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
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("19266025-354c-4bb9-986b-3483b2b1cdef")]
	public interface nsIAppShellService
	{
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow CreateTopLevelWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aParent, [MarshalAs(UnmanagedType.Interface)] nsIURI aUrl, uint aChromeMask, int aInitialWidth, int aInitialHeight, [MarshalAs(UnmanagedType.Interface)] nsITabParent aOpeningTab, mozIDOMWindowProxy aOpenerWindow);
		
		/// <summary>
        /// This is the constructor for creating an invisible DocShell.
        /// It is used to simulate DOM windows without an actual physical
        /// representation.
        /// @param aIsChrome Set true if you want to use it for chrome content.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWindowlessBrowser CreateWindowlessBrowser([MarshalAs(UnmanagedType.U1)] bool aIsChrome);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateHiddenWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DestroyHiddenWindow();
		
		/// <summary>
        /// B2G multi-screen support. When open another top-level window on b2g,
        /// a screen ID is needed for identifying which screen this window is
        /// opened to.
        /// @param aScreenId Differentiate screens of windows. It is platform-
        /// specific due to the hardware limitation for now.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScreenId(uint aScreenId);
		
		/// <summary>
        /// Return the (singleton) application hidden window, automatically created
        /// and maintained by this AppShellService.
        /// @param aResult the hidden window.  Do not unhide hidden window.
        /// Do not taunt hidden window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow GetHiddenWindowAttribute();
		
		/// <summary>
        /// Return the (singleton) application hidden window, automatically created
        /// and maintained by this AppShellService.
        /// @param aResult the hidden window.  Do not unhide hidden window.
        /// Do not taunt hidden window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIDOMWindowProxy GetHiddenDOMWindowAttribute();
		
		/// <summary>
        /// Return the (singleton) application hidden private window, automatically
        /// created and maintained by this AppShellService.  This window is created
        /// in private browsing mode.
        /// @param aResult the hidden private window.  Do not unhide hidden window.
        /// Do not taunt hidden window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow GetHiddenPrivateWindowAttribute();
		
		/// <summary>
        /// Return the (singleton) application hidden private window, automatically
        /// created and maintained by this AppShellService.  This window is created
        /// in private browsing mode.
        /// @param aResult the hidden private window.  Do not unhide hidden window.
        /// Do not taunt hidden window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIDOMWindowProxy GetHiddenPrivateDOMWindowAttribute();
		
		/// <summary>
        /// Return true if the application hidden window was provided by the
        /// application. If it wasn't, the default hidden window was used. This will
        /// usually be false on all non-mac platforms.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetApplicationProvidedHiddenWindowAttribute();
		
		/// <summary>
        /// Add a window to the application's registry of windows.  These windows
        /// are generally shown in the Windows taskbar, and the application
        /// knows it can't quit until it's out of registered windows.
        /// @param aWindow the window to register
        /// @note When this method is successful, it fires the global notification
        /// "xul-window-registered"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterTopLevelWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);
		
		/// <summary>
        /// Remove a window from the application's window registry. Note that
        /// this method won't automatically attempt to quit the app when
        /// the last window is unregistered. For that, see Quit().
        /// @param aWindow you see the pattern
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterTopLevelWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow aWindow);
		
		/// <summary>
        /// Whether the hidden private window has been lazily created.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasHiddenPrivateWindowAttribute();
		
		/// <summary>
        /// Start/stop tracking lags in the event loop.
        /// If the event loop gets unresponsive, a "event-loop-lag" notification
        /// is sent. Note that calling `startEventLoopLagTracking` when tracking
        /// is already enabled has no effect.
        /// @return true if tracking succeeded.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool StartEventLoopLagTracking();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopEventLoopLagTracking();
	}
	
	/// <summary>nsIAppShellServiceConsts </summary>
	public class nsIAppShellServiceConsts
	{
		
		// <summary>
        // Create a window, which will be initially invisible.
        // @param aParent the parent window.  Can be null.
        // @param aUrl the contents of the new window.
        // @param aChromeMask chrome flags affecting the kind of OS border
        // given to the window. see nsIBrowserWindow for
        // bit/flag definitions.
        // @param aCallbacks interface providing C++ hooks for window initialization
        // before the window is made visible.  Can be null.
        // Deprecated.
        // @param aInitialWidth width, in pixels, of the window.  Width of window
        // at creation.  Can be overridden by the "width"
        // tag in the XUL.  Set to NS_SIZETOCONTENT to force
        // the window to wrap to its contents.
        // @param aInitialHeight like aInitialWidth, but subtly different.
        // @param aOpeningTab The TabParent that requested that this window be opened.
        // Can be left null.
        // @param aOpenerWindow The Window Proxy which requested that this window be opened.
        // Can be left null.
        // </summary>
		public const long SIZE_TO_CONTENT = -1;
	}
}
