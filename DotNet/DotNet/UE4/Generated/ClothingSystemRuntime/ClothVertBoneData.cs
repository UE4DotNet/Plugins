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
        ///<summary>Bone data for a vertex</summary>
        [StructLayout( LayoutKind.Explicit, Size=52 )]
        public unsafe struct ClothVertBoneData {
            [FieldOffset(0)] public int NumInfluences;

            [FieldOffset(4)] byte BoneIndices; //TODO: numeric uint16 BoneIndices

            [FieldOffset(20)] public float BoneWeights;

        }
}
