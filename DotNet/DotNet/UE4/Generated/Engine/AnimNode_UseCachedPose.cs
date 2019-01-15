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
        ///<summary>Anim Node Use Cached Pose</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct AnimNode_UseCachedPose {
            ///<summary>Note: This link is intentionally not public; it's wired up during compilation</summary>
            [FieldOffset(56)] PoseLink LinkToCachingNode;

            [FieldOffset(80)] public Name CachePoseName;

        }
}
