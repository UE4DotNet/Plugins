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
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct SkeletalMeshOptimizationSettings {
            [FieldOffset(0)] public byte ReductionMethod;

            [FieldOffset(4)] public float NumOfTrianglesPercentage;

            [FieldOffset(8)] public float MaxDeviationPercentage;

            [FieldOffset(12)] public bool bRemapMorphTargets;

            [FieldOffset(13)] public byte SilhouetteImportance;

            [FieldOffset(14)] public byte TextureImportance;

            [FieldOffset(15)] public byte ShadingImportance;

            [FieldOffset(16)] public byte SkinningImportance;

            [FieldOffset(20)] public float WeldingThreshold;

            [FieldOffset(24)] public bool bRecalcNormals;

            [FieldOffset(28)] public float NormalsThreshold;

            [FieldOffset(32)] public int MaxBonesPerVertex;

            [FieldOffset(56)] public int BaseLOD;

        }
}
