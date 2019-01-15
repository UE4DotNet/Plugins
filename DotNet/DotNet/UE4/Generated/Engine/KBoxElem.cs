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
        ///<summary>Box shape used for collision</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct KBoxElem {
            ///<summary>Position of the box's origin</summary>
            [FieldOffset(128)] Vector Center;

            ///<summary>Rotation of the box</summary>
            [FieldOffset(140)] Rotator Rotation;

            [FieldOffset(152)] public float X;

            [FieldOffset(156)] public float Y;

            [FieldOffset(160)] public float Z;

        }
}
