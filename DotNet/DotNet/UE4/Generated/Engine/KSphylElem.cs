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
        ///<summary>Capsule shape used for collision. Z axis is capsule axis.</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct KSphylElem {
            ///<summary>Position of the capsule's origin</summary>
            [FieldOffset(128)] Vector Center;

            ///<summary>Rotation of the capsule</summary>
            [FieldOffset(140)] Rotator Rotation;

            [FieldOffset(152)] public float Radius;

            [FieldOffset(156)] public float Length;

        }
}
