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
    [StructLayout( LayoutKind.Explicit, Size=328 )]
    internal unsafe struct AudioSettings_fields {
        [FieldOffset(80)] public SoftObjectPath DefaultSoundClassName;
        [FieldOffset(112)] public SoftObjectPath DefaultMediaSoundClassName;
        [FieldOffset(144)] public SoftObjectPath DefaultSoundConcurrencyName;
        [FieldOffset(176)] public SoftObjectPath DefaultBaseSoundMix;
        [FieldOffset(208)] public SoftObjectPath VoiPSoundClass;
        [FieldOffset(240)] byte VoiPSampleRate; //TODO: enum EVoiceSampleRate VoiPSampleRate
        [FieldOffset(244)] public float VoipBufferingDelay;
        [FieldOffset(248)] public float DefaultReverbSendLevel;
        [FieldOffset(252)] public int MaximumConcurrentStreams;
        [FieldOffset(256)] public NativeArray QualityLevels;
        [FieldOffset(272)] public bool bAllowVirtualizedSounds;
        [FieldOffset(272)] public bool bDisableMasterEQ;
        [FieldOffset(272)] public bool bAllowCenterChannel3DPanning;
        [FieldOffset(276)] byte MaxWaveInstances; //TODO: numeric uint32 MaxWaveInstances
        [FieldOffset(280)] byte NumStoppingSources; //TODO: numeric uint32 NumStoppingSources
        [FieldOffset(284)] byte PanningMethod; //TODO: enum EPanningMethod PanningMethod
        [FieldOffset(285)] byte MonoChannelUpmixMethod; //TODO: enum EMonoChannelUpmixMethod MonoChannelUpmixMethod
        [FieldOffset(288)] byte DialogueFilenameFormat; //TODO: string FString DialogueFilenameFormat
    }
    internal unsafe struct AudioSettings_methods {
    }
    internal unsafe struct AudioSettings_events {
    }
}
