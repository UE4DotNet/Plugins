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


namespace UE4.AnimGraph.Native {
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct AnimationGraphSchema_fields {
        [FieldOffset(72)] byte PN_SequenceName; //TODO: string FString PN_SequenceName
        [FieldOffset(88)] public Name NAME_NeverAsPin;
        [FieldOffset(100)] public Name NAME_PinHiddenByDefault;
        [FieldOffset(112)] public Name NAME_PinShownByDefault;
        [FieldOffset(124)] public Name NAME_AlwaysAsPin;
        [FieldOffset(136)] public Name NAME_CustomizeProperty;
        [FieldOffset(148)] public Name NAME_OnEvaluate;
        [FieldOffset(160)] public Name DefaultEvaluationHandlerName;
    }
    internal unsafe struct AnimationGraphSchema_methods {
    }
    internal unsafe struct AnimationGraphSchema_events {
    }
}
