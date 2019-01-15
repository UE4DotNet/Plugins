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
        ///<summary>Struct holding parameters needed when creating a new clothing asset or sub asset (LOD)</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct SkeletalMeshClothBuildParams {
            [FieldOffset(0)] byte TargetAsset; //TODO: weak object TWeakObjectPtr<UClothingAssetBase> TargetAsset

            [FieldOffset(8)] public int TargetLod;

            [FieldOffset(12)] public bool bRemapParameters;

            [FieldOffset(16)] byte AssetName; //TODO: string FString AssetName

            [FieldOffset(32)] public int LodIndex;

            [FieldOffset(36)] public int SourceSection;

            [FieldOffset(40)] public bool bRemoveFromMesh;

            [FieldOffset(48)] byte PhysicsAsset; //TODO: soft object TSoftObjectPtr<UPhysicsAsset> PhysicsAsset

        }
}
