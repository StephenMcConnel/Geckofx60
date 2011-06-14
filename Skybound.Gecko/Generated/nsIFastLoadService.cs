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
// Generated by IDLImporter from file nsIFastLoadService.idl
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
	
	
	/// <summary>nsIFastLoadFileIO </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("61cd17e0-b07a-4158-9817-36a206b100e9")]
	public interface nsIFastLoadFileIO
	{
		
		/// <summary>Member GetInputStreamAttribute </summary>
		/// <returns>A nsIInputStream</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetInputStreamAttribute();
		
		/// <summary>Member GetOutputStreamAttribute </summary>
		/// <returns>A nsIOutputStream</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIOutputStream GetOutputStreamAttribute();
		
		/// <summary>
        /// Causes outputStream to be created in non-truncating mode
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableTruncate();
	}
	
	/// <summary>nsIFastLoadService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c18df300-c2e4-4115-a61c-9110655f7dd8")]
	public interface nsIFastLoadService
	{
		
		/// <summary>Member NewFastLoadFile </summary>
		/// <param name='aBaseName'> </param>
		/// <returns>A nsIFile</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile NewFastLoadFile([MarshalAs(UnmanagedType.LPStr)] string aBaseName);
		
		/// <summary>Member NewInputStream </summary>
		/// <param name='aFile'> </param>
		/// <returns>A nsIObjectInputStream</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIObjectInputStream NewInputStream([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
		
		/// <summary>Member NewOutputStream </summary>
		/// <param name='aDestStream'> </param>
		/// <returns>A nsIObjectOutputStream</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIObjectOutputStream NewOutputStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aDestStream);
		
		/// <summary>
        /// parameter to startMuxedDocument.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIObjectInputStream GetInputStreamAttribute();
		
		/// <summary>
        /// parameter to startMuxedDocument.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInputStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);
		
		/// <summary>Member GetOutputStreamAttribute </summary>
		/// <returns>A nsIObjectOutputStream</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIObjectOutputStream GetOutputStreamAttribute();
		
		/// <summary>Member SetOutputStreamAttribute </summary>
		/// <param name='aOutputStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOutputStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);
		
		/// <summary>Member GetFileIOAttribute </summary>
		/// <returns>A nsIFastLoadFileIO</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFastLoadFileIO GetFileIOAttribute();
		
		/// <summary>Member SetFileIOAttribute </summary>
		/// <param name='aFileIO'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileIOAttribute([MarshalAs(UnmanagedType.Interface)] nsIFastLoadFileIO aFileIO);
		
		/// <summary>Member GetDirectionAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDirectionAttribute();
		
		/// <summary>
        /// These methods associate a URI object with its spec, for faster select
        /// using the object pointer as a key, rather than the spec string.  The
        /// selectMuxedDocument method returns the previously selected URI object,
        /// in case a caller needs to reselect the previous after muxing data for
        /// a given URI synchronously.  For the non-blocking or "asynchronous" i/o
        /// case, the caller must select the source URI from the FastLoad multiplex
        /// before writing a new burst of data parsed from the slow-loaded source.
        ///
        /// Clients of inputStream and outputStream should try to demultiplex data
        /// from the input stream only if fastLoadService->StartMuxedDocument(uri,
        /// urispec, NS_FASTLOAD_READ) succeeds.  If StartMuxedDocument fails with
        /// NS_ERROR_NOT_AVAILABLE, callers should slow-load the documents, muxing
        /// their data to the current output stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartMuxedDocument([MarshalAs(UnmanagedType.Interface)] nsISupports aURI, [MarshalAs(UnmanagedType.LPStr)] string aURISpec, int aDirectionFlags);
		
		/// <summary>Member SelectMuxedDocument </summary>
		/// <param name='aURI'> </param>
		/// <returns>A nsISupports</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports SelectMuxedDocument([MarshalAs(UnmanagedType.Interface)] nsISupports aURI);
		
		/// <summary>Member EndMuxedDocument </summary>
		/// <param name='aURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndMuxedDocument([MarshalAs(UnmanagedType.Interface)] nsISupports aURI);
		
		/// <summary>Member AddDependency </summary>
		/// <param name='aFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDependency([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
		
		/// <summary>Member ComputeChecksum </summary>
		/// <param name='aFile'> </param>
		/// <param name='aControl'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint ComputeChecksum([MarshalAs(UnmanagedType.Interface)] nsIFile aFile, [MarshalAs(UnmanagedType.Interface)] nsIFastLoadReadControl aControl);
		
		/// <summary>Member CacheChecksum </summary>
		/// <param name='aFile'> </param>
		/// <param name='aStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CacheChecksum([MarshalAs(UnmanagedType.Interface)] nsIFile aFile, [MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aStream);
		
		/// <summary>Member GetFastLoadReferent </summary>
		/// <param name='aPtr'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFastLoadReferent([MarshalAs(UnmanagedType.Interface)] ref nsISupports aPtr);
		
		/// <summary>Member ReadFastLoadPtr </summary>
		/// <param name='aInputStream'> </param>
		/// <param name='aPtr'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadFastLoadPtr([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aPtr);
		
		/// <summary>Member WriteFastLoadPtr </summary>
		/// <param name='aOutputStream'> </param>
		/// <param name='aPtr'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WriteFastLoadPtr([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream, [MarshalAs(UnmanagedType.Interface)] nsISupports aPtr);
		
		/// <summary>
        /// Return true if aURISpec identifies a muxed document in the FastLoad
        /// file, false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMuxedDocument([MarshalAs(UnmanagedType.LPStr)] string aURISpec);
	}
}
