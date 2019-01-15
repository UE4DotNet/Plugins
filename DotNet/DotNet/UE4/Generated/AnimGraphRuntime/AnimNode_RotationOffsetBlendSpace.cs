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
        ///<summary>@TODO: Comment</summary>
        [StructLayout( LayoutKind.Explicit, Size=520 )]
        public unsafe struct AnimNode_RotationOffsetBlendSpace {
            ///<summary>Base Pose</summary>
            [FieldOffset(304)] PoseLink BasePose;

            [FieldOffset(328)] public int LODThreshold;

            [FieldOffset(332)] public bool bIsLODEnabled;

            [FieldOffset(333)] byte AlphaInputType; //TODO: enum EAnimAlphaInputType AlphaInputType

            [FieldOffset(336)] public float Alpha;

            ///<summary>Alpha Scale Bias</summary>
            [FieldOffset(340)] InputScaleBias AlphaScaleBias;

            [FieldOffset(348)] public float ActualAlpha;

            [FieldOffset(352)] public bool bAlphaBoolEnabled;

            ///<summary>Alpha Bool Blend</summary>
            [FieldOffset(360)] InputAlphaBoolBlend AlphaBoolBlend;

            [FieldOffset(448)] public Name AlphaCurveName;

            ///<summary>Alpha Scale Bias Clamp</summary>
            [FieldOffset(460)] InputScaleBiasClamp AlphaScaleBiasClamp;

        }
}
