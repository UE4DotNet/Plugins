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
        ///<summary>Anim Node Save Cached Pose</summary>
        [StructLayout( LayoutKind.Explicit, Size=232 )]
        public unsafe struct AnimNode_SaveCachedPose {
            ///<summary>Pose</summary>
            [FieldOffset(56)] PoseLink Pose;

            [FieldOffset(80)] public Name CachePoseName;

            [FieldOffset(92)] public float GlobalWeight;

        }
}
