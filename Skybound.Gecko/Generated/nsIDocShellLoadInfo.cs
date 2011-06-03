// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDocShellLoadInfo.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDocShellLoadInfo.idl
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
	
	
	/// <summary>nsIDocShellLoadInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("92a0a637-373e-4647-9476-ead11e005c75")]
	public interface nsIDocShellLoadInfo
	{
		
		/// <summary>Member GetReferrerAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetReferrerAttribute();
		
		/// <summary>Member SetReferrerAttribute </summary>
		/// <param name='aReferrer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI  aReferrer);
		
		/// <summary>Member GetOwnerAttribute </summary>
		/// <returns>A nsISupports </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports  GetOwnerAttribute();
		
		/// <summary>Member SetOwnerAttribute </summary>
		/// <param name='aOwner'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports  aOwner);
		
		/// <summary>Member GetInheritOwnerAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetInheritOwnerAttribute();
		
		/// <summary>Member SetInheritOwnerAttribute </summary>
		/// <param name='aInheritOwner'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInheritOwnerAttribute(System.Boolean  aInheritOwner);
		
		/// <summary>Member GetOwnerIsExplicitAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetOwnerIsExplicitAttribute();
		
		/// <summary>Member SetOwnerIsExplicitAttribute </summary>
		/// <param name='aOwnerIsExplicit'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerIsExplicitAttribute(System.Boolean  aOwnerIsExplicit);
		
		/// <summary>Member GetLoadTypeAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetLoadTypeAttribute();
		
		/// <summary>Member SetLoadTypeAttribute </summary>
		/// <param name='aLoadType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadTypeAttribute(System.IntPtr aLoadType);
		
		/// <summary>Member GetSHEntryAttribute </summary>
		/// <returns>A nsISHEntry </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry  GetSHEntryAttribute();
		
		/// <summary>Member SetSHEntryAttribute </summary>
		/// <param name='aSHEntry'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSHEntryAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry  aSHEntry);
		
		/// <summary>Member GetTargetAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTargetAttribute();
		
		/// <summary>Member SetTargetAttribute </summary>
		/// <param name='aTarget'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aTarget);
		
		/// <summary>Member GetPostDataStreamAttribute </summary>
		/// <returns>A nsIInputStream </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream  GetPostDataStreamAttribute();
		
		/// <summary>Member SetPostDataStreamAttribute </summary>
		/// <param name='aPostDataStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPostDataStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aPostDataStream);
		
		/// <summary>Member GetHeadersStreamAttribute </summary>
		/// <returns>A nsIInputStream </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream  GetHeadersStreamAttribute();
		
		/// <summary>Member SetHeadersStreamAttribute </summary>
		/// <param name='aHeadersStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeadersStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aHeadersStream);
		
		/// <summary>Member GetSendReferrerAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetSendReferrerAttribute();
		
		/// <summary>Member SetSendReferrerAttribute </summary>
		/// <param name='aSendReferrer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSendReferrerAttribute(System.Boolean  aSendReferrer);
	}
}
