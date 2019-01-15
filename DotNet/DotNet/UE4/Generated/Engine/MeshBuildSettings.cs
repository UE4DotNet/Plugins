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
        ///<summary>Settings applied when building a mesh.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct MeshBuildSettings {
            [FieldOffset(0)] public bool bUseMikkTSpace;

            [FieldOffset(0)] public bool bRecomputeNormals;

            [FieldOffset(0)] public bool bRecomputeTangents;

            [FieldOffset(0)] public bool bRemoveDegenerates;

            [FieldOffset(0)] public bool bBuildAdjacencyBuffer;

            [FieldOffset(0)] public bool bBuildReversedIndexBuffer;

            [FieldOffset(0)] public bool bUseHighPrecisionTangentBasis;

            [FieldOffset(0)] public bool bUseFullPrecisionUVs;

            [FieldOffset(1)] public bool bGenerateLightmapUVs;

            [FieldOffset(1)] public bool bGenerateDistanceFieldAsIfTwoSided;

            [FieldOffset(4)] public int MinLightmapResolution;

            [FieldOffset(8)] public int SrcLightmapIndex;

            [FieldOffset(12)] public int DstLightmapIndex;

            ///<summary>The local scale applied when building the mesh</summary>
            [FieldOffset(20)] Vector BuildScale3D;

            [FieldOffset(32)] public float DistanceFieldResolutionScale;

            [FieldOffset(40)] 
            private IntPtr  DistanceFieldReplacementMesh_field;
            ///<summary>Distance Field Replacement Mesh</summary>
            public StaticMesh DistanceFieldReplacementMesh {
                get {return DistanceFieldReplacementMesh_field;}
                set {DistanceFieldReplacementMesh_field = value;}
            }

        }
}
