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
// Generated by IDLImporter from file nsIXTFElement.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>nsIXTFElement </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4f144387-796d-4baf-8641-5db45dba1808")]
	public interface nsIXTFElement
	{
		
		/// <summary>
        /// (i.e. holding a reference to this will not create a cycle).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnCreated([MarshalAs(UnmanagedType.Interface)] nsIXTFElementWrapper wrapper);
		
		/// <summary>
        /// called when the wrapper object is being destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDestroyed();
		
		/// <summary>
        /// onCreated()-calls until after onDestroyed()-calls).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsAttributeHandlerAttribute();
		
		/// <summary>
        /// @note 'Normal' DOM interfaces are always automatically scriptable.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScriptingInterfaces(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.Guid[] array);
		
		/// <summary>
        /// Event notifications:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillChangeDocument([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument newDoc);
		
		/// <summary>Member DocumentChanged </summary>
		/// <param name='newDoc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DocumentChanged([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument newDoc);
		
		/// <summary>Member WillChangeParent </summary>
		/// <param name='newParent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillChangeParent([MarshalAs(UnmanagedType.Interface)] nsIDOMElement newParent);
		
		/// <summary>Member ParentChanged </summary>
		/// <param name='newParent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParentChanged([MarshalAs(UnmanagedType.Interface)] nsIDOMElement newParent);
		
		/// <summary>Member WillInsertChild </summary>
		/// <param name='child'> </param>
		/// <param name='index'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillInsertChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode child, uint index);
		
		/// <summary>Member ChildInserted </summary>
		/// <param name='child'> </param>
		/// <param name='index'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ChildInserted([MarshalAs(UnmanagedType.Interface)] nsIDOMNode child, uint index);
		
		/// <summary>Member WillAppendChild </summary>
		/// <param name='child'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillAppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode child);
		
		/// <summary>Member ChildAppended </summary>
		/// <param name='child'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ChildAppended([MarshalAs(UnmanagedType.Interface)] nsIDOMNode child);
		
		/// <summary>Member WillRemoveChild </summary>
		/// <param name='index'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillRemoveChild(uint index);
		
		/// <summary>Member ChildRemoved </summary>
		/// <param name='index'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ChildRemoved(uint index);
		
		/// <summary>Member WillSetAttribute </summary>
		/// <param name='name'> </param>
		/// <param name='newValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillSetAttribute([MarshalAs(UnmanagedType.Interface)] nsIAtom name, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase newValue);
		
		/// <summary>Member AttributeSet </summary>
		/// <param name='name'> </param>
		/// <param name='newValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AttributeSet([MarshalAs(UnmanagedType.Interface)] nsIAtom name, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase newValue);
		
		/// <summary>Member WillRemoveAttribute </summary>
		/// <param name='name'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillRemoveAttribute([MarshalAs(UnmanagedType.Interface)] nsIAtom name);
		
		/// <summary>Member AttributeRemoved </summary>
		/// <param name='name'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AttributeRemoved([MarshalAs(UnmanagedType.Interface)] nsIAtom name);
		
		/// <summary>
        /// added to the element.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginAddingChildren();
		
		/// <summary>Member DoneAddingChildren </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoneAddingChildren();
		
		/// <summary>
        /// other default handlers won't be able to handle it again.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleDefault([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aEvent);
		
		/// <summary>
        /// other needed state.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CloneState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// Returns accesskey attribute node.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr GetAccesskeyNodeAttribute();
		
		/// <summary>
        /// Performs accesskey. The method is called when accesskey is activated.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PerformAccesskey();
	}
}
