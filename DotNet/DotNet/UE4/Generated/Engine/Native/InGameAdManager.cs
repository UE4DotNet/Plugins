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
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct InGameAdManager_fields {
        [FieldOffset(72)] public bool bShouldPauseWhileAdOpen;
        [FieldOffset(80)] public NativeArray ClickedBannerDelegates;
        [FieldOffset(96)] public NativeArray ClosedAdDelegates;
    }
    internal unsafe struct InGameAdManager_methods {
    }
    internal unsafe struct InGameAdManager_events {
    }
}
