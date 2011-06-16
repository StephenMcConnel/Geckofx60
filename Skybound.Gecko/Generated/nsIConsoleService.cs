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
// Generated by IDLImporter from file nsIConsoleService.idl
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
	
	
	/// <summary>nsIConsoleService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("883472a0-ea9b-11da-8ad9-0800200c9a66")]
	public interface nsIConsoleService
	{
		
		/// <summary>Member LogMessage </summary>
		/// <param name='message'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogMessage([MarshalAs(UnmanagedType.Interface)] nsIConsoleMessage message);
		
		/// <summary>
        /// Convenience method for logging simple messages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogStringMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string message);
		
		/// <summary>
        /// Get an array of all the messages logged so far.  If no messages
        /// are logged, this function will return a count of 0, but still
        /// will allocate one word for messages, so as to show up as a
        /// 0-length array when called from script.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMessageArray(out nsIConsoleMessage messages, out uint count);
		
		/// <summary>
        /// To guard against stack overflows from listeners that could log
        /// messages (it's easy to do this inadvertently from listeners
        /// implemented in JavaScript), we don't call any listeners when
        /// another error is already being logged.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterListener([MarshalAs(UnmanagedType.Interface)] nsIConsoleListener listener);
		
		/// <summary>
        /// Each registered listener should also be unregistered.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterListener([MarshalAs(UnmanagedType.Interface)] nsIConsoleListener listener);
		
		/// <summary>
        /// Clear the message buffer (e.g. for privacy reasons).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reset();
	}
}
