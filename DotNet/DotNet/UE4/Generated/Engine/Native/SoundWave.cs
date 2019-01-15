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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=712 )]
    internal unsafe struct SoundWave_fields {
        [FieldOffset(192)] public int CompressionQuality;
        [FieldOffset(196)] public int StreamingPriority;
        [FieldOffset(200)] byte SampleRateQuality; //TODO: enum ESoundwaveSampleRateSettings SampleRateQuality
        [FieldOffset(202)] public byte SoundGroup;
        [FieldOffset(203)] public bool bLooping;
        [FieldOffset(203)] public bool bStreaming;
        [FieldOffset(203)] public bool bMature;
        [FieldOffset(204)] public bool bManualWordWrap;
        [FieldOffset(204)] public bool bSingleLine;
        [FieldOffset(204)] public bool bVirtualizeWhenSilent;
        [FieldOffset(204)] public bool bIsAmbisonics;
        [FieldOffset(216)] byte SpokenText; //TODO: string FString SpokenText
        [FieldOffset(232)] public float SubtitlePriority;
        [FieldOffset(236)] public float Volume;
        [FieldOffset(240)] public float Pitch;
        [FieldOffset(244)] public int NumChannels;
        [FieldOffset(248)] public NativeArray ChannelOffsets;
        [FieldOffset(264)] public NativeArray ChannelSizes;
        [FieldOffset(280)] public int RawPCMDataSize;
        [FieldOffset(284)] public int SampleRate;
        [FieldOffset(288)] public NativeArray Subtitles;
        [FieldOffset(304)] byte Comment; //TODO: string FString Comment
        [FieldOffset(320)] public NativeArray LocalizedSubtitles;
        [FieldOffset(368)]  public IntPtr  AssetImportData;
        [FieldOffset(376)]  public IntPtr  Curves;
        [FieldOffset(384)]  public IntPtr  InternalCurves;
    }
    internal unsafe struct SoundWave_methods {
    }
    internal unsafe struct SoundWave_events {
    }
}
