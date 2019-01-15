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
    [StructLayout( LayoutKind.Explicit, Size=1280 )]
    internal unsafe struct NavigationTestingActor_fields {
        [FieldOffset(1024)]  public IntPtr  CapsuleComponent;
        [FieldOffset(1032)]  public IntPtr  EdRenderComp;
        [FieldOffset(1040)]  public IntPtr  InvokerComponent;
        [FieldOffset(1048)] public bool bActAsNavigationInvoker;
        [FieldOffset(1056)] public NavAgentProperties NavAgentProps;
        [FieldOffset(1112)] public Vector QueryingExtent;
        [FieldOffset(1128)]  public IntPtr  MyNavData;
        [FieldOffset(1136)] public Vector ProjectedLocation;
        [FieldOffset(1148)] public bool bProjectedLocationValid;
        [FieldOffset(1148)] public bool bSearchStart;
        [FieldOffset(1148)] public bool bUseHierarchicalPathfinding;
        [FieldOffset(1148)] public bool bGatherDetailedInfo;
        [FieldOffset(1148)] public bool bDrawDistanceToWall;
        [FieldOffset(1148)] public bool bShowNodePool;
        [FieldOffset(1148)] public bool bShowBestPath;
        [FieldOffset(1148)] public bool bShowDiffWithPreviousStep;
        [FieldOffset(1149)] public bool bShouldBeVisibleInGame;
        [FieldOffset(1152)] public byte CostDisplayMode;
        [FieldOffset(1156)] public Vector2D TextCanvasOffset;
        [FieldOffset(1164)] public bool bPathExist;
        [FieldOffset(1164)] public bool bPathIsPartial;
        [FieldOffset(1164)] public bool bPathSearchOutOfNodes;
        [FieldOffset(1168)] public float PathfindingTime;
        [FieldOffset(1172)] public float PathCost;
        [FieldOffset(1176)] public int PathfindingSteps;
        [FieldOffset(1184)]  public IntPtr  OtherActor;
        [FieldOffset(1192)] public IntPtr FilterClass;
        [FieldOffset(1200)] public int ShowStepIndex;
        [FieldOffset(1204)] public float OffsetFromCornersDistance;
    }
    internal unsafe struct NavigationTestingActor_methods {
    }
    internal unsafe struct NavigationTestingActor_events {
    }
}
