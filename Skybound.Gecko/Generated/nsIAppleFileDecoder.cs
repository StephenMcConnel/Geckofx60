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
// Generated by IDLImporter from file nsIAppleFileDecoder.idl
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
	
	
	/// <summary>nsIAppleFileDecoder </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3a2bb280-64b8-11d5-9daa-bb433143c53c")]
	public interface nsIAppleFileDecoder : nsIOutputStream
	{
		
		/// <summary>
        /// Close the stream. Forces the output stream to flush any buffered data.
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if unable to flush without blocking
        /// the calling thread (non-blocking mode only)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close();
		
		/// <summary>
        /// Flush the stream.
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if unable to flush without blocking
        /// the calling thread (non-blocking mode only)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Flush();
		
		/// <summary>
        /// Write data into the stream.
        ///
        /// @param aBuf the buffer containing the data to be written
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint Write([MarshalAs(UnmanagedType.LPStr)] string aBuf, uint aCount);
		
		/// <summary>
        /// Writes data into the stream from an input stream.
        ///
        /// @param aFromStream the stream containing the data to be written
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        ///
        /// NOTE: This method is defined by this interface in order to allow the
        /// output stream to efficiently copy the data from the input stream into
        /// its internal buffer (if any). If this method was provided as an external
        /// facility, a separate char* buffer would need to be used in order to call
        /// the output stream's other Write method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint WriteFrom([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, uint aCount);
		
		/// <summary>
        /// Low-level write method that has access to the stream's underlying buffer.
        /// The reader function may be called multiple times for segmented buffers.
        /// WriteSegments is expected to keep calling the reader until either there
        /// is nothing left to write or the reader returns an error.  WriteSegments
        /// should not call the reader with zero bytes to provide.
        ///
        /// @param aReader the "provider" of the data to be written
        /// @param aClosure opaque parameter passed to reader
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws NS_ERROR_NOT_IMPLEMENTED if the stream has no underlying buffer
        /// @throws <other-error> on failure
        ///
        /// NOTE: this function may be unimplemented if a stream has no underlying
        /// buffer (e.g., socket output stream).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint WriteSegments(System.IntPtr aReader, System.IntPtr aClosure, uint aCount);
		
		/// <summary>
        /// @return true if stream is non-blocking
        ///
        /// NOTE: writing to a blocking output stream will block the calling thread
        /// until all given data can be consumed by the stream.
        ///
        /// NOTE: a non-blocking output stream may implement nsIAsyncOutputStream to
        /// provide consumers with a way to wait for the stream to accept more data
        /// once its write method is unable to accept any data without blocking.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsNonBlocking();
		
		/// <summary>
        /// Initialize the Apple File Decoder Output stream.
        ///
        /// @param outputStream     The output stream which the AppleFile Decoder will write to the data fork.
        /// @param outputFile       The output file which the AppleFile Decoder will write to the resource fork.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Initialize([MarshalAs(UnmanagedType.Interface)] nsIOutputStream outputStream, [MarshalAs(UnmanagedType.Interface)] nsIFile outputFile);
	}
}
