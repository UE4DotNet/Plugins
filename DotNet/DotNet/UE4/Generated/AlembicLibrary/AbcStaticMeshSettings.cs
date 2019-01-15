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


namespace UE4.AlembicLibrary{
        ///<summary>Abc Static Mesh Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=3 )]
        public unsafe struct AbcStaticMeshSettings {
            [FieldOffset(0)] public bool bMergeMeshes;

            [FieldOffset(1)] public bool bPropagateMatrixTransformations;

            [FieldOffset(2)] public bool bGenerateLightmapUVs;

        }
}
