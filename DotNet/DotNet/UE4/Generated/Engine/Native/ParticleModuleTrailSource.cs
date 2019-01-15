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
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct ParticleModuleTrailSource_fields {
        [FieldOffset(72)] public byte SourceMethod;
        [FieldOffset(76)] public Name SourceName;
        [FieldOffset(88)] public RawDistributionFloat SourceStrength;
        [FieldOffset(144)] public bool bLockSourceStength;
        [FieldOffset(148)] public int SourceOffsetCount;
        [FieldOffset(152)] public NativeArray SourceOffsetDefaults;
        [FieldOffset(168)] public byte SelectionMethod;
        [FieldOffset(172)] public bool bInheritRotation;
    }
    internal unsafe struct ParticleModuleTrailSource_methods {
    }
    internal unsafe struct ParticleModuleTrailSource_events {
    }
}
