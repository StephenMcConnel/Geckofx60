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
// Generated by IDLImporter from file nsIPropertyBag2.idl
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
    ///nsIVariant based Property Bag support. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("625cfd1e-da1e-4417-9ee9-dbc8e0b3fd79")]
	public interface nsIPropertyBag2 : nsIPropertyBag
	{
		
		/// <summary>
        /// Get a nsISimpleEnumerator whose elements are nsIProperty objects.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISimpleEnumerator GetEnumeratorAttribute();
		
		/// <summary>
        /// Get a property value for the given name.
        /// @throws NS_ERROR_FAILURE if a property with that name doesn't
        /// exist.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant GetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        /// requested value
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPropertyAsInt32([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPropertyAsUint32([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetPropertyAsInt64([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetPropertyAsUint64([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPropertyAsDouble([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPropertyAsAString([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPropertyAsACString([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPropertyAsAUTF8String([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPropertyAsBool([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop);
		
		/// <summary>
        /// This method returns null if the value exists, but is null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPropertyAsInterface([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop, ref System.Guid iid);
		
		/// <summary>
        /// This method returns null if the value does not exist,
        /// or exists but is null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant Get([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop);
		
		/// <summary>
        /// Check for the existence of a key.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasKey([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prop);
	}
}
