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
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct PawnAction_Move_fields {
        [FieldOffset(168)]  public IntPtr  GoalActor;
        [FieldOffset(176)] public Vector GoalLocation;
        [FieldOffset(188)] public float AcceptableRadius;
        [FieldOffset(192)] public IntPtr FilterClass;
        [FieldOffset(200)] public bool bAllowStrafe;
        [FieldOffset(200)] public bool bFinishOnOverlap;
        [FieldOffset(200)] public bool bUsePathfinding;
        [FieldOffset(200)] public bool bAllowPartialPath;
        [FieldOffset(200)] public bool bProjectGoalToNavigation;
        [FieldOffset(200)] public bool bUpdatePathToGoal;
        [FieldOffset(200)] public bool bAbortChildActionOnPathChange;
    }
    internal unsafe struct PawnAction_Move_methods {
    }
    internal unsafe struct PawnAction_Move_events {
    }
}
