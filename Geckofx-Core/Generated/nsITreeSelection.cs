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
// Generated by IDLImporter from file nsITreeSelection.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ab6fe746-300b-4ab4-abb9-1c0e3977874c")]
	public interface nsITreeSelection
	{
		
		/// <summary>
        /// The tree widget for this selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITreeBoxObject GetTreeAttribute();
		
		/// <summary>
        /// The tree widget for this selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTreeAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeBoxObject aTree);
		
		/// <summary>
        /// This attribute is a boolean indicating single selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSingleAttribute();
		
		/// <summary>
        /// The number of rows currently selected in this tree.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCountAttribute();
		
		/// <summary>
        /// Indicates whether or not the row at the specified index is
        /// part of the selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSelected(int index);
		
		/// <summary>
        /// Deselect all rows and select the row at the specified index.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Select(int index);
		
		/// <summary>
        /// Perform a timed select.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TimedSelect(int index, int delay);
		
		/// <summary>
        /// Toggle the selection state of the row at the specified index.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ToggleSelect(int index);
		
		/// <summary>
        /// Select the range specified by the indices.  If augment is true,
        /// then we add the range to the selection without clearing out anything
        /// else.  If augment is false, everything is cleared except for the specified range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RangedSelect(int startIndex, int endIndex, [MarshalAs(UnmanagedType.U1)] bool augment);
		
		/// <summary>
        /// Clears the range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearRange(int startIndex, int endIndex);
		
		/// <summary>
        /// Clears the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearSelection();
		
		/// <summary>
        /// Inverts the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvertSelection();
		
		/// <summary>
        /// Selects all rows.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectAll();
		
		/// <summary>
        /// Iterate the selection using these methods.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRangeCount();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRangeAt(int i, ref int min, ref int max);
		
		/// <summary>
        /// Can be used to invalidate the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvalidateSelection();
		
		/// <summary>
        /// Called when the row count changes to adjust selection indices.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AdjustSelection(int index, int count);
		
		/// <summary>
        /// This attribute is a boolean indicating whether or not the
        /// "select" event should fire when the selection is changed using
        /// one of our methods.  A view can use this to temporarily suppress
        /// the selection while manipulating all of the indices, e.g., on
        /// a sort.
        /// Note: setting this attribute to false will fire a select event.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSelectEventsSuppressedAttribute();
		
		/// <summary>
        /// This attribute is a boolean indicating whether or not the
        /// "select" event should fire when the selection is changed using
        /// one of our methods.  A view can use this to temporarily suppress
        /// the selection while manipulating all of the indices, e.g., on
        /// a sort.
        /// Note: setting this attribute to false will fire a select event.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectEventsSuppressedAttribute([MarshalAs(UnmanagedType.U1)] bool aSelectEventsSuppressed);
		
		/// <summary>
        /// The current item (the one that gets a focus rect in addition to being
        /// selected).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCurrentIndexAttribute();
		
		/// <summary>
        /// The current item (the one that gets a focus rect in addition to being
        /// selected).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentIndexAttribute(int aCurrentIndex);
		
		/// <summary>
        /// The current column.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITreeColumn GetCurrentColumnAttribute();
		
		/// <summary>
        /// The current column.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentColumnAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeColumn aCurrentColumn);
		
		/// <summary>
        /// The selection "pivot".  This is the first item the user selected as
        /// part of a ranged select.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetShiftSelectPivotAttribute();
	}
	
	/// <summary>
    /// The following interface is not scriptable and MUST NEVER BE MADE scriptable.
    /// Native treeselections implement it, and we use this to check whether a
    /// treeselection is native (and therefore suitable for use by untrusted content).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1bd59678-5cb3-4316-b246-31a91b19aabe")]
	public interface nsINativeTreeSelection : nsITreeSelection
	{
		
		/// <summary>
        /// The tree widget for this selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsITreeBoxObject GetTreeAttribute();
		
		/// <summary>
        /// The tree widget for this selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTreeAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeBoxObject aTree);
		
		/// <summary>
        /// This attribute is a boolean indicating single selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetSingleAttribute();
		
		/// <summary>
        /// The number of rows currently selected in this tree.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetCountAttribute();
		
		/// <summary>
        /// Indicates whether or not the row at the specified index is
        /// part of the selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSelected(int index);
		
		/// <summary>
        /// Deselect all rows and select the row at the specified index.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Select(int index);
		
		/// <summary>
        /// Perform a timed select.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void TimedSelect(int index, int delay);
		
		/// <summary>
        /// Toggle the selection state of the row at the specified index.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ToggleSelect(int index);
		
		/// <summary>
        /// Select the range specified by the indices.  If augment is true,
        /// then we add the range to the selection without clearing out anything
        /// else.  If augment is false, everything is cleared except for the specified range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RangedSelect(int startIndex, int endIndex, [MarshalAs(UnmanagedType.U1)] bool augment);
		
		/// <summary>
        /// Clears the range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ClearRange(int startIndex, int endIndex);
		
		/// <summary>
        /// Clears the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ClearSelection();
		
		/// <summary>
        /// Inverts the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InvertSelection();
		
		/// <summary>
        /// Selects all rows.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SelectAll();
		
		/// <summary>
        /// Iterate the selection using these methods.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetRangeCount();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetRangeAt(int i, ref int min, ref int max);
		
		/// <summary>
        /// Can be used to invalidate the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InvalidateSelection();
		
		/// <summary>
        /// Called when the row count changes to adjust selection indices.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AdjustSelection(int index, int count);
		
		/// <summary>
        /// This attribute is a boolean indicating whether or not the
        /// "select" event should fire when the selection is changed using
        /// one of our methods.  A view can use this to temporarily suppress
        /// the selection while manipulating all of the indices, e.g., on
        /// a sort.
        /// Note: setting this attribute to false will fire a select event.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetSelectEventsSuppressedAttribute();
		
		/// <summary>
        /// This attribute is a boolean indicating whether or not the
        /// "select" event should fire when the selection is changed using
        /// one of our methods.  A view can use this to temporarily suppress
        /// the selection while manipulating all of the indices, e.g., on
        /// a sort.
        /// Note: setting this attribute to false will fire a select event.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSelectEventsSuppressedAttribute([MarshalAs(UnmanagedType.U1)] bool aSelectEventsSuppressed);
		
		/// <summary>
        /// The current item (the one that gets a focus rect in addition to being
        /// selected).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetCurrentIndexAttribute();
		
		/// <summary>
        /// The current item (the one that gets a focus rect in addition to being
        /// selected).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCurrentIndexAttribute(int aCurrentIndex);
		
		/// <summary>
        /// The current column.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsITreeColumn GetCurrentColumnAttribute();
		
		/// <summary>
        /// The current column.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCurrentColumnAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeColumn aCurrentColumn);
		
		/// <summary>
        /// The selection "pivot".  This is the first item the user selected as
        /// part of a ranged select.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetShiftSelectPivotAttribute();
		
		/// <summary>
        /// The following interface is not scriptable and MUST NEVER BE MADE scriptable.
        /// Native treeselections implement it, and we use this to check whether a
        /// treeselection is native (and therefore suitable for use by untrusted content).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnsureNative();
	}
}
