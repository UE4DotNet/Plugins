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
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct BTTask_MoveTo_fields {
        [FieldOffset(184)] public float AcceptableRadius;
        [FieldOffset(192)] public IntPtr FilterClass;
        [FieldOffset(200)] public float ObservedBlackboardValueTolerance;
        [FieldOffset(204)] public bool bObserveBlackboardValue;
        [FieldOffset(204)] public bool bAllowStrafe;
        [FieldOffset(204)] public bool bAllowPartialPath;
        [FieldOffset(204)] public bool bTrackMovingGoal;
        [FieldOffset(204)] public bool bProjectGoalLocation;
        [FieldOffset(204)] public bool bReachTestIncludesAgentRadius;
        [FieldOffset(204)] public bool bReachTestIncludesGoalRadius;
        [FieldOffset(204)] public bool bStopOnOverlap;
        [FieldOffset(205)] public bool bStopOnOverlapNeedsUpdate;
    }
    internal unsafe struct BTTask_MoveTo_methods {
    }
    internal unsafe struct BTTask_MoveTo_events {
    }
}
