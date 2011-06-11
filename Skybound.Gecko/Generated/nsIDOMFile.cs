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
	[Guid("5822776a-049c-4de7-adb6-dd9efc39d082")]
	public interface nsIDOMBlob
	{
		
		/// <summary>Member GetSizeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetSizeAttribute();
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member Slice </summary>
		/// <param name='start'> </param>
		/// <param name='length'> </param>
		/// <param name='contentType'> </param>
		/// <returns>A nsIDOMBlob</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMBlob Slice(System.UInt32  start, System.UInt32  length, [MarshalAs(UnmanagedType.LPStruct)] nsAString contentType);
		
		/// <summary>Member GetInternalStreamAttribute </summary>
		/// <returns>A nsIInputStream </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream  GetInternalStreamAttribute();
		
		/// <summary>
        /// moz-filedata: protocol handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetInternalUrl([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  principal);
	}
	
	/// <summary>nsIDOMBlob_MOZILLA_2_0_BRANCH </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cb5b4191-a555-4e57-b8d2-88091184b59f")]
	public interface nsIDOMBlob_MOZILLA_2_0_BRANCH
	{
		
		/// <summary>Member MozSlice </summary>
		/// <param name='start'> </param>
		/// <param name='end'> </param>
		/// <param name='contentType'> </param>
		/// <returns>A nsIDOMBlob</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMBlob MozSlice(System.Int32  start, System.Int32  end, [MarshalAs(UnmanagedType.LPStruct)] nsAString contentType);
	}
	
	/// <summary>nsIDOMFile </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ae1405b0-e411-481e-9606-b29ec7982687")]
	public interface nsIDOMFile : nsIDOMBlob
	{
		
		/// <summary>Member GetSizeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetSizeAttribute();
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member Slice </summary>
		/// <param name='start'> </param>
		/// <param name='length'> </param>
		/// <param name='contentType'> </param>
		/// <returns>A nsIDOMBlob</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMBlob Slice(System.UInt32  start, System.UInt32  length, [MarshalAs(UnmanagedType.LPStruct)] nsAString contentType);
		
		/// <summary>Member GetInternalStreamAttribute </summary>
		/// <returns>A nsIInputStream </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream  GetInternalStreamAttribute();
		
		/// <summary>
        /// moz-filedata: protocol handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetInternalUrl([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  principal);
		
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
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetFileSizeAttribute();
		
		/// <summary>Member GetAsText </summary>
		/// <param name='encoding'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetAsText([MarshalAs(UnmanagedType.LPStruct)] nsAString encoding);
		
		/// <summary>
        /// raises(FileException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetAsDataURL();
		
		/// <summary>
        /// raises(FileException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetAsBinary();
	}
}
