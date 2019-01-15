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
        ///<summary>Settings used to reduce a mesh.</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct MeshReductionSettings {
            [FieldOffset(0)] public float PercentTriangles;

            [FieldOffset(4)] public float MaxDeviation;

            [FieldOffset(8)] public float PixelError;

            [FieldOffset(12)] public float WeldingThreshold;

            [FieldOffset(16)] public float HardAngleThreshold;

            [FieldOffset(20)] public byte SilhouetteImportance;

            [FieldOffset(21)] public byte TextureImportance;

            [FieldOffset(22)] public byte ShadingImportance;

            [FieldOffset(23)] public bool bRecalculateNormals;

            [FieldOffset(24)] public int BaseLODModel;

            [FieldOffset(28)] public bool bGenerateUniqueLightmapUVs;

            [FieldOffset(29)] public bool bKeepSymmetry;

            [FieldOffset(30)] public bool bVisibilityAided;

            [FieldOffset(31)] public bool bCullOccluded;

            [FieldOffset(32)] public byte VisibilityAggressiveness;

            [FieldOffset(33)] public byte VertexColorImportance;

        }
}
