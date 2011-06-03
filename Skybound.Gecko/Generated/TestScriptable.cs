// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: TestScriptable.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file TestScriptable.idl
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
	
	
	/// <summary>testScriptableInterface </summary>
	[ComImport()]
	[Guid("76d74662-0eae-404c-9d1f-697c0e321c0a")]
	public interface testScriptableInterface
	{
		
		/// <summary>Member GetScriptable_attr1Attribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetScriptable_attr1Attribute();
		
		/// <summary>Member GetScriptable_attr2Attribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetScriptable_attr2Attribute();
		
		/// <summary>Member SetScriptable_attr2Attribute </summary>
		/// <param name='aScriptable_attr2'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScriptable_attr2Attribute(System.Int32  aScriptable_attr2);
		
		/// <summary>Member GetNotscriptable_attr1Attribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetNotscriptable_attr1Attribute();
		
		/// <summary>Member GetNotscriptable_attr2Attribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetNotscriptable_attr2Attribute();
		
		/// <summary>Member SetNotscriptable_attr2Attribute </summary>
		/// <param name='aNotscriptable_attr2'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNotscriptable_attr2Attribute(System.Int32  aNotscriptable_attr2);
		
		/// <summary>Member Scriptable_method1 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Scriptable_method1();
		
		/// <summary>Member Notscriptable_method1 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Notscriptable_method1();
		
		/// <summary>Member Notscriptable_method2 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Notscriptable_method2();
		
		/// <summary>Member Notscriptable_method3 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Notscriptable_method3();
	}
	
	/// <summary>testNotscriptableInterface </summary>
	[ComImport()]
	[Guid("76d74662-0eae-404c-9d1f-697c0e321c0a")]
	public interface testNotscriptableInterface
	{
		
		/// <summary>Member GetNotscriptable_attr1Attribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetNotscriptable_attr1Attribute();
		
		/// <summary>Member GetNotscriptable_attr2Attribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetNotscriptable_attr2Attribute();
		
		/// <summary>Member SetNotscriptable_attr2Attribute </summary>
		/// <param name='aNotscriptable_attr2'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNotscriptable_attr2Attribute(System.Int32  aNotscriptable_attr2);
		
		/// <summary>Member Notscriptable_method1 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Notscriptable_method1();
	}
}
