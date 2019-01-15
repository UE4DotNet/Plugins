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
        ///<summary>Sphere shape used for collision</summary>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct KSphereElem {
            ///<summary>Position of the sphere's origin</summary>
            [FieldOffset(112)] Vector Center;

            [FieldOffset(124)] public float Radius;

        }
}
