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
        ///<summary>Per-section settings.</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct MeshSectionInfo {
            [FieldOffset(0)] public int MaterialIndex;

            [FieldOffset(4)] public bool bEnableCollision;

            [FieldOffset(5)] public bool bCastShadow;

        }
}
