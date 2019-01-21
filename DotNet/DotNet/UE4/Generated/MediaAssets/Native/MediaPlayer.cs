// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;

using UE4.MediaUtils;

namespace UE4.MediaAssets.Native {
    [StructLayout( LayoutKind.Explicit, Size=328 )]
    internal unsafe struct MediaPlayer_fields {
        [FieldOffset(56)] byte OnEndReached; //TODO: multicast delegate FOnMediaPlayerMediaEvent OnEndReached
        [FieldOffset(72)] byte OnMediaClosed; //TODO: multicast delegate FOnMediaPlayerMediaEvent OnMediaClosed
        [FieldOffset(88)] byte OnMediaOpened; //TODO: multicast delegate FOnMediaPlayerMediaOpened OnMediaOpened
        [FieldOffset(104)] byte OnMediaOpenFailed; //TODO: multicast delegate FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed
        [FieldOffset(120)] byte OnPlaybackResumed; //TODO: multicast delegate FOnMediaPlayerMediaEvent OnPlaybackResumed
        [FieldOffset(136)] byte OnPlaybackSuspended; //TODO: multicast delegate FOnMediaPlayerMediaEvent OnPlaybackSuspended
        [FieldOffset(152)] byte OnSeekCompleted; //TODO: multicast delegate FOnMediaPlayerMediaEvent OnSeekCompleted
        [FieldOffset(168)] byte OnTracksChanged; //TODO: multicast delegate FOnMediaPlayerMediaEvent OnTracksChanged
        [FieldOffset(184)] public Timespan CacheAhead;
        [FieldOffset(192)] public Timespan CacheBehind;
        [FieldOffset(200)] public Timespan CacheBehindGame;
        [FieldOffset(208)] public bool NativeAudioOut;
        [FieldOffset(209)] public bool PlayOnOpen;
        [FieldOffset(212)] public bool Shuffle;
        [FieldOffset(212)] public bool Loop;
        [FieldOffset(216)]  public IntPtr  Playlist;
        [FieldOffset(224)] public int PlaylistIndex;
        [FieldOffset(232)] public Timespan TimeDelay;
        [FieldOffset(240)] public float HorizontalFieldOfView;
        [FieldOffset(244)] public float VerticalFieldOfView;
        [FieldOffset(248)] public Rotator ViewRotation;
        [FieldOffset(304)] public FGuid PlayerGuid;
        [FieldOffset(321)] public bool AffectedByPIEHandling;
    }
    internal unsafe struct MediaPlayer_methods {
        internal struct CanPause_method {
            static internal IntPtr CanPause_ptr;
            static CanPause_method() {
                CanPause_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "CanPause");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CanPause_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct CanPlaySource_method {
            static internal IntPtr CanPlaySource_ptr;
            static CanPlaySource_method() {
                CanPlaySource_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "CanPlaySource");
            }

