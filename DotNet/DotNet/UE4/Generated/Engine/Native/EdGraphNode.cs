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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct EdGraphNode_fields {
        [FieldOffset(72)] public NativeArray DeprecatedPins;
        [FieldOffset(88)] public int NodePosX;
        [FieldOffset(92)] public int NodePosY;
        [FieldOffset(96)] public int NodeWidth;
        [FieldOffset(100)] public int NodeHeight;
        [FieldOffset(104)] public byte AdvancedPinDisplay;
        [FieldOffset(105)] byte EnabledState; //TODO: enum ENodeEnabledState EnabledState
        [FieldOffset(107)] public bool bDisplayAsDisabled;
        [FieldOffset(107)] public bool bUserSetEnabledState;
        [FieldOffset(107)] public bool bCanResizeNode;
        [FieldOffset(107)] public bool bHasCompilerMessage;
        [FieldOffset(108)] public bool bCommentBubblePinned;
        [FieldOffset(108)] public bool bCommentBubbleVisible;
        [FieldOffset(108)] public bool bCommentBubbleMakeVisible;
        [FieldOffset(108)] public bool bCanRenameNode;
        [FieldOffset(112)] byte NodeUpgradeMessage; //TODO: text FText NodeUpgradeMessage
        [FieldOffset(136)] byte NodeComment; //TODO: string FString NodeComment
        [FieldOffset(152)] public int ErrorType;
        [FieldOffset(160)] byte ErrorMsg; //TODO: string FString ErrorMsg
        [FieldOffset(176)] public FGuid NodeGuid;
    }
    internal unsafe struct EdGraphNode_methods {
    }
    internal unsafe struct EdGraphNode_events {
    }
}
