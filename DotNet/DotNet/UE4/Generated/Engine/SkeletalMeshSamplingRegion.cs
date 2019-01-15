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
        ///<summary>Defined a named region on a mesh that will have associated triangles and bones for fast sampling at each enabled LOD.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct SkeletalMeshSamplingRegion {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(12)] public int LODIndex;

            [FieldOffset(16)] public bool bSupportUniformlyDistributedSampling;

            [FieldOffset(24)] byte MaterialFilters; //TODO: array TArray MaterialFilters

            [FieldOffset(40)] byte BoneFilters; //TODO: array TArray BoneFilters

        }
}
