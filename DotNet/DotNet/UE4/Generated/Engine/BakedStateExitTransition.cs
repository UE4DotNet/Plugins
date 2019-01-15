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


namespace UE4.Engine{
        ///<summary>Baked State Exit Transition</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct BakedStateExitTransition {
            [FieldOffset(0)] public int CanTakeDelegateIndex;

            [FieldOffset(4)] public int CustomResultNodeIndex;

            [FieldOffset(8)] public int TransitionIndex;

            [FieldOffset(12)] public bool bDesiredTransitionReturnValue;

            [FieldOffset(13)] public bool bAutomaticRemainingTimeRule;

            [FieldOffset(16)] byte PoseEvaluatorLinks; //TODO: array TArray PoseEvaluatorLinks

        }
}
