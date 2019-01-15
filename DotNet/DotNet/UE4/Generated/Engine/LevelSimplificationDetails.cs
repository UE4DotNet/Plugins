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
        ///<summary>Level Simplification Details</summary>
        [StructLayout( LayoutKind.Explicit, Size=308 )]
        public unsafe struct LevelSimplificationDetails {
            [FieldOffset(0)] public bool bCreatePackagePerAsset;

            [FieldOffset(4)] public float DetailsPercentage;

            ///<summary>Landscape material simplification</summary>
            [FieldOffset(8)] MaterialProxySettings StaticMeshMaterialSettings;

            [FieldOffset(148)] public bool bOverrideLandscapeExportLOD;

            [FieldOffset(152)] public int LandscapeExportLOD;

            ///<summary>Landscape material simplification</summary>
            [FieldOffset(156)] MaterialProxySettings LandscapeMaterialSettings;

            [FieldOffset(296)] public bool bBakeFoliageToLandscape;

            [FieldOffset(297)] public bool bBakeGrassToLandscape;

        }
}
