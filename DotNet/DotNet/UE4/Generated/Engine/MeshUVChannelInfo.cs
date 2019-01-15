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
        ///<summary>The world size for each texcoord mapping. Used by the texture streaming.</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct MeshUVChannelInfo {
            [FieldOffset(0)] public bool bInitialized;

            [FieldOffset(1)] public bool bOverrideDensities;

            [FieldOffset(4)] public float LocalUVDensities;

        }
}
