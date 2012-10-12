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
// Generated by IDLImporter from file nsIInputStreamChannel.idl
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
    /// nsIInputStreamChannel
    ///
    /// This interface provides methods to initialize an input stream channel.
    /// The input stream channel serves as a data pump for an input stream.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("274c4d7a-2447-4ceb-a6de-80db1b83f5d2")]
	public interface nsIInputStreamChannel
	{
		
		/// <summary>
        /// Sets the URI for this channel.  This must be called before the
        /// channel is opened, and it may only be called once.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Get/set the content stream
        ///
        /// This stream contains the data that will be pushed to the channel's
        /// stream listener.  If the stream is non-blocking and supports the
        /// nsIAsyncInputStream interface, then the stream will be read directly.
        /// Otherwise, the stream will be read on a background thread.
        ///
        /// This attribute must be set before the channel is opened, and it may
        /// only be set once.
        ///
        /// @throws NS_ERROR_IN_PROGRESS if the setter is called after the channel
        /// has been opened.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetContentStreamAttribute();
		
		/// <summary>
        /// Get/set the content stream
        ///
        /// This stream contains the data that will be pushed to the channel's
        /// stream listener.  If the stream is non-blocking and supports the
        /// nsIAsyncInputStream interface, then the stream will be read directly.
        /// Otherwise, the stream will be read on a background thread.
        ///
        /// This attribute must be set before the channel is opened, and it may
        /// only be set once.
        ///
        /// @throws NS_ERROR_IN_PROGRESS if the setter is called after the channel
        /// has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aContentStream);
	}
}
