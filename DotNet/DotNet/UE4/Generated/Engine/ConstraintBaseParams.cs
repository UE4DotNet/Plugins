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
        ///<summary>Constraint Base Params</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct ConstraintBaseParams {
            [FieldOffset(0)] public float Stiffness;

            [FieldOffset(4)] public float Damping;

            [FieldOffset(8)] public float Restitution;

            [FieldOffset(12)] public float ContactDistance;

            [FieldOffset(16)] public bool bSoftConstraint;

        }
}
