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


namespace UE4.AnimGraphRuntime{
        ///<summary>Evaluates a point in an anim sequence, using a specific time input rather than advancing time internally.</summary>
        ///<remarks>
        ///Typically the playback position of the animation for this node will represent something other than time, like jump height.
        ///This node will not trigger any notifies present in the associated sequence.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=192 )]
        public unsafe struct AnimNode_PoseByName {
            [FieldOffset(168)] public Name PoseName;

            [FieldOffset(180)] public float PoseWeight;

        }
}
