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
        ///<summary>Cloth Collision Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct ClothCollisionData {
            [FieldOffset(0)] byte Spheres; //TODO: array TArray Spheres

            [FieldOffset(16)] byte SphereConnections; //TODO: array TArray SphereConnections

            [FieldOffset(32)] byte Convexes; //TODO: array TArray Convexes

        }
}
