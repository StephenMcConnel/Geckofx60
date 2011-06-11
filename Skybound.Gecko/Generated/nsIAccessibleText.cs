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
// Generated by IDLImporter from file nsIAccessibleText.idl
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
	
	
	/// <summary>nsIAccessibleText </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0f4633b1-550c-4b50-8c04-0eb1005eef2f")]
	public interface nsIAccessibleText
	{
		
		/// <summary>
        /// The current current caret offset.
        /// If set < 0 then caret will be placed  at the end of the text
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetCaretOffsetAttribute();
		
		/// <summary>
        /// The current current caret offset.
        /// If set < 0 then caret will be placed  at the end of the text
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaretOffsetAttribute(System.Int32  aCaretOffset);
		
		/// <summary>Member GetCharacterCountAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetCharacterCountAttribute();
		
		/// <summary>Member GetSelectionCountAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSelectionCountAttribute();
		
		/// <summary>
        /// String methods may need to return multibyte-encoded strings,
        /// since some locales can't be encoded using 16-bit chars.
        /// So the methods below might return UTF-16 strings, or they could
        /// return "string" values which are UTF-8.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetText(System.Int32  startOffset, System.Int32  endOffset);
		
		/// <summary>Member GetTextAfterOffset </summary>
		/// <param name='offset'> </param>
		/// <param name='boundaryType'> </param>
		/// <param name='startOffset'> </param>
		/// <param name='endOffset'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetTextAfterOffset(System.Int32  offset, System.IntPtr boundaryType, out System.Int32  startOffset, out System.Int32  endOffset);
		
		/// <summary>Member GetTextAtOffset </summary>
		/// <param name='offset'> </param>
		/// <param name='boundaryType'> </param>
		/// <param name='startOffset'> </param>
		/// <param name='endOffset'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetTextAtOffset(System.Int32  offset, System.IntPtr boundaryType, out System.Int32  startOffset, out System.Int32  endOffset);
		
		/// <summary>Member GetTextBeforeOffset </summary>
		/// <param name='offset'> </param>
		/// <param name='boundaryType'> </param>
		/// <param name='startOffset'> </param>
		/// <param name='endOffset'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetTextBeforeOffset(System.Int32  offset, System.IntPtr boundaryType, out System.Int32  startOffset, out System.Int32  endOffset);
		
		/// <summary>
        /// It would be better to return an unsigned long here,
        /// to allow unicode chars > 16 bits
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		char GetCharacterAtOffset(System.Int32  offset);
		
		/// <summary>
        /// Get the accessible start/end offsets around the given offset,
        /// return the text attributes for this range of text.
        ///
        /// @param  includeDefAttrs   [in] points whether text attributes applied to
        /// the entire accessible should be included or not.
        /// @param  offset            [in] text offset
        /// @param  rangeStartOffset  [out] start offset of the range of text
        /// @param  rangeEndOffset    [out] end offset of the range of text
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPersistentProperties GetTextAttributes(System.Boolean  includeDefAttrs, System.Int32  offset, out System.Int32  rangeStartOffset, out System.Int32  rangeEndOffset);
		
		/// <summary>
        /// Return the text attributes that apply to the entire accessible.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPersistentProperties  GetDefaultTextAttributesAttribute();
		
		/// <summary>
        /// Returns the bounding box of the specified position.
        ///
        /// The virtual character after the last character of the represented text,
        /// i.e. the one at position length is a special case. It represents the
        /// current input position and will therefore typically be queried by AT more
        /// often than other positions. Because it does not represent an existing
        /// character its bounding box is defined in relation to preceding characters.
        /// It should be roughly equivalent to the bounding box of some character when
        /// inserted at the end of the text. Its height typically being the maximal
        /// height of all the characters in the text or the height of the preceding
        /// character, its width being at least one pixel so that the bounding box is
        /// not degenerate.
        ///
        /// @param offset - Index of the character for which to return its bounding
        /// box. The valid range is 0..length.
        /// @param x - X coordinate of the bounding box of the referenced character.
        /// @param y - Y coordinate of the bounding box of the referenced character.
        /// @param width - Width of the bounding box of the referenced character.
        /// @param height - Height of the bounding box of the referenced character.
        /// @param coordType - Specifies if the coordinates are relative to the screen
        /// or to the parent window (see constants declared in
        /// nsIAccessibleCoordinateType).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharacterExtents(System.Int32  offset, out System.Int32  x, out System.Int32  y, out System.Int32  width, out System.Int32  height, System.UInt32  coordType);
		
		/// <summary>Member GetRangeExtents </summary>
		/// <param name='startOffset'> </param>
		/// <param name='endOffset'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		/// <param name='coordType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRangeExtents(System.Int32  startOffset, System.Int32  endOffset, out System.Int32  x, out System.Int32  y, out System.Int32  width, out System.Int32  height, System.UInt32  coordType);
		
		/// <summary>
        /// Get the text offset at the given point, or return -1
        /// if no character exists at that point
        ///
        /// @param x - The position's x value for which to look up the index of the
        /// character that is rendered on to the display at that point.
        /// @param y - The position's y value for which to look up the index of the
        /// character that is rendered on to the display at that point.
        /// @param coordType - Screen coordinates or window coordinates (see constants
        /// declared in nsIAccessibleCoordinateType).
        /// @return offset - Index of the character under the given point or -1 if
        /// the point is invalid or there is no character under
        /// the point.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetAtPoint(System.Int32  x, System.Int32  y, System.UInt32  coordType);
		
		/// <summary>Member GetSelectionBounds </summary>
		/// <param name='selectionNum'> </param>
		/// <param name='startOffset'> </param>
		/// <param name='endOffset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSelectionBounds(System.Int32  selectionNum, out System.Int32  startOffset, out System.Int32  endOffset);
		
		/// <summary>
        /// Set the bounds for the given selection range
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionBounds(System.Int32  selectionNum, System.Int32  startOffset, System.Int32  endOffset);
		
		/// <summary>Member AddSelection </summary>
		/// <param name='startOffset'> </param>
		/// <param name='endOffset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSelection(System.Int32  startOffset, System.Int32  endOffset);
		
		/// <summary>Member RemoveSelection </summary>
		/// <param name='selectionNum'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveSelection(System.Int32  selectionNum);
		
		/// <summary>
        /// Makes a specific part of string visible on screen.
        ///
        /// @param startIndex  0-based character offset
        /// @param endIndex    0-based character offset - the offset of the
        /// character just past the last character of the
        /// string
        /// @param scrollType  defines how to scroll (see nsIAccessibleScrollType for
        /// available constants)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollSubstringTo(System.Int32  startIndex, System.Int32  endIndex, System.UInt32  scrollType);
		
		/// <summary>
        /// Moves the top left of a substring to a specified location.
        ///
        /// @param startIndex      0-based character offset
        /// @param endIndex        0-based character offset - the offset of the
        /// character just past the last character of
        /// the string
        /// @param coordinateType  specifies the coordinates origin (for available
        /// constants refer to nsIAccessibleCoordinateType)
        /// @param x               defines the x coordinate
        /// @param y               defines the y coordinate
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollSubstringToPoint(System.Int32  startIndex, System.Int32  endIndex, System.UInt32  coordinateType, System.Int32  x, System.Int32  y);
	}
}
