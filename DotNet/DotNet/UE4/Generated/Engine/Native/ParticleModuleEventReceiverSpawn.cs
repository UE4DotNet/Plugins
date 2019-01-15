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
    [StructLayout( LayoutKind.Explicit, Size=256 )]
    internal unsafe struct ParticleModuleEventReceiverSpawn_fields {
        [FieldOffset(88)] public RawDistributionFloat SpawnCount;
        [FieldOffset(144)] public bool bUseParticleTime;
        [FieldOffset(144)] public bool bUsePSysLocation;
        [FieldOffset(144)] public bool bInheritVelocity;
        [FieldOffset(152)] public RawDistributionVector InheritVelocityScale;
        [FieldOffset(232)] public NativeArray PhysicalMaterials;
        [FieldOffset(248)] public bool bBanPhysicalMaterials;
    }
    internal unsafe struct ParticleModuleEventReceiverSpawn_methods {
    }
    internal unsafe struct ParticleModuleEventReceiverSpawn_events {
    }
}
