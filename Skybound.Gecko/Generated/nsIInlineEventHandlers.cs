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
// Generated by IDLImporter from file nsIInlineEventHandlers.idl
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
	
	
	/// <summary>nsIInlineEventHandlers </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5b3f9656-9d81-40e4-85ba-01f302177815")]
	public interface nsIInlineEventHandlers
	{
		
		/// <summary>Member GetOnabortAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnabortAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnabortAttribute </summary>
		/// <param name='aOnabort'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnabortAttribute(Gecko.JsVal aOnabort, System.IntPtr jsContext);
		
		/// <summary>Member GetOnblurAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnblurAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnblurAttribute </summary>
		/// <param name='aOnblur'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnblurAttribute(Gecko.JsVal aOnblur, System.IntPtr jsContext);
		
		/// <summary>Member GetOncanplayAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncanplayAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOncanplayAttribute </summary>
		/// <param name='aOncanplay'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncanplayAttribute(Gecko.JsVal aOncanplay, System.IntPtr jsContext);
		
		/// <summary>Member GetOncanplaythroughAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncanplaythroughAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOncanplaythroughAttribute </summary>
		/// <param name='aOncanplaythrough'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncanplaythroughAttribute(Gecko.JsVal aOncanplaythrough, System.IntPtr jsContext);
		
		/// <summary>Member GetOnchangeAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnchangeAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnchangeAttribute </summary>
		/// <param name='aOnchange'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnchangeAttribute(Gecko.JsVal aOnchange, System.IntPtr jsContext);
		
		/// <summary>Member GetOnclickAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnclickAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnclickAttribute </summary>
		/// <param name='aOnclick'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnclickAttribute(Gecko.JsVal aOnclick, System.IntPtr jsContext);
		
		/// <summary>Member GetOncontextmenuAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncontextmenuAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOncontextmenuAttribute </summary>
		/// <param name='aOncontextmenu'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncontextmenuAttribute(Gecko.JsVal aOncontextmenu, System.IntPtr jsContext);
		
		/// <summary>
        /// [implicit_jscontext] attribute jsval oncuechange;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndblclickAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// [implicit_jscontext] attribute jsval oncuechange;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndblclickAttribute(Gecko.JsVal aOndblclick, System.IntPtr jsContext);
		
		/// <summary>Member GetOndragAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOndragAttribute </summary>
		/// <param name='aOndrag'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragAttribute(Gecko.JsVal aOndrag, System.IntPtr jsContext);
		
		/// <summary>Member GetOndragendAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragendAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOndragendAttribute </summary>
		/// <param name='aOndragend'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragendAttribute(Gecko.JsVal aOndragend, System.IntPtr jsContext);
		
		/// <summary>Member GetOndragenterAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragenterAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOndragenterAttribute </summary>
		/// <param name='aOndragenter'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragenterAttribute(Gecko.JsVal aOndragenter, System.IntPtr jsContext);
		
		/// <summary>Member GetOndragleaveAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragleaveAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOndragleaveAttribute </summary>
		/// <param name='aOndragleave'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragleaveAttribute(Gecko.JsVal aOndragleave, System.IntPtr jsContext);
		
		/// <summary>Member GetOndragoverAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragoverAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOndragoverAttribute </summary>
		/// <param name='aOndragover'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragoverAttribute(Gecko.JsVal aOndragover, System.IntPtr jsContext);
		
		/// <summary>Member GetOndragstartAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragstartAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOndragstartAttribute </summary>
		/// <param name='aOndragstart'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragstartAttribute(Gecko.JsVal aOndragstart, System.IntPtr jsContext);
		
		/// <summary>Member GetOndropAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndropAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOndropAttribute </summary>
		/// <param name='aOndrop'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndropAttribute(Gecko.JsVal aOndrop, System.IntPtr jsContext);
		
		/// <summary>Member GetOndurationchangeAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndurationchangeAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOndurationchangeAttribute </summary>
		/// <param name='aOndurationchange'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndurationchangeAttribute(Gecko.JsVal aOndurationchange, System.IntPtr jsContext);
		
		/// <summary>Member GetOnemptiedAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnemptiedAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnemptiedAttribute </summary>
		/// <param name='aOnemptied'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnemptiedAttribute(Gecko.JsVal aOnemptied, System.IntPtr jsContext);
		
		/// <summary>Member GetOnendedAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnendedAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnendedAttribute </summary>
		/// <param name='aOnended'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnendedAttribute(Gecko.JsVal aOnended, System.IntPtr jsContext);
		
		/// <summary>Member GetOnerrorAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnerrorAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnerrorAttribute </summary>
		/// <param name='aOnerror'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute(Gecko.JsVal aOnerror, System.IntPtr jsContext);
		
		/// <summary>Member GetOnfocusAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnfocusAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnfocusAttribute </summary>
		/// <param name='aOnfocus'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnfocusAttribute(Gecko.JsVal aOnfocus, System.IntPtr jsContext);
		
		/// <summary>Member GetOninputAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOninputAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOninputAttribute </summary>
		/// <param name='aOninput'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOninputAttribute(Gecko.JsVal aOninput, System.IntPtr jsContext);
		
		/// <summary>Member GetOninvalidAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOninvalidAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOninvalidAttribute </summary>
		/// <param name='aOninvalid'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOninvalidAttribute(Gecko.JsVal aOninvalid, System.IntPtr jsContext);
		
		/// <summary>Member GetOnkeydownAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnkeydownAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnkeydownAttribute </summary>
		/// <param name='aOnkeydown'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnkeydownAttribute(Gecko.JsVal aOnkeydown, System.IntPtr jsContext);
		
		/// <summary>Member GetOnkeypressAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnkeypressAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnkeypressAttribute </summary>
		/// <param name='aOnkeypress'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnkeypressAttribute(Gecko.JsVal aOnkeypress, System.IntPtr jsContext);
		
		/// <summary>Member GetOnkeyupAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnkeyupAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnkeyupAttribute </summary>
		/// <param name='aOnkeyup'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnkeyupAttribute(Gecko.JsVal aOnkeyup, System.IntPtr jsContext);
		
		/// <summary>Member GetOnloadAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnloadAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnloadAttribute </summary>
		/// <param name='aOnload'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadAttribute(Gecko.JsVal aOnload, System.IntPtr jsContext);
		
		/// <summary>Member GetOnloadeddataAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnloadeddataAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnloadeddataAttribute </summary>
		/// <param name='aOnloadeddata'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadeddataAttribute(Gecko.JsVal aOnloadeddata, System.IntPtr jsContext);
		
		/// <summary>Member GetOnloadedmetadataAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnloadedmetadataAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnloadedmetadataAttribute </summary>
		/// <param name='aOnloadedmetadata'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadedmetadataAttribute(Gecko.JsVal aOnloadedmetadata, System.IntPtr jsContext);
		
		/// <summary>Member GetOnloadstartAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnloadstartAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnloadstartAttribute </summary>
		/// <param name='aOnloadstart'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadstartAttribute(Gecko.JsVal aOnloadstart, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmousedownAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmousedownAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmousedownAttribute </summary>
		/// <param name='aOnmousedown'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmousedownAttribute(Gecko.JsVal aOnmousedown, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmousemoveAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmousemoveAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmousemoveAttribute </summary>
		/// <param name='aOnmousemove'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmousemoveAttribute(Gecko.JsVal aOnmousemove, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmouseoutAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmouseoutAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmouseoutAttribute </summary>
		/// <param name='aOnmouseout'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmouseoutAttribute(Gecko.JsVal aOnmouseout, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmouseoverAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmouseoverAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmouseoverAttribute </summary>
		/// <param name='aOnmouseover'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmouseoverAttribute(Gecko.JsVal aOnmouseover, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmouseupAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmouseupAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmouseupAttribute </summary>
		/// <param name='aOnmouseup'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmouseupAttribute(Gecko.JsVal aOnmouseup, System.IntPtr jsContext);
		
		/// <summary>
        /// [implicit_jscontext] attribute jsval onmousewheel;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmozfullscreenchangeAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// [implicit_jscontext] attribute jsval onmousewheel;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmozfullscreenchangeAttribute(Gecko.JsVal aOnmozfullscreenchange, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmozfullscreenerrorAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmozfullscreenerrorAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmozfullscreenerrorAttribute </summary>
		/// <param name='aOnmozfullscreenerror'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmozfullscreenerrorAttribute(Gecko.JsVal aOnmozfullscreenerror, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmozpointerlockchangeAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmozpointerlockchangeAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmozpointerlockchangeAttribute </summary>
		/// <param name='aOnmozpointerlockchange'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmozpointerlockchangeAttribute(Gecko.JsVal aOnmozpointerlockchange, System.IntPtr jsContext);
		
		/// <summary>Member GetOnmozpointerlockerrorAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmozpointerlockerrorAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnmozpointerlockerrorAttribute </summary>
		/// <param name='aOnmozpointerlockerror'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmozpointerlockerrorAttribute(Gecko.JsVal aOnmozpointerlockerror, System.IntPtr jsContext);
		
		/// <summary>Member GetOnpauseAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnpauseAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnpauseAttribute </summary>
		/// <param name='aOnpause'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnpauseAttribute(Gecko.JsVal aOnpause, System.IntPtr jsContext);
		
		/// <summary>Member GetOnplayAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnplayAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnplayAttribute </summary>
		/// <param name='aOnplay'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnplayAttribute(Gecko.JsVal aOnplay, System.IntPtr jsContext);
		
		/// <summary>Member GetOnplayingAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnplayingAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnplayingAttribute </summary>
		/// <param name='aOnplaying'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnplayingAttribute(Gecko.JsVal aOnplaying, System.IntPtr jsContext);
		
		/// <summary>Member GetOnprogressAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnprogressAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnprogressAttribute </summary>
		/// <param name='aOnprogress'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnprogressAttribute(Gecko.JsVal aOnprogress, System.IntPtr jsContext);
		
		/// <summary>Member GetOnratechangeAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnratechangeAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnratechangeAttribute </summary>
		/// <param name='aOnratechange'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnratechangeAttribute(Gecko.JsVal aOnratechange, System.IntPtr jsContext);
		
		/// <summary>Member GetOnresetAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnresetAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnresetAttribute </summary>
		/// <param name='aOnreset'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnresetAttribute(Gecko.JsVal aOnreset, System.IntPtr jsContext);
		
		/// <summary>Member GetOnscrollAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnscrollAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnscrollAttribute </summary>
		/// <param name='aOnscroll'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnscrollAttribute(Gecko.JsVal aOnscroll, System.IntPtr jsContext);
		
		/// <summary>Member GetOnseekedAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnseekedAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnseekedAttribute </summary>
		/// <param name='aOnseeked'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnseekedAttribute(Gecko.JsVal aOnseeked, System.IntPtr jsContext);
		
		/// <summary>Member GetOnseekingAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnseekingAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnseekingAttribute </summary>
		/// <param name='aOnseeking'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnseekingAttribute(Gecko.JsVal aOnseeking, System.IntPtr jsContext);
		
		/// <summary>Member GetOnselectAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnselectAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnselectAttribute </summary>
		/// <param name='aOnselect'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnselectAttribute(Gecko.JsVal aOnselect, System.IntPtr jsContext);
		
		/// <summary>Member GetOnshowAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnshowAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnshowAttribute </summary>
		/// <param name='aOnshow'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnshowAttribute(Gecko.JsVal aOnshow, System.IntPtr jsContext);
		
		/// <summary>Member GetOnstalledAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnstalledAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnstalledAttribute </summary>
		/// <param name='aOnstalled'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnstalledAttribute(Gecko.JsVal aOnstalled, System.IntPtr jsContext);
		
		/// <summary>Member GetOnsubmitAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnsubmitAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnsubmitAttribute </summary>
		/// <param name='aOnsubmit'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnsubmitAttribute(Gecko.JsVal aOnsubmit, System.IntPtr jsContext);
		
		/// <summary>Member GetOnsuspendAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnsuspendAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnsuspendAttribute </summary>
		/// <param name='aOnsuspend'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnsuspendAttribute(Gecko.JsVal aOnsuspend, System.IntPtr jsContext);
		
		/// <summary>Member GetOntimeupdateAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOntimeupdateAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOntimeupdateAttribute </summary>
		/// <param name='aOntimeupdate'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOntimeupdateAttribute(Gecko.JsVal aOntimeupdate, System.IntPtr jsContext);
		
		/// <summary>Member GetOnvolumechangeAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnvolumechangeAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnvolumechangeAttribute </summary>
		/// <param name='aOnvolumechange'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnvolumechangeAttribute(Gecko.JsVal aOnvolumechange, System.IntPtr jsContext);
		
		/// <summary>Member GetOnwaitingAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnwaitingAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnwaitingAttribute </summary>
		/// <param name='aOnwaiting'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnwaitingAttribute(Gecko.JsVal aOnwaiting, System.IntPtr jsContext);
		
		/// <summary>
        /// Non-HTML5 event attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncopyAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// Non-HTML5 event attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncopyAttribute(Gecko.JsVal aOncopy, System.IntPtr jsContext);
		
		/// <summary>Member GetOncutAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncutAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOncutAttribute </summary>
		/// <param name='aOncut'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncutAttribute(Gecko.JsVal aOncut, System.IntPtr jsContext);
		
		/// <summary>Member GetOnpasteAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnpasteAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnpasteAttribute </summary>
		/// <param name='aOnpaste'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnpasteAttribute(Gecko.JsVal aOnpaste, System.IntPtr jsContext);
		
		/// <summary>Member GetOnbeforescriptexecuteAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnbeforescriptexecuteAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnbeforescriptexecuteAttribute </summary>
		/// <param name='aOnbeforescriptexecute'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnbeforescriptexecuteAttribute(Gecko.JsVal aOnbeforescriptexecute, System.IntPtr jsContext);
		
		/// <summary>Member GetOnafterscriptexecuteAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnafterscriptexecuteAttribute(System.IntPtr jsContext);
		
		/// <summary>Member SetOnafterscriptexecuteAttribute </summary>
		/// <param name='aOnafterscriptexecute'> </param>
		/// <param name='jsContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnafterscriptexecuteAttribute(Gecko.JsVal aOnafterscriptexecute, System.IntPtr jsContext);
	}
}
