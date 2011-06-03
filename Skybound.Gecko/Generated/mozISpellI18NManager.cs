// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: mozISpellI18NManager.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file mozISpellI18NManager.idl
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
	
	
	/// <summary>mozISpellI18NManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AEB8936F-219C-4D3C-8385-D9382DAA551A")]
	public interface mozISpellI18NManager
	{
		
		/// <summary>Member GetUtil </summary>
		/// <param name='language'> </param>
		/// <returns>A mozISpellI18NUtil</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozISpellI18NUtil GetUtil([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string language);
	}
}
