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

#pragma warning disable CS0108
using UE4.MediaAssets.Native;

namespace UE4.MediaAssets {
    ///<summary>Implements a media player asset that can play movies and other media sources.</summary>
    public unsafe partial class MediaPlayer : UObject  {

        ///<summary>Check whether media playback can be paused right now.</summary>
        ///<remarks>
        ///Playback can be paused if the media supports pausing and if it is currently playing.
        ///
        ///@return true if pausing playback can be paused, false otherwise.
        ///@see CanPlay, Pause
        ///</remarks>
        public bool CanPause()  => 
            MediaPlayer_methods.CanPause_method.Invoke(ObjPointer);

        ///<summary>Check whether the specified media source can be played by this player.</summary>
        ///<remarks>
        ///If a desired player name is set for this player, it will only check
        ///whether that particular player type can play the specified source.
        ///
        ///@param MediaSource The media source to check.
        ///@return true if the media source can be opened, false otherwise.
        ///@see CanPlayUrl, SetDesiredPlayerName
        ///</remarks>
        public bool CanPlaySource(MediaSource MediaSource)  => 
            MediaPlayer_methods.CanPlaySource_method.Invoke(ObjPointer, MediaSource);

        ///<summary>Check whether the specified URL can be played by this player.</summary>
        ///<remarks>
        ///If a desired player name is set for this player, it will only check
        ///whether that particular player type can play the specified URL.
        ///
        ///@param Url The URL to check.
        ///@see CanPlaySource, SetDesiredPlayerName
        ///</remarks>
        public bool CanPlayUrl(string Url)  => 
            MediaPlayer_methods.CanPlayUrl_method.Invoke(ObjPointer, Url);

        ///<summary>Close the currently open media, if any.</summary>
        ///<remarks>
        ///@see OnMediaClosed, OpenPlaylist, OpenPlaylistIndex, OpenSource, OpenUrl, Pause, Play
        ///</remarks>
        public void Close()  => 
            MediaPlayer_methods.Close_method.Invoke(ObjPointer);

