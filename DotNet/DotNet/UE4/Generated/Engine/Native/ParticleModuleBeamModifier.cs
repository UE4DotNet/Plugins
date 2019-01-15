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
    [StructLayout( LayoutKind.Explicit, Size=312 )]
    internal unsafe struct ParticleModuleBeamModifier_fields {
        [FieldOffset(72)] public byte ModifierType;
        [FieldOffset(76)] public BeamModifierOptions PositionOptions;
        [FieldOffset(80)] public RawDistributionVector Position;
        [FieldOffset(160)] public BeamModifierOptions TangentOptions;
        [FieldOffset(168)] public RawDistributionVector Tangent;
        [FieldOffset(248)] public bool bAbsoluteTangent;
        [FieldOffset(252)] public BeamModifierOptions StrengthOptions;
        [FieldOffset(256)] public RawDistributionFloat Strength;
    }
    internal unsafe struct ParticleModuleBeamModifier_methods {
    }
    internal unsafe struct ParticleModuleBeamModifier_events {
    }
}
