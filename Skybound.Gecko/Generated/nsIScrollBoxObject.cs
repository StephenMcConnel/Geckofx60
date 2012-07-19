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
// Generated by IDLImporter from file nsIScrollBoxObject.idl
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

	
	
	/// <summary>nsIScrollBoxObject </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56E2ADA8-4631-11d4-BA11-001083023C1E")]
	public interface nsIScrollBoxObject
	{
		
		/// <summary>
        /// Scroll to the given coordinates, in css pixels.
        /// (0,0) will put the top left corner of the scrolled element's padding-box
        /// at the top left corner of the scrollport (which is its inner-border-box).
        /// Values will be clamped to legal values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollTo(int x, int y);
		
		/// <summary>
        /// Scroll the given amount of device pixels to the right and down.
        /// Values will be clamped to make the resuling position legal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollBy(int dx, int dy);
		
		/// <summary>Member ScrollByLine </summary>
		/// <param name='dlines'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollByLine(int dlines);
		
		/// <summary>Member ScrollByIndex </summary>
		/// <param name='dindexes'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollByIndex(int dindexes);
		
		/// <summary>Member ScrollToLine </summary>
		/// <param name='line'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollToLine(int line);
		
		/// <summary>Member ScrollToElement </summary>
		/// <param name='child'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollToElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement child);
		
		/// <summary>Member ScrollToIndex </summary>
		/// <param name='index'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollToIndex(int index);
		
		/// <summary>
        /// Get the current scroll position in css pixels.
        /// @see scrollTo for the definition of x and y.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPosition(ref int x, ref int y);
		
		/// <summary>Member GetScrolledSize </summary>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScrolledSize(ref int width, ref int height);
		
		/// <summary>Member EnsureElementIsVisible </summary>
		/// <param name='child'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnsureElementIsVisible([MarshalAs(UnmanagedType.Interface)] nsIDOMElement child);
		
		/// <summary>Member EnsureIndexIsVisible </summary>
		/// <param name='index'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnsureIndexIsVisible(int index);
		
		/// <summary>Member EnsureLineIsVisible </summary>
		/// <param name='line'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnsureLineIsVisible(int line);
	}
}
