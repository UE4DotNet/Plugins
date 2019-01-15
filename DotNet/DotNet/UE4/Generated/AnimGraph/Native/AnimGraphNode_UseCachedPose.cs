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
    [StructLayout( LayoutKind.Explicit, Size=392 )]
    internal unsafe struct AnimGraphNode_UseCachedPose_fields {
        [FieldOffset(272)] public AnimNode_UseCachedPose Node;
        [FieldOffset(368)] byte SaveCachedPoseNode; //TODO: weak object TWeakObjectPtr<UAnimGraphNode_SaveCachedPose> SaveCachedPoseNode
        [FieldOffset(376)] byte NameOfCache; //TODO: string FString NameOfCache
    }
    internal unsafe struct AnimGraphNode_UseCachedPose_methods {
    }
    internal unsafe struct AnimGraphNode_UseCachedPose_events {
    }
}
