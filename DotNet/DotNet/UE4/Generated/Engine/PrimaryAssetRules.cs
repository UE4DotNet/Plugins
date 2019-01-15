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
        ///<summary>Structure defining rules for what to do with assets, this is defined per type and can be overridden per asset</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct PrimaryAssetRules {
            [FieldOffset(0)] public int Priority;

            [FieldOffset(4)] public bool bApplyRecursively;

            [FieldOffset(8)] public int ChunkId;

            [FieldOffset(12)] byte CookRule; //TODO: enum EPrimaryAssetCookRule CookRule

        }
}
