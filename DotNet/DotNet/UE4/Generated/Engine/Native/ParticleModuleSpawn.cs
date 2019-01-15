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
    [StructLayout( LayoutKind.Explicit, Size=280 )]
    internal unsafe struct ParticleModuleSpawn_fields {
        [FieldOffset(80)] public RawDistributionFloat Rate;
        [FieldOffset(136)] public RawDistributionFloat RateScale;
        [FieldOffset(192)] public byte ParticleBurstMethod;
        [FieldOffset(200)] public NativeArray BurstList;
        [FieldOffset(216)] public RawDistributionFloat BurstScale;
        [FieldOffset(272)] public bool bApplyGlobalSpawnRateScale;
    }
    internal unsafe struct ParticleModuleSpawn_methods {
    }
    internal unsafe struct ParticleModuleSpawn_events {
    }
}
