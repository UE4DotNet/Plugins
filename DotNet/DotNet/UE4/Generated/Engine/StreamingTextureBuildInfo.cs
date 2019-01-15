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
        ///<summary>This struct holds the result of TextureStreaming Build for each component texture, as referred by its used materials.</summary>
        ///<remarks>
        ///It is possible that the entry referred by this data is not actually relevant in a given quality / target.
        ///It is also possible that some texture are not referred, and will then fall on fallbacks computation.
        ///Because each component holds its precomputed data for each texture, this struct is designed to be as compact as possible.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct StreamingTextureBuildInfo {
            [FieldOffset(0)] byte PackedRelativeBox; //TODO: numeric uint32 PackedRelativeBox

            [FieldOffset(4)] public int TextureLevelIndex;

            [FieldOffset(8)] public float TexelFactor;

        }
}
