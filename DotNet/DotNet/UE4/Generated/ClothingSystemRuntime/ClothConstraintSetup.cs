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


namespace UE4.ClothingSystemRuntime{
        ///<summary>Container for a constraint setup, these can be horizontal, vertical, shear and bend</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct ClothConstraintSetup {
            [FieldOffset(0)] public float Stiffness;

            [FieldOffset(4)] public float StiffnessMultiplier;

            [FieldOffset(8)] public float StretchLimit;

            [FieldOffset(12)] public float CompressionLimit;

        }
}
