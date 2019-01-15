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
        ///<summary>Data about a single point in a projectile path trace.</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct PredictProjectilePathPointData {
            ///<summary>Location of this point</summary>
            [FieldOffset(0)] Vector Location;

            ///<summary>Velocity at this point</summary>
            [FieldOffset(12)] Vector Velocity;

            [FieldOffset(24)] public float Time;

        }
}
