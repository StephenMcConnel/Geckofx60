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
// Generated by IDLImporter from file nsIDOMSVGPathSegList.idl
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
	
	
	/// <summary>nsIDOMSVGPathSegList </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("94a6db98-3f34-4529-a35f-89ef49713795")]
	public interface nsIDOMSVGPathSegList
	{
		
		/// <summary>Member GetNumberOfItemsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetNumberOfItemsAttribute();
		
		/// <summary>Member Clear </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
		
		/// <summary>
        /// raises(nsIDOMDOMException);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg Initialize([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPathSeg  newItem);
		
		/// <summary>
        /// raises(nsIDOMDOMException, nsIDOMSVGException);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg GetItem(System.UInt32  index);
		
		/// <summary>
        /// raises(nsIDOMDOMException);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg InsertItemBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPathSeg  newItem, System.UInt32  index);
		
		/// <summary>
        /// raises(nsIDOMDOMException, nsIDOMSVGException);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg ReplaceItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPathSeg  newItem, System.UInt32  index);
		
		/// <summary>
        /// raises(nsIDOMDOMException, nsIDOMSVGException);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg RemoveItem(System.UInt32  index);
		
		/// <summary>
        /// raises(nsIDOMDOMException);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPathSeg AppendItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGPathSeg  newItem);
	}
}
