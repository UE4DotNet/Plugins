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
        ///<summary>Datasmith Static Mesh Import Options</summary>
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        public unsafe struct DatasmithStaticMeshImportOptions {
            [FieldOffset(0)] byte MinLightmapResolution; //TODO: enum EDatasmithImportLightmapMin MinLightmapResolution

            [FieldOffset(1)] byte MaxLightmapResolution; //TODO: enum EDatasmithImportLightmapMax MaxLightmapResolution

            [FieldOffset(2)] public bool bGenerateLightmapUVs;

            [FieldOffset(3)] public bool bRemoveDegenerates;

        }
}
