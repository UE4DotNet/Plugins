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
    [StructLayout( LayoutKind.Explicit, Size=336 )]
    internal unsafe struct AISystem_fields {
        [FieldOffset(104)] public SoftClassPath PerceptionSystemClassName;
        [FieldOffset(136)] public SoftClassPath HotSpotManagerClassName;
        [FieldOffset(168)] public float AcceptanceRadius;
        [FieldOffset(172)] public float PathfollowingRegularPathPointAcceptanceRadius;
        [FieldOffset(176)] public float PathfollowingNavLinkAcceptanceRadius;
        [FieldOffset(180)] public bool bFinishMoveOnGoalOverlap;
        [FieldOffset(181)] public bool bAcceptPartialPaths;
        [FieldOffset(182)] public bool bAllowStrafing;
        [FieldOffset(183)] public bool bEnableBTAITasks;
        [FieldOffset(184)] public bool bAllowControllersAsEQSQuerier;
        [FieldOffset(185)] public bool bEnableDebuggerPlugin;
        [FieldOffset(186)] public byte DefaultSightCollisionChannel;
        [FieldOffset(192)]  public IntPtr  BehaviorTreeManager;
        [FieldOffset(200)]  public IntPtr  EnvironmentQueryManager;
        [FieldOffset(208)]  public IntPtr  PerceptionSystem;
        [FieldOffset(216)] public NativeArray AllProxyObjects;
        [FieldOffset(232)]  public IntPtr  HotSpotManager;
        [FieldOffset(240)]  public IntPtr  NavLocalGrids;
    }
    internal unsafe struct AISystem_methods {
    }
    internal unsafe struct AISystem_events {
    }
}
