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
// Generated by IDLImporter from file nsIDOMFile.idl
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
	
	
	/// <summary>nsIDOMBlob </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d5237f31-443a-460b-9e42-449a135346f0")]
	public interface nsIDOMBlob
	{
		
		/// <summary>Member GetSizeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSizeAttribute();
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member GetInternalStreamAttribute </summary>
		/// <returns>A nsIInputStream</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetInternalStreamAttribute();
		
		/// <summary>
        /// moz-filedata: protocol handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInternalUrl([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>Member MozSlice </summary>
		/// <param name='start'> </param>
		/// <param name='end'> </param>
		/// <param name='contentType'> </param>
		/// <returns>A nsIDOMBlob</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMBlob MozSlice(int start, int end, [MarshalAs(UnmanagedType.LPStruct)] nsAString contentType);
	}
	
	/// <summary>nsIDOMFile </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("91c9ebd9-2a4a-4a38-9412-ef492a2799be")]
	public interface nsIDOMFile : nsIDOMBlob
	{
		
		/// <summary>Member GetSizeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetSizeAttribute();
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member GetInternalStreamAttribute </summary>
		/// <returns>A nsIInputStream</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream GetInternalStreamAttribute();
		
		/// <summary>
        /// moz-filedata: protocol handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetInternalUrl([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>Member MozSlice </summary>
		/// <param name='start'> </param>
		/// <param name='end'> </param>
		/// <param name='contentType'> </param>
		/// <returns>A nsIDOMBlob</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMBlob MozSlice(int start, int end, [MarshalAs(UnmanagedType.LPStruct)] nsAString contentType);
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>Member GetMozFullPathAttribute </summary>
		/// <param name='aMozFullPath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMozFullPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMozFullPath);
		
		/// <summary>
        /// This performs no security checks!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMozFullPathInternalAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMozFullPathInternal);
		
		/// <summary>
        /// release
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFileName);
		
		/// <summary>Member GetFileSizeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFileSizeAttribute();
		
		/// <summary>Member GetAsText </summary>
		/// <param name='encoding'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsText([MarshalAs(UnmanagedType.LPStruct)] nsAString encoding, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// raises(FileException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsDataURL([MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// raises(FileException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsBinary([MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
	}
	
	/// <summary>
    /// raises(FileException) on retrieval
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c4a77171-039b-4f84-97f9-820fb51626af")]
	public interface nsIDOMMozBlobBuilder
	{
		
		/// <summary>
        /// raises(FileException) on retrieval
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMBlob GetBlob([MarshalAs(UnmanagedType.LPStruct)] nsAString contentType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Append(System.IntPtr data);
	}
}
