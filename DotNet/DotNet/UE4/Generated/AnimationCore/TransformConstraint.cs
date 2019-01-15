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


namespace UE4.AnimationCore{
        ///<summary>Transform Constraint</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct TransformConstraint {
            ///<summary>@</summary>
            ///<remarks>
            ///note thought of separating this out per each but we'll have an issue with applying transform in what order
            ///but something to think about if that seems better
            ///</remarks>
            [FieldOffset(0)] ConstraintDescription Operator;

            [FieldOffset(16)] public Name SourceNode;

            [FieldOffset(28)] public Name TargetNode;

            [FieldOffset(40)] public float Weight;

            [FieldOffset(44)] public bool bMaintainOffset;

        }
}
