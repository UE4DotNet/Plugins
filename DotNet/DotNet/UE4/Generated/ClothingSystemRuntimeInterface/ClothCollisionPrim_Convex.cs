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
        ///<summary>
        ///Data for a single convex element
        ///A convex is a collection of planes, in which the clothing will attempt to stay outside of the
        ///shape created by the planes combined.
        ///</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct ClothCollisionPrim_Convex {
            [FieldOffset(0)] byte Planes; //TODO: array TArray Planes

            [FieldOffset(16)] public int BoneIndex;

        }
}
