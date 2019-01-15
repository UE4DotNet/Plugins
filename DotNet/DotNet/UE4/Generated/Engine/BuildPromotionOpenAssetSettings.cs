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
        ///<summary>Holds settings for the open assets stage of the build promotion test</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct BuildPromotionOpenAssetSettings {
            ///<summary>The blueprint asset to open</summary>
            [FieldOffset(0)] FilePath BlueprintAsset;

            ///<summary>The material asset to open</summary>
            [FieldOffset(16)] FilePath MaterialAsset;

            ///<summary>The particle system asset to open</summary>
            [FieldOffset(32)] FilePath ParticleSystemAsset;

            ///<summary>The skeletal mesh asset to open</summary>
            [FieldOffset(48)] FilePath SkeletalMeshAsset;

            ///<summary>The static mesh asset to open</summary>
            [FieldOffset(64)] FilePath StaticMeshAsset;

            ///<summary>The texture asset to open</summary>
            [FieldOffset(80)] FilePath TextureAsset;

        }
}
