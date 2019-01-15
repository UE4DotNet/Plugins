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


namespace UE4.DatasmithContent{
        ///<summary>Datasmith Mesh Build Settings Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct DatasmithMeshBuildSettingsTemplate {
            [FieldOffset(0)] public bool bUseMikkTSpace;

            [FieldOffset(0)] public bool bRecomputeNormals;

            [FieldOffset(0)] public bool bRecomputeTangents;

            [FieldOffset(0)] public bool bRemoveDegenerates;

            [FieldOffset(0)] public bool bBuildAdjacencyBuffer;

            [FieldOffset(0)] public bool bUseHighPrecisionTangentBasis;

            [FieldOffset(0)] public bool bUseFullPrecisionUVs;

            [FieldOffset(0)] public bool bGenerateLightmapUVs;

            [FieldOffset(4)] public int MinLightmapResolution;

            [FieldOffset(8)] public int SrcLightmapIndex;

            [FieldOffset(12)] public int DstLightmapIndex;

        }
}
