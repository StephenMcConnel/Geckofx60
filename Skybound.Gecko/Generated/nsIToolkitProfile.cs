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
// Generated by IDLImporter from file nsIToolkitProfile.idl
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
    /// Hold on to a profile lock. Once you release the last reference to this
    /// interface, the profile lock is released.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7c58c703-d245-4864-8d75-9648ca4a6139")]
	public interface nsIProfileLock
	{
		
		/// <summary>
        /// The main profile directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetDirectoryAttribute();
		
		/// <summary>
        /// A directory corresponding to the main profile directory that exists for
        /// the purpose of storing data on the local filesystem, including cache
        /// files or other data files that may not represent critical user data.
        /// (e.g., this directory may not be included as part of a backup scheme.)
        ///
        /// In some cases, this directory may just be the main profile directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetLocalDirectoryAttribute();
		
		/// <summary>
        /// The timestamp of an existing profile lock at lock time.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetReplacedLockTimeAttribute();
		
		/// <summary>
        /// Unlock the profile.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unlock();
	}
	
	/// <summary>
    /// A interface representing a profile.
    /// @note THIS INTERFACE SHOULD BE IMPLEMENTED BY THE TOOLKIT CODE ONLY! DON'T
    /// EVEN THINK ABOUT IMPLEMENTING THIS IN JAVASCRIPT!
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7422b090-4a86-4407-972e-75468a625388")]
	public interface nsIToolkitProfile
	{
		
		/// <summary>
        /// The location of the profile directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetRootDirAttribute();
		
		/// <summary>
        /// The location of the profile local directory, which may be the same as
        /// the root directory.  See nsIProfileLock::localDirectory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetLocalDirAttribute();
		
		/// <summary>
        /// The name of the profile.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// The name of the profile.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Removes the profile from the registry of profiles.
        ///
        /// @param removeFiles
        /// Indicates whether or not the profile directory should be
        /// removed in addition.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove([MarshalAs(UnmanagedType.U1)] bool removeFiles);
		
		/// <summary>
        /// Lock this profile using platform-specific locking methods.
        ///
        /// @param lockFile If locking fails, this may return a lockFile object
        /// which can be used in platform-specific ways to
        /// determine which process has the file locked. Null
        /// may be passed.
        /// @return An interface which holds a profile lock as long as you reference
        /// it.
        /// @throws NS_ERROR_FILE_ACCESS_DENIED if the profile was already locked.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProfileLock Lock([MarshalAs(UnmanagedType.Interface)] ref nsIProfileUnlocker aUnlocker);
	}
}
