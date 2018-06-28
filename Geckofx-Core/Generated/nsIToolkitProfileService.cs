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
// Generated by IDLImporter from file nsIToolkitProfileService.idl
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
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1947899b-f369-48fa-89da-f7c37bb1e6bc")]
	public interface nsIToolkitProfileService
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStartWithLastProfileAttribute();
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartWithLastProfileAttribute([MarshalAs(UnmanagedType.U1)] bool aStartWithLastProfile);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStartOfflineAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aStartOffline);
		
		/// <summary>
        ///nsIToolkitProfile </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetProfilesAttribute();
		
		/// <summary>
        /// The currently selected profile (the one used or about to be used by the
        /// browser).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile GetSelectedProfileAttribute();
		
		/// <summary>
        /// The currently selected profile (the one used or about to be used by the
        /// browser).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectedProfileAttribute([MarshalAs(UnmanagedType.Interface)] nsIToolkitProfile aSelectedProfile);
		
		/// <summary>
        /// The default profile (the one used or about to be used by the
        /// browser if no other profile is specified at runtime). This is the profile
        /// marked with Default=1 in profiles.ini and is usually the same as
        /// selectedProfile, except on Developer Edition.
        ///
        /// Developer Edition uses a profile named "dev-edition-default" as the
        /// default profile (which it creates if it doesn't exist), unless a special
        /// empty file named "ignore-dev-edition-profile" is present next to
        /// profiles.ini. In that case Developer Edition behaves the same as any
        /// other build of Firefox.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile GetDefaultProfileAttribute();
		
		/// <summary>
        /// The default profile (the one used or about to be used by the
        /// browser if no other profile is specified at runtime). This is the profile
        /// marked with Default=1 in profiles.ini and is usually the same as
        /// selectedProfile, except on Developer Edition.
        ///
        /// Developer Edition uses a profile named "dev-edition-default" as the
        /// default profile (which it creates if it doesn't exist), unless a special
        /// empty file named "ignore-dev-edition-profile" is present next to
        /// profiles.ini. In that case Developer Edition behaves the same as any
        /// other build of Firefox.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultProfileAttribute([MarshalAs(UnmanagedType.Interface)] nsIToolkitProfile aDefaultProfile);
		
		/// <summary>
        /// Get a profile by name. This is mainly for use by the -P
        /// commandline flag.
        ///
        /// @param aName The profile name to find.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile GetProfileByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Lock an arbitrary path as a profile. If the path does not exist, it
        /// will be created and the defaults copied from the application directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProfileLock LockProfilePath([MarshalAs(UnmanagedType.Interface)] nsIFile aDirectory, [MarshalAs(UnmanagedType.Interface)] nsIFile aTempDirectory);
		
		/// <summary>
        /// Create a new profile.
        ///
        /// The profile temporary directory will be chosen based on where the
        /// profile directory is located.
        ///
        /// @param aRootDir
        /// The profile directory. May be null, in which case a suitable
        /// default will be chosen based on the profile name.
        /// @param aName
        /// The profile name.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile CreateProfile([MarshalAs(UnmanagedType.Interface)] nsIFile aRootDir, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Returns the number of profiles.
        /// @return the number of profiles.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProfileCountAttribute();
		
		/// <summary>
        /// Flush the profiles list file.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Flush();
	}
}
