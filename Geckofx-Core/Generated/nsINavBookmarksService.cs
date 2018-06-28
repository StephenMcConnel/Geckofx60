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
// Generated by IDLImporter from file nsINavBookmarksService.idl
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
    /// Observer for bookmarks changes.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4d00c221-2c4a-47ab-a617-abb324110492")]
	public interface nsINavBookmarkObserver
	{
		
		/// <summary>
        /// This observer should not be called for items that are tags.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSkipTagsAttribute();
		
		/// <summary>
        /// This observer should not be called for descendants when the parent is removed.
        /// For example when revmoing a folder containing bookmarks.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSkipDescendantsOnItemRemovalAttribute();
		
		/// <summary>
        /// Notifies that a batch transaction has started.
        /// Other notifications will be sent during the batch, but the observer is
        /// guaranteed that onEndUpdateBatch() will be called at its completion.
        /// During a batch the observer should do its best to reduce the work done to
        /// handle notifications, since multiple changes are going to happen in a short
        /// timeframe.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnBeginUpdateBatch();
		
		/// <summary>
        /// Notifies that a batch transaction has ended.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnEndUpdateBatch();
		
		/// <summary>
        /// Notifies that an item (any type) was added.  Called after the actual
        /// addition took place.
        /// When a new item is created, all the items following it in the same folder
        /// will have their index shifted down, but no additional notifications will
        /// be sent.
        ///
        /// @param aItemId
        /// The id of the item that was added.
        /// @param aParentId
        /// The id of the folder to which the item was added.
        /// @param aIndex
        /// The item's index in the folder.
        /// @param aItemType
        /// The type of the added item (see TYPE_* constants below).
        /// @param aURI
        /// The URI of the added item if it was TYPE_BOOKMARK, null otherwise.
        /// @param aTitle
        /// The title of the added item.
        /// @param aDateAdded
        /// The stored date added value, in microseconds from the epoch.
        /// @param aGuid
        /// The unique ID associated with the item.
        /// @param aParentGuid
        /// The unique ID associated with the item's parent.
        /// @param aSource
        /// A change source constant from nsINavBookmarksService::SOURCE_*,
        /// passed to the method that notifies the observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemAdded(long aItemId, long aParentId, int aIndex, ushort aItemType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle, long aDateAdded, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGuid, ushort aSource);
		
		/// <summary>
        /// Notifies that an item was removed.  Called after the actual remove took
        /// place.
        /// When an item is removed, all the items following it in the same folder
        /// will have their index shifted down, but no additional notifications will
        /// be sent.
        ///
        /// @param aItemId
        /// The id of the item that was removed.
        /// @param aParentId
        /// The id of the folder from which the item was removed.
        /// @param aIndex
        /// The bookmark's index in the folder.
        /// @param aItemType
        /// The type of the item to be removed (see TYPE_* constants below).
        /// @param aURI
        /// The URI of the added item if it was TYPE_BOOKMARK, null otherwise.
        /// @param aGuid
        /// The unique ID associated with the item.
        /// @param aParentGuid
        /// The unique ID associated with the item's parent.
        /// @param aSource
        /// A change source constant from nsINavBookmarksService::SOURCE_*,
        /// passed to the method that notifies the observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemRemoved(long aItemId, long aParentId, int aIndex, ushort aItemType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGuid, ushort aSource);
		
		/// <summary>
        /// Notifies that an item's information has changed.  This will be called
        /// whenever any attributes like "title" are changed.
        ///
        /// @param aItemId
        /// The id of the item that was changed.
        /// @param aProperty
        /// The property which changed.  Can be null for the removal of all of
        /// the annotations, in this case aIsAnnotationProperty is true.
        /// @param aIsAnnotationProperty
        /// Whether or not aProperty is the name of an annotation.  If true
        /// aNewValue is always an empty string.
        /// @param aNewValue
        /// For certain properties, this is set to the new value of the
        /// property (see the list below).
        /// @param aLastModified
        /// The updated last-modified value.
        /// @param aItemType
        /// The type of the item to be removed (see TYPE_* constants below).
        /// @param aParentId
        /// The id of the folder containing the item.
        /// @param aGuid
        /// The unique ID associated with the item.
        /// @param aParentGuid
        /// The unique ID associated with the item's parent.
        /// @param aOldValue
        /// For certain properties, this is set to the new value of the
        /// property (see the list below).
        /// @param aSource
        /// A change source constant from nsINavBookmarksService::SOURCE_*,
        /// passed to the method that notifies the observer.
        ///
        /// @note List of values that may be associated with properties:
        /// aProperty     | aNewValue
        /// =====================================================================
        /// guid          | The new bookmark guid.
        /// cleartime     | Empty string (all visits to this item were removed).
        /// title         | The new title.
        /// favicon       | The "moz-anno" URL of the new favicon.
        /// uri           | new URL.
        /// tags          | Empty string (tags for this item changed)
        /// dateAdded     | PRTime (as string) when the item was first added.
        /// lastModified  | PRTime (as string) when the item was last modified.
        ///
        /// aProperty     | aOldValue
        /// =====================================================================
        /// guid          | The old bookmark guid.
        /// cleartime     | Empty string (currently unused).
        /// title         | Empty string (currently unused).
        /// favicon       | Empty string (currently unused).
        /// uri           | old URL.
        /// tags          | Empty string (currently unused).
        /// dateAdded     | Empty string (currently unused).
        /// lastModified  | Empty string (currently unused).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemChanged(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProperty, [MarshalAs(UnmanagedType.U1)] bool aIsAnnotationProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewValue, long aLastModified, ushort aItemType, long aParentId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGuid, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aOldValue, ushort aSource);
		
		/// <summary>
        /// Notifies that the item was visited.  Can be invoked only for TYPE_BOOKMARK
        /// items.
        ///
        /// @param aItemId
        /// The id of the bookmark that was visited.
        /// @param aVisitId
        /// The id of the visit.
        /// @param aTime
        /// The time of the visit.
        /// @param aTransitionType
        /// The transition for the visit.  See nsINavHistoryService::TRANSITION_*
        /// constants for a list of possible values.
        /// @param aURI
        /// The nsIURI for this bookmark.
        /// @param aParentId
        /// The id of the folder containing the item.
        /// @param aGuid
        /// The unique ID associated with the item.
        /// @param aParentGuid
        /// The unique ID associated with the item's parent.
        ///
        /// @see onItemChanged with property = "cleartime" for when all visits to an
        /// item are removed.
        ///
        /// @note The reported time is the time of the visit that was added, which may
        /// be well in the past since the visit time can be specified.  This
        /// means that the visit the observer is told about may not be the most
        /// recent visit for that page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemVisited(long aItemId, long aVisitId, long aTime, uint aTransitionType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, long aParentId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGuid);
		
		/// <summary>
        /// Notifies that an item has been moved.
        ///
        /// @param aItemId
        /// The id of the item that was moved.
        /// @param aOldParentId
        /// The id of the old parent.
        /// @param aOldIndex
        /// The old index inside the old parent.
        /// @param aNewParentId
        /// The id of the new parent.
        /// @param aNewIndex
        /// The index inside the new parent.
        /// @param aItemType
        /// The type of the item to be removed (see TYPE_* constants below).
        /// @param aGuid
        /// The unique ID associated with the item.
        /// @param aOldParentGuid
        /// The unique ID associated with the old item's parent.
        /// @param aNewParentGuid
        /// The unique ID associated with the new item's parent.
        /// @param aSource
        /// A change source constant from nsINavBookmarksService::SOURCE_*,
        /// passed to the method that notifies the observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemMoved(long aItemId, long aOldParentId, int aOldIndex, long aNewParentId, int aNewIndex, ushort aItemType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOldParentGuid, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNewParentGuid, ushort aSource);
	}
	
	/// <summary>
    /// The BookmarksService interface provides methods for managing bookmarked
    /// history items.  Bookmarks consist of a set of user-customizable
    /// folders.  A URI in history can be contained in one or more such folders.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("24533891-afa6-4663-b72d-3143d03f1b04")]
	public interface nsINavBookmarksService
	{
		
		/// <summary>
        /// The item ID of the Places root.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetPlacesRootAttribute();
		
		/// <summary>
        /// The item ID of the bookmarks menu folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetBookmarksMenuFolderAttribute();
		
		/// <summary>
        /// The item ID of the top-level folder that contain the tag "folders".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetTagsFolderAttribute();
		
		/// <summary>
        /// The item ID of the unfiled-bookmarks folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetUnfiledBookmarksFolderAttribute();
		
		/// <summary>
        /// The item ID of the personal toolbar folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetToolbarFolderAttribute();
		
		/// <summary>
        /// The item ID of the mobile bookmarks folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetMobileFolderAttribute();
		
		/// <summary>
        /// Inserts a child bookmark into the given folder.
        ///
        /// @param aParentId
        /// The id of the parent folder
        /// @param aURI
        /// The URI to insert
        /// @param aIndex
        /// The index to insert at, or DEFAULT_INDEX to append
        /// @param aTitle
        /// The title for the new bookmark
        /// @param [optional] aGuid
        /// The GUID to be set for the new item.  If not set, a new GUID is
        /// generated.  Unless you've a very sound reason, such as an undo
        /// manager implementation, do not pass this argument.
        /// @param [optional] aSource
        /// The change source. This is forwarded to all bookmark observers,
        /// allowing them to distinguish between insertions from different
        /// callers. Defaults to SOURCE_DEFAULT if omitted.
        /// @return The ID of the newly-created bookmark.
        ///
        /// @note aTitle will be truncated to TITLE_LENGTH_MAX and
        /// aURI will be truncated to URI_LENGTH_MAX.
        /// @throws if aGuid is malformed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int InsertBookmark(long aParentId, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, ushort aSource);
		
		/// <summary>
        /// Removes a child item. Used to delete a bookmark or separator.
        /// @param aItemId
        /// The child item to remove
        /// @param [optional] aSource
        /// The change source, forwarded to all bookmark observers. Defaults
        /// to SOURCE_DEFAULT.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItem(long aItemId, ushort aSource);
		
		/// <summary>
        /// Creates a new child folder and inserts it under the given parent.
        /// @param aParentFolder
        /// The id of the parent folder
        /// @param aName
        /// The name of the new folder
        /// @param aIndex
        /// The index to insert at, or DEFAULT_INDEX to append
        /// @param [optional] aGuid
        /// The GUID to be set for the new item.  If not set, a new GUID is
        /// generated.  Unless you've a very sound reason, such as an undo
        /// manager implementation, do not pass this argument.
        /// @param [optional] aSource
        /// The change source, forwarded to all bookmark observers. Defaults
        /// to SOURCE_DEFAULT.
        /// @return The ID of the newly-inserted folder.
        /// @throws if aGuid is malformed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CreateFolder(long aParentFolder, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, int index, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid, ushort aSource);
		
		/// <summary>
        /// Set the title for an item.
        /// @param aItemId
        /// The id of the item whose title should be updated.
        /// @param aTitle
        /// The new title for the bookmark.
        /// @param [optional] aSource
        /// The change source, forwarded to all bookmark observers. Defaults
        /// to SOURCE_DEFAULT.
        ///
        /// @note  aTitle will be truncated to TITLE_LENGTH_MAX.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemTitle(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle, ushort aSource);
		
		/// <summary>
        /// Get the title for an item.
        ///
        /// If no item title is available it will return a void string (null in JS).
        ///
        /// @param aItemId
        /// The id of the item whose title should be retrieved
        /// @return The title of the item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemTitle(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Set the last modified time for an item.
        ///
        /// @param aItemId
        /// the id of the item whose last modified time should be updated.
        /// @param aLastModified
        /// the new last modified value in microseconds.  Note that it is
        /// rounded down to milliseconds precision.
        /// @param [optional] aSource
        /// The change source, forwarded to all bookmark observers. Defaults
        /// to SOURCE_DEFAULT.
        ///
        /// @note This is the only method that will send an itemChanged notification
        /// for the property.  lastModified will still be updated in
        /// any other method that changes an item property, but we will send
        /// the corresponding itemChanged notification instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemLastModified(long aItemId, long aLastModified, ushort aSource);
		
		/// <summary>
        /// Get the URI for a bookmark item.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetBookmarkURI(long aItemId);
		
		/// <summary>
        ////**
        /// Get the parent folder's id for an item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFolderIdForItem(long aItemId);
		
		/// <summary>
        /// Adds a bookmark observer. If ownsWeak is false, the bookmark service will
        /// keep an owning reference to the observer.  If ownsWeak is true, then
        /// aObserver must implement nsISupportsWeakReference, and the bookmark
        /// service will keep a weak reference to the observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsINavBookmarkObserver observer, [MarshalAs(UnmanagedType.U1)] bool ownsWeak);
		
		/// <summary>
        /// Removes a bookmark observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsINavBookmarkObserver observer);
		
		/// <summary>
        /// Gets an array of registered nsINavBookmarkObserver objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetObservers(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref nsINavBookmarkObserver[] observers);
		
		/// <summary>
        /// Runs the passed callback inside of a database transaction.
        /// Use this when a lot of things are about to change, for example
        /// adding or deleting a large number of bookmark items. Calls can
        /// be nested. Observers are notified when batches begin and end, via
        /// nsINavBookmarkObserver.onBeginUpdateBatch/onEndUpdateBatch.
        ///
        /// @param aCallback
        /// nsINavHistoryBatchCallback interface to call.
        /// @param aUserData
        /// Opaque parameter passed to nsINavBookmarksBatchCallback
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RunInBatchMode([MarshalAs(UnmanagedType.Interface)] nsINavHistoryBatchCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsISupports aUserData);
	}
	
	/// <summary>nsINavBookmarksServiceConsts </summary>
	public class nsINavBookmarksServiceConsts
	{
		
		// <summary>
        // This value should be used for APIs that allow passing in an index
        // where an index is not known, or not required to be specified.
        // e.g.: When appending an item to a folder.
        // </summary>
		public const short DEFAULT_INDEX = -1;
		
		// 
		public const ushort TYPE_BOOKMARK = 1;
		
		// 
		public const ushort TYPE_FOLDER = 2;
		
		// 
		public const ushort TYPE_SEPARATOR = 3;
		
		// <summary>
        // This const exists just to avoid reusing the value.
        // </summary>
		public const ushort TYPE_DYNAMIC_CONTAINER = 4;
		
		// <summary>
        // parameters to methods used by Sync, and forwarded to observers.
        // </summary>
		public const ushort SOURCE_DEFAULT = 0;
		
		// 
		public const ushort SOURCE_SYNC = 1;
		
		// 
		public const ushort SOURCE_IMPORT = 2;
		
		// 
		public const ushort SOURCE_IMPORT_REPLACE = 3;
		
		// 
		public const ushort SOURCE_SYNC_REPARENT_REMOVED_FOLDER_CHILDREN = 4;
		
		// <summary>
        // before upload.
        // </summary>
		public const ushort SYNC_STATUS_UNKNOWN = 0;
		
		// <summary>
        // changed to "NORMAL" before upload.
        // </summary>
		public const ushort SYNC_STATUS_NEW = 1;
		
		// <summary>
        // tombstone if it's deleted.
        // </summary>
		public const ushort SYNC_STATUS_NORMAL = 2;
	}
}
