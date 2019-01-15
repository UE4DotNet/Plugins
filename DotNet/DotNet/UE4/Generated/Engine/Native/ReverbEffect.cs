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
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct ReverbEffect_fields {
        [FieldOffset(56)] public float Density;
        [FieldOffset(60)] public float Diffusion;
        [FieldOffset(64)] public float Gain;
        [FieldOffset(68)] public float GainHF;
        [FieldOffset(72)] public float DecayTime;
        [FieldOffset(76)] public float DecayHFRatio;
        [FieldOffset(80)] public float ReflectionsGain;
        [FieldOffset(84)] public float ReflectionsDelay;
        [FieldOffset(88)] public float LateGain;
        [FieldOffset(92)] public float LateDelay;
        [FieldOffset(96)] public float AirAbsorptionGainHF;
        [FieldOffset(100)] public float RoomRolloffFactor;
        [FieldOffset(104)] public bool bChanged;
    }
    internal unsafe struct ReverbEffect_methods {
    }
    internal unsafe struct ReverbEffect_events {
    }
}
