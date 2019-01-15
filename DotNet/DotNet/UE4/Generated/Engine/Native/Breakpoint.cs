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
    internal unsafe struct Breakpoint_fields {
        [FieldOffset(56)] public bool bEnabled;
        [FieldOffset(64)]  public IntPtr  Node;
        [FieldOffset(72)] public bool bStepOnce;
        [FieldOffset(72)] public bool bStepOnce_WasPreviouslyDisabled;
        [FieldOffset(72)] public bool bStepOnce_RemoveAfterHit;
    }
    internal unsafe struct Breakpoint_methods {
    }
    internal unsafe struct Breakpoint_events {
    }
}
