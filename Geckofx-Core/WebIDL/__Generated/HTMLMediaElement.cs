namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMediaElement : WebIDLBase
    {
        
        public HTMLMediaElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Error
        {
            get
            {
                return this.GetProperty<nsISupports>("error");
            }
        }
        
        public string Src
        {
            get
            {
                return this.GetProperty<string>("src");
            }
            set
            {
                this.SetProperty("src", value);
            }
        }
        
        public string CurrentSrc
        {
            get
            {
                return this.GetProperty<string>("currentSrc");
            }
        }
        
        public string CrossOrigin
        {
            get
            {
                return this.GetProperty<string>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
        
        public ushort NetworkState
        {
            get
            {
                return this.GetProperty<ushort>("networkState");
            }
        }
        
        public string Preload
        {
            get
            {
                return this.GetProperty<string>("preload");
            }
            set
            {
                this.SetProperty("preload", value);
            }
        }
        
        public nsISupports Buffered
        {
            get
            {
                return this.GetProperty<nsISupports>("buffered");
            }
        }
        
        public ushort ReadyState
        {
            get
            {
                return this.GetProperty<ushort>("readyState");
            }
        }
        
        public bool Seeking
        {
            get
            {
                return this.GetProperty<bool>("seeking");
            }
        }
        
        public double CurrentTime
        {
            get
            {
                return this.GetProperty<double>("currentTime");
            }
            set
            {
                this.SetProperty("currentTime", value);
            }
        }
        
        public double Duration
        {
            get
            {
                return this.GetProperty<double>("duration");
            }
        }
        
        public bool IsEncrypted
        {
            get
            {
                return this.GetProperty<bool>("isEncrypted");
            }
        }
        
        public bool Paused
        {
            get
            {
                return this.GetProperty<bool>("paused");
            }
        }
        
        public double DefaultPlaybackRate
        {
            get
            {
                return this.GetProperty<double>("defaultPlaybackRate");
            }
            set
            {
                this.SetProperty("defaultPlaybackRate", value);
            }
        }
        
        public double PlaybackRate
        {
            get
            {
                return this.GetProperty<double>("playbackRate");
            }
            set
            {
                this.SetProperty("playbackRate", value);
            }
        }
        
        public nsISupports Played
        {
            get
            {
                return this.GetProperty<nsISupports>("played");
            }
        }
        
        public nsISupports Seekable
        {
            get
            {
                return this.GetProperty<nsISupports>("seekable");
            }
        }
        
        public bool Ended
        {
            get
            {
                return this.GetProperty<bool>("ended");
            }
        }
        
        public bool Autoplay
        {
            get
            {
                return this.GetProperty<bool>("autoplay");
            }
            set
            {
                this.SetProperty("autoplay", value);
            }
        }
        
        public bool Loop
        {
            get
            {
                return this.GetProperty<bool>("loop");
            }
            set
            {
                this.SetProperty("loop", value);
            }
        }
        
        public bool Controls
        {
            get
            {
                return this.GetProperty<bool>("controls");
            }
            set
            {
                this.SetProperty("controls", value);
            }
        }
        
        public double Volume
        {
            get
            {
                return this.GetProperty<double>("volume");
            }
            set
            {
                this.SetProperty("volume", value);
            }
        }
        
        public bool Muted
        {
            get
            {
                return this.GetProperty<bool>("muted");
            }
            set
            {
                this.SetProperty("muted", value);
            }
        }
        
        public bool DefaultMuted
        {
            get
            {
                return this.GetProperty<bool>("defaultMuted");
            }
            set
            {
                this.SetProperty("defaultMuted", value);
            }
        }
        
        public nsISupports AudioTracks
        {
            get
            {
                return this.GetProperty<nsISupports>("audioTracks");
            }
        }
        
        public nsISupports VideoTracks
        {
            get
            {
                return this.GetProperty<nsISupports>("videoTracks");
            }
        }
        
        public nsISupports TextTracks
        {
            get
            {
                return this.GetProperty<nsISupports>("textTracks");
            }
        }
        
        public void Load()
        {
            this.CallVoidMethod("load");
        }
        
        public string CanPlayType(string type)
        {
            return this.CallMethod<string>("canPlayType", type);
        }
        
        public void FastSeek(double time)
        {
            this.CallVoidMethod("fastSeek", time);
        }
        
        public Promise Play()
        {
            return this.CallMethod<Promise>("play");
        }
        
        public void Pause()
        {
            this.CallVoidMethod("pause");
        }
        
        public nsISupports AddTextTrack(TextTrackKind kind)
        {
            return this.CallMethod<nsISupports>("addTextTrack", kind);
        }
        
        public nsISupports AddTextTrack(TextTrackKind kind, string label)
        {
            return this.CallMethod<nsISupports>("addTextTrack", kind, label);
        }
        
        public nsISupports AddTextTrack(TextTrackKind kind, string label, string language)
        {
            return this.CallMethod<nsISupports>("addTextTrack", kind, label, language);
        }
        
        public nsISupports MozMediaSourceObject
        {
            get
            {
                return this.GetProperty<nsISupports>("mozMediaSourceObject");
            }
        }
        
        public string MozDebugReaderData
        {
            get
            {
                return this.GetProperty<string>("mozDebugReaderData");
            }
        }
        
        public nsISupports SrcObject
        {
            get
            {
                return this.GetProperty<nsISupports>("srcObject");
            }
            set
            {
                this.SetProperty("srcObject", value);
            }
        }
        
        public bool MozPreservesPitch
        {
            get
            {
                return this.GetProperty<bool>("mozPreservesPitch");
            }
            set
            {
                this.SetProperty("mozPreservesPitch", value);
            }
        }
        
        public bool MozAllowCasting
        {
            get
            {
                return this.GetProperty<bool>("mozAllowCasting");
            }
            set
            {
                this.SetProperty("mozAllowCasting", value);
            }
        }
        
        public bool MozIsCasting
        {
            get
            {
                return this.GetProperty<bool>("mozIsCasting");
            }
            set
            {
                this.SetProperty("mozIsCasting", value);
            }
        }
        
        public bool MozAudioCaptured
        {
            get
            {
                return this.GetProperty<bool>("mozAudioCaptured");
            }
        }
        
        public double MozFragmentEnd
        {
            get
            {
                return this.GetProperty<double>("mozFragmentEnd");
            }
        }
        
        public Promise <string> MozRequestDebugInfo()
        {
            return this.CallMethod<Promise <string>>("mozRequestDebugInfo");
        }
        
        public Promise <string> MozRequestDebugLog()
        {
            return this.CallMethod<Promise <string>>("mozRequestDebugLog");
        }
        
        public Promise MozDumpDebugInfo()
        {
            return this.CallMethod<Promise>("mozDumpDebugInfo");
        }
        
        public nsISupports MozCaptureStream()
        {
            return this.CallMethod<nsISupports>("mozCaptureStream");
        }
        
        public nsISupports MozCaptureStreamUntilEnded()
        {
            return this.CallMethod<nsISupports>("mozCaptureStreamUntilEnded");
        }
        
        public object MozGetMetadata()
        {
            return this.CallMethod<object>("mozGetMetadata");
        }
        
        public void ReportCanPlayTelemetry()
        {
            this.CallVoidMethod("reportCanPlayTelemetry");
        }
        
        public nsISupports MediaKeys
        {
            get
            {
                return this.GetProperty<nsISupports>("mediaKeys");
            }
        }
        
        public Promise SetMediaKeys(nsISupports mediaKeys)
        {
            return this.CallMethod<Promise>("setMediaKeys", mediaKeys);
        }
        
        public double ComputedVolume
        {
            get
            {
                return this.GetProperty<double>("computedVolume");
            }
        }
        
        public bool ComputedMuted
        {
            get
            {
                return this.GetProperty<bool>("computedMuted");
            }
        }
        
        public uint ComputedSuspended
        {
            get
            {
                return this.GetProperty<uint>("computedSuspended");
            }
        }
        
        public Promise SeekToNextFrame()
        {
            return this.CallMethod<Promise>("seekToNextFrame");
        }
        
        public void SetVisible(bool aVisible)
        {
            this.CallVoidMethod("setVisible", aVisible);
        }
        
        public bool HasSuspendTaint()
        {
            return this.CallMethod<bool>("hasSuspendTaint");
        }
    }
}
