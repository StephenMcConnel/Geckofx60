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
// Generated by IDLImporter from file nsITextInputProcessorCallback.idl
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
    /// nsITextInputProcessorNotification stores the type of notification to IME and
    /// its detail.  See each explanation of attribute for the detail.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c0ce1add-82bb-45ab-b99a-42cfba7fd5d7")]
	public interface nsITextInputProcessorNotification
	{
		
		/// <summary>
        /// type attribute represents what's notified or requested.  Value must be
        /// one of following values:
        ///
        /// "request-to-commit"  (required to be handled)
        /// This is requested when Gecko believes that active composition should be
        /// committed.  nsITextInputProcessorCallback::onNotify() has to handle this
        /// notification.
        ///
        /// "request-to-cancel" (required to be handled)
        /// This is requested when Gecko believes that active composition should be
        /// canceled.  I.e., composition should be committed with empty string.
        /// nsITextInputProcessorCallback::onNotify() has to handle this
        /// notification.
        ///
        /// "notify-end-input-transaction" (optional)
        /// This is notified when the callback is detached from
        /// nsITextInputProcessor.  I.e., the TextInputProcessor lost the rights
        /// to input text and needs to call .beginInputTransaction() before next
        /// input.
        ///
        /// "notify-focus" (optional)
        /// This is notified when an editable editor gets focus and Gecko starts
        /// to observe changes in the content. E.g., selection changes.
        /// IME shouldn't change DOM tree, focus nor something when this is notified.
        ///
        /// "notify-blur" (optional)
        /// This is notified when an editable editor loses focus and Gecko stops
        /// observing the changes in the content.
        ///
        /// "notify-text-change" (optional)
        /// This is notified when text in the focused editor is modified.
        /// Some attributes below are available to retrieve the detail.
        /// IME shouldn't change DOM tree, focus nor something when this is notified.
        /// Note that when there is no chance to notify you of some text changes
        /// safely, this represents all changes as a change.
        ///
        /// "notify-selection-change" (optional)
        /// This is notified when selection in the focused editor is changed.
        /// Some attributes below are available to retrieve the detail.
        /// IME shouldn't change DOM tree, focus nor something when this is notified.
        /// Note that when there was no chance to notify you of this safely, this
        /// represents the latest selection change.
        ///
        /// "notify-position-change" (optional)
        /// This is notified when layout is changed in the editor or the window
        /// is moved.
        /// IME shouldn't change DOM tree, focus nor something when this is notified.
        /// Note that when there was no chance to notify you of this safely, this
        /// represents the latest layout change.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-text-change" or
        /// "notify-selection-change".
        /// This is offset of the start of modified text range if type is
        /// "notify-text-change".  Or offset of start of selection if type is
        /// "notify-selection-change".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetOffsetAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-selection-change".
        /// This is selected text.  I.e., the length is selected length and
        /// it's empty if the selection is collapsed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText);
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-selection-change".
        /// This is set to true when the selection is collapsed.  Otherwise, false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCollapsedAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-selection-change".
        /// This is selected length.  I.e., if this is 0, collapsed is set to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLengthAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-selection-change".
        /// When selection is created from latter point to former point, this is
        /// set to true.  Otherwise, false.
        /// I.e., if this is true, offset + length is the anchor of selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReversedAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-selection-change".
        /// This indicates the start of the selection's writing mode.
        /// The value can be "horizontal-tb", "vertical-rl" or "vertical-lr".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWritingModeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aWritingMode);
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-selection-change".
        /// If the selection change was caused by composition, this is set to true.
        /// Otherwise, false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCausedByCompositionAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-selection-change".
        /// If the selection change was caused by selection event, this is set to true.
        /// Otherwise, false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCausedBySelectionEventAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-selection-change".
        /// If the selection change occurred during composition, this is set to true.
        /// Otherwise, false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOccurredDuringCompositionAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-text-change".
        /// This is removed text length by the change(s).  If this is empty, new text
        /// was just inserted.  Otherwise, the text is replaced with new text.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRemovedLengthAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-text-change".
        /// This is added text length by the change(s).  If this is empty, old text
        /// was just deleted.  Otherwise, the text replaces the old text.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAddedLengthAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-text-change".
        /// If the text change(s) was caused only by composition, this is set to true.
        /// Otherwise, false.  I.e., if one of text changes are caused by JS or
        /// modifying without composition, this is set to false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCausedOnlyByCompositionAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-text-change".
        /// If at least one text change not caused by composition occurred during
        /// composition, this is set to true.  Otherwise, false.
        /// Note that this is set to false when new change is caused by neither
        /// composition nor occurred during composition because it's outdated for
        /// new composition.
        /// In other words, when text changes not caused by composition occurred
        /// during composition and it may cause committing composition, this is
        /// set to true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIncludingChangesDuringCompositionAttribute();
		
		/// <summary>
        /// This attribute has a valid value when type is "notify-text-change".
        /// If at least one text change occurred when there was no composition, this
        /// is set to true.  Otherwise, false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIncludingChangesWithoutCompositionAttribute();
	}
	
	/// <summary>
    /// nsITextInputProcessorCallback is a callback interface for JS to implement
    /// IME.  IME implemented by JS can implement onNotify() function and must send
    /// it to nsITextInputProcessor at initializing.  Then, onNotify() will be
    /// called with nsITextInputProcessorNotification instance.
    /// The reason why onNotify() uses string simply is that if we will support
    /// other notifications such as text changes and selection changes, we need to
    /// notify IME of some other information.  Then, only changing
    /// nsITextInputProcessorNotification interface is better for compatibility.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("23d5f242-adb5-46f1-8766-90d1bf0383df")]
	public interface nsITextInputProcessorCallback
	{
		
		/// <summary>
        /// When Gecko notifies IME of something or requests something to IME,
        /// this is called.
        ///
        /// @param aTextInputProcessor Reference to the nsITextInputProcessor service
        /// which is the original receiver of the request
        /// or notification.
        /// @param aNotification       Stores type of notifications and additional
        /// information.
        /// @return                    Return true if it succeeded or does nothing.
        /// Otherwise, return false.
        ///
        /// Example #1 The simplest implementation of nsITextInputProcessorCallback is:
        ///
        /// function simpleCallback(aTIP, aNotification)
        /// {
        /// try {
        /// switch (aNotification.type) {
        /// case "request-to-commit":
        /// aTIP.commitComposition();
        /// break;
        /// case "request-to-cancel":
        /// aTIP.cancelComposition();
        /// break;
        /// }
        /// } catch (e) {
        /// return false;
        /// }
        /// return true;
        /// }
        ///
        /// var TIP = Components.classes["@mozilla.org/text-input-processor;1"].
        /// createInstance(Components.interfaces.nsITextInputProcessor);
        /// if (!TIP.init(window, simpleCallback)) {
        /// return;
        /// }
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnNotify([MarshalAs(UnmanagedType.Interface)] nsITextInputProcessor aTextInputProcessor, [MarshalAs(UnmanagedType.Interface)] nsITextInputProcessorNotification aNotification);
	}
}
