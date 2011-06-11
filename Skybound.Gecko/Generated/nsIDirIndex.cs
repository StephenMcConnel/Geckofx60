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
// Generated by IDLImporter from file nsIDirIndex.idl
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
    ///A class holding information about a directory index.
    /// These have no reference back to their original source -
    /// changing these attributes won't affect the directory
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("23bbabd0-1dd2-11b2-86b7-aad68ae7d7e0")]
	public interface nsIDirIndex
	{
		
		/// <summary>
        /// The type of the entry - one of the constants above
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetTypeAttribute();
		
		/// <summary>
        /// The type of the entry - one of the constants above
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute(System.UInt32  aType);
		
		/// <summary>
        /// The content type - may be null if it is unknown.
        /// Unspecified for directories
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetContentTypeAttribute();
		
		/// <summary>
        /// The content type - may be null if it is unknown.
        /// Unspecified for directories
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStr)] System.String  aContentType);
		
		/// <summary>
        /// The fully qualified filename, expressed as a uri
        ///
        /// This is encoded with the encoding specified in
        /// the nsIDirIndexParser, and is also escaped.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetLocationAttribute();
		
		/// <summary>
        /// The fully qualified filename, expressed as a uri
        ///
        /// This is encoded with the encoding specified in
        /// the nsIDirIndexParser, and is also escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLocationAttribute([MarshalAs(UnmanagedType.LPStr)] System.String  aLocation);
		
		/// <summary>
        /// A description for the filename, which should be
        /// displayed by a viewer
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDescriptionAttribute();
		
		/// <summary>
        /// A description for the filename, which should be
        /// displayed by a viewer
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDescription);
		
		/// <summary>
        /// File size, with -1 meaning "unknown"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSizeAttribute();
		
		/// <summary>
        /// File size, with -1 meaning "unknown"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSizeAttribute(System.Int32  aSize);
		
		/// <summary>
        /// Last-modified time in seconds-since-epoch.
        /// -1 means unknown - this is valid, because there were no
        /// ftp servers in 1969
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLastModifiedAttribute();
		
		/// <summary>
        /// Last-modified time in seconds-since-epoch.
        /// -1 means unknown - this is valid, because there were no
        /// ftp servers in 1969
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastModifiedAttribute(System.UInt32  aLastModified);
	}
}
