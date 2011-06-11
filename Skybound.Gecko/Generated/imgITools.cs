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
// Generated by IDLImporter from file imgITools.idl
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
	
	
	/// <summary>imgITools </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c395d8f1-c616-4a1b-adfd-747b4b1b2cbe")]
	public interface imgITools
	{
		
		/// <summary>
        /// decodeImageData
        /// Caller provides an input stream and mimetype. We read from the stream
        /// and decompress it (according to the specified mime type) and return
        /// the resulting imgIContainer. (If the caller already has a container,
        /// it can be provided as input to be reused).
        ///
        /// @param aStream
        /// An input stream for an encoded image file.
        /// @param aMimeType
        /// Type of image in the stream.
        /// @param aContainer
        /// An imgIContainer holding the decoded image. Specify |null| when
        /// calling to have one created, otherwise specify a container to
        /// be used. It is an error to pass an already-initialized container
        /// as aContainer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecodeImageData([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aStream, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType, ref imgIContainer  aContainer);
		
		/// <summary>
        /// encodeImage
        /// Caller provides an image container, and the mime type it should be
        /// encoded to. We return an input stream for the encoded image data.
        ///
        /// @param aContainer
        /// An image container.
        /// @param aMimeType
        /// Type of encoded image desired (eg "image/png").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream EncodeImage(imgIContainer  aContainer, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType);
		
		/// <summary>
        /// encodeScaledImage
        /// Caller provides an image container, and the mime type it should be
        /// encoded to. We return an input stream for the encoded image data.
        /// The encoded image is scaled to the specified dimensions.
        ///
        /// @param aContainer
        /// An image container.
        /// @param aMimeType
        /// Type of encoded image desired (eg "image/png").
        /// @param aWidth, aHeight
        /// The size (in pixels) desired for the resulting image.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream EncodeScaledImage(imgIContainer  aContainer, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType, System.Int32  aWidth, System.Int32  aHeight);
	}
}
