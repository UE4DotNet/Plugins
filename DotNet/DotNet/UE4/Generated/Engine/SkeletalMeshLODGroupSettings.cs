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
        ///<summary>Skeletal Mesh LODGroup Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=184 )]
        public unsafe struct SkeletalMeshLODGroupSettings {
            ///<summary>The screen sizes to use for the respective LOD level</summary>
            [FieldOffset(0)] PerPlatformFloat ScreenSize;

            [FieldOffset(88)] public float LODHysteresis;

            [FieldOffset(92)] byte BoneFilterActionOption; //TODO: enum EBoneFilterActionOption BoneFilterActionOption

            [FieldOffset(96)] byte BoneList; //TODO: array TArray BoneList

            ///<summary>The optimization settings to use for the respective LOD level</summary>
            [FieldOffset(112)] SkeletalMeshOptimizationSettings ReductionSettings;

        }
}
