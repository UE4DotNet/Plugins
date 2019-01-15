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
        ///<summary>Rig Transform Constraint</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct RigTransformConstraint {
            [FieldOffset(0)] public byte TranformType;

            [FieldOffset(4)] public Name ParentSpace;

            [FieldOffset(16)] public float Weight;

        }
}
