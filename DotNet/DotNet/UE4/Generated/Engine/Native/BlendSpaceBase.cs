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
    [StructLayout( LayoutKind.Explicit, Size=496 )]
    internal unsafe struct BlendSpaceBase_fields {
        [FieldOffset(248)] public bool bRotationBlendInMeshSpace;
        [FieldOffset(256)]  public IntPtr  PreviewBasePose;
        [FieldOffset(264)] public float AnimLength;
        [FieldOffset(268)] public InterpolationParameter InterpolationParam;
        [FieldOffset(292)] public float TargetWeightInterpolationSpeedPerSec;
        [FieldOffset(296)] public byte NotifyTriggerMode;
        [FieldOffset(304)] public NativeArray PerBoneBlend;
        [FieldOffset(320)] public int SampleIndexWithMarkers;
        [FieldOffset(328)] public NativeArray SampleData;
        [FieldOffset(344)] public NativeArray GridSamples;
        [FieldOffset(360)] public BlendParameter BlendParameters;
    }
    internal unsafe struct BlendSpaceBase_methods {
    }
    internal unsafe struct BlendSpaceBase_events {
    }
}
