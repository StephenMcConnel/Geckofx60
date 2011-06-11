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
// Generated by IDLImporter from file nsITransactionList.idl
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
    /// The nsITransactionList interface.
    /// <P>
    /// The implementation for this interface is provided by the Transaction Manager.
    /// This interface provides a mechanism for accessing the transactions on the
    /// Undo or Redo stacks as well as any auto-aggregated children that a
    /// transaction may have.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("97f863f3-f886-11d4-9d39-0060b0f8baff")]
	public interface nsITransactionList
	{
		
		/// <summary>
        /// The number of transactions contained in this list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetNumItemsAttribute();
		
		/// <summary>
        /// itemIsBatch() returns true if the item at aIndex is a batch. Note that
        /// currently there is no requirement for a TransactionManager implementation
        /// to associate a toplevel nsITransaction with a batch so it is possible for
        /// itemIsBatch() to return true and getItem() to return null. However, you
        /// can still access the transactions contained in the batch with a call to
        /// getChildListForItem().
        /// @param aIndex The index of the item in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ItemIsBatch(System.Int32  aIndex);
		
		/// <summary>
        /// getItem() returns the transaction at the given index in the list. Note that
        /// a null can be returned here if the item is a batch. The transaction
        /// returned is AddRef'd so it is up to the caller to Release the transaction
        /// when it is done.
        /// @param aIndex The index of the item in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransaction GetItem(System.Int32  aIndex);
		
		/// <summary>
        /// getNumChildrenForItem() returns the number of child (auto-aggreated)
        /// transactions the item at aIndex has.
        /// @param aIndex The index of the item in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumChildrenForItem(System.Int32  aIndex);
		
		/// <summary>
        /// getChildListForItem() returns the list of children associated with the
        /// item at aIndex. Implementations may return null if there are no children,
        /// or an empty list. The list returned is AddRef'd so it is up to the caller
        /// to Release the transaction when it is done.
        /// @param aIndex The index of the item in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransactionList GetChildListForItem(System.Int32  aIndex);
	}
}
