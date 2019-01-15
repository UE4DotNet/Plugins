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
        ///<summary>Local anim node for extensible processing.</summary>
        ///<remarks>Cant be used outside of this context as it has no graph node counterpart</remarks>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct AnimNode_SingleNode {
            ///<summary>Source Pose</summary>
            [FieldOffset(56)] PoseLink SourcePose;

        }
}
