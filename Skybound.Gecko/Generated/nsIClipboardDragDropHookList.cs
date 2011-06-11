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
// Generated by IDLImporter from file nsIClipboardDragDropHookList.idl
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
    /// 876A2015-6B66-11D7-8F18-0003938A9D96
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("876A2015-6B66-11D7-8F18-0003938A9D96")]
	public interface nsIClipboardDragDropHookList
	{
		
		/// <summary>
        /// Add a hook to list.
        /// @param aHooks  implementation of hooks
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddClipboardDragDropHooks([MarshalAs(UnmanagedType.Interface)] nsIClipboardDragDropHooks  aHooks);
		
		/// <summary>
        /// Remove a hook from list (note if this implementation is not present
        /// in the list then removal will be ignored).
        /// @param aHooks  implementation of hooks
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveClipboardDragDropHooks([MarshalAs(UnmanagedType.Interface)] nsIClipboardDragDropHooks  aHooks);
		
		/// <summary>
        /// Gets an enumerator for all hooks which have been added.
        /// @return nsISimpleEnumerator for nsIClipboardDragDropHooks
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetHookEnumerator();
	}
}
