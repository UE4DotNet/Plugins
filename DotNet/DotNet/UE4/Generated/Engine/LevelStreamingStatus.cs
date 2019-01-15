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
        ///<summary>level streaming updates that should be applied immediately after committing the map change</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct LevelStreamingStatus {
            [FieldOffset(0)] public Name PackageName;

            [FieldOffset(12)] public bool bShouldBeLoaded;

            [FieldOffset(12)] public bool bShouldBeVisible;

            [FieldOffset(16)] byte LODIndex; //TODO: numeric uint32 LODIndex

        }
}
