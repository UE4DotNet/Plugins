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
        ///<summary>Mesh Proxy Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=212 )]
        public unsafe struct MeshProxySettings {
            [FieldOffset(0)] public int ScreenSize;

            [FieldOffset(4)] public bool bOverrideVoxelSize;

            [FieldOffset(8)] public float VoxelSize;

            ///<summary>Material simplification</summary>
            [FieldOffset(12)] MaterialProxySettings MaterialSettings;

            [FieldOffset(164)] public bool bCalculateCorrectLODModel;

            [FieldOffset(168)] public float MergeDistance;

            ///<summary>Base color assigned to LOD geometry that can't be associated with the source geometry: e.g. doors and windows that have been closed by the Merge Distance</summary>
            [FieldOffset(172)] Color UnresolvedGeometryColor;

            [FieldOffset(176)] public bool bOverrideTransferDistance;

            [FieldOffset(180)] public float MaxRayCastDist;

            [FieldOffset(184)] public bool bUseHardAngleThreshold;

            [FieldOffset(188)] public float HardAngleThreshold;

            [FieldOffset(192)] public byte NormalCalculationMethod;

            [FieldOffset(196)] public int LightMapResolution;

            [FieldOffset(200)] public bool bComputeLightMapResolution;

            [FieldOffset(201)] public bool bRecalculateNormals;

            [FieldOffset(203)] public bool bUseLandscapeCulling;

            [FieldOffset(204)] public byte LandscapeCullingPrecision;

            [FieldOffset(205)] public bool bAllowAdjacency;

            [FieldOffset(206)] public bool bAllowDistanceField;

            [FieldOffset(207)] public bool bReuseMeshLightmapUVs;

            [FieldOffset(208)] public bool bCreateCollision;

            [FieldOffset(209)] public bool bAllowVertexColors;

            [FieldOffset(210)] public bool bGenerateLightmapUVs;

        }
}