            internal static unsafe bool Invoke(IntPtr obj, MediaSource MediaSource) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MediaSource;
                Main.GetProcessEvent(obj, CanPlaySource_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct CanPlayUrl_method {
            static internal IntPtr CanPlayUrl_ptr;
            static CanPlayUrl_method() {
                CanPlayUrl_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "CanPlayUrl");
            }

            internal static unsafe bool Invoke(IntPtr obj, string Url) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Url_handle = GCHandle.Alloc(Url, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Url_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Url.Length;
                *(int*)(b+IntPtr.Size+4+0) = Url.Length;
                Main.GetProcessEvent(obj, CanPlayUrl_ptr, new IntPtr(p)); ;
                Url_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct Close_method {
            static internal IntPtr Close_ptr;
            static Close_method() {
                Close_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "Close");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Close_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAudioTrackChannels_method {
            static internal IntPtr GetAudioTrackChannels_ptr;
            static GetAudioTrackChannels_method() {
                GetAudioTrackChannels_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetAudioTrackChannels");
            }

            internal static unsafe int Invoke(IntPtr obj, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                Main.GetProcessEvent(obj, GetAudioTrackChannels_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetAudioTrackSampleRate_method {
            static internal IntPtr GetAudioTrackSampleRate_ptr;
            static GetAudioTrackSampleRate_method() {
                GetAudioTrackSampleRate_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetAudioTrackSampleRate");
            }

            internal static unsafe int Invoke(IntPtr obj, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                Main.GetProcessEvent(obj, GetAudioTrackSampleRate_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetAudioTrackType_method {
            static internal IntPtr GetAudioTrackType_ptr;
            static GetAudioTrackType_method() {
                GetAudioTrackType_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetAudioTrackType");
            }

            internal static unsafe string Invoke(IntPtr obj, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                Main.GetProcessEvent(obj, GetAudioTrackType_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct GetDesiredPlayerName_method {
            static internal IntPtr GetDesiredPlayerName_ptr;
            static GetDesiredPlayerName_method() {
                GetDesiredPlayerName_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetDesiredPlayerName");
            }

            internal static unsafe Name Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDesiredPlayerName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct GetDuration_method {
            static internal IntPtr GetDuration_ptr;
            static GetDuration_method() {
                GetDuration_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetDuration");
            }

            internal static unsafe Timespan Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDuration_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+0));
            }
        }
        internal struct GetHorizontalFieldOfView_method {
            static internal IntPtr GetHorizontalFieldOfView_ptr;
            static GetHorizontalFieldOfView_method() {
                GetHorizontalFieldOfView_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetHorizontalFieldOfView");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetHorizontalFieldOfView_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetMediaName_method {
            static internal IntPtr GetMediaName_ptr;
            static GetMediaName_method() {
                GetMediaName_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetMediaName");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMediaName_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct GetNumTrackFormats_method {
            static internal IntPtr GetNumTrackFormats_ptr;
            static GetNumTrackFormats_method() {
                GetNumTrackFormats_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetNumTrackFormats");
            }

            internal static unsafe int Invoke(IntPtr obj, EMediaPlayerTrack TrackType, int TrackIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TrackType;
                *((int*)(b+4)) = TrackIndex;
                Main.GetProcessEvent(obj, GetNumTrackFormats_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetNumTracks_method {
            static internal IntPtr GetNumTracks_ptr;
            static GetNumTracks_method() {
                GetNumTracks_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetNumTracks");
            }

            internal static unsafe int Invoke(IntPtr obj, EMediaPlayerTrack TrackType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TrackType;
                Main.GetProcessEvent(obj, GetNumTracks_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetPlayerName_method {
            static internal IntPtr GetPlayerName_ptr;
            static GetPlayerName_method() {
                GetPlayerName_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetPlayerName");
            }

            internal static unsafe Name Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayerName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct GetPlaylist_method {
            static internal IntPtr GetPlaylist_ptr;
            static GetPlaylist_method() {
                GetPlaylist_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetPlaylist");
            }

            internal static unsafe MediaPlaylist Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaylist_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetPlaylistIndex_method {
            static internal IntPtr GetPlaylistIndex_ptr;
            static GetPlaylistIndex_method() {
                GetPlaylistIndex_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetPlaylistIndex");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaylistIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetRate_method {
            static internal IntPtr GetRate_ptr;
            static GetRate_method() {
                GetRate_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetRate");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRate_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetSelectedTrack_method {
            static internal IntPtr GetSelectedTrack_ptr;
            static GetSelectedTrack_method() {
                GetSelectedTrack_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetSelectedTrack");
            }

            internal static unsafe int Invoke(IntPtr obj, EMediaPlayerTrack TrackType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TrackType;
                Main.GetProcessEvent(obj, GetSelectedTrack_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct GetSupportedRates_method {
            static internal IntPtr GetSupportedRates_ptr;
            static GetSupportedRates_method() {
                GetSupportedRates_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetSupportedRates");
            }

            internal static unsafe IReadOnlyCollection<FloatRange> Invoke(IntPtr obj, bool Unthinned) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+16)) = Unthinned;
                Main.GetProcessEvent(obj, GetSupportedRates_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutRates
                return UObject.ToUnmangedCollection<FloatRange>(b+0);
            }
        }
        internal struct GetTime_method {
            static internal IntPtr GetTime_ptr;
            static GetTime_method() {
                GetTime_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetTime");
            }

            internal static unsafe Timespan Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTime_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+0));
            }
        }
        internal struct GetTimeDelay_method {
            static internal IntPtr GetTimeDelay_ptr;
            static GetTimeDelay_method() {
                GetTimeDelay_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetTimeDelay");
            }

            internal static unsafe Timespan Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTimeDelay_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+0));
            }
        }
        internal struct GetTrackDisplayName_method {
            static internal IntPtr GetTrackDisplayName_ptr;
            static GetTrackDisplayName_method() {
                GetTrackDisplayName_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetTrackDisplayName");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj, EMediaPlayerTrack TrackType, int TrackIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TrackType;
                *((int*)(b+4)) = TrackIndex;
                Main.GetProcessEvent(obj, GetTrackDisplayName_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct GetTrackFormat_method {
            static internal IntPtr GetTrackFormat_ptr;
            static GetTrackFormat_method() {
                GetTrackFormat_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetTrackFormat");
            }

            internal static unsafe int Invoke(IntPtr obj, EMediaPlayerTrack TrackType, int TrackIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TrackType;
                *((int*)(b+4)) = TrackIndex;
                Main.GetProcessEvent(obj, GetTrackFormat_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetTrackLanguage_method {
            static internal IntPtr GetTrackLanguage_ptr;
            static GetTrackLanguage_method() {
                GetTrackLanguage_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetTrackLanguage");
            }

            internal static unsafe string Invoke(IntPtr obj, EMediaPlayerTrack TrackType, int TrackIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TrackType;
                *((int*)(b+4)) = TrackIndex;
                Main.GetProcessEvent(obj, GetTrackLanguage_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct GetUrl_method {
            static internal IntPtr GetUrl_ptr;
            static GetUrl_method() {
                GetUrl_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetUrl");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUrl_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetVerticalFieldOfView_method {
            static internal IntPtr GetVerticalFieldOfView_ptr;
            static GetVerticalFieldOfView_method() {
                GetVerticalFieldOfView_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetVerticalFieldOfView");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVerticalFieldOfView_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetVideoTrackAspectRatio_method {
            static internal IntPtr GetVideoTrackAspectRatio_ptr;
            static GetVideoTrackAspectRatio_method() {
                GetVideoTrackAspectRatio_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetVideoTrackAspectRatio");
            }

            internal static unsafe float Invoke(IntPtr obj, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                Main.GetProcessEvent(obj, GetVideoTrackAspectRatio_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetVideoTrackDimensions_method {
            static internal IntPtr GetVideoTrackDimensions_ptr;
            static GetVideoTrackDimensions_method() {
                GetVideoTrackDimensions_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetVideoTrackDimensions");
            }

            internal static unsafe IntPoint Invoke(IntPtr obj, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                Main.GetProcessEvent(obj, GetVideoTrackDimensions_ptr, new IntPtr(p)); ;
                return *((IntPoint*)(b+8));
            }
        }
        internal struct GetVideoTrackFrameRate_method {
            static internal IntPtr GetVideoTrackFrameRate_ptr;
            static GetVideoTrackFrameRate_method() {
                GetVideoTrackFrameRate_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetVideoTrackFrameRate");
            }

            internal static unsafe float Invoke(IntPtr obj, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                Main.GetProcessEvent(obj, GetVideoTrackFrameRate_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetVideoTrackFrameRates_method {
            static internal IntPtr GetVideoTrackFrameRates_ptr;
            static GetVideoTrackFrameRates_method() {
                GetVideoTrackFrameRates_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetVideoTrackFrameRates");
            }

            internal static unsafe FloatRange Invoke(IntPtr obj, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                Main.GetProcessEvent(obj, GetVideoTrackFrameRates_ptr, new IntPtr(p)); ;
                return *((FloatRange*)(b+8));
            }
        }
        internal struct GetVideoTrackType_method {
            static internal IntPtr GetVideoTrackType_ptr;
            static GetVideoTrackType_method() {
                GetVideoTrackType_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetVideoTrackType");
            }

            internal static unsafe string Invoke(IntPtr obj, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                Main.GetProcessEvent(obj, GetVideoTrackType_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct GetViewRotation_method {
            static internal IntPtr GetViewRotation_ptr;
            static GetViewRotation_method() {
                GetViewRotation_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "GetViewRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct HasError_method {
            static internal IntPtr HasError_ptr;
            static HasError_method() {
                HasError_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "HasError");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasError_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsBuffering_method {
            static internal IntPtr IsBuffering_ptr;
            static IsBuffering_method() {
                IsBuffering_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "IsBuffering");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsBuffering_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsConnecting_method {
            static internal IntPtr IsConnecting_ptr;
            static IsConnecting_method() {
                IsConnecting_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "IsConnecting");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsConnecting_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsLooping_method {
            static internal IntPtr IsLooping_ptr;
            static IsLooping_method() {
                IsLooping_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "IsLooping");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLooping_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPaused_method {
            static internal IntPtr IsPaused_ptr;
            static IsPaused_method() {
                IsPaused_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "IsPaused");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPaused_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlaying_method {
            static internal IntPtr IsPlaying_ptr;
            static IsPlaying_method() {
                IsPlaying_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "IsPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPreparing_method {
            static internal IntPtr IsPreparing_ptr;
            static IsPreparing_method() {
                IsPreparing_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "IsPreparing");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPreparing_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsReady_method {
            static internal IntPtr IsReady_ptr;
            static IsReady_method() {
                IsReady_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "IsReady");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsReady_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Next_method {
            static internal IntPtr Next_ptr;
            static Next_method() {
                Next_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "Next");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Next_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct OpenFile_method {
            static internal IntPtr OpenFile_ptr;
            static OpenFile_method() {
                OpenFile_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "OpenFile");
            }

            internal static unsafe bool Invoke(IntPtr obj, string FilePath) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var FilePath_handle = GCHandle.Alloc(FilePath, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = FilePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = FilePath.Length;
                *(int*)(b+IntPtr.Size+4+0) = FilePath.Length;
                Main.GetProcessEvent(obj, OpenFile_ptr, new IntPtr(p)); ;
                FilePath_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct OpenPlaylist_method {
            static internal IntPtr OpenPlaylist_ptr;
            static OpenPlaylist_method() {
                OpenPlaylist_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "OpenPlaylist");
            }

            internal static unsafe bool Invoke(IntPtr obj, MediaPlaylist InPlaylist) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InPlaylist;
                Main.GetProcessEvent(obj, OpenPlaylist_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct OpenPlaylistIndex_method {
            static internal IntPtr OpenPlaylistIndex_ptr;
            static OpenPlaylistIndex_method() {
                OpenPlaylistIndex_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "OpenPlaylistIndex");
            }

            internal static unsafe bool Invoke(IntPtr obj, MediaPlaylist InPlaylist, int Index) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InPlaylist;
                *((int*)(b+8)) = Index;
                Main.GetProcessEvent(obj, OpenPlaylistIndex_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct OpenSource_method {
            static internal IntPtr OpenSource_ptr;
            static OpenSource_method() {
                OpenSource_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "OpenSource");
            }

            internal static unsafe bool Invoke(IntPtr obj, MediaSource MediaSource) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MediaSource;
                Main.GetProcessEvent(obj, OpenSource_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct OpenSourceWithOptions_method {
            static internal IntPtr OpenSourceWithOptions_ptr;
            static OpenSourceWithOptions_method() {
                OpenSourceWithOptions_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "OpenSourceWithOptions");
            }

            internal static unsafe bool Invoke(IntPtr obj, MediaSource MediaSource, MediaPlayerOptions Options) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MediaSource;
                *((MediaPlayerOptions*)(b+8)) = Options;
                Main.GetProcessEvent(obj, OpenSourceWithOptions_ptr, new IntPtr(p)); ;
                return *((bool*)(b+36));
            }
        }
        internal struct OpenUrl_method {
            static internal IntPtr OpenUrl_ptr;
            static OpenUrl_method() {
                OpenUrl_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "OpenUrl");
            }

            internal static unsafe bool Invoke(IntPtr obj, string Url) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Url_handle = GCHandle.Alloc(Url, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Url_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Url.Length;
                *(int*)(b+IntPtr.Size+4+0) = Url.Length;
                Main.GetProcessEvent(obj, OpenUrl_ptr, new IntPtr(p)); ;
                Url_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct Pause_method {
            static internal IntPtr Pause_ptr;
            static Pause_method() {
                Pause_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "Pause");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Pause_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Play_method {
            static internal IntPtr Play_ptr;
            static Play_method() {
                Play_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "Play");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Play_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Previous_method {
            static internal IntPtr Previous_ptr;
            static Previous_method() {
                Previous_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "Previous");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Previous_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Reopen_method {
            static internal IntPtr Reopen_ptr;
            static Reopen_method() {
                Reopen_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "Reopen");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Reopen_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Rewind_method {
            static internal IntPtr Rewind_ptr;
            static Rewind_method() {
                Rewind_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "Rewind");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Rewind_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Seek_method {
            static internal IntPtr Seek_ptr;
            static Seek_method() {
                Seek_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "Seek");
            }

            internal static unsafe bool Invoke(IntPtr obj, Timespan Time) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = Time;
                Main.GetProcessEvent(obj, Seek_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SelectTrack_method {
            static internal IntPtr SelectTrack_ptr;
            static SelectTrack_method() {
                SelectTrack_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SelectTrack");
            }

            internal static unsafe bool Invoke(IntPtr obj, EMediaPlayerTrack TrackType, int TrackIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TrackType;
                *((int*)(b+4)) = TrackIndex;
                Main.GetProcessEvent(obj, SelectTrack_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SetBlockOnTime_method {
            static internal IntPtr SetBlockOnTime_ptr;
            static SetBlockOnTime_method() {
                SetBlockOnTime_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetBlockOnTime");
            }

            internal static unsafe void Invoke(IntPtr obj, Timespan Time) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = Time;
                Main.GetProcessEvent(obj, SetBlockOnTime_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDesiredPlayerName_method {
            static internal IntPtr SetDesiredPlayerName_ptr;
            static SetDesiredPlayerName_method() {
                SetDesiredPlayerName_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetDesiredPlayerName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name PlayerName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = PlayerName;
                Main.GetProcessEvent(obj, SetDesiredPlayerName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLooping_method {
            static internal IntPtr SetLooping_ptr;
            static SetLooping_method() {
                SetLooping_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetLooping");
            }

            internal static unsafe bool Invoke(IntPtr obj, bool Looping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = Looping;
                Main.GetProcessEvent(obj, SetLooping_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct SetNativeVolume_method {
            static internal IntPtr SetNativeVolume_ptr;
            static SetNativeVolume_method() {
                SetNativeVolume_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetNativeVolume");
            }

            internal static unsafe bool Invoke(IntPtr obj, float Volume) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Volume;
                Main.GetProcessEvent(obj, SetNativeVolume_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct SetRate_method {
            static internal IntPtr SetRate_ptr;
            static SetRate_method() {
                SetRate_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetRate");
            }

            internal static unsafe bool Invoke(IntPtr obj, float Rate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Rate;
                Main.GetProcessEvent(obj, SetRate_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct SetTimeDelay_method {
            static internal IntPtr SetTimeDelay_ptr;
            static SetTimeDelay_method() {
                SetTimeDelay_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetTimeDelay");
            }

            internal static unsafe void Invoke(IntPtr obj, Timespan TimeDelay) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = TimeDelay;
                Main.GetProcessEvent(obj, SetTimeDelay_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTrackFormat_method {
            static internal IntPtr SetTrackFormat_ptr;
            static SetTrackFormat_method() {
                SetTrackFormat_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetTrackFormat");
            }

            internal static unsafe bool Invoke(IntPtr obj, EMediaPlayerTrack TrackType, int TrackIndex, int FormatIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)TrackType;
                *((int*)(b+4)) = TrackIndex;
                *((int*)(b+8)) = FormatIndex;
                Main.GetProcessEvent(obj, SetTrackFormat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct SetVideoTrackFrameRate_method {
            static internal IntPtr SetVideoTrackFrameRate_ptr;
            static SetVideoTrackFrameRate_method() {
                SetVideoTrackFrameRate_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetVideoTrackFrameRate");
            }

            internal static unsafe bool Invoke(IntPtr obj, int TrackIndex, int FormatIndex, float FrameRate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = TrackIndex;
                *((int*)(b+4)) = FormatIndex;
                *((float*)(b+8)) = FrameRate;
                Main.GetProcessEvent(obj, SetVideoTrackFrameRate_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct SetViewField_method {
            static internal IntPtr SetViewField_ptr;
            static SetViewField_method() {
                SetViewField_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetViewField");
            }

            internal static unsafe bool Invoke(IntPtr obj, float Horizontal, float Vertical, bool Absolute) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Horizontal;
                *((float*)(b+4)) = Vertical;
                *((bool*)(b+8)) = Absolute;
                Main.GetProcessEvent(obj, SetViewField_ptr, new IntPtr(p)); ;
                return *((bool*)(b+9));
            }
        }
        internal struct SetViewRotation_method {
            static internal IntPtr SetViewRotation_ptr;
            static SetViewRotation_method() {
                SetViewRotation_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SetViewRotation");
            }

            internal static unsafe bool Invoke(IntPtr obj, Rotator Rotation, bool Absolute) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = Rotation;
                *((bool*)(b+12)) = Absolute;
                Main.GetProcessEvent(obj, SetViewRotation_ptr, new IntPtr(p)); ;
                return *((bool*)(b+13));
            }
        }
        internal struct SupportsRate_method {
            static internal IntPtr SupportsRate_ptr;
            static SupportsRate_method() {
                SupportsRate_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SupportsRate");
            }

            internal static unsafe bool Invoke(IntPtr obj, float Rate, bool Unthinned) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Rate;
                *((bool*)(b+4)) = Unthinned;
                Main.GetProcessEvent(obj, SupportsRate_ptr, new IntPtr(p)); ;
                return *((bool*)(b+5));
            }
        }
        internal struct SupportsScrubbing_method {
            static internal IntPtr SupportsScrubbing_ptr;
            static SupportsScrubbing_method() {
                SupportsScrubbing_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SupportsScrubbing");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SupportsScrubbing_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SupportsSeeking_method {
            static internal IntPtr SupportsSeeking_ptr;
            static SupportsSeeking_method() {
                SupportsSeeking_ptr = Main.GetMethodUFunction(MediaPlayer.StaticClass, "SupportsSeeking");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SupportsSeeking_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct MediaPlayer_events {
    }
}
