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
    [StructLayout( LayoutKind.Explicit, Size=272 )]
    internal unsafe struct ParticleModuleAttractorPoint_fields {
        [FieldOffset(72)] public RawDistributionVector Position;
        [FieldOffset(152)] public RawDistributionFloat Range;
        [FieldOffset(208)] public RawDistributionFloat Strength;
        [FieldOffset(264)] public bool StrengthByDistance;
        [FieldOffset(264)] public bool bAffectBaseVelocity;
        [FieldOffset(264)] public bool bOverrideVelocity;
        [FieldOffset(264)] public bool bUseWorldSpacePosition;
        [FieldOffset(264)] public bool Positive_X;
        [FieldOffset(264)] public bool Positive_Y;
        [FieldOffset(264)] public bool Positive_Z;
        [FieldOffset(264)] public bool Negative_X;
        [FieldOffset(265)] public bool Negative_Y;
        [FieldOffset(265)] public bool Negative_Z;
    }
    internal unsafe struct ParticleModuleAttractorPoint_methods {
    }
    internal unsafe struct ParticleModuleAttractorPoint_events {
    }
}
