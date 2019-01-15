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


namespace UE4.NavigationSystem{
        ///<summary>Nav Collision Cylinder</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct NavCollisionCylinder {
            ///<summary>Offset</summary>
            [FieldOffset(0)] Vector Offset;

            [FieldOffset(12)] public float Radius;

            [FieldOffset(16)] public float Height;

        }
}
