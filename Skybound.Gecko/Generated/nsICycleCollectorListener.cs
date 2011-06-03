// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsICycleCollectorListener.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsICycleCollectorListener.idl
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
	
	
	/// <summary>nsICycleCollectorListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("194b749a-4ceb-4dd1-928d-d30b5f14c23e")]
	public interface nsICycleCollectorListener
	{
		
		/// <summary>Member Begin </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Begin();
		
		/// <summary>Member NoteObject </summary>
		/// <param name='aAddress'> </param>
		/// <param name='aObjectDescription'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NoteObject(System.UInt32  aAddress, [MarshalAs(UnmanagedType.LPStr)] System.String  aObjectDescription);
		
		/// <summary>Member NoteEdge </summary>
		/// <param name='aFromAddress'> </param>
		/// <param name='aToAddress'> </param>
		/// <param name='aEdgeName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NoteEdge(System.UInt32  aFromAddress, System.UInt32  aToAddress, [MarshalAs(UnmanagedType.LPStr)] System.String  aEdgeName);
		
		/// <summary>Member BeginDescriptions </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginDescriptions();
		
		/// <summary>Member DescribeRefcountedObject </summary>
		/// <param name='aAddress'> </param>
		/// <param name='aKnownEdges'> </param>
		/// <param name='aTotalEdges'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DescribeRefcountedObject(System.UInt32  aAddress, System.UInt32  aKnownEdges, System.UInt32  aTotalEdges);
		
		/// <summary>Member DescribeGCedObject </summary>
		/// <param name='aAddress'> </param>
		/// <param name='aMarked'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DescribeGCedObject(System.UInt32  aAddress, System.Boolean  aMarked);
		
		/// <summary>Member End </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void End();
	}
}
