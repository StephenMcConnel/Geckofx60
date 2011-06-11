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
// Generated by IDLImporter from file nsIDocShellHistory.idl
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
	
	
	/// <summary>nsIDocShellHistory </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("95e425aa-afc6-40a0-9db4-7f210a58310a")]
	public interface nsIDocShellHistory
	{
		
		/// <summary>
        /// Get the SHEntry associated with a child docshell
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry GetChildSHEntry(System.Int32  aChildOffset);
		
		/// <summary>
        /// Add a Child SHEntry for a frameset page, given the child's loadtype.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddChildSHEntry([MarshalAs(UnmanagedType.Interface)] nsISHEntry  aCloneReference, [MarshalAs(UnmanagedType.Interface)] nsISHEntry  aHistoryEntry, System.Int32  aChildOffset, System.UInt32  aLoadType);
		
		/// <summary>
        /// Whether this docshell should save entries in global history.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetUseGlobalHistoryAttribute();
		
		/// <summary>
        /// Whether this docshell should save entries in global history.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUseGlobalHistoryAttribute(System.Boolean  aUseGlobalHistory);
		
		/// <summary>
        /// Removes nsISHEntry objects related to this docshell from session history.
        /// Use this only with subdocuments, like iframes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFromSessionHistory();
		
		/// <summary>
        /// Set when an iframe/frame is added dynamically.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetCreatedDynamicallyAttribute();
		
		/// <summary>
        /// Set when an iframe/frame is added dynamically.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCreatedDynamicallyAttribute(System.Boolean  aCreatedDynamically);
		
		/// <summary>
        /// Returns false for mLSHE, true for mOSHE
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCurrentSHEntry([MarshalAs(UnmanagedType.Interface)] out nsISHEntry  aEntry);
	}
}
