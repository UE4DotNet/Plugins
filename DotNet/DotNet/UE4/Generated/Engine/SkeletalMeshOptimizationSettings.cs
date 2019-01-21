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
        ///<summary>FSkeletalMeshOptimizationSettings - The settings used to optimize a skeletal mesh LOD.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct SkeletalMeshOptimizationSettings {
            [FieldOffset(0)] public float NumOfTrianglesPercentage;

            [FieldOffset(4)] public float MaxDeviationPercentage;

            [FieldOffset(8)] public byte ReductionMethod;

            [FieldOffset(9)] public byte SilhouetteImportance;

            [FieldOffset(10)] public byte TextureImportance;

            [FieldOffset(11)] public byte ShadingImportance;

            [FieldOffset(12)] public byte SkinningImportance;

            [FieldOffset(13)] public bool bRemapMorphTargets;

            [FieldOffset(13)] public bool bRecalcNormals;

            [FieldOffset(16)] public float WeldingThreshold;

            [FieldOffset(20)] public float NormalsThreshold;

            [FieldOffset(24)] public int MaxBonesPerVertex;

            [FieldOffset(28)] public int BaseLOD;

        }
}
