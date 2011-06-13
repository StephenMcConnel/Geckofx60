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
// Generated by IDLImporter from file nsIPromptService2.idl
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
    /// This is an improved version of nsIPromptService that is less prescriptive
    /// about the resulting user interface.
    ///
    /// @status INCOMPLETE do not freeze before fixing bug 228207
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cf86d196-dbee-4482-9dfa-3477aa128319")]
	public interface nsIPromptService2 : nsIPromptService
	{
		
		/// <summary>
        /// Puts up an alert dialog with an OK button.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Alert([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText);
		
		/// <summary>
        /// Puts up an alert dialog with an OK button and a labeled checkbox.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        /// @param aCheckMsg
        /// Text to appear with the checkbox.
        /// @param aCheckState
        /// Contains the initial checked state of the checkbox when this method
        /// is called and the final checked state after this method returns.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AlertCheck([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref bool aCheckState);
		
		/// <summary>
        /// Puts up a dialog with OK and Cancel buttons.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        ///
        /// @return true for OK, false for Cancel
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Confirm([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText);
		
		/// <summary>
        /// Puts up a dialog with OK and Cancel buttons and a labeled checkbox.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        /// @param aCheckMsg
        /// Text to appear with the checkbox.
        /// @param aCheckState
        /// Contains the initial checked state of the checkbox when this method
        /// is called and the final checked state after this method returns.
        ///
        /// @return true for OK, false for Cancel
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool ConfirmCheck([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref bool aCheckState);
		
		/// <summary>
        /// Puts up a dialog with up to 3 buttons and an optional, labeled checkbox.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        /// @param aButtonFlags
        /// A combination of Button Flags.
        /// @param aButton0Title
        /// Used when button 0 uses TITLE_IS_STRING
        /// @param aButton1Title
        /// Used when button 1 uses TITLE_IS_STRING
        /// @param aButton2Title
        /// Used when button 2 uses TITLE_IS_STRING
        /// @param aCheckMsg
        /// Text to appear with the checkbox.  Null if no checkbox.
        /// @param aCheckState
        /// Contains the initial checked state of the checkbox when this method
        /// is called and the final checked state after this method returns.
        ///
        /// @return index of the button pressed.
        ///
        /// Buttons are numbered 0 - 2. The implementation can decide whether the
        /// sequence goes from right to left or left to right.  Button 0 is the
        /// default button unless one of the Button Default Flags is specified.
        ///
        /// A button may use a predefined title, specified by one of the Button Title
        /// Flags values.  Each title value can be multiplied by a position value to
        /// assign the title to a particular button.  If BUTTON_TITLE_IS_STRING is
        /// used for a button, the string parameter for that button will be used.  If
        /// the value for a button position is zero, the button will not be shown.
        ///
        /// In general, aButtonFlags is constructed per the following example:
        ///
        /// aButtonFlags = (BUTTON_POS_0) * (BUTTON_TITLE_AAA) +
        /// (BUTTON_POS_1) * (BUTTON_TITLE_BBB) +
        /// BUTTON_POS_1_DEFAULT;
        ///
        /// where "AAA" and "BBB" correspond to one of the button titles.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int ConfirmEx([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, uint aButtonFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aButton0Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aButton1Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aButton2Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref bool aCheckState);
		
		/// <summary>
        /// Puts up a dialog with an edit field and an optional, labeled checkbox.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        /// @param aValue
        /// Contains the default value for the dialog field when this method
        /// is called (null value is ok).  Upon return, if the user pressed
        /// OK, then this parameter contains a newly allocated string value.
        /// Otherwise, the parameter's value is unmodified.
        /// @param aCheckMsg
        /// Text to appear with the checkbox.  If null, check box will not be shown.
        /// @param aCheckState
        /// Contains the initial checked state of the checkbox when this method
        /// is called and the final checked state after this method returns.
        ///
        /// @return true for OK, false for Cancel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Prompt([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] ref string aValue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref bool aCheckState);
		
		/// <summary>
        /// Puts up a dialog with an edit field, a password field, and an optional,
        /// labeled checkbox.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        /// @param aUsername
        /// Contains the default value for the username field when this method
        /// is called (null value is ok).  Upon return, if the user pressed OK,
        /// then this parameter contains a newly allocated string value.
        /// Otherwise, the parameter's value is unmodified.
        /// @param aPassword
        /// Contains the default value for the password field when this method
        /// is called (null value is ok).  Upon return, if the user pressed OK,
        /// then this parameter contains a newly allocated string value.
        /// Otherwise, the parameter's value is unmodified.
        /// @param aCheckMsg
        /// Text to appear with the checkbox.  If null, check box will not be shown.
        /// @param aCheckState
        /// Contains the initial checked state of the checkbox when this method
        /// is called and the final checked state after this method returns.
        ///
        /// @return true for OK, false for Cancel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PromptUsernameAndPassword([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] ref string aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] ref string aPassword, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref bool aCheckState);
		
		/// <summary>
        /// Puts up a dialog with a password field and an optional, labeled checkbox.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        /// @param aPassword
        /// Contains the default value for the password field when this method
        /// is called (null value is ok).  Upon return, if the user pressed OK,
        /// then this parameter contains a newly allocated string value.
        /// Otherwise, the parameter's value is unmodified.
        /// @param aCheckMsg
        /// Text to appear with the checkbox.  If null, check box will not be shown.
        /// @param aCheckState
        /// Contains the initial checked state of the checkbox when this method
        /// is called and the final checked state after this method returns.
        ///
        /// @return true for OK, false for Cancel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PromptPassword([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] ref string aPassword, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref bool aCheckState);
		
		/// <summary>
        /// Puts up a dialog box which has a list box of strings from which the user
        /// may make a single selection.
        ///
        /// @param aParent
        /// The parent window or null.
        /// @param aDialogTitle
        /// Text to appear in the title of the dialog.
        /// @param aText
        /// Text to appear in the body of the dialog.
        /// @param aCount
        /// The length of the aSelectList array parameter.
        /// @param aSelectList
        /// The list of strings to display.
        /// @param aOutSelection
        /// Contains the index of the selected item in the list when this
        /// method returns true.
        ///
        /// @return true for OK, false for Cancel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Select([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, uint aCount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=3)] string aSelectList, out int aOutSelection);
		
		/// <summary>
        /// parameters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptAuth([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, uint level, [MarshalAs(UnmanagedType.Interface)] nsIAuthInformation authInfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string checkboxLabel, ref bool checkValue);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICancelable AsyncPromptAuth([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsIAuthPromptCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, uint level, [MarshalAs(UnmanagedType.Interface)] nsIAuthInformation authInfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string checkboxLabel, ref bool checkValue);
	}
}
