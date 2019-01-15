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

using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>Anim Node Make Dynamic Additive</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct AnimNode_MakeDynamicAdditive {
            ///<summary>Reference pose for additive delta calculation</summary>
            [FieldOffset(56)] PoseLink Base;

            ///<summary>Pose to make additive</summary>
            [FieldOffset(80)] PoseLink Additive;

            [FieldOffset(104)] public bool bMeshSpaceAdditive;

        }
}
