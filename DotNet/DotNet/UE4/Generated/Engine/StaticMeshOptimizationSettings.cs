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
        ///<summary>Old optimization settings.</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct StaticMeshOptimizationSettings {
            [FieldOffset(0)] public byte ReductionMethod;

            [FieldOffset(4)] public float NumOfTrianglesPercentage;

            [FieldOffset(8)] public float MaxDeviationPercentage;

            [FieldOffset(12)] public float WeldingThreshold;

            [FieldOffset(16)] public bool bRecalcNormals;

            [FieldOffset(20)] public float NormalsThreshold;

            [FieldOffset(24)] public byte SilhouetteImportance;

            [FieldOffset(25)] public byte TextureImportance;

            [FieldOffset(26)] public byte ShadingImportance;

        }
}
