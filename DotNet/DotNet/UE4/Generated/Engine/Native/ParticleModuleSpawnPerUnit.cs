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
    [StructLayout( LayoutKind.Explicit, Size=160 )]
    internal unsafe struct ParticleModuleSpawnPerUnit_fields {
        [FieldOffset(80)] public float UnitScalar;
        [FieldOffset(88)] public RawDistributionFloat SpawnPerUnit;
        [FieldOffset(144)] public bool bIgnoreSpawnRateWhenMoving;
        [FieldOffset(148)] public float MovementTolerance;
        [FieldOffset(152)] public float MaxFrameDistance;
        [FieldOffset(156)] public bool bIgnoreMovementAlongX;
        [FieldOffset(156)] public bool bIgnoreMovementAlongY;
        [FieldOffset(156)] public bool bIgnoreMovementAlongZ;
    }
    internal unsafe struct ParticleModuleSpawnPerUnit_methods {
    }
    internal unsafe struct ParticleModuleSpawnPerUnit_events {
    }
}
