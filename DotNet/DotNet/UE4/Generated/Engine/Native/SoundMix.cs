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
    [StructLayout( LayoutKind.Explicit, Size=160 )]
    internal unsafe struct SoundMix_fields {
        [FieldOffset(56)] public bool bApplyEQ;
        [FieldOffset(60)] public float EQPriority;
        [FieldOffset(64)] public AudioEQEffect EQSettings;
        [FieldOffset(120)] public NativeArray SoundClassEffects;
        [FieldOffset(136)] public float InitialDelay;
        [FieldOffset(140)] public float FadeInTime;
        [FieldOffset(144)] public float Duration;
        [FieldOffset(148)] public float FadeOutTime;
        [FieldOffset(152)] public bool bChanged;
    }
    internal unsafe struct SoundMix_methods {
    }
    internal unsafe struct SoundMix_events {
    }
}
