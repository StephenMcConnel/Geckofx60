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
// Generated by IDLImporter from file nsIDownloadProgressListener.idl
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
    ///A minimally extended progress listener used by download manager
    /// to update its default UI.  This is implemented in nsDownloadProgressListener.js.
    /// See nsIWebProgressListener for documentation, and use its constants.  This isn't
    /// too pretty, but the alternative is having this extend nsIWebProgressListener and
    /// adding an |item| attribute, which would mean a separate nsIDownloadProgressListener
    /// for every nsIDownloadItem, which is a waste...
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7acb07ea-cac2-4c15-a3ad-23aaa789ed51")]
	public interface nsIDownloadProgressListener
	{
		
		/// <summary>
        /// document
        /// The document of the download manager frontend.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDocumentAttribute();
		
		/// <summary>
        /// document
        /// The document of the download manager frontend.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument);
		
		/// <summary>
        /// Dispatched whenever the state of the download changes.
        ///
        /// @param aState The previous download sate.
        /// @param aDownload The download object.
        /// @see nsIDownloadManager for download states.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDownloadStateChange(short aState, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStateChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aStateFlags, int aStatus, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProgressChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, long aCurSelfProgress, long aMaxSelfProgress, long aCurTotalProgress, long aMaxTotalProgress, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aState, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload);
	}
}
