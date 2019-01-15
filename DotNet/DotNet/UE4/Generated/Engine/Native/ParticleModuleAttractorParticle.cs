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
    [StructLayout( LayoutKind.Explicit, Size=224 )]
    internal unsafe struct ParticleModuleAttractorParticle_fields {
        [FieldOffset(72)] public Name EmitterName;
        [FieldOffset(88)] public RawDistributionFloat Range;
        [FieldOffset(144)] public bool bStrengthByDistance;
        [FieldOffset(152)] public RawDistributionFloat Strength;
        [FieldOffset(208)] public bool bAffectBaseVelocity;
        [FieldOffset(212)] public byte SelectionMethod;
        [FieldOffset(216)] public bool bRenewSource;
        [FieldOffset(216)] public bool bInheritSourceVel;
        [FieldOffset(220)] public int LastSelIndex;
    }
    internal unsafe struct ParticleModuleAttractorParticle_methods {
    }
    internal unsafe struct ParticleModuleAttractorParticle_events {
    }
}
