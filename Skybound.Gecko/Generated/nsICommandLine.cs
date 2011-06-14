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
// Generated by IDLImporter from file nsICommandLine.idl
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
    /// Represents the command line used to invoke a XUL application. This may be the
    /// original command-line of this instance, or a command line remoted from another
    /// instance of the application.
    ///
    /// DEFINITIONS:
    /// "arguments" are any values found on the command line.
    /// "flags" are switches. In normalized form they are preceded by a single dash.
    /// Some flags may take "parameters", e.g. "-url <param>" or "-install-xpi <param>"
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bc3173bd-aa46-46a0-9d25-d9867a9659b6")]
	public interface nsICommandLine
	{
		
		/// <summary>
        /// Number of arguments in the command line. The application name is not
        /// part of the command line.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLengthAttribute();
		
		/// <summary>
        /// Get an argument from the array of command-line arguments.
        ///
        /// On windows, flags of the form /flag are normalized to -flag. /flag:param
        /// are normalized to -flag param.
        ///
        /// On *nix and mac flags of the form --flag are normalized to -flag. --flag=param
        /// are normalized to the form -flag param.
        ///
        /// @param aIndex The argument to retrieve. This index is 0-based, and does
        /// not include the application name.
        /// @return       The indexth argument.
        /// @throws       NS_ERROR_INVALID_ARG if aIndex is out of bounds.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetArgument(int aIndex);
		
		/// <summary>
        /// Find a command-line flag.
        ///
        /// @param aFlag          The flag name to locate. Do not include the initial
        /// hyphen.
        /// @param aCaseSensitive Whether to do case-sensitive comparisons.
        /// @return               The position of the flag in the command line.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int FindFlag([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlag, [MarshalAs(UnmanagedType.Bool)] bool aCaseSensitive);
		
		/// <summary>
        /// Remove arguments from the command line. This normally occurs after
        /// a handler has processed the arguments.
        ///
        /// @param aStart  Index to begin removing.
        /// @param aEnd    Index to end removing, inclusive.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveArguments(int aStart, int aEnd);
		
		/// <summary>
        /// A helper method which will find a flag and remove it in one step.
        ///
        /// @param aFlag  The flag name to find and remove.
        /// @param aCaseSensitive Whether to do case-sensitive comparisons.
        /// @return       Whether the flag was found.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleFlag([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlag, [MarshalAs(UnmanagedType.Bool)] bool aCaseSensitive);
		
		/// <summary>
        /// Find a flag with a parameter and remove both. This is a helper
        /// method that combines "findFlag" and "removeArguments" in one step.
        ///
        /// @return   null (a void astring) if the flag is not found. The parameter value
        /// if found. Note that null and the empty string are not the same.
        /// @throws   NS_ERROR_INVALID_ARG if the flag exists without a parameter
        ///
        /// @param aFlag The flag name to find and remove.
        /// @param aCaseSensitive Whether to do case-sensitive flag search.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString HandleFlagWithParam([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlag, [MarshalAs(UnmanagedType.Bool)] bool aCaseSensitive);
		
		/// <summary>
        /// The type of command line being processed.
        ///
        /// STATE_INITIAL_LAUNCH  is the first launch of the application instance.
        /// STATE_REMOTE_AUTO     is a remote command line automatically redirected to
        /// this instance.
        /// STATE_REMOTE_EXPLICIT is a remote command line explicitly redirected to
        /// this instance using xremote/windde/appleevents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetStateAttribute();
		
		/// <summary>
        /// There may be a command-line handler which performs a default action if
        /// there was no explicit action on the command line (open a default browser
        /// window, for example). This flag allows the default action to be prevented.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPreventDefaultAttribute();
		
		/// <summary>
        /// There may be a command-line handler which performs a default action if
        /// there was no explicit action on the command line (open a default browser
        /// window, for example). This flag allows the default action to be prevented.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPreventDefaultAttribute([MarshalAs(UnmanagedType.Bool)] bool aPreventDefault);
		
		/// <summary>
        /// The working directory for this command line. Use this property instead
        /// of the working directory for the current process, since a redirected
        /// command line may have had a different working directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetWorkingDirectoryAttribute();
		
		/// <summary>
        /// A window to be targeted by this command line. In most cases, this will
        /// be null (xremote will sometimes set this attribute).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetWindowContextAttribute();
		
		/// <summary>
        /// Resolve a file-path argument into an nsIFile. This method gracefully
        /// handles relative or absolute file paths, according to the working
        /// directory of this command line.
        ///
        /// @param aArgument  The command-line argument to resolve.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile ResolveFile([MarshalAs(UnmanagedType.LPStruct)] nsAString aArgument);
		
		/// <summary>
        /// Resolves a URI argument into a URI. This method has platform-specific
        /// logic for converting an absolute URI or a relative file-path into the
        /// appropriate URI object; it gracefully handles win32 C:\ paths which would
        /// confuse the ioservice if passed directly.
        ///
        /// @param aArgument  The command-line argument to resolve.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI ResolveURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aArgument);
	}
}
