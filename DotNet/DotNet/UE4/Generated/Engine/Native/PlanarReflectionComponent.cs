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
    [StructLayout( LayoutKind.Explicit, Size=1008 )]
    internal unsafe struct PlanarReflectionComponent_fields {
        [FieldOffset(784)]  public IntPtr  PreviewBox;
        [FieldOffset(792)] public float NormalDistortionStrength;
        [FieldOffset(796)] public float PrefilterRoughness;
        [FieldOffset(800)] public float PrefilterRoughnessDistance;
        [FieldOffset(804)] public int ScreenPercentage;
        [FieldOffset(808)] public float ExtraFOV;
        [FieldOffset(820)] public float DistanceFromPlaneFadeoutStart;
        [FieldOffset(824)] public float DistanceFromPlaneFadeoutEnd;
        [FieldOffset(828)] public float AngleFromPlaneFadeStart;
        [FieldOffset(832)] public float AngleFromPlaneFadeEnd;
        [FieldOffset(836)] public bool bRenderSceneTwoSided;
    }
    internal unsafe struct PlanarReflectionComponent_methods {
    }
    internal unsafe struct PlanarReflectionComponent_events {
    }
}
