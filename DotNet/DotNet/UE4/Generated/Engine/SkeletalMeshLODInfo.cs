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
        ///<summary>Struct containing information for a particular LOD level, such as materials and info for when to use it.</summary>
        [StructLayout( LayoutKind.Explicit, Size=272 )]
        public unsafe struct SkeletalMeshLODInfo {
            ///<summary>ScreenSize to display this LOD.</summary>
            ///<remarks>
            ///The screen size is based around the projected diameter of the bounding
            ///sphere of the model. i.e. 0.5 means half the screen's maximum dimension.
            ///</remarks>
            [FieldOffset(0)] PerPlatformFloat ScreenSize;

            [FieldOffset(88)] public float LODHysteresis;

            [FieldOffset(96)] byte LODMaterialMap; //TODO: array TArray LODMaterialMap

            [FieldOffset(128)] public bool bHasBeenSimplified;

            ///<summary>Reduction settings to apply when building render data.</summary>
            [FieldOffset(136)] SkeletalMeshOptimizationSettings ReductionSettings;

            [FieldOffset(224)] byte BonesToRemove; //TODO: array TArray BonesToRemove

            [FieldOffset(240)] 
            private IntPtr  BakePose_field;
            ///<summary>Pose which should be used to reskin vertex influences for which the bones will be removed in this LOD level, uses ref-pose by default</summary>
            public AnimSequence BakePose {
                get {return BakePose_field;}
                set {BakePose_field = value;}
            }

            [FieldOffset(248)] byte SourceImportFilename; //TODO: string FString SourceImportFilename

            [FieldOffset(264)] public bool bHasPerLODVertexColors;

            [FieldOffset(264)] public bool bAllowCPUAccess;

            [FieldOffset(264)] public bool bSupportUniformlyDistributedSampling;

            [FieldOffset(268)] public bool bImportWithBaseMesh;

        }
}
