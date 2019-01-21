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
    [StructLayout( LayoutKind.Explicit, Size=352 )]
    internal unsafe struct AISystem_fields {
        [FieldOffset(120)] public SoftClassPath PerceptionSystemClassName;
        [FieldOffset(152)] public SoftClassPath HotSpotManagerClassName;
        [FieldOffset(184)] public float AcceptanceRadius;
        [FieldOffset(188)] public float PathfollowingRegularPathPointAcceptanceRadius;
        [FieldOffset(192)] public float PathfollowingNavLinkAcceptanceRadius;
        [FieldOffset(196)] public bool bFinishMoveOnGoalOverlap;
        [FieldOffset(197)] public bool bAcceptPartialPaths;
        [FieldOffset(198)] public bool bAllowStrafing;
        [FieldOffset(199)] public bool bEnableBTAITasks;
        [FieldOffset(200)] public bool bAllowControllersAsEQSQuerier;
        [FieldOffset(201)] public bool bEnableDebuggerPlugin;
        [FieldOffset(202)] public byte DefaultSightCollisionChannel;
        [FieldOffset(208)]  public IntPtr  BehaviorTreeManager;
        [FieldOffset(216)]  public IntPtr  EnvironmentQueryManager;
        [FieldOffset(224)]  public IntPtr  PerceptionSystem;
        [FieldOffset(232)] public NativeArray AllProxyObjects;
        [FieldOffset(248)]  public IntPtr  HotSpotManager;
        [FieldOffset(256)]  public IntPtr  NavLocalGrids;
    }
    internal unsafe struct AISystem_methods {
    }
    internal unsafe struct AISystem_events {
    }
}
