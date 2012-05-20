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
// Generated by IDLImporter from file nsIPrompt.idl
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
    /// This is the prompt interface which can be used without knowlege of a
    /// parent window. The parentage is hidden by the GetInterface though
    /// which it is gotten. This interface is identical to nsIPromptService
    /// but without the parent nsIDOMWindow parameter. See nsIPromptService
    /// for all documentation.
    ///
    /// Accesskeys can be attached to buttons and checkboxes by inserting
    /// an & before the accesskey character. For a real &, use && instead.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a63f70c0-148b-11d3-9333-00104ba0fd40")]
	public interface nsIPrompt
	{
		
		/// <summary>
        /// This is the prompt interface which can be used without knowlege of a
        /// parent window. The parentage is hidden by the GetInterface though
        /// which it is gotten. This interface is identical to nsIPromptService
        /// but without the parent nsIDOMWindow parameter. See nsIPromptService
        /// for all documentation.
        ///
        /// Accesskeys can be attached to buttons and checkboxes by inserting
        /// an & before the accesskey character. For a real &, use && instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Alert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AlertCheck([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string checkMsg, [MarshalAs(UnmanagedType.U1)] ref bool checkValue);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Confirm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmCheck([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string checkMsg, [MarshalAs(UnmanagedType.U1)] ref bool checkValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int ConfirmEx([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, uint buttonFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string button0Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string button1Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string button2Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string checkMsg, [MarshalAs(UnmanagedType.U1)] ref bool checkValue);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Prompt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] ref string value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string checkMsg, [MarshalAs(UnmanagedType.U1)] ref bool checkValue);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptPassword([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] ref string password, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string checkMsg, [MarshalAs(UnmanagedType.U1)] ref bool checkValue);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptUsernameAndPassword([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] ref string username, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] ref string password, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string checkMsg, [MarshalAs(UnmanagedType.U1)] ref bool checkValue);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Select([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string dialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] System.IntPtr[] selectList, ref int outSelection);
	}
	
	/// <summary>nsIPromptConsts </summary>
	public class nsIPromptConsts
	{
		
		// 
		public const ulong BUTTON_POS_0 = 1;
		
		// 
		public const ulong BUTTON_POS_1 = 1<<8;
		
		// 
		public const ulong BUTTON_POS_2 = 1<<16;
		
		// 
		public const ulong BUTTON_TITLE_OK = 1;
		
		// 
		public const ulong BUTTON_TITLE_CANCEL = 2;
		
		// 
		public const ulong BUTTON_TITLE_YES = 3;
		
		// 
		public const ulong BUTTON_TITLE_NO = 4;
		
		// 
		public const ulong BUTTON_TITLE_SAVE = 5;
		
		// 
		public const ulong BUTTON_TITLE_DONT_SAVE = 6;
		
		// 
		public const ulong BUTTON_TITLE_REVERT = 7;
		
		// 
		public const ulong BUTTON_TITLE_IS_STRING = 127;
		
		// 
		public const ulong BUTTON_POS_0_DEFAULT = 0<<24;
		
		// 
		public const ulong BUTTON_POS_1_DEFAULT = 1<<24;
		
		// 
		public const ulong BUTTON_POS_2_DEFAULT = 2<<24;
		
		// <summary>
        //used for security dialogs, buttons are initially disabled </summary>
		public const ulong BUTTON_DELAY_ENABLE = 1<<26;
		
		// 
		public const ulong STD_OK_CANCEL_BUTTONS = (BUTTON_TITLE_OK*BUTTON_POS_0)+(BUTTON_TITLE_CANCEL*BUTTON_POS_1);
		
		// 
		public const ulong STD_YES_NO_BUTTONS = (BUTTON_TITLE_YES*BUTTON_POS_0)+(BUTTON_TITLE_NO*BUTTON_POS_1);
	}
}
