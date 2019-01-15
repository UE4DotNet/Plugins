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


namespace UE4.ArchVisCharacter.Native {
    [StructLayout( LayoutKind.Explicit, Size=2032 )]
    internal unsafe struct ArchVisCharMovementComponent_fields {
        [FieldOffset(1944)] public Rotator RotationalAcceleration;
        [FieldOffset(1956)] public Rotator RotationalDeceleration;
        [FieldOffset(1968)] public Rotator MaxRotationalVelocity;
        [FieldOffset(1980)] public float MinPitch;
        [FieldOffset(1984)] public float MaxPitch;
        [FieldOffset(1988)] public float WalkingFriction;
        [FieldOffset(1992)] public float WalkingSpeed;
        [FieldOffset(1996)] public float WalkingAcceleration;
    }
    internal unsafe struct ArchVisCharMovementComponent_methods {
    }
    internal unsafe struct ArchVisCharMovementComponent_events {
    }
}
