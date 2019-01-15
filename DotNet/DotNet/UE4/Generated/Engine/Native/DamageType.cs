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
    [StructLayout( LayoutKind.Explicit, Size=80 )]
    internal unsafe struct DamageType_fields {
        [FieldOffset(56)] public bool bCausedByWorld;
        [FieldOffset(56)] public bool bScaleMomentumByMass;
        [FieldOffset(56)] public bool bRadialDamageVelChange;
        [FieldOffset(60)] public float DamageImpulse;
        [FieldOffset(64)] public float DestructibleImpulse;
        [FieldOffset(68)] public float DestructibleDamageSpreadScale;
        [FieldOffset(72)] public float DamageFalloff;
    }
    internal unsafe struct DamageType_methods {
    }
    internal unsafe struct DamageType_events {
    }
}
