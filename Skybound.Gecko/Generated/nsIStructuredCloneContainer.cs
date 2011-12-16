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
// Generated by IDLImporter from file nsIStructuredCloneContainer.idl
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
    /// This interface acts as a container for an object serialized using the
    /// structured clone algorithm.
    ///
    /// You can copy an object into an nsIStructuredCloneContainer using
    /// initFromVariant or initFromBase64.  It's an error to initialize an
    /// nsIStructuredCloneContainer more than once.
    ///
    /// Once you've initialized the container, you can get a copy of the object it
    /// stores by calling deserializeToVariant.  You can also get a base-64-encoded
    /// string containing a copy of the container's serialized data, using
    /// getDataAsBase64.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("400a282d-7157-4ed0-85b4-8bdc2fa634cd")]
	public interface nsIStructuredCloneContainer
	{
		
		/// <summary>
        /// Initialize this structured clone container so it contains a clone of the
        /// given variant. aData must be backed by a jsval.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitFromVariant([MarshalAs(UnmanagedType.Interface)] nsIVariant aData);
		
		/// <summary>
        /// Initialize this structured clone container from a base-64-encoded byte
        /// stream, stored in aData.  aFormatVersion should be the version of the
        /// structured clone algorithm which was used to generate aData.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitFromBase64([MarshalAs(UnmanagedType.LPStruct)] nsAString aData, uint aFormatVersion);
		
		/// <summary>
        /// Deserialize the object this conatiner holds, returning it wrapped as
        /// an nsIVariant.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant DeserializeToVariant();
		
		/// <summary>
        /// Get this structured clone container's data as a base-64-encoded string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDataAsBase64([MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Get the size in bytes of this container's serialized data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSerializedNBytesAttribute();
		
		/// <summary>
        /// Get the version of the structured clone algorithm which was used to
        /// generate this container's serialized buffer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFormatVersionAttribute();
	}
}
