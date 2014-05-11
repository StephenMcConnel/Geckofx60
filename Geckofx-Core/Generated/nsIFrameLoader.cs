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
    /// These interfaces do *not* scroll or scale the content document;
    /// instead they set a "goal" scroll/scale wrt the current content
    /// view.  When the content document is painted, the scroll*
    /// attributes are used to set a compensating transform.  If the
    /// metrics of the content document's current pixels don't match the
    /// view config, the transform matrix may need to translate
    /// content pixels and/or perform a "fuzzy-scale" that doesn't
    /// re-rasterize fonts or intelligently resample images.
    ///
    /// The attrs are allowed to transform content pixels in
    /// such a way that the <browser>'s visible rect encloses pixels that
    /// the content document does not (yet) define.
    ///
    /// The view scroll values are in units of chrome-document CSS
    /// pixels.
    ///
    /// These APIs are designed to be used with nsIDOMWindowUtils
    /// setDisplayPort() and setResolution().
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c04c5c40-fa2a-4e9c-94f5-b362a10a86cb")]
	public interface nsIContentView
	{
		
		/// <summary>
        /// Scroll view to or by the given chrome-document CSS pixels.
        /// Fails if the view is no longer valid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollTo(float xPx, float yPx);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollBy(float dxPx, float dyPx);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScale(float xScale, float yScale);
		
		/// <summary>
        /// Scroll offset in chrome-document CSS pixels.
        ///
        /// When this view is active (i.e. it is being painted because it's in the
        /// visible region of the screen), this value is at first lined up with the
        /// content's scroll offset.
        ///
        /// Note that when this view becomes inactive, the new content view will have
        /// scroll values that are reset to the default!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetScrollXAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetScrollYAttribute();
		
		/// <summary>
        /// Dimensions of the viewport in chrome-document CSS pixels.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetViewportWidthAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetViewportHeightAttribute();
		
		/// <summary>
        /// Dimensions of scrolled content in chrome-document CSS pixels.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetContentWidthAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetContentHeightAttribute();
		
		/// <summary>
        /// ID that can be used in conjunction with nsIDOMWindowUtils to change
        /// the actual document, instead of just how it is transformed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIdAttribute();
	}
	
	/// <summary>nsIContentViewManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ba5af90d-ece5-40b2-9a1d-a0154128db1c")]
	public interface nsIContentViewManager
	{
		
		/// <summary>
        /// Retrieve view scrolling/scaling interfaces in a given area,
        /// used to support asynchronous re-paints of content pixels.
        /// These interfaces are only meaningful for <browser>.
        ///
        /// Pixels are in chrome device pixels and are relative to the browser
        /// element.
        ///
        /// @param aX x coordinate that will be in target rectangle
        /// @param aY y coordinate that will be in target rectangle
        /// @param aTopSize How much to expand up the rectangle
        /// @param aRightSize How much to expand right the rectangle
        /// @param aBottomSize How much to expand down the rectangle
        /// @param aLeftSize How much to expand left the rectangle
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentViewsIn(float aXPx, float aYPx, float aTopSize, float aRightSize, float aBottomSize, float aLeftSize, ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=6)] ref nsIContentView[] aResult);
		
		/// <summary>
        /// The root content view.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIContentView GetRootContentViewAttribute();
	}
	
	/// <summary>nsIFrameLoader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4c9f91c0-7a5d-11e3-981f-0800200c9a66")]
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
		void LoadFrame();
		
		/// <summary>
        /// Loads the specified URI in this frame. Behaves identically to loadFrame,
        /// except that this method allows specifying the URI to load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
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
		void SendCrossProcessMouseEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase aType, float aX, float aY, int aButton, int aClickCount, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aIgnoreRootScrollFrame);
		
		/// <summary>
        /// Activate event forwarding from client (remote frame) to parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActivateFrameEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase aType, [MarshalAs(UnmanagedType.U1)] bool capture);
		
		/// <summary>
        /// Note, when frameloaders are swapped, also messageManagers are swapped.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMessageSender GetMessageManagerAttribute();
		
		/// <summary>
        /// @see nsIDOMWindowUtils sendKeyEvent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendCrossProcessKeyEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase aType, int aKeyCode, int aCharCode, int aModifiers, [MarshalAs(UnmanagedType.U1)] bool aPreventDefault);
		
		/// <summary>Member GetDelayRemoteDialogsAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDelayRemoteDialogsAttribute();
		
		/// <summary>Member SetDelayRemoteDialogsAttribute </summary>
		/// <param name='aDelayRemoteDialogs'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDelayRemoteDialogsAttribute([MarshalAs(UnmanagedType.U1)] bool aDelayRemoteDialogs);
		
		/// <summary>Member GetRenderModeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRenderModeAttribute();
		
		/// <summary>Member SetRenderModeAttribute </summary>
		/// <param name='aRenderMode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRenderModeAttribute(uint aRenderMode);
		
		/// <summary>Member GetEventModeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetEventModeAttribute();
		
		/// <summary>Member SetEventModeAttribute </summary>
		/// <param name='aEventMode'> </param>
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
        /// Get or set this frame loader's visibility.
        ///
        /// The notion of "visibility" here is separate from the notion of a
        /// window/docshell's visibility.  This field is mostly here so that we can
        /// have a notion of visibility in the parent process when frames are OOP.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibleAttribute();
		
		/// <summary>
        /// Get or set this frame loader's visibility.
        ///
        /// The notion of "visibility" here is separate from the notion of a
        /// window/docshell's visibility.  This field is mostly here so that we can
        /// have a notion of visibility in the parent process when frames are OOP.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibleAttribute([MarshalAs(UnmanagedType.U1)] bool aVisible);
	}
	
	/// <summary>nsIFrameLoaderConsts </summary>
	public class nsIFrameLoaderConsts
	{
		
		// <summary>
        // The default rendering mode is synchronous scrolling.  In this
        // mode, it's an error to try to set a target viewport.
        // </summary>
		public const ulong RENDER_MODE_DEFAULT = 0x00000000;
		
		// <summary>
        // When asynchronous scrolling is enabled, a target viewport can be
        // set to transform content pixels wrt its CSS viewport.
        //
        // NB: when async scrolling is enabled, it's the *user's*
        // responsibility to update the target scroll offset.  In effect,
        // the platform hands over control of scroll offset to the user.
        // </summary>
		public const ulong RENDER_MODE_ASYNC_SCROLL = 0x00000001;
		
		// <summary>
        // The default event mode automatically forwards the events
        // handled in nsEventStateManager::HandleCrossProcessEvent to
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
	[Guid("5879040e-83e9-40e3-b2bb-5ddf43b76e47")]
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
        /// Swap frame loaders with the given nsIFrameLoaderOwner.  This may
        /// only be posible in a very limited range of circumstances, or
        /// never, depending on the object implementing this interface.
        ///
        /// @throws NS_ERROR_NOT_IMPLEMENTED if the swapping logic is not
        /// implemented for the two given frame loader owners.
        /// @throws NS_ERROR_DOM_SECURITY_ERR if the swap is not allowed on
        /// security grounds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SwapFrameLoaders(System.IntPtr aOtherOwner);
	}
}
