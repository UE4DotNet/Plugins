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
    [StructLayout( LayoutKind.Explicit, Size=1032 )]
    internal unsafe struct PixelInspectorView_fields {
        [FieldOffset(840)] public LinearColor FinalColor;
        [FieldOffset(856)] public LinearColor SceneColor;
        [FieldOffset(872)] public float Luminance;
        [FieldOffset(876)] public LinearColor HdrColor;
        [FieldOffset(892)] public Vector Normal;
        [FieldOffset(904)] public float PerObjectGBufferData;
        [FieldOffset(908)] public float Metallic;
        [FieldOffset(912)] public float Specular;
        [FieldOffset(916)] public float Roughness;
        [FieldOffset(920)] public byte MaterialShadingModel;
        [FieldOffset(924)] public int SelectiveOutputMask;
        [FieldOffset(928)] public LinearColor BaseColor;
        [FieldOffset(944)] public float IndirectIrradiance;
        [FieldOffset(948)] public float AmbientOcclusion;
        [FieldOffset(952)] public LinearColor SubSurfaceColor;
        [FieldOffset(968)] public Vector SubsurfaceProfile;
        [FieldOffset(980)] public float Opacity;
        [FieldOffset(984)] public float ClearCoat;
        [FieldOffset(988)] public float ClearCoatRoughness;
        [FieldOffset(992)] public Vector WorldNormal;
        [FieldOffset(1004)] public float BackLit;
        [FieldOffset(1008)] public float Cloth;
        [FieldOffset(1012)] public Vector EyeTangent;
        [FieldOffset(1024)] public float IrisMask;
        [FieldOffset(1028)] public float IrisDistance;
    }
    internal unsafe struct PixelInspectorView_methods {
    }
    internal unsafe struct PixelInspectorView_events {
    }
}
