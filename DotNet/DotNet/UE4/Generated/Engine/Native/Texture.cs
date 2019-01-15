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
    [StructLayout( LayoutKind.Explicit, Size=528 )]
    internal unsafe struct Texture_fields {
        [FieldOffset(64)] public TextureSource Source;
        [FieldOffset(240)] public FGuid LightingGuid;
        [FieldOffset(272)]  public IntPtr  AssetImportData;
        [FieldOffset(280)] public float AdjustBrightness;
        [FieldOffset(284)] public float AdjustBrightnessCurve;
        [FieldOffset(288)] public float AdjustVibrance;
        [FieldOffset(292)] public float AdjustSaturation;
        [FieldOffset(296)] public float AdjustRGBCurve;
        [FieldOffset(300)] public float AdjustHue;
        [FieldOffset(304)] public float AdjustMinAlpha;
        [FieldOffset(308)] public float AdjustMaxAlpha;
        [FieldOffset(312)] public bool CompressionNoAlpha;
        [FieldOffset(312)] public bool CompressionNone;
        [FieldOffset(312)] public bool DeferCompression;
        [FieldOffset(316)] public int MaxTextureSize;
        [FieldOffset(320)] public byte CompressionQuality;
        [FieldOffset(324)] public bool bDitherMipMapAlpha;
        [FieldOffset(336)] public Vector4 AlphaCoverageThresholds;
        [FieldOffset(352)] public bool bPreserveBorder;
        [FieldOffset(352)] public bool bFlipGreenChannel;
        [FieldOffset(352)] public bool bForcePVRTC4;
        [FieldOffset(356)] public byte PowerOfTwoMode;
        [FieldOffset(360)] public Color PaddingColor;
        [FieldOffset(364)] public bool bChromaKeyTexture;
        [FieldOffset(368)] public float ChromaKeyThreshold;
        [FieldOffset(372)] public Color ChromaKeyColor;
        [FieldOffset(376)] public byte MipGenSettings;
        [FieldOffset(384)]  public IntPtr  CompositeTexture;
        [FieldOffset(392)] public byte CompositeTextureMode;
        [FieldOffset(396)] public float CompositePower;
        [FieldOffset(400)] public int LODBias;
        [FieldOffset(404)] public int NumCinematicMipLevels;
        [FieldOffset(408)] public byte CompressionSettings;
        [FieldOffset(409)] public byte Filter;
        [FieldOffset(410)] public byte LODGroup;
        [FieldOffset(411)] public bool SRGB;
        [FieldOffset(411)] public bool bUseLegacyGamma;
        [FieldOffset(411)] public bool NeverStream;
        [FieldOffset(411)] public bool bNoTiling;
        [FieldOffset(411)] public bool bUseCinematicMipLevels;
        [FieldOffset(411)] public bool bAsyncResourceReleaseHasBeenStarted;
        [FieldOffset(412)] public int CachedCombinedLODBias;
        [FieldOffset(416)] public NativeArray AssetUserData;
    }
    internal unsafe struct Texture_methods {
    }
    internal unsafe struct Texture_events {
    }
}
