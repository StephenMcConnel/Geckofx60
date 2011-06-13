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
// Generated by IDLImporter from file imgILoader.idl
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
    /// imgILoader interface
    ///
    /// @author Stuart Parmenter <pavlov@netscape.com>
    /// @version 0.3
    /// @see imagelib2
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("47fbc3e7-c654-4ffb-83fc-a861394145ee")]
	public interface imgILoader
	{
		
		/// <summary>
        /// Start the load and decode of an image.
        /// @param aURI the URI to load
        /// @param aInitialDocumentURI the URI that 'initiated' the load -- used for 3rd party cookie blocking
        /// @param aReferrerURI the 'referring' URI
        /// @param aLoadGroup Loadgroup to put the image load into
        /// @param aObserver the observer (may be null)
        /// @param aCX some random data
        /// @param aLoadFlags Load flags for the request
        /// @param aCacheKey cache key to use for a load if the original
        /// image came from a request that had post data
        /// @param aRequest A newly created, unused imgIRequest object or NULL for one to
        ///                     be created for you.
        /// libpr0n does NOT keep a strong ref to the observer; this prevents
        /// reference cycles.  This means that callers of loadImage should
        /// make sure to Cancel() the resulting request before the observer
        /// goes away.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIRequest LoadImage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aInitialDocumentURL, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrerURI, [MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup, imgIDecoderObserver aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports aCX, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsISupports cacheKey, imgIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsIChannelPolicy channelPolicy);
		
		/// <summary>
        /// Start the load and decode of an image.
        /// @param aChannel the channel to load the image from.  This must
        /// already be opened before ths method is called, and there
        /// must have been no OnDataAvailable calls for it yet.
        /// @param aObserver the observer (may be null)
        /// @param cx some random data
        /// @param aListener [out]
        /// A listener that you must send the channel's notifications and data to.
        /// Can be null, in which case imagelib has found a cached image and is
        /// not interested in the data. @aChannel will be canceled for you in
        /// this case.
        ///
        /// libpr0n does NOT keep a strong ref to the observer; this prevents
        /// reference cycles.  This means that callers of loadImageWithChannel should
        /// make sure to Cancel() the resulting request before the observer goes away.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIRequest LoadImageWithChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, imgIDecoderObserver aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports cx, [MarshalAs(UnmanagedType.Interface)] out nsIStreamListener aListener);
		
		/// <summary>
        /// Checks if a decoder for the an image with the given mime type is available
        /// @param mimeType The type to find a decoder for
        /// @return true if a decoder is available, false otherwise
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SupportImageWithMimeType([MarshalAs(UnmanagedType.LPStr)] string mimeType);
	}
}
