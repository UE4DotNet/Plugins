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
    [StructLayout( LayoutKind.Explicit, Size=88 )]
    internal unsafe struct Player_fields {
        [FieldOffset(64)]  public IntPtr  PlayerController;
        [FieldOffset(72)] public int CurrentNetSpeed;
        [FieldOffset(76)] public int ConfiguredInternetSpeed;
        [FieldOffset(80)] public int ConfiguredLanSpeed;
    }
    internal unsafe struct Player_methods {
    }
    internal unsafe struct Player_events {
    }
}
