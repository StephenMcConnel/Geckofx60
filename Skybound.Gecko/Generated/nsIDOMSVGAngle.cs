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
// Generated by IDLImporter from file nsIDOMSVGAngle.idl
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
    /// The nsIDOMSVGAngle interface is the interface to an SVG angle.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/SVG11/types.html#InterfaceSVGAngle
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("58b6190e-37b3-412a-ba02-1d5ad6c6ea7c")]
	public interface nsIDOMSVGAngle
	{
		
		/// <summary>
        /// Angle Unit Types
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetUnitTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetValueAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAttribute(double aValue);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetValueInSpecifiedUnitsAttribute();
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueInSpecifiedUnitsAttribute(double aValueInSpecifiedUnits);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAsStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValueAsString);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAsStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValueAsString);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NewValueSpecifiedUnits(ushort unitType, double valueInSpecifiedUnits);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertToSpecifiedUnits(ushort unitType);
	}
}
