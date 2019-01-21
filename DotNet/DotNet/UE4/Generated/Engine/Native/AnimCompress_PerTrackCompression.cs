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
    [StructLayout( LayoutKind.Explicit, Size=256 )]
    internal unsafe struct AnimCompress_PerTrackCompression_fields {
        [FieldOffset(128)] public float MaxZeroingThreshold;
        [FieldOffset(132)] public float MaxPosDiffBitwise;
        [FieldOffset(136)] public float MaxAngleDiffBitwise;
        [FieldOffset(140)] public float MaxScaleDiffBitwise;
        [FieldOffset(144)] public NativeArray AllowedRotationFormats;
        [FieldOffset(160)] public NativeArray AllowedTranslationFormats;
        [FieldOffset(176)] public NativeArray AllowedScaleFormats;
        [FieldOffset(192)] public bool bResampleAnimation;
        [FieldOffset(196)] public float ResampledFramerate;
        [FieldOffset(200)] public int MinKeysForResampling;
        [FieldOffset(204)] public bool bUseAdaptiveError;
        [FieldOffset(204)] public bool bUseOverrideForEndEffectors;
        [FieldOffset(208)] public int TrackHeightBias;
        [FieldOffset(212)] public float ParentingDivisor;
        [FieldOffset(216)] public float ParentingDivisorExponent;
        [FieldOffset(220)] public bool bUseAdaptiveError2;
        [FieldOffset(224)] public float RotationErrorSourceRatio;
        [FieldOffset(228)] public float TranslationErrorSourceRatio;
        [FieldOffset(232)] public float ScaleErrorSourceRatio;
        [FieldOffset(236)] public float MaxErrorPerTrackRatio;
        [FieldOffset(240)] public float PerturbationProbeSize;
    }
    internal unsafe struct AnimCompress_PerTrackCompression_methods {
    }
    internal unsafe struct AnimCompress_PerTrackCompression_events {
    }
}
