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
    [StructLayout( LayoutKind.Explicit, Size=344 )]
    internal unsafe struct ParticleModuleLight_fields {
        [FieldOffset(72)] public bool bUseInverseSquaredFalloff;
        [FieldOffset(73)] public bool bAffectsTranslucency;
        [FieldOffset(74)] public bool bPreviewLightRadius;
        [FieldOffset(76)] public float SpawnFraction;
        [FieldOffset(80)] public RawDistributionVector ColorScaleOverLife;
        [FieldOffset(160)] public RawDistributionFloat BrightnessOverLife;
        [FieldOffset(216)] public RawDistributionFloat RadiusScale;
        [FieldOffset(272)] public RawDistributionFloat LightExponent;
        [FieldOffset(328)] public LightingChannels LightingChannels;
        [FieldOffset(332)] public float VolumetricScatteringIntensity;
        [FieldOffset(336)] public bool bHighQualityLights;
        [FieldOffset(337)] public bool bShadowCastingLights;
    }
    internal unsafe struct ParticleModuleLight_methods {
    }
    internal unsafe struct ParticleModuleLight_events {
    }
}
