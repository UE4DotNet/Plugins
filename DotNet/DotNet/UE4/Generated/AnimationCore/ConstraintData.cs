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
        ///<summary>Constraint Data that is contained in Node Datat</summary>
        ///<remarks>You can have as many of these per node</remarks>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct ConstraintData {
            ///<summary>Constraint Description</summary>
            [FieldOffset(0)] ConstraintDescriptor Constraint;

            [FieldOffset(16)] public float Weight;

            [FieldOffset(20)] public bool bMaintainOffset;

            ///<summary>Constraint offset if bMaintainOffset is used</summary>
            [FieldOffset(32)] Transform Offset;

            ///<summary>Current Transform</summary>
            [FieldOffset(80)] Transform CurrentTransform;

        }
}
