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
// Generated by IDLImporter from file nsIAccelerometer.idl
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
	
	
	/// <summary>nsIAcceleration </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1B406E32-CF42-471E-A470-6FD600BF4C7B")]
	public interface nsIAcceleration
	{
		
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
	
	/// <summary>nsIAccelerationListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3386BED8-7393-4704-8FFC-1EB2C35432FF")]
	public interface nsIAccelerationListener
	{
		
		/// <summary>Member OnAccelerationChange </summary>
		/// <param name='aAcceleration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAccelerationChange([MarshalAs(UnmanagedType.Interface)] nsIAcceleration aAcceleration);
	}
	
	/// <summary>nsIAccelerometer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4B04E228-0B33-43FC-971F-AF60CEDB1C21")]
	public interface nsIAccelerometer
	{
		
		/// <summary>Member AddListener </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddListener([MarshalAs(UnmanagedType.Interface)] nsIAccelerationListener aListener);
		
		/// <summary>Member RemoveListener </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIAccelerationListener aListener);
		
		/// <summary>Member AddWindowListener </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWindowListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>Member RemoveWindowListener </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWindowListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
	}
	
	/// <summary>
    ///for use by IPC system to notify non-chrome processes of
    /// accelerometer events
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("22dd1d8a-51bf-406f-8b6d-d1919f8f1c7d")]
	public interface nsIAccelerometerUpdate : nsIAccelerometer
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddListener([MarshalAs(UnmanagedType.Interface)] nsIAccelerationListener aListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIAccelerationListener aListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddWindowListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveWindowListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        ///must be called on the main thread or else </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AccelerationChanged(double x, double y, double z);
	}
}
