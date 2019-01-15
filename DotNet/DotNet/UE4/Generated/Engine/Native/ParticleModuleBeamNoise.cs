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
    [StructLayout( LayoutKind.Explicit, Size=464 )]
    internal unsafe struct ParticleModuleBeamNoise_fields {
        [FieldOffset(72)] public bool bLowFreq_Enabled;
        [FieldOffset(76)] public int Frequency;
        [FieldOffset(80)] public int Frequency_LowRange;
        [FieldOffset(88)] public RawDistributionVector NoiseRange;
        [FieldOffset(168)] public RawDistributionFloat NoiseRangeScale;
        [FieldOffset(224)] public bool bNRScaleEmitterTime;
        [FieldOffset(232)] public RawDistributionVector NoiseSpeed;
        [FieldOffset(312)] public bool bSmooth;
        [FieldOffset(316)] public float NoiseLockRadius;
        [FieldOffset(320)] public bool bNoiseLock;
        [FieldOffset(320)] public bool bOscillate;
        [FieldOffset(324)] public float NoiseLockTime;
        [FieldOffset(328)] public float NoiseTension;
        [FieldOffset(332)] public bool bUseNoiseTangents;
        [FieldOffset(336)] public RawDistributionFloat NoiseTangentStrength;
        [FieldOffset(392)] public int NoiseTessellation;
        [FieldOffset(396)] public bool bTargetNoise;
        [FieldOffset(400)] public float FrequencyDistance;
        [FieldOffset(404)] public bool bApplyNoiseScale;
        [FieldOffset(408)] public RawDistributionFloat NoiseScale;
    }
    internal unsafe struct ParticleModuleBeamNoise_methods {
    }
    internal unsafe struct ParticleModuleBeamNoise_events {
    }
}
