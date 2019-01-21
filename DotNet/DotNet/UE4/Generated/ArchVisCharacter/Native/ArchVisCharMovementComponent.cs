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
    [StructLayout( LayoutKind.Explicit, Size=1968 )]
    internal unsafe struct ArchVisCharMovementComponent_fields {
        [FieldOffset(1888)] public Rotator RotationalAcceleration;
        [FieldOffset(1900)] public Rotator RotationalDeceleration;
        [FieldOffset(1912)] public Rotator MaxRotationalVelocity;
        [FieldOffset(1924)] public float MinPitch;
        [FieldOffset(1928)] public float MaxPitch;
        [FieldOffset(1932)] public float WalkingFriction;
        [FieldOffset(1936)] public float WalkingSpeed;
        [FieldOffset(1940)] public float WalkingAcceleration;
    }
    internal unsafe struct ArchVisCharMovementComponent_methods {
    }
    internal unsafe struct ArchVisCharMovementComponent_events {
    }
}
