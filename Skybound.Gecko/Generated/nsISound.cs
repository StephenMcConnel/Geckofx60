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
// Generated by IDLImporter from file nsISound.idl
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
	
	
	/// <summary>nsISound </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("86B75B05-DB60-4c3e-97A7-82B363A41A01")]
	public interface nsISound
	{
		
		/// <summary>Member Play </summary>
		/// <param name='aURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Play([MarshalAs(UnmanagedType.Interface)] nsIURL  aURL);
		
		/// <summary>
        /// for playing system sounds
        ///
        /// NS_SYSSOUND_* params are obsolete. The new events will not be supported by
        /// this method.  You should use playEventSound method instaed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PlaySystemSound([MarshalAs(UnmanagedType.LPStruct)] nsAString soundAlias);
		
		/// <summary>Member Beep </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Beep();
		
		/// <summary>
        /// Not strictly necessary, but avoids delay before first sound.
        /// The various methods on nsISound call Init() if they need to.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		/// <summary>
        /// In some situations, playEventSound will be called.  Then, each
        /// implementations will play a system sound for the event if it's necessary.
        ///
        /// NOTE: Don't change these values because they are used in
        /// nsPIPromptService.idl. So, if they are changed, that makes big impact for
        /// the embedders.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PlayEventSound(System.UInt32  aEventId);
	}
}
