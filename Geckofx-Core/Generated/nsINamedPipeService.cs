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
// Generated by IDLImporter from file nsINamedPipeService.idl
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
    /// nsINamedPipeDataObserver
    ///
    /// This is the callback interface for nsINamedPipeService.
    /// The functions are called by the internal thread in the nsINamedPipeService.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("de4f460b-94fd-442c-9002-1637beb2185a")]
	public interface nsINamedPipeDataObserver
	{
		
		/// <summary>
        /// onDataAvailable
        ///
        /// @param aBytesTransferred
        /// Transfered bytes during last transmission.
        /// @param aOverlapped
        /// Corresponding overlapped structure used by the async I/O
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDataAvailable(uint aBytesTransferred, System.IntPtr aOverlapped);
		
		/// <summary>
        /// onError
        ///
        /// @param aError
        /// Error code of the error.
        /// @param aOverlapped
        /// Corresponding overlapped structure used by the async I/O
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnError(uint aError, System.IntPtr aOverlapped);
	}
	
	/// <summary>
    /// nsINamedPipeService
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1bf19133-5625-4ac8-836a-80b1c215f72b")]
	public interface nsINamedPipeService
	{
		
		/// <summary>
        /// addDataObserver
        ///
        /// @param aHandle
        /// The handle that is going to be monitored for read/write operations.
        /// Only handles that are opened with overlapped IO are supported.
        /// @param aObserver
        /// The observer of the handle, the service strong-refs of the observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDataObserver(System.IntPtr aHandle, [MarshalAs(UnmanagedType.Interface)] nsINamedPipeDataObserver aObserver);
		
		/// <summary>
        /// removeDataObserver
        ///
        /// @param aHandle
        ///              The handle associated to the observer, and will be closed by the
        ///              service.
        /// @param aObserver
        /// The observer to be removed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDataObserver(System.IntPtr aHandle, [MarshalAs(UnmanagedType.Interface)] nsINamedPipeDataObserver aObserver);
		
		/// <summary>
        /// isOnCurrentThread
        ///
        /// @return the caller runs within the internal thread.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsOnCurrentThread();
	}
}