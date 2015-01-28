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
// Generated by IDLImporter from file nsITCPSocketParent.idl
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
    /// is written in C++.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("868662a4-681c-4b89-9f02-6fe5b7ace265")]
	public interface nsITCPSocketParent
	{
		
		/// <summary>
        /// is written in C++.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitJS(ref Gecko.JsVal intermediary, System.IntPtr jsContext);
		
		/// <summary>
        ///        Current ready state.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, ref Gecko.JsVal data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase readyState, System.IntPtr jsContext);
		
		/// <summary>
        ///        Intermediate class object. See nsITCPSocketIntermediary.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSocketAndIntermediary([MarshalAs(UnmanagedType.Interface)] nsIDOMTCPSocket socket, [MarshalAs(UnmanagedType.Interface)] nsITCPSocketIntermediary intermediary, System.IntPtr jsContext);
		
		/// <summary>
        ///        to the latest call of send().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendUpdateBufferedAmount(uint bufferedAmount, uint trackingNumber);
	}
	
	/// <summary>
    /// implements nsITCPSocketIntermediary in Javascript.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c434224a-dbb7-4869-8b2b-e49cee990e85")]
	public interface nsITCPSocketIntermediary
	{
		
		/// <summary>
        /// Open the connection to the server with the given parameters
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTCPSocket Open([MarshalAs(UnmanagedType.Interface)] nsITCPSocketParent parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase host, ushort port, [MarshalAs(UnmanagedType.U1)] bool useSSL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase binaryType, uint appId);
		
		/// <summary>
        /// Listen on a port
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTCPServerSocket Listen([MarshalAs(UnmanagedType.Interface)] nsITCPServerSocketParent parent, ushort port, ushort backlog, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase binaryType);
		
		/// <summary>
        /// Called when received a child request to send a string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnRecvSendString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data, uint trackingNumber);
		
		/// <summary>
        /// Called when received a child request to send an array buffer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnRecvSendArrayBuffer(ref Gecko.JsVal data, uint trackingNumber);
	}
}
