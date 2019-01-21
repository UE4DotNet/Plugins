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


namespace UE4.PixelInspectorModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=1040 )]
    internal unsafe struct PixelInspectorView_fields {
        [FieldOffset(840)] public LinearColor FinalColor;
        [FieldOffset(856)] public LinearColor SceneColor;
        [FieldOffset(872)] public float PreExposure;
        [FieldOffset(876)] public float Luminance;
        [FieldOffset(880)] public LinearColor HdrColor;
        [FieldOffset(896)] public Vector Normal;
        [FieldOffset(908)] public float PerObjectGBufferData;
        [FieldOffset(912)] public float Metallic;
        [FieldOffset(916)] public float Specular;
        [FieldOffset(920)] public float Roughness;
        [FieldOffset(924)] public byte MaterialShadingModel;
        [FieldOffset(928)] public int SelectiveOutputMask;
        [FieldOffset(932)] public LinearColor BaseColor;
        [FieldOffset(948)] public float IndirectIrradiance;
        [FieldOffset(952)] public float AmbientOcclusion;
        [FieldOffset(956)] public LinearColor SubSurfaceColor;
        [FieldOffset(972)] public Vector SubsurfaceProfile;
        [FieldOffset(984)] public float Opacity;
        [FieldOffset(988)] public float ClearCoat;
        [FieldOffset(992)] public float ClearCoatRoughness;
        [FieldOffset(996)] public Vector WorldNormal;
        [FieldOffset(1008)] public float BackLit;
        [FieldOffset(1012)] public float Cloth;
        [FieldOffset(1016)] public Vector EyeTangent;
        [FieldOffset(1028)] public float IrisMask;
        [FieldOffset(1032)] public float IrisDistance;
    }
    internal unsafe struct PixelInspectorView_methods {
    }
    internal unsafe struct PixelInspectorView_events {
    }
}
