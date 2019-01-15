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
    [StructLayout( LayoutKind.Explicit, Size=376 )]
    internal unsafe struct SoundNodeEnveloper_fields {
        [FieldOffset(80)] public float LoopStart;
        [FieldOffset(84)] public float LoopEnd;
        [FieldOffset(88)] public float DurationAfterLoop;
        [FieldOffset(92)] public int LoopCount;
        [FieldOffset(96)] public bool bLoopIndefinitely;
        [FieldOffset(96)] public bool bLoop;
        [FieldOffset(120)] public RuntimeFloatCurve VolumeCurve;
        [FieldOffset(240)] public RuntimeFloatCurve PitchCurve;
        [FieldOffset(360)] public float PitchMin;
        [FieldOffset(364)] public float PitchMax;
        [FieldOffset(368)] public float VolumeMin;
        [FieldOffset(372)] public float VolumeMax;
    }
    internal unsafe struct SoundNodeEnveloper_methods {
    }
    internal unsafe struct SoundNodeEnveloper_events {
    }
}
