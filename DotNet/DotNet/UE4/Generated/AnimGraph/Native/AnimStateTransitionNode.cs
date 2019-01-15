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

namespace UE4.AnimGraph.Native {
    [StructLayout( LayoutKind.Explicit, Size=912 )]
    internal unsafe struct AnimStateTransitionNode_fields {
        [FieldOffset(208)]  public IntPtr  BoundGraph;
        [FieldOffset(216)]  public IntPtr  CustomTransitionGraph;
        [FieldOffset(224)] public int PriorityOrder;
        [FieldOffset(228)] public float CrossfadeDuration;
        [FieldOffset(233)] byte BlendMode; //TODO: enum EAlphaBlendOption BlendMode
        [FieldOffset(240)]  public IntPtr  CustomBlendCurve;
        [FieldOffset(248)]  public IntPtr  BlendProfile;
        [FieldOffset(256)] public bool bAutomaticRuleBasedOnSequencePlayerInState;
        [FieldOffset(257)] public byte LogicType;
        [FieldOffset(264)] public AnimNotifyEvent TransitionStart;
        [FieldOffset(448)] public AnimNotifyEvent TransitionEnd;
        [FieldOffset(632)] public AnimNotifyEvent TransitionInterrupt;
        [FieldOffset(816)] public bool Bidirectional;
        [FieldOffset(817)] public bool bSharedRules;
        [FieldOffset(818)] public bool bSharedCrossfade;
        [FieldOffset(824)] byte SharedRulesName; //TODO: string FString SharedRulesName
        [FieldOffset(840)] public FGuid SharedRulesGuid;
        [FieldOffset(856)] public LinearColor SharedColor;
        [FieldOffset(872)] byte SharedCrossfadeName; //TODO: string FString SharedCrossfadeName
        [FieldOffset(888)] public FGuid SharedCrossfadeGuid;
        [FieldOffset(904)] public int SharedCrossfadeIdx;
    }
    internal unsafe struct AnimStateTransitionNode_methods {
    }
    internal unsafe struct AnimStateTransitionNode_events {
    }
}
