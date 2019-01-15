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
        ///<summary>Mesh merging settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=204 )]
        public unsafe struct MeshMergingSettings {
            [FieldOffset(0)] public bool bGenerateLightMapUV;

            [FieldOffset(4)] public int TargetLightMapResolution;

            [FieldOffset(8)] public bool bComputedLightMapResolution;

            [FieldOffset(10)] public bool bPivotPointAtZero;

            [FieldOffset(11)] public bool bMergePhysicsData;

            [FieldOffset(12)] public bool bMergeMaterials;

            ///<summary>Material simplification</summary>
            [FieldOffset(16)] MaterialProxySettings MaterialSettings;

            [FieldOffset(156)] public bool bBakeVertexDataToMesh;

            [FieldOffset(157)] public bool bUseVertexDataForBakingMaterial;

            [FieldOffset(158)] public bool bUseTextureBinning;

            [FieldOffset(159)] public bool bReuseMeshLightmapUVs;

            [FieldOffset(160)] public bool bMergeEquivalentMaterials;

            [FieldOffset(161)] byte OutputUVs; //TODO: enum EUVOutput OutputUVs

            [FieldOffset(172)] public int GutterSize;

            [FieldOffset(177)] byte LODSelectionType; //TODO: enum EMeshLODSelectionType LODSelectionType

            [FieldOffset(184)] public int SpecificLOD;

            [FieldOffset(188)] public bool bUseLandscapeCulling;

            [FieldOffset(189)] public bool bIncludeImposters;

            [FieldOffset(190)] public bool bAllowDistanceField;

        }
}
