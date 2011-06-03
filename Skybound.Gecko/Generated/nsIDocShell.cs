// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDocShell.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDocShell.idl
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
	
	
	/// <summary>nsIDocShell </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("98cdbcc4-2d81-4191-a63f-b6c52085edbc")]
	public interface nsIDocShell
	{
		
		/// <summary>Member LoadURI </summary>
		/// <param name='uri'> </param>
		/// <param name='loadInfo'> </param>
		/// <param name='aLoadFlags'> </param>
		/// <param name='firstParty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI  uri, [MarshalAs(UnmanagedType.Interface)] nsIDocShellLoadInfo  loadInfo, System.UInt32  aLoadFlags, System.Boolean  firstParty);
		
		/// <summary>Member LoadStream </summary>
		/// <param name='aStream'> </param>
		/// <param name='aURI'> </param>
		/// <param name='aContentType'> </param>
		/// <param name='aContentCharset'> </param>
		/// <param name='aLoadInfo'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aStream, [MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentType, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentCharset, [MarshalAs(UnmanagedType.Interface)] nsIDocShellLoadInfo  aLoadInfo);
		
		/// <summary>Member InternalLoad </summary>
		/// <param name='aURI'> </param>
		/// <param name='aReferrer'> </param>
		/// <param name='aOwner'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aWindowTarget'> </param>
		/// <param name='aTypeHint'> </param>
		/// <param name='aPostDataStream'> </param>
		/// <param name='aHeadersStream'> </param>
		/// <param name='aLoadFlags'> </param>
		/// <param name='aSHEntry'> </param>
		/// <param name='firstParty'> </param>
		/// <param name='aDocShell'> </param>
		/// <param name='aRequest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InternalLoad([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI  aReferrer, [MarshalAs(UnmanagedType.Interface)] nsISupports  aOwner, System.UInt32  aFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aWindowTarget, [MarshalAs(UnmanagedType.LPStr)] System.String  aTypeHint, [MarshalAs(UnmanagedType.Interface)] nsIInputStream  aPostDataStream, [MarshalAs(UnmanagedType.Interface)] nsIInputStream  aHeadersStream, System.UInt32  aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsISHEntry  aSHEntry, System.Boolean  firstParty, [MarshalAs(UnmanagedType.Interface)] out nsIDocShell  aDocShell, [MarshalAs(UnmanagedType.Interface)] out nsIRequest  aRequest);
		
		/// <summary>Member AddState </summary>
		/// <param name='aData'> </param>
		/// <param name='aTitle'> </param>
		/// <param name='aURL'> </param>
		/// <param name='aReplace'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddState([MarshalAs(UnmanagedType.Interface)] nsIVariant  aData, [MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle, [MarshalAs(UnmanagedType.LPStruct)] nsAString aURL, System.Boolean  aReplace);
		
		/// <summary>Member CreateLoadInfo </summary>
		/// <param name='loadInfo'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateLoadInfo([MarshalAs(UnmanagedType.Interface)] out nsIDocShellLoadInfo  loadInfo);
		
		/// <summary>Member PrepareForNewContentModel </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrepareForNewContentModel();
		
		/// <summary>Member SetCurrentURI </summary>
		/// <param name='aURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>Member FirePageHideNotification </summary>
		/// <param name='isUnload'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FirePageHideNotification(System.Boolean  isUnload);
		
		/// <summary>Member GetPresContextAttribute </summary>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  GetPresContextAttribute();
		
		/// <summary>Member GetPresShellAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPresShellAttribute();
		
		/// <summary>Member GetEldestPresShellAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetEldestPresShellAttribute();
		
		/// <summary>Member GetContentViewerAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetContentViewerAttribute();
		
		/// <summary>Member GetChromeEventHandlerAttribute </summary>
		/// <returns>A nsIDOMEventTarget </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget  GetChromeEventHandlerAttribute();
		
		/// <summary>Member SetChromeEventHandlerAttribute </summary>
		/// <param name='aChromeEventHandler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChromeEventHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget  aChromeEventHandler);
		
		/// <summary>Member GetDocumentCharsetInfoAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetDocumentCharsetInfoAttribute();
		
		/// <summary>Member SetDocumentCharsetInfoAttribute </summary>
		/// <param name='aDocumentCharsetInfo'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentCharsetInfoAttribute(System.IntPtr aDocumentCharsetInfo);
		
		/// <summary>Member GetAllowPluginsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowPluginsAttribute();
		
		/// <summary>Member SetAllowPluginsAttribute </summary>
		/// <param name='aAllowPlugins'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowPluginsAttribute(System.Boolean  aAllowPlugins);
		
		/// <summary>Member GetAllowJavascriptAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowJavascriptAttribute();
		
		/// <summary>Member SetAllowJavascriptAttribute </summary>
		/// <param name='aAllowJavascript'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowJavascriptAttribute(System.Boolean  aAllowJavascript);
		
		/// <summary>Member GetAllowMetaRedirectsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowMetaRedirectsAttribute();
		
		/// <summary>Member SetAllowMetaRedirectsAttribute </summary>
		/// <param name='aAllowMetaRedirects'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowMetaRedirectsAttribute(System.Boolean  aAllowMetaRedirects);
		
		/// <summary>Member GetAllowSubframesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowSubframesAttribute();
		
		/// <summary>Member SetAllowSubframesAttribute </summary>
		/// <param name='aAllowSubframes'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowSubframesAttribute(System.Boolean  aAllowSubframes);
		
		/// <summary>Member GetAllowImagesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowImagesAttribute();
		
		/// <summary>Member SetAllowImagesAttribute </summary>
		/// <param name='aAllowImages'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowImagesAttribute(System.Boolean  aAllowImages);
		
		/// <summary>Member GetAllowDNSPrefetchAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowDNSPrefetchAttribute();
		
		/// <summary>Member SetAllowDNSPrefetchAttribute </summary>
		/// <param name='aAllowDNSPrefetch'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowDNSPrefetchAttribute(System.Boolean  aAllowDNSPrefetch);
		
		/// <summary>Member GetDocShellEnumerator </summary>
		/// <param name='aItemType'> </param>
		/// <param name='aDirection'> </param>
		/// <returns>A nsISimpleEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetDocShellEnumerator(System.Int32  aItemType, System.Int32  aDirection);
		
		/// <summary>Member GetAppTypeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetAppTypeAttribute();
		
		/// <summary>Member SetAppTypeAttribute </summary>
		/// <param name='aAppType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAppTypeAttribute(System.UInt32  aAppType);
		
		/// <summary>Member GetAllowAuthAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowAuthAttribute();
		
		/// <summary>Member SetAllowAuthAttribute </summary>
		/// <param name='aAllowAuth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowAuthAttribute(System.Boolean  aAllowAuth);
		
		/// <summary>Member GetZoomAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetZoomAttribute();
		
		/// <summary>Member SetZoomAttribute </summary>
		/// <param name='aZoom'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetZoomAttribute(double aZoom);
		
		/// <summary>Member GetMarginWidthAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetMarginWidthAttribute();
		
		/// <summary>Member SetMarginWidthAttribute </summary>
		/// <param name='aMarginWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginWidthAttribute(System.Int32  aMarginWidth);
		
		/// <summary>Member GetMarginHeightAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetMarginHeightAttribute();
		
		/// <summary>Member SetMarginHeightAttribute </summary>
		/// <param name='aMarginHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginHeightAttribute(System.Int32  aMarginHeight);
		
		/// <summary>Member TabToTreeOwner </summary>
		/// <param name='forward'> </param>
		/// <param name='tookFocus'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TabToTreeOwner(System.Boolean  forward, out System.Boolean  tookFocus);
		
		/// <summary>Member GetBusyFlagsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetBusyFlagsAttribute();
		
		/// <summary>Member GetLoadTypeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLoadTypeAttribute();
		
		/// <summary>Member SetLoadTypeAttribute </summary>
		/// <param name='aLoadType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadTypeAttribute(System.UInt32  aLoadType);
		
		/// <summary>Member IsBeingDestroyed </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsBeingDestroyed();
		
		/// <summary>Member GetIsExecutingOnLoadHandlerAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsExecutingOnLoadHandlerAttribute();
		
		/// <summary>Member GetLayoutHistoryStateAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetLayoutHistoryStateAttribute();
		
		/// <summary>Member SetLayoutHistoryStateAttribute </summary>
		/// <param name='aLayoutHistoryState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLayoutHistoryStateAttribute(System.IntPtr aLayoutHistoryState);
		
		/// <summary>Member GetShouldSaveLayoutStateAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetShouldSaveLayoutStateAttribute();
		
		/// <summary>Member GetSecurityUIAttribute </summary>
		/// <returns>A nsISecureBrowserUI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISecureBrowserUI  GetSecurityUIAttribute();
		
		/// <summary>Member SetSecurityUIAttribute </summary>
		/// <param name='aSecurityUI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecurityUIAttribute([MarshalAs(UnmanagedType.Interface)] nsISecureBrowserUI  aSecurityUI);
		
		/// <summary>Member SuspendRefreshURIs </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SuspendRefreshURIs();
		
		/// <summary>Member ResumeRefreshURIs </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeRefreshURIs();
		
		/// <summary>Member BeginRestore </summary>
		/// <param name='viewer'> </param>
		/// <param name='top'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginRestore(System.IntPtr viewer, System.Boolean  top);
		
		/// <summary>Member FinishRestore </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FinishRestore();
		
		/// <summary>Member GetRestoringDocumentAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetRestoringDocumentAttribute();
		
		/// <summary>Member GetUseErrorPagesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetUseErrorPagesAttribute();
		
		/// <summary>Member SetUseErrorPagesAttribute </summary>
		/// <param name='aUseErrorPages'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUseErrorPagesAttribute(System.Boolean  aUseErrorPages);
		
		/// <summary>Member GetPreviousTransIndexAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetPreviousTransIndexAttribute();
		
		/// <summary>Member GetLoadedTransIndexAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetLoadedTransIndexAttribute();
		
		/// <summary>Member HistoryPurged </summary>
		/// <param name='numEntries'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HistoryPurged(System.Int32  numEntries);
		
		/// <summary>Member GetSessionStorageForURI </summary>
		/// <param name='uri'> </param>
		/// <param name='documentURI'> </param>
		/// <returns>A nsIDOMStorage</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStorage GetSessionStorageForURI([MarshalAs(UnmanagedType.Interface)] nsIURI  uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString documentURI);
		
		/// <summary>Member GetSessionStorageForPrincipal </summary>
		/// <param name='principal'> </param>
		/// <param name='documentURI'> </param>
		/// <param name='create'> </param>
		/// <returns>A nsIDOMStorage</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStorage GetSessionStorageForPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  principal, [MarshalAs(UnmanagedType.LPStruct)] nsAString documentURI, System.Boolean  create);
		
		/// <summary>Member AddSessionStorage </summary>
		/// <param name='principal'> </param>
		/// <param name='storage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSessionStorage([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  principal, [MarshalAs(UnmanagedType.Interface)] nsIDOMStorage  storage);
		
		/// <summary>Member GetCurrentDocumentChannelAttribute </summary>
		/// <returns>A nsIChannel </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel  GetCurrentDocumentChannelAttribute();
		
		/// <summary>Member SetChildOffset </summary>
		/// <param name='offset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChildOffset(System.UInt32  offset);
		
		/// <summary>Member GetIsInUnloadAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsInUnloadAttribute();
		
		/// <summary>Member GetChannelIsUnsafeAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetChannelIsUnsafeAttribute();
		
		/// <summary>Member DetachEditorFromWindow </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DetachEditorFromWindow();
		
		/// <summary>Member GetIsOffScreenBrowserAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsOffScreenBrowserAttribute();
		
		/// <summary>Member SetIsOffScreenBrowserAttribute </summary>
		/// <param name='aIsOffScreenBrowser'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsOffScreenBrowserAttribute(System.Boolean  aIsOffScreenBrowser);
		
		/// <summary>Member GetPrintPreviewAttribute </summary>
		/// <returns>A nsIWebBrowserPrint </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserPrint  GetPrintPreviewAttribute();
		
		/// <summary>Member GetCanExecuteScriptsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetCanExecuteScriptsAttribute();
		
		/// <summary>Member GetIsActiveAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsActiveAttribute();
		
		/// <summary>Member SetIsActiveAttribute </summary>
		/// <param name='aIsActive'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsActiveAttribute(System.Boolean  aIsActive);
		
		/// <summary>Member GetHistoryIDAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetHistoryIDAttribute();
		
		/// <summary>Member GetIsAppTabAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsAppTabAttribute();
		
		/// <summary>Member SetIsAppTabAttribute </summary>
		/// <param name='aIsAppTab'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsAppTabAttribute(System.Boolean  aIsAppTab);
	}
	
	/// <summary>nsIDocShell_MOZILLA_2_0_BRANCH </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5f7a2184-31b6-4d67-9c75-0c17477766e2")]
	public interface nsIDocShell_MOZILLA_2_0_BRANCH
	{
		
		/// <summary>Member CreateAboutBlankContentViewer </summary>
		/// <param name='aPrincipal'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateAboutBlankContentViewer([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  aPrincipal);
	}
}
