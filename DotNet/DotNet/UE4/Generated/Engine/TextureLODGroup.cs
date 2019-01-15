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
        ///<summary>LOD settings for a single texture group.</summary>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct TextureLODGroup {
            [FieldOffset(0)] public byte Group;

            [FieldOffset(12)] public int LODBias;

            [FieldOffset(16)] public int LODBias_Smaller;

            [FieldOffset(20)] public int LODBias_Smallest;

            [FieldOffset(28)] public int NumStreamedMips;

            [FieldOffset(32)] public byte MipGenSettings;

            [FieldOffset(36)] public int MinLODSize;

            [FieldOffset(40)] public int MaxLODSize;

            [FieldOffset(44)] public int MaxLODSize_Smaller;

            [FieldOffset(48)] public int MaxLODSize_Smallest;

            [FieldOffset(52)] public int OptionalLODBias;

            [FieldOffset(56)] public int OptionalMaxLODSize;

            [FieldOffset(64)] public Name MinMagFilter;

            [FieldOffset(76)] public Name MipFilter;

        }
}
