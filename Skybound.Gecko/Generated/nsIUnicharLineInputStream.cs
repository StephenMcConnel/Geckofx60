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
// Generated by IDLImporter from file nsIUnicharLineInputStream.idl
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
	
	
	/// <summary>nsIUnicharLineInputStream </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("67f42475-ba80-40f8-ac0b-649c89230184")]
	public interface nsIUnicharLineInputStream
	{
		
		/// <summary>
        /// Read a single line from the stream, where a line is a
        /// possibly zero length sequence of characters terminated by a
        /// CR, LF, CRLF, LFCR, or eof.
        /// The line terminator is not returned.
        /// @retval false
        /// End of file. This line is the last line of the file
        /// (aLine is valid).
        /// @retval true
        /// The file contains further lines.
        /// @note Do not mix readLine with other read functions.
        /// Doing so can cause various problems and is not supported.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ReadLine([MarshalAs(UnmanagedType.LPStruct)] nsAString aLine);
	}
}
