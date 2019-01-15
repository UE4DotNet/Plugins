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
        ///<summary>Datasmith Import Base Options</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct DatasmithImportBaseOptions {
            [FieldOffset(0)] byte SceneHandling; //TODO: enum EDatasmithImportScene SceneHandling

            [FieldOffset(1)] public bool bIncludeGeometry;

            [FieldOffset(2)] public bool bIncludeMaterial;

            [FieldOffset(3)] public bool bIncludeLight;

            [FieldOffset(4)] public bool bIncludeCamera;

            ///<summary>Asset Options</summary>
            [FieldOffset(8)] DatasmithAssetImportOptions AssetOptions;

            ///<summary>Static Mesh Options</summary>
            [FieldOffset(20)] DatasmithStaticMeshImportOptions StaticMeshOptions;

        }
}
