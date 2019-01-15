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


namespace UE4.OnlineSubsystemUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=1048 )]
    internal unsafe struct OnlineBeaconHostObject_fields {
        [FieldOffset(1008)] byte BeaconTypeName; //TODO: string FString BeaconTypeName
        [FieldOffset(1024)] public IntPtr ClientBeaconActorClass;
        [FieldOffset(1032)] public NativeArray ClientActors;
    }
    internal unsafe struct OnlineBeaconHostObject_methods {
    }
    internal unsafe struct OnlineBeaconHostObject_events {
    }
}
