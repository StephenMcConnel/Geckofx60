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
// Generated by IDLImporter from file nsIDOM3EventTarget.idl
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
    /// The nsIDOMEventTarget interface is the interface implemented by all
    /// event targets in the Document Object Model.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/DOM-Level-3-Events/
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3e9c01a7-de97-4c3b-8294-b4bd9d7056d1")]
	public interface nsIDOM3EventTarget
	{
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddGroupedEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, bool useCapture, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventGroup evtGroup);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveGroupedEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, bool useCapture, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventGroup evtGroup);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanTrigger([MarshalAs(UnmanagedType.LPStruct)] nsAString type);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsRegisteredHere([MarshalAs(UnmanagedType.LPStruct)] nsAString type);
	}
}
