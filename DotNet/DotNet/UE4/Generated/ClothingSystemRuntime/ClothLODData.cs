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

using UE4.ClothingSystemRuntimeInterface;

namespace UE4.ClothingSystemRuntime{
        ///<summary>Cloth LODData</summary>
        [StructLayout( LayoutKind.Explicit, Size=280 )]
        public unsafe struct ClothLODData {
            ///<summary>Raw phys mesh data</summary>
            [FieldOffset(0)] ClothPhysicalMeshData PhysicalMeshData;

            ///<summary>Collision primitive and covex data for clothing collisions</summary>
            [FieldOffset(184)] ClothCollisionData CollisionData;

            [FieldOffset(232)] byte ParameterMasks; //TODO: array TArray ParameterMasks

        }
}
