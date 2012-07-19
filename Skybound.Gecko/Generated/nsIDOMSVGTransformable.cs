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
// Generated by IDLImporter from file nsIDOMSVGTransformable.idl
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

	
	
	/// <summary>nsIDOMSVGTransformable </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b81f6e37-1842-4534-a546-1ab86e59a3c6")]
	public interface nsIDOMSVGTransformable : nsIDOMSVGLocatable
	{
		
		/// <summary>Member GetNearestViewportElementAttribute </summary>
		/// <returns>A nsIDOMSVGElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGElement GetNearestViewportElementAttribute();
		
		/// <summary>Member GetFarthestViewportElementAttribute </summary>
		/// <returns>A nsIDOMSVGElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGElement GetFarthestViewportElementAttribute();
		
		/// <summary>Member GetBBox </summary>
		/// <returns>A nsIDOMSVGRect</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGRect GetBBox();
		
		/// <summary>Member GetCTM </summary>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGMatrix GetCTM();
		
		/// <summary>Member GetScreenCTM </summary>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGMatrix GetScreenCTM();
		
		/// <summary>Member GetTransformToElement </summary>
		/// <param name='element'> </param>
		/// <returns>A nsIDOMSVGMatrix</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMSVGMatrix GetTransformToElement([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGElement element);
		
		/// <summary>Member GetTransformAttribute </summary>
		/// <returns>A nsIDOMSVGAnimatedTransformList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGAnimatedTransformList GetTransformAttribute();
	}
}
