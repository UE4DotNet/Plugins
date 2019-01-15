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
        ///<summary>Holds settings for the blueprint editor build promotion tests</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct BlueprintEditorPromotionSettings {
            ///<summary>The starting mesh for the blueprint *</summary>
            [FieldOffset(0)] FilePath FirstMeshPath;

            ///<summary>The mesh to set on the blueprint after the delay *</summary>
            [FieldOffset(16)] FilePath SecondMeshPath;

            ///<summary>Default particle asset to use for tests</summary>
            [FieldOffset(32)] FilePath DefaultParticleAsset;

        }
}
