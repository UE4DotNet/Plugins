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


namespace UE4.MagicLeap{
        ///<summary>Parameters for a raycast request.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct RaycastQueryParams {
            ///<summary>Where the ray is cast from.</summary>
            [FieldOffset(0)] Vector Position;

            ///<summary>Direction of the ray to fire.</summary>
            [FieldOffset(12)] Vector Direction;

            ///<summary>Up vector of the ray to fire. This is used to orient the area the rays are cast over.</summary>
            [FieldOffset(24)] Vector UpVector;

            [FieldOffset(36)] public int Width;

            [FieldOffset(40)] public int Height;

            [FieldOffset(44)] public float HorizontalFovDegrees;

            [FieldOffset(48)] public bool CollideWithUnobserved;

            [FieldOffset(52)] public int UserData;

        }
}
