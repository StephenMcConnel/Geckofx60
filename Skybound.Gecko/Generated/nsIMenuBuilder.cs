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
// Generated by IDLImporter from file nsIMenuBuilder.idl
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
    /// An interface used to construct native toolbar or context menus from <menu>
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("12724737-f7db-43b4-94ab-708a7b86e115")]
	public interface nsIMenuBuilder
	{
		
		/// <summary>
        /// Create the top level menu or a submenu. The implementation should create
        /// a new context for this menu, so all subsequent methods will add new items
        /// to this newly created menu.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenContainer([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLabel);
		
		/// <summary>
        /// Add a new menu item. All menu item details can be obtained from
        /// the element. This method is not called for hidden elements or elements
        /// with no or empty label. The icon should be loaded only if aCanLoadIcon
        /// is true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddItemFor([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLMenuItemElement aElement, [MarshalAs(UnmanagedType.Bool)] bool aCanLoadIcon);
		
		/// <summary>
        /// Create a new separator.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSeparator();
		
		/// <summary>
        /// Remove last added separator.
        /// Sometimes it's needed to remove last added separator, otherwise it's not
        /// possible to implement the postprocessing in one pass.
        /// See http://www.whatwg.org/specs/web-apps/current-work/multipage/interactive-elements.html#building-menus-and-toolbars
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UndoAddSeparator();
		
		/// <summary>
        /// Set the context to the parent menu.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CloseContainer();
	}
}
