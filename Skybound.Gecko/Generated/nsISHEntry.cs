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
// Generated by IDLImporter from file nsISHEntry.idl
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
	
	
	/// <summary>
    /// The interface to nsISHentry. Each document or subframe in
    /// Session History will have a nsISHEntry associated with it which will
    /// hold all information required to recreate the document from history
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("39b73c3a-48eb-4189-8069-247279c3c42d")]
	public interface nsISHEntry : nsIHistoryEntry
	{
		
		/// <summary>
        /// A readonly property that returns the URI
        /// of the current entry. The object returned is
        /// of type nsIURI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI  GetURIAttribute();
		
		/// <summary>
        /// A readonly property that returns the title
        /// of the current entry.  The object returned
        /// is a encoded string
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetTitleAttribute();
		
		/// <summary>
        /// A readonly property that returns a boolean
        /// flag which indicates if the entry was created as a
        /// result of a subframe navigation. This flag will be
        /// 'false' when a frameset page is visited for
        /// the first time. This flag will be 'true' for all
        /// history entries created as a result of a subframe
        /// navigation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetIsSubFrameAttribute();
		
		/// <summary>
        ///URI for the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>
        ///Referrer URI </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetReferrerURIAttribute();
		
		/// <summary>
        ///Referrer URI </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI  aReferrerURI);
		
		/// <summary>
        ///Content viewer, for fast restoration of presentation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetContentViewerAttribute();
		
		/// <summary>
        ///Content viewer, for fast restoration of presentation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentViewerAttribute(System.IntPtr aContentViewer);
		
		/// <summary>
        ///Whether the content viewer is marked "sticky" </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetStickyAttribute();
		
		/// <summary>
        ///Whether the content viewer is marked "sticky" </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStickyAttribute(System.Boolean  aSticky);
		
		/// <summary>
        ///Saved state of the global window object </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports  GetWindowStateAttribute();
		
		/// <summary>
        ///Saved state of the global window object </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindowStateAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports  aWindowState);
		
		/// <summary>
        /// Saved position and dimensions of the content viewer; we must adjust the
        /// root view's widget accordingly if this has changed when the presentation
        /// is restored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetViewerBounds([MarshalAs(UnmanagedType.Interface)] nsIntRect  bounds);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetViewerBounds([MarshalAs(UnmanagedType.Interface)] nsIntRect  bounds);
		
		/// <summary>
        ///Append a child shell to the end of our list. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddChildShell([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem  shell);
		
		/// <summary>
        /// Get the child shell at |index|; returns null if |index| is out of bounds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem ChildShellAt(System.Int32  index);
		
		/// <summary>
        /// Clear the child shell list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearChildShells();
		
		/// <summary>
        ///Saved refresh URI list for the content viewer </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray  GetRefreshURIListAttribute();
		
		/// <summary>
        ///Saved refresh URI list for the content viewer </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRefreshURIListAttribute([MarshalAs(UnmanagedType.Interface)] nsISupportsArray  aRefreshURIList);
		
		/// <summary>
        /// Ensure that the cached presentation members are self-consistent.
        /// If either |contentViewer| or |windowState| are null, then all of the
        /// following members are cleared/reset:
        /// contentViewer, sticky, windowState, viewerBounds, childShells,
        /// refreshURIList.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SyncPresentationState();
		
		/// <summary>
        ///Title for the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		/// <summary>
        ///Post Data for the document </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream  GetPostDataAttribute();
		
		/// <summary>
        ///Post Data for the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPostDataAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aPostData);
		
		/// <summary>
        ///LayoutHistoryState for scroll position and form values </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetLayoutHistoryStateAttribute();
		
		/// <summary>
        ///LayoutHistoryState for scroll position and form values </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLayoutHistoryStateAttribute(System.IntPtr aLayoutHistoryState);
		
		/// <summary>
        ///parent of this entry </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry  GetParentAttribute();
		
		/// <summary>
        ///parent of this entry </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry  aParent);
		
		/// <summary>
        /// The loadType for this entry. This is typically loadHistory except
        /// when reload is pressed, it has the appropriate reload flag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLoadTypeAttribute();
		
		/// <summary>
        /// The loadType for this entry. This is typically loadHistory except
        /// when reload is pressed, it has the appropriate reload flag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadTypeAttribute(System.UInt32  aLoadType);
		
		/// <summary>
        /// An ID to help identify this entry from others during
        /// subframe navigation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetIDAttribute();
		
		/// <summary>
        /// An ID to help identify this entry from others during
        /// subframe navigation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIDAttribute(System.UInt32  aID);
		
		/// <summary>
        /// pageIdentifier is an integer that should be the same for two entries
        /// attached to the same docshell only if the two entries are entries for
        /// the same page in the sense that one could go from the state represented
        /// by one to the state represented by the other simply by scrolling (so the
        /// entries are separated by an anchor traversal or a subframe navigation in
        /// some other frame).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetPageIdentifierAttribute();
		
		/// <summary>
        /// pageIdentifier is an integer that should be the same for two entries
        /// attached to the same docshell only if the two entries are entries for
        /// the same page in the sense that one could go from the state represented
        /// by one to the state represented by the other simply by scrolling (so the
        /// entries are separated by an anchor traversal or a subframe navigation in
        /// some other frame).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageIdentifierAttribute(System.UInt32  aPageIdentifier);
		
		/// <summary>
        /// docIdentifier is an integer that should be the same for two entries
        /// attached to the same docshell if and only if the two entries are entries
        /// for the same document.  In practice, two entries A and B will have the
        /// same docIdentifier if they have the same pageIdentifier or if B was
        /// created by A calling history.pushState().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetDocIdentifierAttribute();
		
		/// <summary>
        /// docIdentifier is an integer that should be the same for two entries
        /// attached to the same docshell if and only if the two entries are entries
        /// for the same document.  In practice, two entries A and B will have the
        /// same docIdentifier if they have the same pageIdentifier or if B was
        /// created by A calling history.pushState().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocIdentifierAttribute(System.UInt32  aDocIdentifier);
		
		/// <summary>
        /// Changes this entry's doc identifier to a new value which is unique
        /// among those of all other entries.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUniqueDocIdentifier();
		
		/// <summary>
        ///attribute to set and get the cache key for the entry </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports  GetCacheKeyAttribute();
		
		/// <summary>
        ///attribute to set and get the cache key for the entry </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheKeyAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports  aCacheKey);
		
		/// <summary>
        ///attribute to indicate whether layoutHistoryState should be saved </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetSaveLayoutStateFlagAttribute();
		
		/// <summary>
        ///attribute to indicate whether layoutHistoryState should be saved </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSaveLayoutStateFlagAttribute(System.Boolean  aSaveLayoutStateFlag);
		
		/// <summary>
        ///attribute to indicate whether the page is already expired in cache </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetExpirationStatusAttribute();
		
		/// <summary>
        ///attribute to indicate whether the page is already expired in cache </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetExpirationStatusAttribute(System.Boolean  aExpirationStatus);
		
		/// <summary>
        /// attribute to indicate the content-type of the document that this
        /// is a session history entry for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentType);
		
		/// <summary>
        /// attribute to indicate the content-type of the document that this
        /// is a session history entry for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentType);
		
		/// <summary>
        ///Set/Get scrollers' positon in anchored pages </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScrollPosition(System.Int32  x, System.Int32  y);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScrollPosition(out System.Int32  x, out System.Int32  y);
		
		/// <summary>
        ///Additional ways to create an entry </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create([MarshalAs(UnmanagedType.Interface)] nsIURI  URI, [MarshalAs(UnmanagedType.LPStruct)] nsAString title, [MarshalAs(UnmanagedType.Interface)] nsIInputStream  inputStream, System.IntPtr layoutHistoryState, [MarshalAs(UnmanagedType.Interface)] nsISupports  cacheKey, [MarshalAs(UnmanagedType.LPStruct)] nsAString  contentType, [MarshalAs(UnmanagedType.Interface)] nsISupports  owner, System.UInt32  docshellID, System.Boolean  dynamicCreation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry Clone();
		
		/// <summary>
        ///Attribute that indicates if this entry is for a subframe navigation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsSubFrame(System.Boolean  aFlag);
		
		/// <summary>
        ///Return any content viewer present in or below this node in the
        ///        nsSHEntry tree.  This will differ from contentViewer in the case
        ///        where a child nsSHEntry has the content viewer for this tree. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetAnyContentViewer([MarshalAs(UnmanagedType.Interface)] out nsISHEntry  ownerEntry);
		
		/// <summary>
        /// Get the owner, if any, that was associated with the channel
        /// that the document that was loaded to create this history entry
        /// came from.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports  GetOwnerAttribute();
		
		/// <summary>
        /// Get the owner, if any, that was associated with the channel
        /// that the document that was loaded to create this history entry
        /// came from.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports  aOwner);
		
		/// <summary>
        /// Get/set data associated with this history state via a pushState() call,
        /// encoded as JSON.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStateDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStateData);
		
		/// <summary>
        /// Get/set data associated with this history state via a pushState() call,
        /// encoded as JSON.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStateDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStateData);
		
		/// <summary>
        /// Gets the owning pointer to the editor data assosicated with
        /// this shistory entry. This forgets its pointer, so free it when
        /// you're done.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr ForgetEditorData();
		
		/// <summary>
        /// Sets the owning pointer to the editor data assosicated with
        /// this shistory entry. Unless forgetEditorData() is called, this
        /// shentry will destroy the editor data when it's destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEditorData(System.IntPtr aData);
		
		/// <summary>
        ///Returns true if this shistory entry is storing a detached editor. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasDetachedEditor();
		
		/// <summary>
        /// Returns true if the related docshell was added because of
        /// dynamic addition of an iframe/frame.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDynamicallyAdded();
		
		/// <summary>
        /// Returns true if any of the child entries returns true
        /// when isDynamicallyAdded is called on it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasDynamicallyAddedChild();
		
		/// <summary>
        /// The history ID of the docshell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetDocshellIDAttribute();
		
		/// <summary>
        /// The history ID of the docshell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocshellIDAttribute(System.UInt32  aDocshellID);
	}
	
	/// <summary>nsISHEntryInternal </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bb66ac35-253b-471f-a317-3ece940f04c5")]
	public interface nsISHEntryInternal
	{
		
		/// <summary>Member RemoveFromBFCacheAsync </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFromBFCacheAsync();
		
		/// <summary>Member RemoveFromBFCacheSync </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFromBFCacheSync();
		
		/// <summary>
        /// A number that is assigned by the sHistory when the entry is activated
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLastTouchedAttribute();
		
		/// <summary>
        /// A number that is assigned by the sHistory when the entry is activated
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastTouchedAttribute(System.UInt32  aLastTouched);
	}
}
