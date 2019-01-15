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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=264 )]
    internal unsafe struct CrowdManager_fields {
        [FieldOffset(56)]  public IntPtr  MyNavData;
        [FieldOffset(64)] public NativeArray AvoidanceConfig;
        [FieldOffset(80)] public NativeArray SamplingPatterns;
        [FieldOffset(96)] public int MaxAgents;
        [FieldOffset(100)] public float MaxAgentRadius;
        [FieldOffset(104)] public int MaxAvoidedAgents;
        [FieldOffset(108)] public int MaxAvoidedWalls;
        [FieldOffset(112)] public float NavmeshCheckInterval;
        [FieldOffset(116)] public float PathOptimizationInterval;
        [FieldOffset(120)] public float SeparationDirClamp;
        [FieldOffset(124)] public float PathOffsetRadiusMultiplier;
        [FieldOffset(128)] public bool bResolveCollisions;
    }
    internal unsafe struct CrowdManager_methods {
    }
    internal unsafe struct CrowdManager_events {
    }
}
