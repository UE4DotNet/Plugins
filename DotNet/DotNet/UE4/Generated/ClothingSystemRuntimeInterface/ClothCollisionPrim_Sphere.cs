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


namespace UE4.ClothingSystemRuntimeInterface{
        ///<summary>Data for a single sphere primitive in the clothing simulation.</summary>
        ///<remarks>
        ///This can either be a
        ///sphere on its own, or part of a capsule referenced by the indices in FClothCollisionPrim_Capsule
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct ClothCollisionPrim_Sphere {
            [FieldOffset(0)] public int BoneIndex;

            [FieldOffset(4)] public float Radius;

            ///<summary>Local Position</summary>
            [FieldOffset(8)] Vector LocalPosition;

        }
}
