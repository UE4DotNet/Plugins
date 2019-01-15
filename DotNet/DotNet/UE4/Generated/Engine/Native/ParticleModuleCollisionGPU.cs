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
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct ParticleModuleCollisionGPU_fields {
        [FieldOffset(72)] public RawDistributionFloat Resilience;
        [FieldOffset(128)] public RawDistributionFloat ResilienceScaleOverLife;
        [FieldOffset(184)] public float Friction;
        [FieldOffset(188)] public float RandomSpread;
        [FieldOffset(192)] public float RandomDistribution;
        [FieldOffset(196)] public float RadiusScale;
        [FieldOffset(200)] public float RadiusBias;
        [FieldOffset(204)] public byte Response;
        [FieldOffset(205)] public byte CollisionMode;
    }
    internal unsafe struct ParticleModuleCollisionGPU_methods {
    }
    internal unsafe struct ParticleModuleCollisionGPU_events {
    }
}
