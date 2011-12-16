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
// Generated by IDLImporter from file nsIConverterOutputStream.idl
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
    /// This interface allows writing strings to a stream, doing automatic
    /// character encoding conversion.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4b71113a-cb0d-479f-8ed5-01daeba2e8d4")]
	public interface nsIConverterOutputStream : nsIUnicharOutputStream
	{
		
		/// <summary>
        /// Write a single character to the stream. When writing many characters,
        /// prefer the string-taking write method.
        ///
        /// @retval true The character was written successfully
        /// @retval false Not all bytes of the character could be written.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Write(uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] string c);
		
		/// <summary>
        /// Write a string to the stream.
        ///
        /// @retval true The string was written successfully
        /// @retval false Not all bytes of the string could be written.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool WriteString([MarshalAs(UnmanagedType.LPStruct)] nsAString str);
		
		/// <summary>
        /// Flush the stream. This finishes the conversion and writes any bytes that
        /// finish the current byte sequence.
        ///
        /// It does NOT flush the underlying stream.
        ///
        /// @see nsIUnicodeEncoder::Finish
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Flush();
		
		/// <summary>
        /// Close the stream and free associated resources. This also closes the
        /// underlying stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close();
		
		/// <summary>
        /// Initialize this stream. Must be called before any other method on this
        /// interface, or you will crash. The output stream passed to this method
        /// must not be null, or you will crash.
        ///
        /// @param aOutStream
        /// The underlying output stream to which the converted strings will
        /// be written.
        /// @param aCharset
        /// The character set to use for encoding the characters. A null
        /// charset will be interpreted as UTF-8.
        /// @param aBufferSize
        /// How many bytes to buffer. A value of 0 means that no bytes will be
        /// buffered. Implementations not supporting buffering may ignore
        /// this parameter.
        /// @param aReplacementCharacter
        /// The replacement character to use when an unsupported character is found.
        /// The character must be encodable in the selected character
        /// encoding; otherwise, attempts to write an unsupported character
        /// will throw NS_ERROR_LOSS_OF_SIGNIFICANT_DATA.
        ///
        /// A value of 0x0000 will cause an exception to be thrown upon
        /// attempts to write unsupported characters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aOutStream, [MarshalAs(UnmanagedType.LPStr)] string aCharset, uint aBufferSize, [MarshalAs(UnmanagedType.LPWStr)] string aReplacementCharacter);
	}
}
