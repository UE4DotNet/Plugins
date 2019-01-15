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
        ///<summary>Source model from which a renderable static mesh is built.</summary>
        [StructLayout( LayoutKind.Explicit, Size=224 )]
        public unsafe struct StaticMeshSourceModel {
            ///<summary>Settings applied when building the mesh.</summary>
            [FieldOffset(24)] MeshBuildSettings BuildSettings;

            ///<summary>Reduction settings to apply when building render data.</summary>
            [FieldOffset(72)] MeshReductionSettings ReductionSettings;

            ///<summary>ScreenSize to display this LOD.</summary>
            ///<remarks>
            ///The screen size is based around the projected diameter of the bounding
            ///sphere of the model. i.e. 0.5 means half the screen's maximum dimension.
            ///</remarks>
            [FieldOffset(112)] PerPlatformFloat ScreenSize;

            [FieldOffset(200)] byte SourceImportFilename; //TODO: string FString SourceImportFilename

            [FieldOffset(216)] public bool bImportWithBaseMesh;

        }
}
