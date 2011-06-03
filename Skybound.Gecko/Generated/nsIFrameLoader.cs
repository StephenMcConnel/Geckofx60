// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIFrameLoader.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIFrameLoader.idl
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
	
	
	/// <summary>nsIContentView </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fbd25468-d2cf-487b-bc58-a0e105398b47")]
	public interface nsIContentView
	{
		
		/// <summary>Member ScrollTo </summary>
		/// <param name='xPx'> </param>
		/// <param name='yPx'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollTo(double xPx, double yPx);
		
		/// <summary>Member ScrollBy </summary>
		/// <param name='dxPx'> </param>
		/// <param name='dyPx'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollBy(double dxPx, double dyPx);
		
		/// <summary>Member SetScale </summary>
		/// <param name='xScale'> </param>
		/// <param name='yScale'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScale(double xScale, double yScale);
		
		/// <summary>Member GetScrollXAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetScrollXAttribute();
		
		/// <summary>Member GetScrollYAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetScrollYAttribute();
		
		/// <summary>Member GetViewportWidthAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetViewportWidthAttribute();
		
		/// <summary>Member GetViewportHeightAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetViewportHeightAttribute();
		
		/// <summary>Member GetContentWidthAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetContentWidthAttribute();
		
		/// <summary>Member GetContentHeightAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetContentHeightAttribute();
		
		/// <summary>Member GetIdAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIdAttribute();
	}
	
	/// <summary>nsIContentViewManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ba5af90d-ece5-40b2-9a1d-a0154128db1c")]
	public interface nsIContentViewManager
	{
		
		/// <summary>Member GetContentViewsIn </summary>
		/// <param name='aXPx'> </param>
		/// <param name='aYPx'> </param>
		/// <param name='aTopSize'> </param>
		/// <param name='aRightSize'> </param>
		/// <param name='aBottomSize'> </param>
		/// <param name='aLeftSize'> </param>
		/// <param name='aLength'> </param>
		/// <returns>A nsIContentView </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIContentView  GetContentViewsIn(double aXPx, double aYPx, double aTopSize, double aRightSize, double aBottomSize, double aLeftSize, out System.UInt32  aLength);
		
		/// <summary>Member GetRootContentViewAttribute </summary>
		/// <returns>A nsIContentView </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIContentView  GetRootContentViewAttribute();
	}
	
	/// <summary>nsIFrameLoader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("50a67436-bb44-11df-8d9a-001e37d2764a")]
	public interface nsIFrameLoader
	{
		
		/// <summary>Member GetDocShellAttribute </summary>
		/// <returns>A nsIDocShell </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShell  GetDocShellAttribute();
		
		/// <summary>Member LoadFrame </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadFrame();
		
		/// <summary>Member LoadURI </summary>
		/// <param name='aURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>Member Destroy </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Destroy();
		
		/// <summary>Member GetDepthTooGreatAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetDepthTooGreatAttribute();
		
		/// <summary>Member UpdatePositionAndSize </summary>
		/// <param name='aIFrame'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdatePositionAndSize(System.IntPtr aIFrame);
		
		/// <summary>Member ActivateRemoteFrame </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActivateRemoteFrame();
		
		/// <summary>Member SendCrossProcessMouseEvent </summary>
		/// <param name='aType'> </param>
		/// <param name='aX'> </param>
		/// <param name='aY'> </param>
		/// <param name='aButton'> </param>
		/// <param name='aClickCount'> </param>
		/// <param name='aModifiers'> </param>
		/// <param name='aIgnoreRootScrollFrame'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendCrossProcessMouseEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, double aX, double aY, System.Int32  aButton, System.Int32  aClickCount, System.Int32  aModifiers, System.Boolean  aIgnoreRootScrollFrame);
		
		/// <summary>Member ActivateFrameEvent </summary>
		/// <param name='aType'> </param>
		/// <param name='capture'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActivateFrameEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, System.Boolean  capture);
		
		/// <summary>Member GetMessageManagerAttribute </summary>
		/// <returns>A nsIChromeFrameMessageManager </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChromeFrameMessageManager  GetMessageManagerAttribute();
		
		/// <summary>Member SendCrossProcessKeyEvent </summary>
		/// <param name='aType'> </param>
		/// <param name='aKeyCode'> </param>
		/// <param name='aCharCode'> </param>
		/// <param name='aModifiers'> </param>
		/// <param name='aPreventDefault'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendCrossProcessKeyEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString aType, System.Int32  aKeyCode, System.Int32  aCharCode, System.Int32  aModifiers, System.Boolean  aPreventDefault);
		
		/// <summary>Member GetDelayRemoteDialogsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetDelayRemoteDialogsAttribute();
		
		/// <summary>Member SetDelayRemoteDialogsAttribute </summary>
		/// <param name='aDelayRemoteDialogs'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDelayRemoteDialogsAttribute(System.Boolean  aDelayRemoteDialogs);
		
		/// <summary>Member ScrollViewportTo </summary>
		/// <param name='xPx'> </param>
		/// <param name='yPx'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollViewportTo(double xPx, double yPx);
		
		/// <summary>Member ScrollViewportBy </summary>
		/// <param name='dxPx'> </param>
		/// <param name='dyPx'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollViewportBy(double dxPx, double dyPx);
		
		/// <summary>Member SetViewportScale </summary>
		/// <param name='xScale'> </param>
		/// <param name='yScale'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetViewportScale(double xScale, double yScale);
		
		/// <summary>Member GetViewportScrollXAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetViewportScrollXAttribute();
		
		/// <summary>Member GetViewportScrollYAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetViewportScrollYAttribute();
	}
	
	/// <summary>nsIFrameLoaderOwner </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5879040e-83e9-40e3-b2bb-5ddf43b76e47")]
	public interface nsIFrameLoaderOwner
	{
		
		/// <summary>Member GetFrameLoaderAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFrameLoaderAttribute();
		
		/// <summary>Member GetFrameLoader </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFrameLoader();
		
		/// <summary>Member SwapFrameLoaders </summary>
		/// <param name='aOtherOwner'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SwapFrameLoaders(System.IntPtr aOtherOwner);
	}
	
	/// <summary>nsIFrameLoader_MOZILLA_2_0_BRANCH </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e3e2d3f8-1397-4984-abb3-435c29a1ca55")]
	public interface nsIFrameLoader_MOZILLA_2_0_BRANCH
	{
		
		/// <summary>Member GetRenderModeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetRenderModeAttribute();
		
		/// <summary>Member SetRenderModeAttribute </summary>
		/// <param name='aRenderMode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRenderModeAttribute(System.UInt32  aRenderMode);
	}
}
