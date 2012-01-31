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
// Generated by IDLImporter from file nsIDownloadManager.idl
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
	
	
	/// <summary>
    /// Keeps track of ongoing downloads, in the form of nsIDownload's.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bacca1ac-1b01-4a6f-9e91-c2ead1f7d2c0")]
	public interface nsIDownloadManager
	{
		
		/// <summary>
        /// Creates an nsIDownload and adds it to be managed by the download manager.
        ///
        /// @param aSource The source URI of the transfer. Must not be null.
        ///
        /// @param aTarget The target URI of the transfer. Must not be null.
        ///
        /// @param aDisplayName The user-readable description of the transfer.
        /// Can be empty.
        ///
        /// @param aMIMEInfo The MIME info associated with the target,
        /// including MIME type and helper app when appropriate.
        /// This parameter is optional.
        ///
        /// @param startTime Time when the download started
        ///
        /// @param aTempFile The location of a temporary file; i.e. a file in which
        /// the received data will be stored, but which is not
        /// equal to the target file. (will be moved to the real
        /// target by the caller, when the download is finished)
        /// May be null.
        ///
        /// @param aCancelable An object that can be used to abort the download.
        /// Must not be null.
        ///
        /// @return The newly created download item with the passed-in properties.
        ///
        /// @note This does not actually start a download.  If you want to add and
        /// start a download, you need to create an nsIWebBrowserPersist, pass it
        /// as the aCancelable object, call this method, set the progressListener
        /// as the returned download object, then call saveURI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDownload AddDownload(short aDownloadType, [MarshalAs(UnmanagedType.Interface)] nsIURI aSource, [MarshalAs(UnmanagedType.Interface)] nsIURI aTarget, [MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayName, [MarshalAs(UnmanagedType.Interface)] nsIMIMEInfo aMIMEInfo, ulong aStartTime, [MarshalAs(UnmanagedType.Interface)] nsILocalFile aTempFile, [MarshalAs(UnmanagedType.Interface)] nsICancelable aCancelable);
		
		/// <summary>
        /// Retrieves a download managed by the download manager.  This can be one that
        /// is in progress, or one that has completed in the past and is stored in the
        /// database.
        ///
        /// @param aID The unique ID of the download.
        /// @return The download with the specified ID.
        /// @throws NS_ERROR_NOT_AVAILABLE if the download is not in the database.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDownload GetDownload(uint aID);
		
		/// <summary>
        /// Cancels the download with the specified ID if it's currently in-progress.
        /// This calls cancel(NS_BINDING_ABORTED) on the nsICancelable provided by the
        /// download.
        ///
        /// @param aID The unique ID of the download.
        /// @throws NS_ERROR_FAILURE if the download is not in-progress.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelDownload(uint aID);
		
		/// <summary>
        /// Removes the download with the specified id if it's not currently
        /// in-progress.  Whereas cancelDownload simply cancels the transfer, but
        /// retains information about it, removeDownload removes all knowledge of it.
        ///
        /// Also notifies observers of the "download-manager-remove-download" topic
        /// with the download id as the subject to allow any DM consumers to react to
        /// the removal.
        ///
        /// @param aID The unique ID of the download.
        /// @throws NS_ERROR_FAILURE if the download is active.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDownload(uint aID);
		
		/// <summary>
        /// Removes all inactive downloads that were started inclusively within the
        /// specified time frame.
        ///
        /// @param aBeginTime
        /// The start time to remove downloads by in microseconds.
        /// @param aEndTime
        /// The end time to remove downloads by in microseconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDownloadsByTimeframe(int aBeginTime, int aEndTime);
		
		/// <summary>
        /// Pause the specified download.
        ///
        /// @param aID The unique ID of the download.
        /// @throws NS_ERROR_FAILURE if the download is not in-progress.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PauseDownload(uint aID);
		
		/// <summary>
        /// Resume the specified download.
        ///
        /// @param aID The unique ID of the download.
        /// @throws NS_ERROR_FAILURE if the download is not in-progress.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeDownload(uint aID);
		
		/// <summary>
        /// Retries a failed download.
        ///
        /// @param aID The unique ID of the download.
        /// @throws NS_ERROR_NOT_AVAILALE if the download id is not known.
        /// @throws NS_ERROR_FAILURE if the download is not in the following states:
        /// nsIDownloadManager::DOWNLOAD_CANCELED
        /// nsIDownloadManager::DOWNLOAD_FAILED
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RetryDownload(uint aID);
		
		/// <summary>
        /// The database connection to the downloads database.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageConnection GetDBConnectionAttribute();
		
		/// <summary>
        /// Whether or not there are downloads that can be cleaned up (removed)
        /// i.e. downloads that have completed, have failed or have been canceled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanCleanUpAttribute();
		
		/// <summary>
        /// Removes completed, failed, and canceled downloads from the list.
        ///
        /// Also notifies observers of the "download-manager-remove-download" topic
        /// with a null subject to allow any DM consumers to react to the removals.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CleanUp();
		
		/// <summary>
        /// The number of files currently being downloaded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetActiveDownloadCountAttribute();
		
		/// <summary>
        /// An enumeration of active nsIDownloads
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetActiveDownloadsAttribute();
		
		/// <summary>
        /// Adds a listener from the download manager.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddListener([MarshalAs(UnmanagedType.Interface)] nsIDownloadProgressListener aListener);
		
		/// <summary>
        /// Removes a listener from the download manager.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIDownloadProgressListener aListener);
		
		/// <summary>
        /// Returns the platform default downloads directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetDefaultDownloadsDirectoryAttribute();
		
		/// <summary>
        /// Returns the user configured downloads directory.
        /// The path is dependent on two user configurable prefs
        /// set in preferences:
        ///
        /// browser.download.folderList
        /// Indicates the location users wish to save downloaded
        /// files too.
        /// Values:
        /// 0 - The desktop is the default download location.
        /// 1 - The system's downloads folder is the default download location.
        /// 2 - The default download location is elsewhere as specified in
        /// browser.download.dir. If invalid, userDownloadsDirectory
        /// will fallback on defaultDownloadsDirectory.
        ///
        /// browser.download.dir -
        /// A local path the user may have selected at some point
        /// where downloaded files are saved. The use of which is
        /// enabled when folderList equals 2.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetUserDownloadsDirectoryAttribute();
	}
}