        ///<summary>Get the number of channels in the specified audio track.</summary>
        ///<remarks>
        ///@param TrackIndex Index of the audio track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@return Number of channels.
        ///@see GetAudioTrackSampleRate, GetAudioTrackType
        ///</remarks>
        public int GetAudioTrackChannels(int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.GetAudioTrackChannels_method.Invoke(ObjPointer, TrackIndex, FormatIndex);

        ///<summary>Get the sample rate of the specified audio track.</summary>
        ///<remarks>
        ///@param TrackIndex Index of the audio track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@return Samples per second.
        ///@see GetAudioTrackChannels, GetAudioTrackType
        ///</remarks>
        public int GetAudioTrackSampleRate(int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.GetAudioTrackSampleRate_method.Invoke(ObjPointer, TrackIndex, FormatIndex);

        ///<summary>Get the type of the specified audio track format.</summary>
        ///<remarks>
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@return Audio format type string.
        ///@see GetAudioTrackSampleRate, GetAudioTrackSampleRate
        ///</remarks>
        public string GetAudioTrackType(int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.GetAudioTrackType_method.Invoke(ObjPointer, TrackIndex, FormatIndex);

        ///<summary>Get the name of the current desired native player.</summary>
        ///<remarks>
        ///@return The name of the desired player, or NAME_None if not set.
        ///@see SetDesiredPlayerName
        ///</remarks>
        public Name GetDesiredPlayerName()  => 
            MediaPlayer_methods.GetDesiredPlayerName_method.Invoke(ObjPointer);

        ///<summary>Get the media's duration.</summary>
        ///<remarks>
        ///@return A time span representing the duration.
        ///@see GetTime, Seek
        ///</remarks>
        public Timespan GetDuration()  => 
            MediaPlayer_methods.GetDuration_method.Invoke(ObjPointer);

        ///<summary>Get the current horizontal field of view (only for 360 videos).</summary>
        ///<remarks>
        ///@return Horizontal field of view (in Euler degrees).
        ///@see GetVerticalFieldOfView, GetViewRotation, SetHorizontalFieldOfView
        ///</remarks>
        public float GetHorizontalFieldOfView()  => 
            MediaPlayer_methods.GetHorizontalFieldOfView_method.Invoke(ObjPointer);

        ///<summary>Get the human readable name of the currently loaded media source.</summary>
        ///<remarks>
        ///@return Media source name, or empty text if no media is opened
        ///@see GetPlayerName, GetUrl
        ///</remarks>
        public byte /*TODO: text FText*/ GetMediaName()  => 
            MediaPlayer_methods.GetMediaName_method.Invoke(ObjPointer);

        ///<summary>Get the number of formats of the specified track.</summary>
        ///<remarks>
        ///@param TrackType The type of media tracks.
        ///@param TrackIndex The index of the track.
        ///@return Number of formats.
        ///@see GetNumTracks, GetSelectedTrack, SelectTrack
        ///</remarks>
        public int GetNumTrackFormats(EMediaPlayerTrack TrackType, int TrackIndex)  => 
            MediaPlayer_methods.GetNumTrackFormats_method.Invoke(ObjPointer, TrackType, TrackIndex);

        ///<summary>Get the number of tracks of the given type.</summary>
        ///<remarks>
        ///@param TrackType The type of media tracks.
        ///@return Number of tracks.
        ///@see GetNumTrackFormats, GetSelectedTrack, SelectTrack
        ///</remarks>
        public int GetNumTracks(EMediaPlayerTrack TrackType)  => 
            MediaPlayer_methods.GetNumTracks_method.Invoke(ObjPointer, TrackType);

        ///<summary>Get the name of the current native media player.</summary>
        ///<remarks>
        ///@return Player name, or NAME_None if not available.
        ///@see GetMediaName
        ///</remarks>
        public Name GetPlayerName()  => 
            MediaPlayer_methods.GetPlayerName_method.Invoke(ObjPointer);

        ///<summary>Get the current play list.</summary>
        ///<remarks>
        ///Media players always have a valid play list. In C++ code you can use
        ///the GetPlaylistRef to get a reference instead of a pointer to it.
        ///
        ///@return The play list.
        ///@see GetPlaylistIndex, GetPlaylistRef
        ///</remarks>
        public MediaPlaylist GetPlaylist()  => 
            MediaPlayer_methods.GetPlaylist_method.Invoke(ObjPointer);

        ///<summary>Get the current play list index.</summary>
        ///<remarks>
        ///@return Play list index.
        ///@see GetPlaylist
        ///</remarks>
        public int GetPlaylistIndex()  => 
            MediaPlayer_methods.GetPlaylistIndex_method.Invoke(ObjPointer);

        ///<summary>Get the media's current playback rate.</summary>
        ///<remarks>
        ///@return The playback rate.
        ///@see SetRate, SupportsRate
        ///</remarks>
        public float GetRate()  => 
            MediaPlayer_methods.GetRate_method.Invoke(ObjPointer);

        ///<summary>Get the index of the currently selected track of the given type.</summary>
        ///<remarks>
        ///@param TrackType The type of track to get.
        ///@return The index of the selected track, or INDEX_NONE if no track is active.
        ///@see GetNumTracks, GetTrackFormat, SelectTrack
        ///</remarks>
        public int GetSelectedTrack(EMediaPlayerTrack TrackType)  => 
            MediaPlayer_methods.GetSelectedTrack_method.Invoke(ObjPointer, TrackType);

        ///<summary>Get the supported playback rates.</summary>
        ///<remarks>
        ///@param Unthinned Whether the rates are for unthinned playback.
        ///@param Will contain the the ranges of supported rates.
        ///@see SetRate, SupportsRate
        ///</remarks>
        public IReadOnlyCollection<FloatRange> GetSupportedRates(bool Unthinned)  => 
            MediaPlayer_methods.GetSupportedRates_method.Invoke(ObjPointer, Unthinned);

        ///<summary>Get the media's current playback time.</summary>
        ///<remarks>
        ///@return Playback time.
        ///@see GetDuration, Seek
        ///</remarks>
        public Timespan GetTime()  => 
            MediaPlayer_methods.GetTime_method.Invoke(ObjPointer);

        ///<summary>Delay of the player's time.</summary>
        ///<remarks>
        ///@return Delay added to the player's time used to manually sync multiple sources.
        ///@see SetTimeDelay
        ///</remarks>
        public Timespan GetTimeDelay()  => 
            MediaPlayer_methods.GetTimeDelay_method.Invoke(ObjPointer);

        ///<summary>Get the human readable name of the specified track.</summary>
        ///<remarks>
        ///@param TrackType The type of track.
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@return Display name.
        ///@see GetNumTracks, GetTrackLanguage
        ///</remarks>
        public byte /*TODO: text FText*/ GetTrackDisplayName(EMediaPlayerTrack TrackType, int TrackIndex)  => 
            MediaPlayer_methods.GetTrackDisplayName_method.Invoke(ObjPointer, TrackType, TrackIndex);

        ///<summary>Get the index of the active format of the specified track type.</summary>
        ///<remarks>
        ///@param TrackType The type of track.
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@return The index of the selected format.
        ///@see GetNumTrackFormats, GetSelectedTrack, SetTrackFormat
        ///</remarks>
        public int GetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex)  => 
            MediaPlayer_methods.GetTrackFormat_method.Invoke(ObjPointer, TrackType, TrackIndex);

        ///<summary>Get the language tag of the specified track.</summary>
        ///<remarks>
        ///@param TrackType The type of track.
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@return Language tag, i.e. "en-US" for English, or "und" for undefined.
        ///@see GetNumTracks, GetTrackDisplayName
        ///</remarks>
        public string GetTrackLanguage(EMediaPlayerTrack TrackType, int TrackIndex)  => 
            MediaPlayer_methods.GetTrackLanguage_method.Invoke(ObjPointer, TrackType, TrackIndex);

        ///<summary>Get the URL of the currently loaded media, if any.</summary>
        ///<remarks>
        ///@return Media URL, or empty string if no media was loaded.
        ///@see OpenUrl
        ///</remarks>
        public string GetUrl()  => 
            MediaPlayer_methods.GetUrl_method.Invoke(ObjPointer);

        ///<summary>Get the current vertical field of view (only for 360 videos).</summary>
        ///<remarks>
        ///@return Vertical field of view (in Euler degrees), or 0.0 if not available.
        ///@see GetHorizontalFieldOfView, GetViewRotation, SetVerticalFieldOfView
        ///</remarks>
        public float GetVerticalFieldOfView()  => 
            MediaPlayer_methods.GetVerticalFieldOfView_method.Invoke(ObjPointer);

        ///<summary>Get the aspect ratio of the specified video track.</summary>
        ///<remarks>
        ///@param TrackIndex Index of the video track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@return Aspect ratio.
        ///@see GetVideoTrackDimensions, GetVideoTrackFrameRate, GetVideoTrackFrameRates, GetVideoTrackType
        ///</remarks>
        public float GetVideoTrackAspectRatio(int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.GetVideoTrackAspectRatio_method.Invoke(ObjPointer, TrackIndex, FormatIndex);

        ///<summary>Get the current dimensions of the specified video track.</summary>
        ///<remarks>
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@return Video dimensions (in pixels).
        ///@see GetVideoTrackAspectRatio, GetVideoTrackFrameRate, GetVideoTrackFrameRates, GetVideoTrackType
        ///</remarks>
        public IntPoint GetVideoTrackDimensions(int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.GetVideoTrackDimensions_method.Invoke(ObjPointer, TrackIndex, FormatIndex);

        ///<summary>Get the frame rate of the specified video track.</summary>
        ///<remarks>
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@return Frame rate (in frames per second).
        ///@see GetVideoTrackAspectRatio, GetVideoTrackDimensions, GetVideoTrackFrameRates, GetVideoTrackType, SetVideoTrackFrameRate
        ///</remarks>
        public float GetVideoTrackFrameRate(int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.GetVideoTrackFrameRate_method.Invoke(ObjPointer, TrackIndex, FormatIndex);

        ///<summary>Get the supported range of frame rates of the specified video track.</summary>
        ///<remarks>
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@return Frame rate range (in frames per second).
        ///@see GetVideoTrackAspectRatio, GetVideoTrackDimensions, GetVideoTrackFrameRate, GetVideoTrackType
        ///</remarks>
        public FloatRange GetVideoTrackFrameRates(int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.GetVideoTrackFrameRates_method.Invoke(ObjPointer, TrackIndex, FormatIndex);

        ///<summary>Get the type of the specified video track format.</summary>
        ///<remarks>
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@return Video format type string.
        ///@see GetVideoTrackAspectRatio, GetVideoTrackDimensions, GetVideoTrackFrameRate, GetVideoTrackFrameRates
        ///</remarks>
        public string GetVideoTrackType(int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.GetVideoTrackType_method.Invoke(ObjPointer, TrackIndex, FormatIndex);

        ///<summary>Get the current view rotation (only for 360 videos).</summary>
        ///<remarks>
        ///@return View rotation, or zero rotator if not available.
        ///@see GetHorizontalFieldOfView, GetVerticalFieldOfView, SetViewRotation
        ///</remarks>
        public Rotator GetViewRotation()  => 
            MediaPlayer_methods.GetViewRotation_method.Invoke(ObjPointer);

        ///<summary>Check whether the player is in an error state.</summary>
        ///<remarks>
        ///When the player is in an error state, no further operations are possible.
        ///The current media must be closed, and a new media source must be opened
        ///before the player can be used again. Errors are usually caused by faulty
        ///media files or interrupted network connections.
        ///
        ///@see IsReady
        ///</remarks>
        public bool HasError()  => 
            MediaPlayer_methods.HasError_method.Invoke(ObjPointer);

        ///<summary>Check whether playback is buffering data.</summary>
        ///<remarks>
        ///@return true if looping, false otherwise.
        ///@see IsConnecting, IsLooping, IsPaused, IsPlaying, IsPreparing, IsReady
        ///</remarks>
        public bool IsBuffering()  => 
            MediaPlayer_methods.IsBuffering_method.Invoke(ObjPointer);

        ///<summary>Check whether the player is currently connecting to a media source.</summary>
        ///<remarks>
        ///@return true if connecting, false otherwise.
        ///@see IsBuffering, IsLooping, IsPaused, IsPlaying, IsPreparing, IsReady
        ///</remarks>
        public bool IsConnecting()  => 
            MediaPlayer_methods.IsConnecting_method.Invoke(ObjPointer);

        ///<summary>Check whether playback is looping.</summary>
        ///<remarks>
        ///@return true if looping, false otherwise.
        ///@see IsBuffering, IsConnecting, IsPaused, IsPlaying, IsPreparing, IsReady, SetLooping
        ///</remarks>
        public bool IsLooping()  => 
            MediaPlayer_methods.IsLooping_method.Invoke(ObjPointer);

        ///<summary>Check whether playback is currently paused.</summary>
        ///<remarks>
        ///@return true if playback is paused, false otherwise.
        ///@see CanPause, IsBuffering, IsConnecting, IsLooping, IsPaused, IsPlaying, IsPreparing, IsReady, Pause
        ///</remarks>
        public bool IsPaused()  => 
            MediaPlayer_methods.IsPaused_method.Invoke(ObjPointer);

        ///<summary>Check whether playback has started.</summary>
        ///<remarks>
        ///@return true if playback has started, false otherwise.
        ///@see CanPlay, IsBuffering, IsConnecting, IsLooping, IsPaused, IsPlaying, IsPreparing, IsReady, Play
        ///</remarks>
        public bool IsPlaying()  => 
            MediaPlayer_methods.IsPlaying_method.Invoke(ObjPointer);

        ///<summary>Check whether the media is currently opening or buffering.</summary>
        ///<remarks>
        ///@return true if playback is being prepared, false otherwise.
        ///@see CanPlay, IsBuffering, IsConnecting, IsLooping, IsPaused, IsPlaying, IsReady, Play
        ///</remarks>
        public bool IsPreparing()  => 
            MediaPlayer_methods.IsPreparing_method.Invoke(ObjPointer);

        ///<summary>Check whether media is ready for playback.</summary>
        ///<remarks>
        ///A player is ready for playback if it has a media source opened that
        ///finished preparing and is not in an error state.
        ///
        ///@return true if media is ready, false otherwise.
        ///@see HasError, IsBuffering, IsConnecting, IsLooping, IsPaused, IsPlaying, IsPreparing
        ///</remarks>
        public bool IsReady()  => 
            MediaPlayer_methods.IsReady_method.Invoke(ObjPointer);

        ///<summary>Open the next item in the current play list.</summary>
        ///<remarks>
        ///The player will start playing the new media source if it was playing
        ///something previously, otherwise it will only open the media source.
        ///
        ///@return true on success, false otherwise.
        ///@see Close, OpenUrl, OpenSource, Play, Previous, SetPlaylist
        ///</remarks>
        public bool Next()  => 
            MediaPlayer_methods.Next_method.Invoke(ObjPointer);

        ///<summary>Opens the specified media file path.</summary>
        ///<remarks>
        ///A return value of true indicates that the player will attempt to open
        ///the media, but it may fail to do so later for other reasons, i.e. if
        ///a connection to the media server timed out. Use the OnMediaOpened and
        ///OnMediaOpenFailed delegates to detect if and when the media is ready!
        ///
        ///@param FilePath The file path to open.
        ///@return true if the file path will be opened, false otherwise.
        ///@see GetUrl, Close, OpenPlaylist, OpenPlaylistIndex, OpenSource, OpenUrl, Reopen
        ///</remarks>
        public bool OpenFile(string FilePath)  => 
            MediaPlayer_methods.OpenFile_method.Invoke(ObjPointer, FilePath);

        ///<summary>Open the first media source in the specified play list.</summary>
        ///<remarks>
        ///@param InPlaylist The play list to open.
        ///@return true if the source will be opened, false otherwise.
        ///@see Close, OpenFile, OpenPlaylistIndex, OpenSource, OpenUrl, Reopen
        ///</remarks>
        public bool OpenPlaylist(MediaPlaylist InPlaylist)  => 
            MediaPlayer_methods.OpenPlaylist_method.Invoke(ObjPointer, InPlaylist);

        ///<summary>Open a particular media source in the specified play list.</summary>
        ///<remarks>
        ///@param InPlaylist The play list to open.
        ///@param Index The index of the source to open.
        ///@return true if the source will be opened, false otherwise.
        ///@see Close, OpenFile, OpenPlaylist, OpenSource, OpenUrl, Reopen
        ///</remarks>
        public bool OpenPlaylistIndex(MediaPlaylist InPlaylist, int Index)  => 
            MediaPlayer_methods.OpenPlaylistIndex_method.Invoke(ObjPointer, InPlaylist, Index);

        ///<summary>Open the specified media source.</summary>
        ///<remarks>
        ///A return value of true indicates that the player will attempt to open
        ///the media, but it may fail to do so later for other reasons, i.e. if
        ///a connection to the media server timed out. Use the OnMediaOpened and
        ///OnMediaOpenFailed delegates to detect if and when the media is ready!
        ///
        ///@param MediaSource The media source to open.
        ///@return true if the source will be opened, false otherwise.
        ///@see Close, OpenFile, OpenPlaylist, OpenPlaylistIndex, OpenUrl, Reopen
        ///</remarks>
        public bool OpenSource(MediaSource MediaSource)  => 
            MediaPlayer_methods.OpenSource_method.Invoke(ObjPointer, MediaSource);

        ///<summary>Opens the specified media URL.</summary>
        ///<remarks>
        ///A return value of true indicates that the player will attempt to open
        ///the media, but it may fail to do so later for other reasons, i.e. if
        ///a connection to the media server timed out. Use the OnMediaOpened and
        ///OnMediaOpenFailed delegates to detect if and when the media is ready!
        ///
        ///@param Url The URL to open.
        ///@return true if the URL will be opened, false otherwise.
        ///@see GetUrl, Close, OpenFile, OpenPlaylist, OpenPlaylistIndex, OpenSource, Reopen
        ///</remarks>
        public bool OpenUrl(string Url)  => 
            MediaPlayer_methods.OpenUrl_method.Invoke(ObjPointer, Url);

        ///<summary>Pauses media playback.</summary>
        ///<remarks>
        ///This is the same as setting the playback rate to 0.0.
        ///
        ///@return true if playback is being paused, false otherwise.
        ///@see CanPause, Close, Next, Play, Previous, Rewind, Seek
        ///</remarks>
        public bool Pause()  => 
            MediaPlayer_methods.Pause_method.Invoke(ObjPointer);

        ///<summary>Starts media playback.</summary>
        ///<remarks>
        ///This is the same as setting the playback rate to 1.0.
        ///
        ///@return true if playback is starting, false otherwise.
        ///@see CanPlay, GetRate, Next, Pause, Previous, SetRate
        ///</remarks>
        public bool Play()  => 
            MediaPlayer_methods.Play_method.Invoke(ObjPointer);

        ///<summary>Open the previous item in the current play list.</summary>
        ///<remarks>
        ///The player will start playing the new media source if it was playing
        ///something previously, otherwise it will only open the media source.
        ///
        ///@return true on success, false otherwise.
        ///@see Close, Next, OpenUrl, OpenSource, Play, SetPlaylist
        ///</remarks>
        public bool Previous()  => 
            MediaPlayer_methods.Previous_method.Invoke(ObjPointer);

        ///<summary>Reopens the currently opened media or play list.</summary>
        ///<remarks>
        ///@return true if the media will be opened, false otherwise.
        ///@see Close, Open, OpenFile, OpenPlaylist, OpenPlaylistIndex, OpenSource, OpenUrl
        ///</remarks>
        public bool Reopen()  => 
            MediaPlayer_methods.Reopen_method.Invoke(ObjPointer);

        ///<summary>Rewinds the media to the beginning.</summary>
        ///<remarks>
        ///This is the same as seeking to zero time.
        ///
        ///@return true if rewinding, false otherwise.
        ///@see GetTime, Seek
        ///</remarks>
        public bool Rewind()  => 
            MediaPlayer_methods.Rewind_method.Invoke(ObjPointer);

        ///<summary>Seeks to the specified playback time.</summary>
        ///<remarks>
        ///@param Time The playback time to set.
        ///@return true on success, false otherwise.
        ///@see GetTime, Rewind
        ///</remarks>
        public bool Seek(Timespan Time)  => 
            MediaPlayer_methods.Seek_method.Invoke(ObjPointer, Time);

        ///<summary>Select the active track of the given type.</summary>
        ///<remarks>
        ///The selected track will use its currently active format. Active formats will
        ///be remembered on a per track basis. The first available format is active by
        ///default. To switch the track format, use SetTrackFormat instead.
        ///
        ///@param TrackType The type of track to select.
        ///@param TrackIndex The index of the track to select, or INDEX_NONE to deselect.
        ///@return true if the track was selected, false otherwise.
        ///@see GetNumTracks, GetSelectedTrack, SetTrackFormat
        ///</remarks>
        public bool SelectTrack(EMediaPlayerTrack TrackType, int TrackIndex)  => 
            MediaPlayer_methods.SelectTrack_method.Invoke(ObjPointer, TrackType, TrackIndex);

        ///<summary>Set the time on which to block.</summary>
        ///<remarks>
        ///If set, this player will block in TickFetch until the video sample
        ///for the specified time are actually available.
        ///
        ///@param Time The time to block on, or FTimespan::MinValue to disable.
        ///</remarks>
        public void SetBlockOnTime(Timespan Time)  => 
            MediaPlayer_methods.SetBlockOnTime_method.Invoke(ObjPointer, Time);

        ///<summary>Set the name of the desired native player.</summary>
        ///<remarks>
        ///@param PlayerName The name of the player to set.
        ///@see GetDesiredPlayerName
        ///</remarks>
        public void SetDesiredPlayerName(Name PlayerName)  => 
            MediaPlayer_methods.SetDesiredPlayerName_method.Invoke(ObjPointer, PlayerName);

        ///<summary>Enables or disables playback looping.</summary>
        ///<remarks>
        ///@param Looping Whether playback should be looped.
        ///@return true on success, false otherwise.
        ///@see IsLooping
        ///</remarks>
        public bool SetLooping(bool Looping)  => 
            MediaPlayer_methods.SetLooping_method.Invoke(ObjPointer, Looping);

        ///<summary>Set the volume on the native player if not mixing with Sound Wave asset.</summary>
        ///<remarks>
        ///The SetNativeVolume can be used to change the audio output volume at runtime. Note that
        ///not all media player plug-ins may support native audio output on all platforms.
        ///
        ///@param Volume The volume to set.
        ///@return true on success, false otherwise.
        ///@see NativeAudioOut
        ///</remarks>
        public bool SetNativeVolume(float Volume)  => 
            MediaPlayer_methods.SetNativeVolume_method.Invoke(ObjPointer, Volume);

        ///<summary>Changes the media's playback rate.</summary>
        ///<remarks>
        ///@param Rate The playback rate to set.
        ///@return true on success, false otherwise.
        ///@see GetRate, SupportsRate
        ///</remarks>
        public bool SetRate(float Rate)  => 
            MediaPlayer_methods.SetRate_method.Invoke(ObjPointer, Rate);

        ///<summary>Delay of the player's time.</summary>
        ///<remarks>
        ///This setting can be used to manually sync multiple sources.
        ///Set to 1 seconds, if you would like that Player to play 1 second behind his current time.
        ///If the value is too big, it is possible that the player would not hold that frame for that long.
        ///@return true on success, false otherwise.
        ///@see GetTimeDelay
        ///</remarks>
        public void SetTimeDelay(Timespan TimeDelay)  => 
            MediaPlayer_methods.SetTimeDelay_method.Invoke(ObjPointer, TimeDelay);

        ///<summary>Set the format on the specified track.</summary>
        ///<remarks>
        ///Selecting the format will not switch to the specified track. To switch
        ///tracks, use SelectTrack instead. If the track is already selected, the
        ///format change will be applied immediately.
        ///
        ///@param TrackType The type of track to update.
        ///@param TrackIndex The index of the track to update.
        ///@param FormatIndex The index of the format to select (must be valid).
        ///@return true if the track was selected, false otherwise.
        ///@see GetNumTrackFormats, GetNumTracks, GetTrackFormat, SelectTrack
        ///</remarks>
        public bool SetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex, int FormatIndex)  => 
            MediaPlayer_methods.SetTrackFormat_method.Invoke(ObjPointer, TrackType, TrackIndex, FormatIndex);

        ///<summary>Set the frame rate of the specified video track.</summary>
        ///<remarks>
        ///@param TrackIndex The index of the track, or INDEX_NONE for the selected one.
        ///@param FormatIndex Index of the track format, or INDEX_NONE for the selected one.
        ///@param FrameRate The frame rate to set (must be in range of format's supported frame rates).
        ///@return true on success, false otherwise.
        ///@see GetVideoTrackAspectRatio, GetVideoTrackDimensions, GetVideoTrackFrameRate, GetVideoTrackFrameRates, GetVideoTrackType
        ///</remarks>
        public bool SetVideoTrackFrameRate(int TrackIndex, int FormatIndex, float FrameRate)  => 
            MediaPlayer_methods.SetVideoTrackFrameRate_method.Invoke(ObjPointer, TrackIndex, FormatIndex, FrameRate);

        ///<summary>Set the field of view (only for 360 videos).</summary>
        ///<remarks>
        ///@param Horizontal Horizontal field of view (in Euler degrees).
        ///@param Vertical Vertical field of view (in Euler degrees).
        ///@param Whether the field of view change should be absolute (true) or relative (false).
        ///@return true on success, false otherwise.
        ///@see GetHorizontalFieldOfView, GetVerticalFieldOfView, SetViewRotation
        ///</remarks>
        public bool SetViewField(float Horizontal, float Vertical, bool Absolute)  => 
            MediaPlayer_methods.SetViewField_method.Invoke(ObjPointer, Horizontal, Vertical, Absolute);

        ///<summary>Set the view's rotation (only for 360 videos).</summary>
        ///<remarks>
        ///@param Rotation The desired view rotation.
        ///@param Whether the rotation change should be absolute (true) or relative (false).
        ///@return true on success, false otherwise.
        ///@see GetViewRotation, SetViewField
        ///</remarks>
        public bool SetViewRotation(Rotator Rotation, bool Absolute)  => 
            MediaPlayer_methods.SetViewRotation_method.Invoke(ObjPointer, Rotation, Absolute);

        ///<summary>Check whether the specified playback rate is supported.</summary>
        ///<remarks>
        ///@param Rate The playback rate to check.
        ///@param Unthinned Whether no frames should be dropped at the given rate.
        ///@see SupportsScrubbing, SupportsSeeking
        ///</remarks>
        public bool SupportsRate(float Rate, bool Unthinned)  => 
            MediaPlayer_methods.SupportsRate_method.Invoke(ObjPointer, Rate, Unthinned);

        ///<summary>Check whether the currently loaded media supports scrubbing.</summary>
        ///<remarks>
        ///@return true if scrubbing is supported, false otherwise.
        ///@see SupportsRate, SupportsSeeking
        ///</remarks>
        public bool SupportsScrubbing()  => 
            MediaPlayer_methods.SupportsScrubbing_method.Invoke(ObjPointer);

        ///<summary>Check whether the currently loaded media can jump to a certain position.</summary>
        ///<remarks>
        ///@return true if seeking is supported, false otherwise.
        ///@see SupportsRate, SupportsScrubbing
        ///</remarks>
        public bool SupportsSeeking()  => 
            MediaPlayer_methods.SupportsSeeking_method.Invoke(ObjPointer);
         //TODO: multicast delegate FOnMediaPlayerMediaEvent OnEndReached
         //TODO: multicast delegate FOnMediaPlayerMediaEvent OnMediaClosed
         //TODO: multicast delegate FOnMediaPlayerMediaOpened OnMediaOpened
         //TODO: multicast delegate FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed
         //TODO: multicast delegate FOnMediaPlayerMediaEvent OnPlaybackResumed
         //TODO: multicast delegate FOnMediaPlayerMediaEvent OnPlaybackSuspended
         //TODO: multicast delegate FOnMediaPlayerMediaEvent OnSeekCompleted
         //TODO: multicast delegate FOnMediaPlayerMediaEvent OnTracksChanged
        ///<summary>Duration of samples to cache ahead of the play head.</summary>
        ///<remarks>
        ///@see CacheBehind, CacheBehindGame
        ///</remarks>
        public unsafe Timespan CacheAhead {
            get {return MediaPlayer_ptr->CacheAhead;}
            set {MediaPlayer_ptr->CacheAhead = value;}
        }
        ///<summary>Duration of samples to cache behind the play head (when not running as game).</summary>
        ///<remarks>
        ///@see CacheAhead, CacheBehindGame
        ///</remarks>
        public unsafe Timespan CacheBehind {
            get {return MediaPlayer_ptr->CacheBehind;}
            set {MediaPlayer_ptr->CacheBehind = value;}
        }
        ///<summary>Duration of samples to cache behind the play head (when running as game).</summary>
        ///<remarks>
        ///@see CacheAhead, CacheBehind
        ///</remarks>
        public unsafe Timespan CacheBehindGame {
            get {return MediaPlayer_ptr->CacheBehindGame;}
            set {MediaPlayer_ptr->CacheBehindGame = value;}
        }
        public bool NativeAudioOut {
            get {return Main.GetGetBoolPropertyByName(this, "NativeAudioOut"); }
            set {Main.SetGetBoolPropertyByName(this, "NativeAudioOut", value); }
        }
        public bool PlayOnOpen {
            get {return Main.GetGetBoolPropertyByName(this, "PlayOnOpen"); }
            set {Main.SetGetBoolPropertyByName(this, "PlayOnOpen", value); }
        }
        public bool Shuffle {
            get {return Main.GetGetBoolPropertyByName(this, "Shuffle"); }
            set {Main.SetGetBoolPropertyByName(this, "Shuffle", value); }
        }
        public bool Loop {
            get {return Main.GetGetBoolPropertyByName(this, "Loop"); }
        }
        ///<summary>The play list to use, if any.</summary>
        ///<remarks>
        ///Use the OpenPlaylist or OpenPlaylistIndex function to change this value at runtime.
        ///
        ///@see OpenPlaylist, OpenPlaylistIndex
        ///</remarks>
        public unsafe MediaPlaylist Playlist {
            get {return MediaPlayer_ptr->Playlist;}
        }
        ///<summary>The current index of the source in the play list being played.</summary>
        ///<remarks>
        ///Use the Previous and Next methods to change this value at runtime.
        ///
        ///@see Next, Previous
        ///</remarks>
        public unsafe int PlaylistIndex {
            get {return MediaPlayer_ptr->PlaylistIndex;}
        }
        ///<summary>Delay of the player's time.</summary>
        ///<remarks>
        ///@see SetTimeDelay, GetTimeDelay
        ///</remarks>
        public unsafe Timespan TimeDelay {
            get {return MediaPlayer_ptr->TimeDelay;}
        }
        ///<summary>The initial horizontal field of view (in Euler degrees; default = 90).</summary>
        ///<remarks>
        ///This setting is used only for 360 videos. It determines the portion of the
        ///video that is visible at a time. To modify the field of view at runtime in
        ///Blueprints, use the SetHorizontalFieldOfView function.
        ///
        ///@see GetHorizontalFieldOfView, SetHorizontalFieldOfView, VerticalFieldOfView, ViewRotation
        ///</remarks>
        public unsafe float HorizontalFieldOfView {
            get {return MediaPlayer_ptr->HorizontalFieldOfView;}
            set {MediaPlayer_ptr->HorizontalFieldOfView = value;}
        }
        ///<summary>The initial vertical field of view (in Euler degrees; default = 60).</summary>
        ///<remarks>
        ///This setting is used only for 360 videos. It determines the portion of the
        ///video that is visible at a time. To modify the field of view at runtime in
        ///Blueprints, use the SetHorizontalFieldOfView function.
        ///
        ///Please note that some 360 video players may be able to change only the
        ///horizontal field of view, and this setting may be ignored.
        ///
        ///@see GetVerticalFieldOfView, SetVerticalFieldOfView, HorizontalFieldOfView, ViewRotation
        ///</remarks>
        public unsafe float VerticalFieldOfView {
            get {return MediaPlayer_ptr->VerticalFieldOfView;}
            set {MediaPlayer_ptr->VerticalFieldOfView = value;}
        }
        ///<summary>The initial view rotation.</summary>
        ///<remarks>
        ///This setting is used only for 360 videos. It determines the rotation of
        ///the video's view. To modify the view orientation at runtime in Blueprints,
        ///use the GetViewRotation and SetViewRotation functions.
        ///
        ///Please note that not all players may support video view rotations.
        ///
        ///@see GetViewRotation, SetViewRotation, HorizontalFieldOfView, VerticalFieldOfView
        ///</remarks>
        public unsafe Rotator ViewRotation {
            get {return MediaPlayer_ptr->ViewRotation;}
            set {MediaPlayer_ptr->ViewRotation = value;}
        }
        ///<summary>The player's globally unique identifier.</summary>
        public unsafe FGuid PlayerGuid {
            get {return MediaPlayer_ptr->PlayerGuid;}
            set {MediaPlayer_ptr->PlayerGuid = value;}
        }
        public bool AffectedByPIEHandling {
            get {return Main.GetGetBoolPropertyByName(this, "AffectedByPIEHandling"); }
            set {Main.SetGetBoolPropertyByName(this, "AffectedByPIEHandling", value); }
        }
        static MediaPlayer() {
            StaticClass = Main.GetClass("MediaPlayer");
        }
        internal unsafe MediaPlayer_fields* MediaPlayer_ptr => (MediaPlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MediaPlayer(IntPtr p) => UObject.Make<MediaPlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MediaPlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MediaPlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
