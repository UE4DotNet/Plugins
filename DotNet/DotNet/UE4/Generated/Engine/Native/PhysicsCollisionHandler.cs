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
    internal unsafe struct PhysicsCollisionHandler_fields {
        [FieldOffset(56)] public float ImpactThreshold;
        [FieldOffset(60)] public float ImpactReFireDelay;
        [FieldOffset(64)]  public IntPtr  DefaultImpactSound;
        [FieldOffset(72)] public float LastImpactSoundTime;
    }
    internal unsafe struct PhysicsCollisionHandler_methods {
    }
    internal unsafe struct PhysicsCollisionHandler_events {
    }
}
