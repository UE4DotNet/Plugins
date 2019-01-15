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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct WorldComposition_fields {
        [FieldOffset(96)] public NativeArray TilesStreaming;
        [FieldOffset(112)] public double TilesStreamingTimeThreshold;
        [FieldOffset(120)] public bool bLoadAllTilesDuringCinematic;
        [FieldOffset(121)] public bool bRebaseOriginIn3DSpace;
        [FieldOffset(122)] public bool bLockTilesLocation;
        [FieldOffset(124)] public float RebaseOriginDistance;
    }
    internal unsafe struct WorldComposition_methods {
    }
    internal unsafe struct WorldComposition_events {
    }
}
