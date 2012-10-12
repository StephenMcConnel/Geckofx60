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
// Generated by IDLImporter from file nsIScrollable.idl
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
	
	
	/// <summary>
    /// The nsIScrollable is an interface that can be implemented by a control that
    /// supports scrolling.  This is a generic interface without concern for the
    /// type of content that may be inside.  It simply deals blindly with scroll
    /// position as a composite of the lowest possible scroll position, the highest
    /// possible position and the current position lying somewhere between the
    /// min and the max.
    ///
    /// XXXroc in our tree, only get/setDefaultScrollbarPreferences and
    /// getScrollbarVisibility are actually used externally. We should gut
    /// the rest. nsDocShell is using twips for all these coordinates
    /// which is going to confuse people anyway...
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("919e792a-6490-40b8-bba5-f9e9ad5640c8")]
	public interface nsIScrollable
	{
		
		/// <summary>
        ///Retrieves or Sets the current thumb position to the curPos passed in for the
        ///	scrolling orientation passed in.  curPos should be between minPos and maxPos.
        ///	@return	NS_OK - Setting or Getting completed successfully.
        ///				NS_ERROR_INVALID_ARG - returned when curPos is not within the
        ///					minPos and maxPos.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCurScrollPos(int scrollOrientation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurScrollPos(int scrollOrientation, int curPos);
		
		/// <summary>
        ///This function atomizes the ability to scroll in two dimensions at the same
        ///	time.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurScrollPosEx(int curHorizontalPos, int curVerticalPos);
		
		/// <summary>
        ///Retrieves or Sets the valid ranges for the thumb.  When maxPos is set to
        ///	something less than the current thumb position, curPos is set = to maxPos.
        ///	@return	NS_OK - Setting or Getting completed successfully.
        ///				NS_ERROR_INVALID_ARG - returned when curPos is not within the
        ///					minPos and maxPos.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScrollRange(int scrollOrientation, ref int minPos, ref int maxPos);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScrollRange(int scrollOrientation, int minPos, int maxPos);
		
		/// <summary>
        ///This function atomizes the ability to set the ranges in two dimensions at
        ///	the same time.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScrollRangeEx(int minHorizontalPos, int maxHorizontalPos, int minVerticalPos, int maxVerticalPos);
		
		/// <summary>
        ///Retrieves or Set the preferences for the scroll bar.
        ///	current is 'scrolling preference for this document'
        ///	default is 'scrolling preference for all documents in this shell'
        ///	resetScrollbarPreferences resets current to default
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDefaultScrollbarPreferences(int scrollOrientation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultScrollbarPreferences(int scrollOrientation, int scrollbarPref);
		
		/// <summary>
        ///Get information about whether the vertical and horizontal scrollbars are
        ///	currently visible.  nsnull is a valid argument.  If you are only interested
        ///	in one of the visibility settings pass nsnull in for the one you aren't
        ///	interested in.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScrollbarVisibility([MarshalAs(UnmanagedType.U1)] ref bool verticalVisible, [MarshalAs(UnmanagedType.U1)] ref bool horizontalVisible);
	}
	
	/// <summary>nsIScrollableConsts </summary>
	public class nsIScrollableConsts
	{
		
		// <summary>
        //Constants declaring the two scroll orientations a scroll bar can be in.
        //        ScrollOrientation_X - Horizontal scrolling.  When passing this
        //                in to a scroll position method you are requesting or
        //                setting the positions for the horizontal scroll bar.
        //        ScrollOrientation_Y - Vertical scrolling.  When passing this
        //                in to a scroll position you are requesting or setting
        //                the positions for the vertical scroll bar.
        //	 </summary>
		public const long ScrollOrientation_X = 1;
		
		// 
		public const long ScrollOrientation_Y = 2;
		
		// <summary>
        //Constants declaring the states of the scroll bars.
        //	ScrollPref_Auto - bars visible only when needed.
        //	ScrollPref_Never - bars never visible, even when scrolling still possible.
        //	ScrollPref_Always - bars always visible, even when scrolling is not possible
        //	 </summary>
		public const long Scrollbar_Auto = 1;
		
		// 
		public const long Scrollbar_Never = 2;
		
		// 
		public const long Scrollbar_Always = 3;
	}
}
