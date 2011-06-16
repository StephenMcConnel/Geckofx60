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
// Generated by IDLImporter from file nsIPrintProgressParams.idl
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
	
	
	/// <summary>nsIPrintProgressParams </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("CA89B55B-6FAF-4051-9645-1C03EF5108F8")]
	public interface nsIPrintProgressParams
	{
		
		/// <summary>
        ///message subject </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDocTitleAttribute();
		
		/// <summary>
        ///message subject </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aDocTitle);
		
		/// <summary>Member GetDocURLAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDocURLAttribute();
		
		/// <summary>Member SetDocURLAttribute </summary>
		/// <param name='aDocURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aDocURL);
	}
}
