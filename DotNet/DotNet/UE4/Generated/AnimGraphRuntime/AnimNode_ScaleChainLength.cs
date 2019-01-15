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
        ///<summary>Scale the length of a chain of bones.</summary>
        [StructLayout( LayoutKind.Explicit, Size=184 )]
        public unsafe struct AnimNode_ScaleChainLength {
            ///<summary>Input Pose</summary>
            [FieldOffset(56)] PoseLink InputPose;

            [FieldOffset(80)] public float DefaultChainLength;

            ///<summary>Chain Start Bone</summary>
            [FieldOffset(84)] BoneReference ChainStartBone;

            ///<summary>Chain End Bone</summary>
            [FieldOffset(108)] BoneReference ChainEndBone;

            [FieldOffset(132)] byte ChainInitialLength; //TODO: enum EScaleChainInitialLength ChainInitialLength

            ///<summary>Target Location</summary>
            [FieldOffset(136)] Vector TargetLocation;

            [FieldOffset(148)] public float Alpha;

            [FieldOffset(152)] public float ActualAlpha;

            ///<summary>Alpha Scale Bias</summary>
            [FieldOffset(156)] InputScaleBias AlphaScaleBias;

            [FieldOffset(164)] public bool bBoneIndicesCached;

        }
}
