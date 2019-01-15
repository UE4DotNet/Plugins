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
    internal unsafe struct LightingBuildInfo_fields {
        [FieldOffset(56)] byte UObject; //TODO: weak object TWeakObjectPtr<UObject> UObject
        [FieldOffset(64)] public float LightingTime;
        [FieldOffset(68)] public float UnmappedTexelsPercentage;
        [FieldOffset(72)] public float UnmappedTexelsMemory;
        [FieldOffset(76)] public float TotalTexelMemory;
        [FieldOffset(80)] byte LevelName; //TODO: string FString LevelName
    }
    internal unsafe struct LightingBuildInfo_methods {
    }
    internal unsafe struct LightingBuildInfo_events {
    }
}
