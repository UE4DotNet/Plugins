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
    [StructLayout( LayoutKind.Explicit, Size=480 )]
    internal unsafe struct LocalPlayer_fields {
        [FieldOffset(128)]  public IntPtr  ViewportClient;
        [FieldOffset(164)] public byte AspectRatioAxisConstraint;
        [FieldOffset(168)] public IntPtr PendingLevelPlayerControllerClass;
        [FieldOffset(176)] public bool bSentSplitJoin;
        [FieldOffset(280)] public int ControllerId;
    }
    internal unsafe struct LocalPlayer_methods {
    }
    internal unsafe struct LocalPlayer_events {
    }
}
