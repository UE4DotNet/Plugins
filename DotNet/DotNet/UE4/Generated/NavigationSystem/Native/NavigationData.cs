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

using UE4.Engine;

namespace UE4.NavigationSystem.Native {
    [StructLayout( LayoutKind.Explicit, Size=1480 )]
    internal unsafe struct NavigationData_fields {
        [FieldOffset(1016)]  public IntPtr  RenderingComp;
        [FieldOffset(1024)] public NavDataConfig NavDataConfig;
        [FieldOffset(1152)] public bool bEnableDrawing;
        [FieldOffset(1152)] public bool bForceRebuildOnLoad;
        [FieldOffset(1152)] public bool bCanBeMainNavData;
        [FieldOffset(1152)] public bool bCanSpawnOnRebuild;
        [FieldOffset(1156)] byte RuntimeGeneration; //TODO: enum ERuntimeGenerationType RuntimeGeneration
        [FieldOffset(1160)] public float ObservedPathsTickInterval;
        [FieldOffset(1164)] byte DataVersion; //TODO: numeric uint32 DataVersion
        [FieldOffset(1376)] public NativeArray SupportedAreas;
    }
    internal unsafe struct NavigationData_methods {
    }
    internal unsafe struct NavigationData_events {
    }
}
