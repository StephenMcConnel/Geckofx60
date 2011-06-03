// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMPopupBlockedEvent.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMPopupBlockedEvent.idl
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
	
	
	/// <summary>nsIDOMPopupBlockedEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("05be571f-c3ea-4959-a340-c57b1591ae4b")]
	public interface nsIDOMPopupBlockedEvent : nsIDOMEvent
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member GetTargetAttribute </summary>
		/// <returns>A nsIDOMEventTarget </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget  GetTargetAttribute();
		
		/// <summary>Member GetCurrentTargetAttribute </summary>
		/// <returns>A nsIDOMEventTarget </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget  GetCurrentTargetAttribute();
		
		/// <summary>Member GetEventPhaseAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhaseAttribute();
		
		/// <summary>Member GetBubblesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetBubblesAttribute();
		
		/// <summary>Member GetCancelableAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetCancelableAttribute();
		
		/// <summary>Member GetTimeStampAttribute </summary>
		/// <returns>A System.Int64 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int64  GetTimeStampAttribute();
		
		/// <summary>Member StopPropagation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		/// <summary>Member PreventDefault </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		/// <summary>Member InitEvent </summary>
		/// <param name='eventTypeArg'> </param>
		/// <param name='canBubbleArg'> </param>
		/// <param name='cancelableArg'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString eventTypeArg, System.Boolean  canBubbleArg, System.Boolean  cancelableArg);
		
		/// <summary>Member GetRequestingWindowAttribute </summary>
		/// <returns>A nsIDOMWindow </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow  GetRequestingWindowAttribute();
		
		/// <summary>Member GetPopupWindowURIAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetPopupWindowURIAttribute();
		
		/// <summary>Member GetPopupWindowFeaturesAttribute </summary>
		/// <param name='aPopupWindowFeatures'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPopupWindowFeaturesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPopupWindowFeatures);
		
		/// <summary>Member GetPopupWindowNameAttribute </summary>
		/// <param name='aPopupWindowName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPopupWindowNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPopupWindowName);
		
		/// <summary>Member InitPopupBlockedEvent </summary>
		/// <param name='typeArg'> </param>
		/// <param name='canBubbleArg'> </param>
		/// <param name='cancelableArg'> </param>
		/// <param name='requestingWindow'> </param>
		/// <param name='popupWindowURI'> </param>
		/// <param name='popupWindowName'> </param>
		/// <param name='popupWindowFeatures'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitPopupBlockedEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, System.Boolean  canBubbleArg, System.Boolean  cancelableArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  requestingWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI  popupWindowURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString popupWindowName, [MarshalAs(UnmanagedType.LPStruct)] nsAString popupWindowFeatures);
	}
}
