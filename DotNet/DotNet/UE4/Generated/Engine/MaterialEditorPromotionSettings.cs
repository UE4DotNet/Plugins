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
        ///<summary>Holds settings for the material editor build promotion tests</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct MaterialEditorPromotionSettings {
            ///<summary>Default material asset to apply to static meshes *</summary>
            [FieldOffset(0)] FilePath DefaultMaterialAsset;

            ///<summary>Default material asset to apply to static meshes *</summary>
            [FieldOffset(16)] FilePath DefaultDiffuseTexture;

            ///<summary>Default material asset to apply to static meshes *</summary>
            [FieldOffset(32)] FilePath DefaultNormalTexture;

        }
}
