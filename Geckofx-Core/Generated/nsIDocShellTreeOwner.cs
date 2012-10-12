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
// Generated by IDLImporter from file nsIDocShellTreeOwner.idl
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
    /// The nsIDocShellTreeOwner
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("932f9f93-8e21-4728-a527-cafc64b4d831")]
	public interface nsIDocShellTreeOwner
	{
		
		/// <summary>
        ///Return the child DocShellTreeItem with the specified name.
        ///	name - This is the name of the item that is trying to be found.
        ///	aRequestor - This is the docshellTreeItem that is requesting the find.  This
        ///	parameter is used to identify when the child is asking its parent to find
        ///	a child with the specific name.  The parent uses this parameter to ensure
        ///	a resursive state does not occur by not again asking the requestor for find
        ///	a shell by the specified name.  Inversely the child uses it to ensure it
        ///	does not ask its parent to do the search if its parent is the one that
        ///	asked it to search.
        ///	aOriginalRequestor - The original treeitem that made the request, if any.
        ///	This is used to ensure that we don't run into cross-site issues.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string name, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);
		
		/// <summary>
        /// Called when a content shell is added to the docshell tree.  This is
        /// _only_ called for "root" content shells (that is, ones whose parent is a
        /// chrome shell).
        ///
        /// @param aContentShell the shell being added.
        /// @param aPrimary whether the shell is primary.
        /// @param aTargetable whether the shell can be a target for named window
        /// targeting.
        /// @param aID the "id" of the shell.  What this actually means is
        /// undefined. Don't rely on this for anything.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ContentShellAdded([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aContentShell, [MarshalAs(UnmanagedType.U1)] bool aPrimary, [MarshalAs(UnmanagedType.U1)] bool aTargetable, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aID);
		
		/// <summary>
        /// Called when a content shell is removed from the docshell tree.  This is
        /// _only_ called for "root" content shells (that is, ones whose parent is a
        /// chrome shell).  Note that if aContentShell was never added,
        /// contentShellRemoved should just do nothing.
        ///
        /// @param aContentShell the shell being removed.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ContentShellRemoved([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aContentShell);
		
		/// <summary>
        ///Returns the Primary Content Shell
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetPrimaryContentShellAttribute();
		
		/// <summary>
        ///Tells the tree owner to size its window or parent window in such a way
        ///	that the shell passed along will be the size specified.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SizeShellTo([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem shell, int cx, int cy);
		
		/// <summary>
        ///Sets the persistence of different attributes of the window.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistence([MarshalAs(UnmanagedType.U1)] bool aPersistPosition, [MarshalAs(UnmanagedType.U1)] bool aPersistSize, [MarshalAs(UnmanagedType.U1)] bool aPersistSizeMode);
		
		/// <summary>
        ///Gets the current persistence states of the window.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPersistence([MarshalAs(UnmanagedType.U1)] ref bool aPersistPosition, [MarshalAs(UnmanagedType.U1)] ref bool aPersistSize, [MarshalAs(UnmanagedType.U1)] ref bool aPersistSizeMode);
		
		/// <summary>
        ///Gets the number of targettable docshells.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTargetableShellCountAttribute();
	}
}
