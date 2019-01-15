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
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct AnimCompress_PerTrackCompression_fields {
        [FieldOffset(120)] public float MaxZeroingThreshold;
        [FieldOffset(124)] public float MaxPosDiffBitwise;
        [FieldOffset(128)] public float MaxAngleDiffBitwise;
        [FieldOffset(132)] public float MaxScaleDiffBitwise;
        [FieldOffset(136)] public NativeArray AllowedRotationFormats;
        [FieldOffset(152)] public NativeArray AllowedTranslationFormats;
        [FieldOffset(168)] public NativeArray AllowedScaleFormats;
        [FieldOffset(184)] public bool bResampleAnimation;
        [FieldOffset(188)] public float ResampledFramerate;
        [FieldOffset(192)] public int MinKeysForResampling;
        [FieldOffset(196)] public bool bUseAdaptiveError;
        [FieldOffset(196)] public bool bUseOverrideForEndEffectors;
        [FieldOffset(200)] public int TrackHeightBias;
        [FieldOffset(204)] public float ParentingDivisor;
        [FieldOffset(208)] public float ParentingDivisorExponent;
        [FieldOffset(212)] public bool bUseAdaptiveError2;
        [FieldOffset(216)] public float RotationErrorSourceRatio;
        [FieldOffset(220)] public float TranslationErrorSourceRatio;
        [FieldOffset(224)] public float ScaleErrorSourceRatio;
        [FieldOffset(228)] public float MaxErrorPerTrackRatio;
        [FieldOffset(232)] public float PerturbationProbeSize;
    }
    internal unsafe struct AnimCompress_PerTrackCompression_methods {
    }
    internal unsafe struct AnimCompress_PerTrackCompression_events {
    }
}
