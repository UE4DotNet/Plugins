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
        ///<summary>This structure represents a baked transition rule inside a state</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct AnimationTransitionRule {
            [FieldOffset(0)] public Name RuleToExecute;

            [FieldOffset(12)] public bool TransitionReturnVal;

            [FieldOffset(16)] public int TransitionIndex;

        }
}
