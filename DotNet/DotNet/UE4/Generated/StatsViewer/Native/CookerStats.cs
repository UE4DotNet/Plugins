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


namespace UE4.StatsViewer.Native {
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct CookerStats_fields {
        [FieldOffset(56)] public NativeArray Assets;
        [FieldOffset(72)] public float SizeBefore;
        [FieldOffset(76)] public float SizeAfter;
        [FieldOffset(80)] byte Path; //TODO: string FString Path
    }
    internal unsafe struct CookerStats_methods {
    }
    internal unsafe struct CookerStats_events {
    }
}
