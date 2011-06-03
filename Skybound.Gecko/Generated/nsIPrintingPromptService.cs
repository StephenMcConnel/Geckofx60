// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPrintingPromptService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPrintingPromptService.idl
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
	
	
	/// <summary>nsIPrintingPromptService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("75D1553D-63BF-4b5d-A8F7-E4E4CAC21BA4")]
	public interface nsIPrintingPromptService
	{
		
		/// <summary>Member ShowPrintDialog </summary>
		/// <param name='parent'> </param>
		/// <param name='webBrowserPrint'> </param>
		/// <param name='printSettings'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrintDialog([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  parent, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint  webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings  printSettings);
		
		/// <summary>Member ShowProgress </summary>
		/// <param name='parent'> </param>
		/// <param name='webBrowserPrint'> </param>
		/// <param name='printSettings'> </param>
		/// <param name='openDialogObserver'> </param>
		/// <param name='isForPrinting'> </param>
		/// <param name='webProgressListener'> </param>
		/// <param name='printProgressParams'> </param>
		/// <param name='notifyOnOpen'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowProgress([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  parent, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint  webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings  printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver  openDialogObserver, System.Boolean  isForPrinting, [MarshalAs(UnmanagedType.Interface)] out nsIWebProgressListener  webProgressListener, [MarshalAs(UnmanagedType.Interface)] out nsIPrintProgressParams  printProgressParams, out System.Boolean  notifyOnOpen);
		
		/// <summary>Member ShowPageSetup </summary>
		/// <param name='parent'> </param>
		/// <param name='printSettings'> </param>
		/// <param name='aObs'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPageSetup([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  parent, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings  printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver  aObs);
		
		/// <summary>Member ShowPrinterProperties </summary>
		/// <param name='parent'> </param>
		/// <param name='printerName'> </param>
		/// <param name='printSettings'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrinterProperties([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string printerName, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings  printSettings);
	}
}
