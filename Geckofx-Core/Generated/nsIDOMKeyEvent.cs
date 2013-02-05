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
// Generated by IDLImporter from file nsIDOMKeyEvent.idl
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
	[Guid("5d116380-8432-48cb-a717-200f04c39d2f")]
	public interface nsIDOMKeyEvent : nsIDOMUIEvent
	{
		
		/// <summary>
        /// The name of the event (case-insensitive). The name must be an XML
        /// name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// Used to indicate the EventTarget to which the event was originally
        /// dispatched.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTargetAttribute();
		
		/// <summary>
        /// Used to indicate the EventTarget whose EventListeners are currently
        /// being processed. This is particularly useful during capturing and
        /// bubbling.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTargetAttribute();
		
		/// <summary>
        /// Used to indicate which phase of event flow is currently being
        /// evaluated.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhaseAttribute();
		
		/// <summary>
        /// Used to indicate whether or not an event is a bubbling event. If the
        /// event can bubble the value is true, else the value is false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubblesAttribute();
		
		/// <summary>
        /// Used to indicate whether or not an event can have its default action
        /// prevented. If the default action can be prevented the value is true,
        /// else the value is false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelableAttribute();
		
		/// <summary>
        /// Used to specify the time (in milliseconds relative to the epoch) at
        /// which the event was created. Due to the fact that some systems may
        /// not provide this information the value of timeStamp may be not
        /// available for all events. When not available, a value of 0 will be
        /// returned. Examples of epoch time are the time of the system start or
        /// 0:0:0 UTC 1st January 1970.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetTimeStampAttribute();
		
		/// <summary>
        /// The stopPropagation method is used prevent further propagation of an
        /// event during event flow. If this method is called by any
        /// EventListener the event will cease propagating through the tree. The
        /// event will complete dispatch to all listeners on the current
        /// EventTarget before event flow stops. This method may be used during
        /// any stage of event flow.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		/// <summary>
        /// If an event is cancelable, the preventDefault method is used to
        /// signify that the event is to be canceled, meaning any default action
        /// normally taken by the implementation as a result of the event will
        /// not occur. If, during any stage of event flow, the preventDefault
        /// method is called the event is canceled. Any default action associated
        /// with the event will not occur. Calling this method for a
        /// non-cancelable event has no effect. Once preventDefault has been
        /// called it will remain in effect throughout the remainder of the
        /// event's propagation. This method may be used during any stage of
        /// event flow.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		/// <summary>
        /// The initEvent method is used to initialize the value of an Event
        /// created through the DocumentEvent interface. This method may only be
        /// called before the Event has been dispatched via the dispatchEvent
        /// method, though it may be called multiple times during that phase if
        /// necessary. If called multiple times the final invocation takes
        /// precedence. If called from a subclass of Event interface only the
        /// values specified in the initEvent method are modified, all other
        /// attributes are left unchanged.
        ///
        /// @param   eventTypeArg Specifies the event type. This type may be
        /// any event type currently defined in this
        /// specification or a new event type.. The string
        /// must be an XML name.
        /// Any new event type must not begin with any
        /// upper, lower, or mixed case version of the
        /// string "DOM". This prefix is reserved for
        /// future DOM event sets. It is also strongly
        /// recommended that third parties adding their
        /// own events use their own prefix to avoid
        /// confusion and lessen the probability of
        /// conflicts with other new events.
        /// @param   canBubbleArg Specifies whether or not the event can bubble.
        /// @param   cancelableArg Specifies whether or not the event's default
        /// action can be prevented.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase eventTypeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg);
		
		/// <summary>
        /// Used to indicate whether preventDefault() has been called for this event.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetDefaultPreventedAttribute();
		
		/// <summary>
        /// Prevents other event listeners from being triggered and,
        /// unlike Event.stopPropagation() its effect is immediate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopImmediatePropagation();
		
		/// <summary>
        ///The original target of the event, before any retargetings. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetOriginalTargetAttribute();
		
		/// <summary>
        /// The explicit original target of the event.  If the event was retargeted
        /// for some reason other than an anonymous boundary crossing, this will be set
        /// to the target before the retargeting occurs.  For example, mouse events
        /// are retargeted to their parent node when they happen over text nodes (bug
        /// 185889), and in that case .target will show the parent and
        /// .explicitOriginalTarget will show the text node.
        /// .explicitOriginalTarget differs from .originalTarget in that it will never
        /// contain anonymous content.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetExplicitOriginalTargetAttribute();
		
		/// <summary>
        /// @deprecated Use nsIDOMEvent::stopPropagation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventBubble();
		
		/// <summary>
        /// @deprecated Use nsIDOMEvent::stopPropagation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventCapture();
		
		/// <summary>
        /// @deprecated Use nsIDOMEvent::defaultPrevented.
        /// To be removed in bug 691151.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetPreventDefault();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsTrustedAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void DuplicatePrivateData();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTarget([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aTarget);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDispatchStopped();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetInternalNSEvent();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTrusted([MarshalAs(UnmanagedType.U1)] bool aTrusted);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Serialize(System.IntPtr aMsg, [MarshalAs(UnmanagedType.U1)] bool aSerializeInterfaceType);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Deserialize(System.IntPtr aMsg, ref System.IntPtr aIter);
		
		/// <summary>
        /// The nsIDOMUIEvent interface is the datatype for all UI events in the
        /// Document Object Model.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Events/
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetViewAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetDetailAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitUIEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, int detailArg);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetLayerXAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetLayerYAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetPageXAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetPageYAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetWhichAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetRangeParentAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetRangeOffsetAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelBubbleAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCancelBubbleAttribute([MarshalAs(UnmanagedType.U1)] bool aCancelBubble);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsCharAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCharCodeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetKeyCodeAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAltKeyAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCtrlKeyAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShiftKeyAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMetaKeyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitKeyEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow viewArg, [MarshalAs(UnmanagedType.U1)] bool ctrlKeyArg, [MarshalAs(UnmanagedType.U1)] bool altKeyArg, [MarshalAs(UnmanagedType.U1)] bool shiftKeyArg, [MarshalAs(UnmanagedType.U1)] bool metaKeyArg, uint keyCodeArg, uint charCodeArg);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetModifierState([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase keyArg);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLocationAttribute();
	}
	
	/// <summary>nsIDOMKeyEventConsts </summary>
	public class nsIDOMKeyEventConsts
	{
		
		// <summary>
        //This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const ulong DOM_VK_CANCEL = 0x03;
		
		// 
		public const ulong DOM_VK_HELP = 0x06;
		
		// 
		public const ulong DOM_VK_BACK_SPACE = 0x08;
		
		// 
		public const ulong DOM_VK_TAB = 0x09;
		
		// 
		public const ulong DOM_VK_CLEAR = 0x0C;
		
		// 
		public const ulong DOM_VK_RETURN = 0x0D;
		
		// 
		public const ulong DOM_VK_ENTER = 0x0E;
		
		// 
		public const ulong DOM_VK_SHIFT = 0x10;
		
		// 
		public const ulong DOM_VK_CONTROL = 0x11;
		
		// 
		public const ulong DOM_VK_ALT = 0x12;
		
		// 
		public const ulong DOM_VK_PAUSE = 0x13;
		
		// 
		public const ulong DOM_VK_CAPS_LOCK = 0x14;
		
		// 
		public const ulong DOM_VK_KANA = 0x15;
		
		// 
		public const ulong DOM_VK_HANGUL = 0x15;
		
		// 
		public const ulong DOM_VK_EISU = 0x16;
		
		// <summary>
        // Japanese Mac keyboard only
        // </summary>
		public const ulong DOM_VK_JUNJA = 0x17;
		
		// 
		public const ulong DOM_VK_FINAL = 0x18;
		
		// 
		public const ulong DOM_VK_HANJA = 0x19;
		
		// 
		public const ulong DOM_VK_KANJI = 0x19;
		
		// 
		public const ulong DOM_VK_ESCAPE = 0x1B;
		
		// 
		public const ulong DOM_VK_CONVERT = 0x1C;
		
		// 
		public const ulong DOM_VK_NONCONVERT = 0x1D;
		
		// 
		public const ulong DOM_VK_ACCEPT = 0x1E;
		
		// 
		public const ulong DOM_VK_MODECHANGE = 0x1F;
		
		// 
		public const ulong DOM_VK_SPACE = 0x20;
		
		// 
		public const ulong DOM_VK_PAGE_UP = 0x21;
		
		// 
		public const ulong DOM_VK_PAGE_DOWN = 0x22;
		
		// 
		public const ulong DOM_VK_END = 0x23;
		
		// 
		public const ulong DOM_VK_HOME = 0x24;
		
		// 
		public const ulong DOM_VK_LEFT = 0x25;
		
		// 
		public const ulong DOM_VK_UP = 0x26;
		
		// 
		public const ulong DOM_VK_RIGHT = 0x27;
		
		// 
		public const ulong DOM_VK_DOWN = 0x28;
		
		// 
		public const ulong DOM_VK_SELECT = 0x29;
		
		// 
		public const ulong DOM_VK_PRINT = 0x2A;
		
		// 
		public const ulong DOM_VK_EXECUTE = 0x2B;
		
		// 
		public const ulong DOM_VK_PRINTSCREEN = 0x2C;
		
		// 
		public const ulong DOM_VK_INSERT = 0x2D;
		
		// 
		public const ulong DOM_VK_DELETE = 0x2E;
		
		// <summary>
        // DOM_VK_0 - DOM_VK_9 match their ascii values
        // </summary>
		public const ulong DOM_VK_0 = 0x30;
		
		// 
		public const ulong DOM_VK_1 = 0x31;
		
		// 
		public const ulong DOM_VK_2 = 0x32;
		
		// 
		public const ulong DOM_VK_3 = 0x33;
		
		// 
		public const ulong DOM_VK_4 = 0x34;
		
		// 
		public const ulong DOM_VK_5 = 0x35;
		
		// 
		public const ulong DOM_VK_6 = 0x36;
		
		// 
		public const ulong DOM_VK_7 = 0x37;
		
		// 
		public const ulong DOM_VK_8 = 0x38;
		
		// 
		public const ulong DOM_VK_9 = 0x39;
		
		// 
		public const ulong DOM_VK_COLON = 0x3A;
		
		// 
		public const ulong DOM_VK_SEMICOLON = 0x3B;
		
		// 
		public const ulong DOM_VK_LESS_THAN = 0x3C;
		
		// 
		public const ulong DOM_VK_EQUALS = 0x3D;
		
		// 
		public const ulong DOM_VK_GREATER_THAN = 0x3E;
		
		// 
		public const ulong DOM_VK_QUESTION_MARK = 0x3F;
		
		// 
		public const ulong DOM_VK_AT = 0x40;
		
		// <summary>
        // DOM_VK_A - DOM_VK_Z match their ascii values
        // </summary>
		public const ulong DOM_VK_A = 0x41;
		
		// 
		public const ulong DOM_VK_B = 0x42;
		
		// 
		public const ulong DOM_VK_C = 0x43;
		
		// 
		public const ulong DOM_VK_D = 0x44;
		
		// 
		public const ulong DOM_VK_E = 0x45;
		
		// 
		public const ulong DOM_VK_F = 0x46;
		
		// 
		public const ulong DOM_VK_G = 0x47;
		
		// 
		public const ulong DOM_VK_H = 0x48;
		
		// 
		public const ulong DOM_VK_I = 0x49;
		
		// 
		public const ulong DOM_VK_J = 0x4A;
		
		// 
		public const ulong DOM_VK_K = 0x4B;
		
		// 
		public const ulong DOM_VK_L = 0x4C;
		
		// 
		public const ulong DOM_VK_M = 0x4D;
		
		// 
		public const ulong DOM_VK_N = 0x4E;
		
		// 
		public const ulong DOM_VK_O = 0x4F;
		
		// 
		public const ulong DOM_VK_P = 0x50;
		
		// 
		public const ulong DOM_VK_Q = 0x51;
		
		// 
		public const ulong DOM_VK_R = 0x52;
		
		// 
		public const ulong DOM_VK_S = 0x53;
		
		// 
		public const ulong DOM_VK_T = 0x54;
		
		// 
		public const ulong DOM_VK_U = 0x55;
		
		// 
		public const ulong DOM_VK_V = 0x56;
		
		// 
		public const ulong DOM_VK_W = 0x57;
		
		// 
		public const ulong DOM_VK_X = 0x58;
		
		// 
		public const ulong DOM_VK_Y = 0x59;
		
		// 
		public const ulong DOM_VK_Z = 0x5A;
		
		// 
		public const ulong DOM_VK_WIN = 0x5B;
		
		// 
		public const ulong DOM_VK_CONTEXT_MENU = 0x5D;
		
		// 
		public const ulong DOM_VK_SLEEP = 0x5F;
		
		// <summary>
        // Numpad keys
        // </summary>
		public const ulong DOM_VK_NUMPAD0 = 0x60;
		
		// 
		public const ulong DOM_VK_NUMPAD1 = 0x61;
		
		// 
		public const ulong DOM_VK_NUMPAD2 = 0x62;
		
		// 
		public const ulong DOM_VK_NUMPAD3 = 0x63;
		
		// 
		public const ulong DOM_VK_NUMPAD4 = 0x64;
		
		// 
		public const ulong DOM_VK_NUMPAD5 = 0x65;
		
		// 
		public const ulong DOM_VK_NUMPAD6 = 0x66;
		
		// 
		public const ulong DOM_VK_NUMPAD7 = 0x67;
		
		// 
		public const ulong DOM_VK_NUMPAD8 = 0x68;
		
		// 
		public const ulong DOM_VK_NUMPAD9 = 0x69;
		
		// 
		public const ulong DOM_VK_MULTIPLY = 0x6A;
		
		// 
		public const ulong DOM_VK_ADD = 0x6B;
		
		// 
		public const ulong DOM_VK_SEPARATOR = 0x6C;
		
		// 
		public const ulong DOM_VK_SUBTRACT = 0x6D;
		
		// 
		public const ulong DOM_VK_DECIMAL = 0x6E;
		
		// 
		public const ulong DOM_VK_DIVIDE = 0x6F;
		
		// 
		public const ulong DOM_VK_F1 = 0x70;
		
		// 
		public const ulong DOM_VK_F2 = 0x71;
		
		// 
		public const ulong DOM_VK_F3 = 0x72;
		
		// 
		public const ulong DOM_VK_F4 = 0x73;
		
		// 
		public const ulong DOM_VK_F5 = 0x74;
		
		// 
		public const ulong DOM_VK_F6 = 0x75;
		
		// 
		public const ulong DOM_VK_F7 = 0x76;
		
		// 
		public const ulong DOM_VK_F8 = 0x77;
		
		// 
		public const ulong DOM_VK_F9 = 0x78;
		
		// 
		public const ulong DOM_VK_F10 = 0x79;
		
		// 
		public const ulong DOM_VK_F11 = 0x7A;
		
		// 
		public const ulong DOM_VK_F12 = 0x7B;
		
		// 
		public const ulong DOM_VK_F13 = 0x7C;
		
		// 
		public const ulong DOM_VK_F14 = 0x7D;
		
		// 
		public const ulong DOM_VK_F15 = 0x7E;
		
		// 
		public const ulong DOM_VK_F16 = 0x7F;
		
		// 
		public const ulong DOM_VK_F17 = 0x80;
		
		// 
		public const ulong DOM_VK_F18 = 0x81;
		
		// 
		public const ulong DOM_VK_F19 = 0x82;
		
		// 
		public const ulong DOM_VK_F20 = 0x83;
		
		// 
		public const ulong DOM_VK_F21 = 0x84;
		
		// 
		public const ulong DOM_VK_F22 = 0x85;
		
		// 
		public const ulong DOM_VK_F23 = 0x86;
		
		// 
		public const ulong DOM_VK_F24 = 0x87;
		
		// 
		public const ulong DOM_VK_NUM_LOCK = 0x90;
		
		// 
		public const ulong DOM_VK_SCROLL_LOCK = 0x91;
		
		// 
		public const ulong DOM_VK_CIRCUMFLEX = 0xA0;
		
		// 
		public const ulong DOM_VK_EXCLAMATION = 0xA1;
		
		// 
		public const ulong DOM_VK_DOUBLE_QUOTE = 0xA2;
		
		// 
		public const ulong DOM_VK_HASH = 0xA3;
		
		// 
		public const ulong DOM_VK_DOLLAR = 0xA4;
		
		// 
		public const ulong DOM_VK_PERCENT = 0xA5;
		
		// 
		public const ulong DOM_VK_AMPERSAND = 0xA6;
		
		// 
		public const ulong DOM_VK_UNDERSCORE = 0xA7;
		
		// 
		public const ulong DOM_VK_OPEN_PAREN = 0xA8;
		
		// 
		public const ulong DOM_VK_CLOSE_PAREN = 0xA9;
		
		// 
		public const ulong DOM_VK_ASTERISK = 0xAA;
		
		// 
		public const ulong DOM_VK_PLUS = 0xAB;
		
		// 
		public const ulong DOM_VK_PIPE = 0xAC;
		
		// 
		public const ulong DOM_VK_HYPHEN_MINUS = 0xAD;
		
		// 
		public const ulong DOM_VK_OPEN_CURLY_BRACKET = 0xAE;
		
		// 
		public const ulong DOM_VK_CLOSE_CURLY_BRACKET = 0xAF;
		
		// 
		public const ulong DOM_VK_TILDE = 0xB0;
		
		// 
		public const ulong DOM_VK_COMMA = 0xBC;
		
		// 
		public const ulong DOM_VK_PERIOD = 0xBE;
		
		// 
		public const ulong DOM_VK_SLASH = 0xBF;
		
		// 
		public const ulong DOM_VK_BACK_QUOTE = 0xC0;
		
		// 
		public const ulong DOM_VK_OPEN_BRACKET = 0xDB;
		
		// <summary>
        // square bracket
        // </summary>
		public const ulong DOM_VK_BACK_SLASH = 0xDC;
		
		// 
		public const ulong DOM_VK_CLOSE_BRACKET = 0xDD;
		
		// <summary>
        // square bracket
        // </summary>
		public const ulong DOM_VK_QUOTE = 0xDE;
		
		// <summary>
        // Apostrophe
        // </summary>
		public const ulong DOM_VK_META = 0xE0;
		
		// 
		public const ulong DOM_VK_ALTGR = 0xE1;
		
		// 
		public const ulong DOM_KEY_LOCATION_STANDARD = 0x00;
		
		// 
		public const ulong DOM_KEY_LOCATION_LEFT = 0x01;
		
		// 
		public const ulong DOM_KEY_LOCATION_RIGHT = 0x02;
		
		// 
		public const ulong DOM_KEY_LOCATION_NUMPAD = 0x03;
		
		// 
		public const ulong DOM_KEY_LOCATION_MOBILE = 0x04;
		
		// 
		public const ulong DOM_KEY_LOCATION_JOYSTICK = 0x05;
	}
}
