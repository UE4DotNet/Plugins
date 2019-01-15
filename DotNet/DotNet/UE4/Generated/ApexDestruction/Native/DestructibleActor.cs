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


namespace UE4.ApexDestruction.Native {
    [StructLayout( LayoutKind.Explicit, Size=1040 )]
    internal unsafe struct DestructibleActor_fields {
        [FieldOffset(1008)]  public IntPtr  DestructibleComponent;
        [FieldOffset(1016)] public bool bAffectNavigation;
        [FieldOffset(1024)] byte OnActorFracture; //TODO: multicast delegate FActorFractureSignature OnActorFracture
    }
    internal unsafe struct DestructibleActor_methods {
    }
    internal unsafe struct DestructibleActor_events {
    }
}
