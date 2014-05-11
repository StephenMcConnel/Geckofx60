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
// Generated by IDLImporter from file nsIDOMUserDataHandler.idl
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
    /// Introduced in DOM Level 3:
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("91afebdd-a201-4db0-b728-9d59580f0cfd")]
	public interface nsIDOMUserDataHandler
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Handle(ushort operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase key, [MarshalAs(UnmanagedType.Interface)] nsIVariant data, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode src, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode dst);
	}
	
	/// <summary>nsIDOMUserDataHandlerConsts </summary>
	public class nsIDOMUserDataHandlerConsts
	{
		
		// <summary>
        // OperationType
        // </summary>
		public const ulong NODE_CLONED = 1;
		
		// 
		public const ulong NODE_IMPORTED = 2;
		
		// 
		public const ulong NODE_DELETED = 3;
		
		// 
		public const ulong NODE_RENAMED = 4;
		
		// 
		public const ulong NODE_ADOPTED = 5;
	}
}
