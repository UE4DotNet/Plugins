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
        ///<summary>Node to handle re-targeting of Hand IK bone chain.</summary>
        ///<remarks>
        ///It looks at position in Mesh Space of Left and Right IK bones, and moves Left and Right IK bones to those.
        ///based on HandFKWeight. (0 = favor left hand, 1 = favor right hand, 0.5 = equal weight).
        ///This is used so characters of different proportions can handle the same props.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=456 )]
        public unsafe struct AnimNode_HandIKRetargeting {
            ///<summary>Bone for Right Hand FK</summary>
            [FieldOffset(336)] BoneReference RightHandFK;

            ///<summary>Bone for Left Hand FK</summary>
            [FieldOffset(360)] BoneReference LeftHandFK;

            ///<summary>Bone for Right Hand IK</summary>
            [FieldOffset(384)] BoneReference RightHandIK;

            ///<summary>Bone for Left Hand IK</summary>
            [FieldOffset(408)] BoneReference LeftHandIK;

            [FieldOffset(432)] byte IKBonesToMove; //TODO: array TArray IKBonesToMove

            [FieldOffset(448)] public float HandFKWeight;

        }
}
