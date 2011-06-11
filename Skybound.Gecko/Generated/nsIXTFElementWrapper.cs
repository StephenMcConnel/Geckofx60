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
// Generated by IDLImporter from file nsIXTFElementWrapper.idl
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
	
	
	/// <summary>nsIXTFElementWrapper </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3697f9ed-d8bc-4c00-890f-7a702d5b4005")]
	public interface nsIXTFElementWrapper
	{
		
		/// <summary>Member GetElementNodeAttribute </summary>
		/// <returns>A nsIDOMElement </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement  GetElementNodeAttribute();
		
		/// <summary>Member GetDocumentFrameElementAttribute </summary>
		/// <returns>A nsIDOMElement </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement  GetDocumentFrameElementAttribute();
		
		/// <summary>
        /// Events can be unmasked by setting the corresponding bit as given
        /// by the NOTIFY_* constants in nsIXTFElement:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetNotificationMaskAttribute();
		
		/// <summary>
        /// Events can be unmasked by setting the corresponding bit as given
        /// by the NOTIFY_* constants in nsIXTFElement:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNotificationMaskAttribute(System.UInt32  aNotificationMask);
		
		/// <summary>
        /// Sets the intrinsic state for the element.
        /// @see nsIContent::IntrinsicState().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIntrinsicState(System.UInt32  newState);
		
		/// <summary>
        /// This sets the name of the class attribute.
        /// Should be called only during ::onCreated.
        /// Note! nsIXTFAttributeHandler can't be used to handle class attribute.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClassAttributeName([MarshalAs(UnmanagedType.Interface)] nsIAtom  name);
	}
}
