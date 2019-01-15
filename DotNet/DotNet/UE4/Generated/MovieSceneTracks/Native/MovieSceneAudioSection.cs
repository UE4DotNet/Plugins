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

using UE4.MovieScene;

namespace UE4.MovieSceneTracks.Native {
    [StructLayout( LayoutKind.Explicit, Size=728 )]
    internal unsafe struct MovieSceneAudioSection_fields {
        [FieldOffset(312)]  public IntPtr  Sound;
        [FieldOffset(320)] public float StartOffset;
        [FieldOffset(336)] public MovieSceneFloatChannel SoundVolume;
        [FieldOffset(496)] public MovieSceneFloatChannel PitchMultiplier;
        [FieldOffset(656)] public bool bSuppressSubtitles;
        [FieldOffset(657)] public bool bOverrideAttenuation;
        [FieldOffset(664)]  public IntPtr  AttenuationSettings;
        [FieldOffset(672)] byte OnQueueSubtitles; //TODO: delegate FOnQueueSubtitles OnQueueSubtitles
        [FieldOffset(696)] byte OnAudioFinished; //TODO: multicast delegate FOnAudioFinished OnAudioFinished
        [FieldOffset(712)] byte OnAudioPlaybackPercent; //TODO: multicast delegate FOnAudioPlaybackPercent OnAudioPlaybackPercent
    }
    internal unsafe struct MovieSceneAudioSection_methods {
    }
    internal unsafe struct MovieSceneAudioSection_events {
    }
}
