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
// Generated by IDLImporter from file nsIXTFPrivate.idl
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
    /// This interface can be used to give access to a private 'inner'
    /// interface when an xtf element is accessed through its wrapper (or
    /// more precisely: accessed through one of the wrapper-generated
    /// nsXTFInterfaceAggregator proxies). For JS-implemented XTF elements
    /// the inner interface can be used to gain access to the underlying
    /// JSObject using xpconnect's "wrappedJSObject" mechanism (see
    /// nsIXPConnect.idl).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("13ef3d54-1dd1-4a5c-a8d5-a04a327fb9b6")]
	public interface nsIXTFPrivate
	{
		
		/// <summary>
        /// This interface can be used to give access to a private 'inner'
        /// interface when an xtf element is accessed through its wrapper (or
        /// more precisely: accessed through one of the wrapper-generated
        /// nsXTFInterfaceAggregator proxies). For JS-implemented XTF elements
        /// the inner interface can be used to gain access to the underlying
        /// JSObject using xpconnect's "wrappedJSObject" mechanism (see
        /// nsIXPConnect.idl).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports  GetInnerAttribute();
	}
}
