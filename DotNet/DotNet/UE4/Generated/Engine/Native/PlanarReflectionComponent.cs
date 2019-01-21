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
    [StructLayout( LayoutKind.Explicit, Size=1024 )]
    internal unsafe struct PlanarReflectionComponent_fields {
        [FieldOffset(792)]  public IntPtr  PreviewBox;
        [FieldOffset(800)] public float NormalDistortionStrength;
        [FieldOffset(804)] public float PrefilterRoughness;
        [FieldOffset(808)] public float PrefilterRoughnessDistance;
        [FieldOffset(812)] public int ScreenPercentage;
        [FieldOffset(816)] public float ExtraFOV;
        [FieldOffset(828)] public float DistanceFromPlaneFadeoutStart;
        [FieldOffset(832)] public float DistanceFromPlaneFadeoutEnd;
        [FieldOffset(836)] public float AngleFromPlaneFadeStart;
        [FieldOffset(840)] public float AngleFromPlaneFadeEnd;
        [FieldOffset(844)] public bool bRenderSceneTwoSided;
    }
    internal unsafe struct PlanarReflectionComponent_methods {
    }
    internal unsafe struct PlanarReflectionComponent_events {
    }
}
