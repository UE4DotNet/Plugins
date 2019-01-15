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
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct TouchInterface_fields {
        [FieldOffset(56)] public NativeArray Controls;
        [FieldOffset(72)] public float ActiveOpacity;
        [FieldOffset(76)] public float InactiveOpacity;
        [FieldOffset(80)] public float TimeUntilDeactive;
        [FieldOffset(84)] public float TimeUntilReset;
        [FieldOffset(88)] public float ActivationDelay;
        [FieldOffset(92)] public bool bPreventRecenter;
        [FieldOffset(96)] public float StartupDelay;
    }
    internal unsafe struct TouchInterface_methods {
    }
    internal unsafe struct TouchInterface_events {
    }
}
