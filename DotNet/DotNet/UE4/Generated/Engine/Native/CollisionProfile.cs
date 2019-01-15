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
    [StructLayout( LayoutKind.Explicit, Size=368 )]
    internal unsafe struct CollisionProfile_fields {
        [FieldOffset(80)] public NativeArray Profiles;
        [FieldOffset(96)] public NativeArray DefaultChannelResponses;
        [FieldOffset(112)] public NativeArray EditProfiles;
        [FieldOffset(128)] public NativeArray ProfileRedirects;
        [FieldOffset(144)] public NativeArray CollisionChannelRedirects;
    }
    internal unsafe struct CollisionProfile_methods {
    }
    internal unsafe struct CollisionProfile_events {
    }
}
