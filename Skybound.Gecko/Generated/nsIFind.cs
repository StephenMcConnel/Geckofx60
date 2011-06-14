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
// Generated by IDLImporter from file nsIFind.idl
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
	
	
	/// <summary>nsIFind </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("75125d55-37ee-4575-b9b5-f33bfa68c2a1")]
	public interface nsIFind
	{
		
		/// <summary>Member GetFindBackwardsAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFindBackwardsAttribute();
		
		/// <summary>Member SetFindBackwardsAttribute </summary>
		/// <param name='aFindBackwards'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFindBackwardsAttribute([MarshalAs(UnmanagedType.Bool)] bool aFindBackwards);
		
		/// <summary>Member GetCaseSensitiveAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCaseSensitiveAttribute();
		
		/// <summary>Member SetCaseSensitiveAttribute </summary>
		/// <param name='aCaseSensitive'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaseSensitiveAttribute([MarshalAs(UnmanagedType.Bool)] bool aCaseSensitive);
		
		/// <summary>
        /// Use "find entire words" mode by setting to a word breaker
        /// or null, to disable "entire words" mode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetWordBreakerAttribute();
		
		/// <summary>
        /// Use "find entire words" mode by setting to a word breaker
        /// or null, to disable "entire words" mode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWordBreakerAttribute(System.IntPtr aWordBreaker);
		
		/// <summary>
        /// Find some text in the current context. The implementation is
        /// responsible for performing the find and highlighting the text.
        ///
        /// @param aPatText     The text to search for.
        /// @param aSearchRange A Range specifying domain of search.
        /// @param aStartPoint  A Range specifying search start point.
        /// If not collapsed, we'll start from
        /// end (forward) or start (backward).
        /// @param aEndPoint    A Range specifying search end point.
        /// If not collapsed, we'll end at
        /// end (forward) or start (backward).
        /// @retval             A range spanning the match that was found (or null).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange Find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPatText, [MarshalAs(UnmanagedType.Interface)] nsIDOMRange aSearchRange, [MarshalAs(UnmanagedType.Interface)] nsIDOMRange aStartPoint, [MarshalAs(UnmanagedType.Interface)] nsIDOMRange aEndPoint);
	}
}
