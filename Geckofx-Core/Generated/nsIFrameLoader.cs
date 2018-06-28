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
// Generated by IDLImporter from file nsIFrameLoader.idl
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
	[Guid("1645af04-1bc7-4363-8f2c-eb9679220ab1")]
	public interface nsIFrameLoader
	{
		
		/// <summary>
        /// Get the docshell from the frame loader.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShell GetDocShellAttribute();
		
		/// <summary>
        /// Get this frame loader's TabParent, if it has a remote frame.  Otherwise,
        /// returns null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITabParent GetTabParentAttribute();
		
		/// <summary>
        /// Get an nsILoadContext for the top-level docshell. For remote
        /// frames, a shim is returned that contains private browsing and app
        /// information.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadContext GetLoadContextAttribute();
		
		/// <summary>
        /// Start loading the frame. This method figures out what to load
        /// from the owner content in the frame loader.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadFrame([MarshalAs(UnmanagedType.U1)] bool originalSrc);
		
		/// <summary>
        /// Loads the specified URI in this frame. Behaves identically to loadFrame,
        /// except that this method allows specifying the URI to load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.U1)] bool originalSrc);
		
		/// <summary>
        /// Adds a blocking promise for the current cross process navigation.
        /// This method can only be called while the "BrowserWillChangeProcess" event
        /// is being fired.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddProcessChangeBlockingPromise(ref Gecko.JsVal aPromise, System.IntPtr jsContext);
		
		/// <summary>
        /// Destroy the frame loader and everything inside it. This will
        /// clear the weak owner content reference.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Destroy();
		
		/// <summary>
        /// Find out whether the loader's frame is at too great a depth in
        /// the frame tree.  This can be used to decide what operations may
        /// or may not be allowed on the loader's docshell.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDepthTooGreatAttribute();
		
		/// <summary>
        /// Updates the position and size of the subdocument loaded by this frameloader.
        ///
        /// @param aIFrame The nsIFrame for the content node that owns this frameloader
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdatePositionAndSize(System.IntPtr aIFrame);
		
		/// <summary>
        /// Activate remote frame.
        /// Throws an exception with non-remote frames.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActivateRemoteFrame();
		
		/// <summary>
        /// Deactivate remote frame.
        /// Throws an exception with non-remote frames.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeactivateRemoteFrame();
		
		/// <summary>
        /// @see nsIDOMWindowUtils sendMouseEvent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendCrossProcessMouseEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, float aX, float aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame);
		
		/// <summary>
        /// Activate event forwarding from client (remote frame) to parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActivateFrameEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, [MarshalAs(UnmanagedType.U1)] bool capture);
		
		/// <summary>
        /// Note, when frameloaders are swapped, also messageManagers are swapped.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMessageSender GetMessageManagerAttribute();
		
		/// <summary>
        /// Request that the next time a remote layer transaction has been
        /// received by the Compositor, a MozAfterRemoteFrame event be sent
        /// to the window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestNotifyAfterRemotePaint();
		
		/// <summary>
        /// Close the window through the ownerElement.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestFrameLoaderClose();
		
		/// <summary>
        /// Print the current document.
        ///
        /// @param aOuterWindowID the ID of the outer window to print
        /// @param aPrintSettings optional print settings to use; printSilent can be
        /// set to prevent prompting.
        /// @param aProgressListener optional print progress listener.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Print(ulong aOuterWindowID, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings, [MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aProgressListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetEventModeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEventModeAttribute(uint aEventMode);
		
		/// <summary>
        /// If false, then the subdocument is not clipped to its CSS viewport, and the
        /// subdocument's viewport scrollbar(s) are not rendered.
        /// Defaults to true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetClipSubdocumentAttribute();
		
		/// <summary>
        /// If false, then the subdocument is not clipped to its CSS viewport, and the
        /// subdocument's viewport scrollbar(s) are not rendered.
        /// Defaults to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClipSubdocumentAttribute([MarshalAs(UnmanagedType.U1)] bool aClipSubdocument);
		
		/// <summary>
        /// If false, then the subdocument's scroll coordinates will not be clamped
        /// to their scroll boundaries.
        /// Defaults to true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetClampScrollPositionAttribute();
		
		/// <summary>
        /// If false, then the subdocument's scroll coordinates will not be clamped
        /// to their scroll boundaries.
        /// Defaults to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClampScrollPositionAttribute([MarshalAs(UnmanagedType.U1)] bool aClampScrollPosition);
		
		/// <summary>
        /// The element which owns this frame loader.
        ///
        /// For example, if this is a frame loader for an <iframe>, this attribute
        /// returns the iframe element.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetOwnerElementAttribute();
		
		/// <summary>
        /// Cached childID of the ContentParent owning the TabParent in this frame
        /// loader. This can be used to obtain the childID after the TabParent died.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetChildIDAttribute();
		
		/// <summary>
        /// Find out whether the owner content really is a mozbrowser. <xul:browser>
        /// is not considered to be a mozbrowser frame.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOwnerIsMozBrowserFrameAttribute();
		
		/// <summary>
        /// The last known width of the frame. Reading this property will not trigger
        /// a reflow, and therefore may not reflect the current state of things. It
        /// should only be used in asynchronous APIs where values are not guaranteed
        /// to be up-to-date when received.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLazyWidthAttribute();
		
		/// <summary>
        /// The last known height of the frame. Reading this property will not trigger
        /// a reflow, and therefore may not reflect the current state of things. It
        /// should only be used in asynchronous APIs where values are not guaranteed
        /// to be up-to-date when received.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLazyHeightAttribute();
		
		/// <summary>
        /// Is `true` if the frameloader is dead (destroy has been called on it)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsDeadAttribute();
	}
	
	/// <summary>nsIFrameLoaderConsts </summary>
	public class nsIFrameLoaderConsts
	{
		
		// <summary>
        // The default event mode automatically forwards the events
        // handled in EventStateManager::HandleCrossProcessEvent to
        // the child content process when these events are targeted to
        // the remote browser element.
        //
        // Used primarly for input events (mouse, keyboard)
        // </summary>
		public const ulong EVENT_MODE_NORMAL_DISPATCH = 0x00000000;
		
		// <summary>
        // With this event mode, it's the application's responsability to
        // convert and forward events to the content process
        // </summary>
		public const ulong EVENT_MODE_DONT_FORWARD_TO_CHILD = 0x00000001;
	}
	
	/// <summary>nsIFrameLoaderOwner </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("adc1b3ba-8deb-4943-8045-e6de0044f2ce")]
	public interface nsIFrameLoaderOwner
	{
		
		/// <summary>
        /// The frame loader owned by this nsIFrameLoaderOwner
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFrameLoaderAttribute();
		
		/// <summary>Member GetFrameLoader </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFrameLoader();
		
		/// <summary>
        /// This method is used internally by SwapFrameLoaders to set the frame loader
        /// on the target nsFrameLoader.
        ///
        /// Avoid using this method outside of that context, and instead prefer using
        /// SwapFrameLoaders.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InternalSetFrameLoader(System.IntPtr aNewFrameLoader);
	}
}
