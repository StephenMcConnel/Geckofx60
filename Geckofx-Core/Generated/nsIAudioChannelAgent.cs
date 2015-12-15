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
// Generated by IDLImporter from file nsIAudioChannelAgent.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5fe83b24-38b9-4901-a4a1-d1bd57d3fe18")]
	public interface nsIAudioChannelAgentCallback
	{
		
		/// <summary>
        /// Notified when the window volume/mute is changed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WindowVolumeChanged(float aVolume, [MarshalAs(UnmanagedType.U1)] bool aMuted);
		
		/// <summary>
        /// Notified when the capture state is changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WindowAudioCaptureChanged();
	}
	
	/// <summary>
    /// This interface provides an agent for gecko components to participate
    /// in the audio channel service. Gecko components are responsible for
    /// 1. Indicating what channel type they are using (via the init() member
    /// function).
    /// 2. Before playing, checking the playable status of the channel.
    /// 3. Notifying the agent when they start/stop using this channel.
    /// 4. Notifying the agent of changes to the visibility of the component using
    /// this channel.
    ///
    /// The agent will invoke a callback to notify Gecko components of
    /// 1. Changes to the playable status of this channel.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("18222148-1b32-463d-b050-b741f43a07ba")]
	public interface nsIAudioChannelAgent
	{
		
		/// <summary>
        /// Before init() is called, this returns AUDIO_AGENT_CHANNEL_ERROR.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetAudioChannelTypeAttribute();
		
		/// <summary>
        /// Initialize the agent with a channel type.
        /// Note: This function should only be called once.
        ///
        /// @param window
        /// The window
        /// @param channelType
        /// Audio Channel Type listed as above
        /// @param callback
        /// 1. Once the playable status changes, agent uses this callback function
        /// to notify Gecko component.
        /// 2. The callback is allowed to be null. Ex: telephony doesn't need to
        /// listen change of the playable status.
        /// 3. The AudioChannelAgent keeps a strong reference to the callback
        /// object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, int channelType, [MarshalAs(UnmanagedType.Interface)] nsIAudioChannelAgentCallback callback);
		
		/// <summary>
        /// This method is just like init(), except the audio channel agent keeps a
        /// weak reference to the callback object.
        ///
        /// In order for this to work, |callback| must implement
        /// nsISupportsWeakReference.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithWeakCallback([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, int channelType, [MarshalAs(UnmanagedType.Interface)] nsIAudioChannelAgentCallback callback);
		
		/// <summary>
        /// Notify the agent that we want to start playing.
        /// Note: Gecko component SHOULD call this function first then start to
        /// play audio stream only when return value is true.
        ///
        /// @param notifyPlaying
        /// Whether to send audio-playback notifications, one of AUDIO_CHANNEL_NOTIFY
        /// or AUDIO_CHANNEL_DONT_NOTIFY.
        ///
        /// @return
        /// normal state: the agent has registered with audio channel service and
        /// the component should start playback.
        /// muted state: the agent has registered with audio channel service but
        /// the component should not start playback.
        /// faded state: the agent has registered with audio channel service the
        /// component should start playback as well as reducing the volume.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyStartedPlaying(uint notifyPlayback, ref float volume, [MarshalAs(UnmanagedType.U1)] ref bool muted);
		
		/// <summary>
        /// Notify the agent we no longer want to play.
        ///
        /// Note : even if notifyStartedPlaying() returned false, the agent would
        /// still be registered with the audio channel service and receive callbacks
        /// for status changes. So notifyStoppedPlaying must still eventually be
        /// called to unregister the agent with the channel service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyStoppedPlaying();
	}
	
	/// <summary>nsIAudioChannelAgentConsts </summary>
	public class nsIAudioChannelAgentConsts
	{
		
		// <summary>
        // This interface provides an agent for gecko components to participate
        // in the audio channel service. Gecko components are responsible for
        // 1. Indicating what channel type they are using (via the init() member
        // function).
        // 2. Before playing, checking the playable status of the channel.
        // 3. Notifying the agent when they start/stop using this channel.
        // 4. Notifying the agent of changes to the visibility of the component using
        // this channel.
        //
        // The agent will invoke a callback to notify Gecko components of
        // 1. Changes to the playable status of this channel.
        // </summary>
		public const long AUDIO_AGENT_CHANNEL_NORMAL = 0;
		
		// 
		public const long AUDIO_AGENT_CHANNEL_CONTENT = 1;
		
		// 
		public const long AUDIO_AGENT_CHANNEL_NOTIFICATION = 2;
		
		// 
		public const long AUDIO_AGENT_CHANNEL_ALARM = 3;
		
		// 
		public const long AUDIO_AGENT_CHANNEL_TELEPHONY = 4;
		
		// 
		public const long AUDIO_AGENT_CHANNEL_RINGER = 5;
		
		// 
		public const long AUDIO_AGENT_CHANNEL_PUBLICNOTIFICATION = 6;
		
		// 
		public const long AUDIO_AGENT_CHANNEL_SYSTEM = 7;
		
		// 
		public const long AUDIO_AGENT_CHANNEL_ERROR = 1000;
		
		// 
		public const long AUDIO_AGENT_STATE_NORMAL = 0;
		
		// 
		public const long AUDIO_AGENT_STATE_MUTED = 1;
		
		// 
		public const long AUDIO_AGENT_STATE_FADED = 2;
		
		// 
		public const long AUDIO_AGENT_DONT_NOTIFY = 0;
		
		// 
		public const long AUDIO_AGENT_NOTIFY = 1;
	}
}
