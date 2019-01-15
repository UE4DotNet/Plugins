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


namespace UE4.ClothingSystemRuntime{
        ///<summary>Physical mesh data created during asset import or created from a skeletal mesh</summary>
        [StructLayout( LayoutKind.Explicit, Size=184 )]
        public unsafe struct ClothPhysicalMeshData {
            [FieldOffset(0)] byte Vertices; //TODO: array TArray Vertices

            [FieldOffset(16)] byte Normals; //TODO: array TArray Normals

            [FieldOffset(32)] byte VertexColors; //TODO: array TArray VertexColors

            [FieldOffset(48)] byte Indices; //TODO: array TArray Indices

            [FieldOffset(64)] byte MaxDistances; //TODO: array TArray MaxDistances

            [FieldOffset(80)] byte BackstopDistances; //TODO: array TArray BackstopDistances

            [FieldOffset(96)] byte BackstopRadiuses; //TODO: array TArray BackstopRadiuses

            [FieldOffset(112)] byte AnimDriveMultipliers; //TODO: array TArray AnimDriveMultipliers

            [FieldOffset(128)] byte InverseMasses; //TODO: array TArray InverseMasses

            [FieldOffset(144)] byte BoneData; //TODO: array TArray BoneData

            [FieldOffset(160)] public int MaxBoneWeights;

            [FieldOffset(164)] public int NumFixedVerts;

            [FieldOffset(168)] byte SelfCollisionIndices; //TODO: array TArray SelfCollisionIndices

        }
}
