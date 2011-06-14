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
// Generated by IDLImporter from file nsIRecyclingAllocator.idl
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
    ///
    /// nsIRecyclingAllocator: A wrapper for the nsRecyclingAllocator
    ///
    /// Holds allocations and reuses them for subsequent allocs.
    /// Thread safe and uses a timer to release freelist.
    ///
    /// @status UNDER_DEVELOPMENT
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d064a04c-9cee-4319-be31-64d565bccba9")]
	public interface nsIRecyclingAllocator : nsIMemory
	{
		
		/// <summary>
        /// Allocates a block of memory of a particular size. If the memory
        /// cannot be allocated (because of an out-of-memory condition), null
        /// is returned.
        ///
        /// @param size - the size of the block to allocate
        /// @result the block of memory
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr Alloc(uint size);
		
		/// <summary>
        /// Reallocates a block of memory to a new size.
        ///
        /// @param ptr - the block of memory to reallocate
        /// @param size - the new size
        /// @result the reallocated block of memory
        ///
        /// If ptr is null, this function behaves like malloc.
        /// If s is the size of the block to which ptr points, the first
        /// min(s, size) bytes of ptr's block are copied to the new block.
        /// If the allocation succeeds, ptr is freed and a pointer to the
        /// new block returned.  If the allocation fails, ptr is not freed
        /// and null is returned. The returned value may be the same as ptr.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr Realloc(System.IntPtr ptr, uint newSize);
		
		/// <summary>
        /// Frees a block of memory. Null is a permissible value, in which case
        /// nothing happens.
        ///
        /// @param ptr - the block of memory to free
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Free(System.IntPtr ptr);
		
		/// <summary>
        /// Attempts to shrink the heap.
        /// @param immediate - if true, heap minimization will occur
        /// immediately if the call was made on the main thread. If
        /// false, the flush will be scheduled to happen when the app is
        /// idle.
        /// @return NS_ERROR_FAILURE if 'immediate' is set an the call
        /// was not on the application's main thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HeapMinimize([MarshalAs(UnmanagedType.Bool)] bool immediate);
		
		/// <summary>
        /// This predicate can be used to determine if we're in a low-memory
        /// situation (what constitutes low-memory is platform dependent). This
        /// can be used to trigger the memory pressure observers.
        ///
        /// DEPRECATED - Always returns false.  See bug 592308.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsLowMemory();
		
		/// <summary>
        ///
        /// nsIRecyclingAllocator: A wrapper for the nsRecyclingAllocator
        ///
        /// Holds allocations and reuses them for subsequent allocs.
        /// Thread safe and uses a timer to release freelist.
        ///
        /// @status UNDER_DEVELOPMENT
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init(uint nblocks, uint recycleAfter, [MarshalAs(UnmanagedType.LPStr)] string id);
	}
}
