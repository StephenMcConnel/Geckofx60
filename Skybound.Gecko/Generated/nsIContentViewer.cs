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
// Generated by IDLImporter from file nsIContentViewer.idl
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
	
	
	/// <summary>nsIContentViewer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("26b2380b-4a1a-46cd-b7d8-7600e41c1688")]
	public interface nsIContentViewer
	{
		
		/// <summary>Member Init </summary>
		/// <param name='aParentWidget'> </param>
		/// <param name='aBounds'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init(System.IntPtr aParentWidget, System.IntPtr aBounds);
		
		/// <summary>Member GetContainerAttribute </summary>
		/// <returns>A nsISupports</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetContainerAttribute();
		
		/// <summary>Member SetContainerAttribute </summary>
		/// <param name='aContainer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContainerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aContainer);
		
		/// <summary>Member LoadStart </summary>
		/// <param name='aDoc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadStart([MarshalAs(UnmanagedType.Interface)] nsISupports aDoc);
		
		/// <summary>Member LoadComplete </summary>
		/// <param name='aStatus'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadComplete(uint aStatus);
		
		/// <summary>
        /// Checks if the document wants to prevent unloading by firing beforeunload on
        /// the document, and if it does, prompts the user. The result is returned.
        ///
        /// @param aCallerClosesWindow indicates that the current caller will close the
        /// window. If the method returns true, all subsequent calls will be
        /// ignored.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PermitUnload([MarshalAs(UnmanagedType.Bool)] bool aCallerClosesWindow);
		
		/// <summary>
        /// Works in tandem with permitUnload, if the caller decides not to close the
        /// window it indicated it will, it is the caller's responsibility to reset
        /// that with this method.
        ///
        /// @Note this method is only meant to be called on documents for which the
        /// caller has indicated that it will close the window. If that is not the case
        /// the behavior of this method is undefined.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetCloseWindow();
		
		/// <summary>Member PageHide </summary>
		/// <param name='isUnload'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PageHide([MarshalAs(UnmanagedType.Bool)] bool isUnload);
		
		/// <summary>
        /// All users of a content viewer are responsible for calling both
        /// close() and destroy(), in that order.
        ///
        /// close() should be called when the load of a new page for the next
        /// content viewer begins, and destroy() should be called when the next
        /// content viewer replaces this one.
        ///
        /// |historyEntry| sets the session history entry for the content viewer.  If
        /// this is null, then Destroy() will be called on the document by close().
        /// If it is non-null, the document will not be destroyed, and the following
        /// actions will happen when destroy() is called (*):
        /// - Sanitize() will be called on the viewer's document
        /// - The content viewer will set the contentViewer property on the
        /// history entry, and release its reference (ownership reversal).
        /// - hide() will be called, and no further destruction will happen.
        ///
        /// (*) unless the document is currently being printed, in which case
        /// it will never be saved in session history.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close([MarshalAs(UnmanagedType.Interface)] nsISHEntry historyEntry);
		
		/// <summary>Member Destroy </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Destroy();
		
		/// <summary>Member Stop </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop();
		
		/// <summary>Member GetDOMDocumentAttribute </summary>
		/// <returns>A nsIDOMDocument</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDOMDocumentAttribute();
		
		/// <summary>Member SetDOMDocumentAttribute </summary>
		/// <param name='aDOMDocument'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDOMDocumentAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDOMDocument);
		
		/// <summary>
        /// Returns DOMDocument as nsIDocument and without addrefing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetDocument();
		
		/// <summary>Member GetBounds </summary>
		/// <param name='aBounds'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBounds(System.IntPtr aBounds);
		
		/// <summary>Member SetBounds </summary>
		/// <param name='aBounds'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBounds(System.IntPtr aBounds);
		
		/// <summary>
        /// The previous content viewer, which has been |close|d but not
        /// |destroy|ed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPreviousViewerAttribute();
		
		/// <summary>
        /// The previous content viewer, which has been |close|d but not
        /// |destroy|ed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPreviousViewerAttribute(System.IntPtr aPreviousViewer);
		
		/// <summary>Member Move </summary>
		/// <param name='aX'> </param>
		/// <param name='aY'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Move(int aX, int aY);
		
		/// <summary>Member Show </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Show();
		
		/// <summary>Member Hide </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Hide();
		
		/// <summary>Member GetStickyAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStickyAttribute();
		
		/// <summary>Member SetStickyAttribute </summary>
		/// <param name='aSticky'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStickyAttribute([MarshalAs(UnmanagedType.Bool)] bool aSticky);
		
		/// <summary>
        /// This is called when the DOM window wants to be closed.  Returns true
        /// if the window can close immediately.  Otherwise, returns false and will
        /// close the DOM window as soon as practical.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool RequestWindowClose();
		
		/// <summary>
        /// Attach the content viewer to its DOM window and docshell.
        /// @param aState A state object that might be useful in attaching the DOM
        /// window.
        /// @param aSHEntry The history entry that the content viewer was stored in.
        /// The entry must have the docshells for all of the child
        /// documents stored in its child shell list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open([MarshalAs(UnmanagedType.Interface)] nsISupports aState, [MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry);
		
		/// <summary>
        /// Clears the current history entry.  This is used if we need to clear out
        /// the saved presentation state.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearHistoryEntry();
		
		/// <summary>
        /// Change the layout to view the document with page layout (like print preview), but
        /// dynamic and editable (like Galley layout).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageMode([MarshalAs(UnmanagedType.Bool)] bool aPageMode, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);
		
		/// <summary>
        /// Get the history entry that this viewer will save itself into when
        /// destroyed.  Can return null
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry GetHistoryEntryAttribute();
		
		/// <summary>
        /// Indicates when we're in a state where content shouldn't be allowed to
        /// trigger a tab-modal prompt (as opposed to a window-modal prompt) because
        /// we're part way through some operation (eg beforeunload) that shouldn't be
        /// rentrant if the user closes the tab while the prompt is showing.
        /// See bug 613800.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsTabModalPromptAllowedAttribute();
		
		/// <summary>Member GetPresShellAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPresShellAttribute();
		
		/// <summary>Member GetPresContextAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPresContextAttribute();
		
		/// <summary>Member SetDocumentInternal </summary>
		/// <param name='aDocument'> </param>
		/// <param name='aForceReuseInnerWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentInternal(System.IntPtr aDocument, [MarshalAs(UnmanagedType.Bool)] bool aForceReuseInnerWindow);
		
		/// <summary>
        /// Find the view to use as the container view for MakeWindow. Returns
        /// null if this will be the root of a view manager hierarchy. In that
        /// case, if mParentWidget is null then this document should not even
        /// be displayed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr FindContainerView();
		
		/// <summary>
        /// Set collector for navigation timing data (load, unload events).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNavigationTiming(System.IntPtr aTiming);
	}
}
