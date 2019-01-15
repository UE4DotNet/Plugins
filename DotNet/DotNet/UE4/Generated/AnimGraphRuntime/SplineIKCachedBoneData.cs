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
        ///<summary>Data cached per bone in the chain</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct SplineIKCachedBoneData {
            ///<summary>The bone we refer to</summary>
            [FieldOffset(0)] BoneReference Bone;

            [FieldOffset(24)] public int RefSkeletonIndex;

        }
}
