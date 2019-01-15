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
        ///<summary>This struct holds data about how a texture is sampled within a material.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct MaterialTextureInfo {
            [FieldOffset(0)] public float SamplingScale;

            [FieldOffset(4)] public int UVChannelIndex;

            [FieldOffset(8)] public Name TextureName;

            ///<summary>The reference to the texture, used to keep the TextureName valid even if it gets renamed.</summary>
            [FieldOffset(24)] SoftObjectPath TextureReference;

            [FieldOffset(56)] public int TextureIndex;

        }
}
