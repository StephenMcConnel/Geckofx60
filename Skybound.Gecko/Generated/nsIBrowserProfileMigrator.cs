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
// Generated by IDLImporter from file nsIBrowserProfileMigrator.idl
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
	
	
	/// <summary>nsIBrowserProfileMigrator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f8365b4a-da55-4e47-be7a-230142360f62")]
	public interface nsIBrowserProfileMigrator
	{
		
		/// <summary>
        /// Copy user profile information to the current active profile.
        /// @param aItems   list of data items to migrate. see above for values.
        /// @param aStartup helper interface which is non-null if called during startup.
        /// @param aProfile profile to migrate from, if there is more than one.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Migrate(ushort aItems, [MarshalAs(UnmanagedType.Interface)] nsIProfileStartup aStartup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aProfile);
		
		/// <summary>
        /// A bit field containing profile items that this migrator
        /// offers for import.
        /// @param   aProfile the profile that we are looking for available data
        /// to import
        /// @param   aDoingStartup "true" if the profile is not currently being used.
        /// @returns bit field containing profile items (see above)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMigrateData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aProfile, [MarshalAs(UnmanagedType.Bool)] bool aDoingStartup);
		
		/// <summary>
        /// Whether or not there is any data that can be imported from this
        /// browser (i.e. whether or not it is installed, and there exists
        /// a user profile)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSourceExistsAttribute();
		
		/// <summary>
        /// Whether or not the import source implementing this interface
        /// has multiple user profiles configured.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSourceHasMultipleProfilesAttribute();
		
		/// <summary>
        /// An enumeration of available profiles. If the import source does
        /// not support profiles, this attribute is null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetSourceProfilesAttribute();
		
		/// <summary>
        /// The import source homepage.  Returns null if not present/available
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSourceHomePageURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aSourceHomePageURL);
	}
}
