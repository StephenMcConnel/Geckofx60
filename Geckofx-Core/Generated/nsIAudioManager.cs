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
// Generated by IDLImporter from file nsIAudioManager.idl
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
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("df31c280-1ef1-11e5-867f-0800200c9a66")]
	public interface nsIAudioManager
	{
		
		/// <summary>
        /// Microphone muted?
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMicrophoneMutedAttribute();
		
		/// <summary>
        /// Microphone muted?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMicrophoneMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aMicrophoneMuted);
		
		/// <summary>
        /// Are we playing audio from the FM radio?
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFmRadioAudioEnabledAttribute();
		
		/// <summary>
        /// Are we playing audio from the FM radio?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFmRadioAudioEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aFmRadioAudioEnabled);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPhoneStateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPhoneStateAttribute(int aPhoneState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetForceForUse(int usage, int force);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetForceForUse(int usage);
		
		/// <summary>
        /// These functions would be used when we enable the new volume control API
        /// (mozAudioChannelManager). The range of volume index is from 0 to N.
        /// More details on : https://gist.github.com/evanxd/41d8e2d91c5201a42bfa
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAudioChannelVolume(uint channel, uint index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAudioChannelVolume(uint channel);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMaxAudioChannelVolume(uint channel);
	}
	
	/// <summary>nsIAudioManagerConsts </summary>
	public class nsIAudioManagerConsts
	{
		
		// <summary>
        // Set the phone's audio mode.
        // </summary>
		public const long PHONE_STATE_INVALID = -2;
		
		// 
		public const long PHONE_STATE_CURRENT = -1;
		
		// 
		public const long PHONE_STATE_NORMAL = 0;
		
		// 
		public const long PHONE_STATE_RINGTONE = 1;
		
		// 
		public const long PHONE_STATE_IN_CALL = 2;
		
		// 
		public const long PHONE_STATE_IN_COMMUNICATION = 3;
		
		// <summary>
        // Configure a particular device ("force") to be used for one of the uses
        // (communication, media playback, etc.)
        // </summary>
		public const long FORCE_NONE = 0;
		
		// <summary>
        // the default
        // </summary>
		public const long FORCE_SPEAKER = 1;
		
		// 
		public const long FORCE_HEADPHONES = 2;
		
		// 
		public const long FORCE_BT_SCO = 3;
		
		// 
		public const long FORCE_BT_A2DP = 4;
		
		// 
		public const long FORCE_WIRED_ACCESSORY = 5;
		
		// 
		public const long FORCE_BT_CAR_DOCK = 6;
		
		// 
		public const long FORCE_BT_DESK_DOCK = 7;
		
		// 
		public const long FORCE_ANALOG_DOCK = 8;
		
		// 
		public const long FORCE_DIGITAL_DOCK = 9;
		
		// 
		public const long FORCE_NO_BT_A2DP = 10;
		
		// 
		public const long USE_COMMUNICATION = 0;
		
		// 
		public const long USE_MEDIA = 1;
		
		// 
		public const long USE_RECORD = 2;
		
		// 
		public const long USE_DOCK = 3;
	}
}
