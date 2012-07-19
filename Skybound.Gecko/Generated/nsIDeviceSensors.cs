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
// Generated by IDLImporter from file nsIDeviceSensors.idl
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

	
	
	/// <summary>nsIDeviceSensorData </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1B406E32-CF42-471E-A470-6FD600BF4C7B")]
	public interface nsIDeviceSensorData
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTypeAttribute();
		
		/// <summary>Member GetXAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetXAttribute();
		
		/// <summary>Member GetYAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetYAttribute();
		
		/// <summary>Member GetZAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetZAttribute();
	}
	
	/// <summary>nsIDeviceSensorDataConsts </summary>
	public class nsIDeviceSensorDataConsts
	{
		
		// <summary>
        // Keep in sync with hal/HalSensor.h
        // </summary>
		public const ulong TYPE_ORIENTATION = 0;
		
		// 
		public const ulong TYPE_ACCELERATION = 1;
		
		// 
		public const ulong TYPE_PROXIMITY = 2;
		
		// 
		public const ulong TYPE_LINEAR_ACCELERATION = 3;
		
		// 
		public const ulong TYPE_GYROSCOPE = 4;
	}
	
	/// <summary>nsIDeviceSensors </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b672bfe0-4479-4094-a9ef-1b6847720d07")]
	public interface nsIDeviceSensors
	{
		
		/// <summary>
        /// to call RemoveWindowListener before the window is deleted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWindowListener(uint aType, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>Member RemoveWindowListener </summary>
		/// <param name='aType'> </param>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWindowListener(uint aType, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>Member RemoveWindowAsListener </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWindowAsListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
	}
}
