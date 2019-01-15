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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct TextureFactory_fields {
        [FieldOffset(136)] public bool NoCompression;
        [FieldOffset(136)] public bool NoAlpha;
        [FieldOffset(136)] public bool bDeferCompression;
        [FieldOffset(140)] public byte CompressionSettings;
        [FieldOffset(144)] public bool bCreateMaterial;
        [FieldOffset(144)] public bool bRGBToBaseColor;
        [FieldOffset(144)] public bool bRGBToEmissive;
        [FieldOffset(144)] public bool bAlphaToRoughness;
        [FieldOffset(144)] public bool bAlphaToEmissive;
        [FieldOffset(144)] public bool bAlphaToOpacity;
        [FieldOffset(144)] public bool bAlphaToOpacityMask;
        [FieldOffset(144)] public bool bTwoSided;
        [FieldOffset(148)] public byte Blending;
        [FieldOffset(149)] public byte ShadingModel;
        [FieldOffset(150)] public byte MipGenSettings;
        [FieldOffset(151)] public byte LODGroup;
        [FieldOffset(152)] public bool bDitherMipMapAlpha;
        [FieldOffset(160)] public Vector4 AlphaCoverageThresholds;
        [FieldOffset(176)] public bool bPreserveBorder;
        [FieldOffset(176)] public bool bFlipNormalMapGreenChannel;
        [FieldOffset(176)] public bool bUsingExistingSettings;
    }
    internal unsafe struct TextureFactory_methods {
    }
    internal unsafe struct TextureFactory_events {
    }
}
