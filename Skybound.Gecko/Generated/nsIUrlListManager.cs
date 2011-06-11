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
// Generated by IDLImporter from file nsIUrlListManager.idl
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
    /// Interface for JS function callbacks
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fa4caf12-d057-4e7e-81e9-ce066ceee90b")]
	public interface nsIUrlListManagerCallback
	{
		
		/// <summary>
        /// Interface for JS function callbacks
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString  value);
	}
	
	/// <summary>nsIUrlListManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9c5598ec-9986-40cf-af40-b5e0d817a3a0")]
	public interface nsIUrlListManager
	{
		
		/// <summary>
        /// Set the URL we check for updates.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUpdateUrl([MarshalAs(UnmanagedType.LPStruct)] nsAString  url);
		
		/// <summary>
        /// Set the URL we use to get keys used to decrypt URLs in
        /// enchash tables.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetKeyUrl([MarshalAs(UnmanagedType.LPStruct)] nsAString  url);
		
		/// <summary>
        /// Set the URL that we will query for complete hashes after a partial
        /// hash match.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGethashUrl([MarshalAs(UnmanagedType.LPStruct)] nsAString  url);
		
		/// <summary>
        /// Add a table to the list of tables we are managing.  The name is a
        /// string of the format provider_name-semantic_type-table_type.  For
        /// example, goog-white-enchash or goog-black-url.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool RegisterTable([MarshalAs(UnmanagedType.LPStruct)] nsAString  tableName, System.Boolean  requireMac);
		
		/// <summary>
        /// Turn on update checking for a table.  I.e., during the next server
        /// check, download updates for this table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableUpdate([MarshalAs(UnmanagedType.LPStruct)] nsAString  tableName);
		
		/// <summary>
        /// Turn off update checking for a table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableUpdate([MarshalAs(UnmanagedType.LPStruct)] nsAString  tableName);
		
		/// <summary>
        /// Lookup a key.  Should not raise exceptions.  Calls the callback
        /// function with a comma-separated list of tables to which the key
        /// belongs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SafeLookup([MarshalAs(UnmanagedType.LPStruct)] nsAString  key, [MarshalAs(UnmanagedType.Interface)] nsIUrlListManagerCallback  cb);
		
		/// <summary>Member CheckForUpdates </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckForUpdates();
	}
}
