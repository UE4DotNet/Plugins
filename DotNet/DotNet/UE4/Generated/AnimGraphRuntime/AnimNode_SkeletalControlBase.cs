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
        ///<summary>Anim Node Skeletal Control Base</summary>
        [StructLayout( LayoutKind.Explicit, Size=360 )]
        public unsafe struct AnimNode_SkeletalControlBase {
            ///<summary>Input link</summary>
            [FieldOffset(56)] ComponentSpacePoseLink ComponentPose;

            [FieldOffset(80)] public int LODThreshold;

            [FieldOffset(84)] public float ActualAlpha;

            [FieldOffset(88)] byte AlphaInputType; //TODO: enum EAnimAlphaInputType AlphaInputType

            [FieldOffset(92)] public float Alpha;

            ///<summary>Alpha Scale Bias</summary>
            [FieldOffset(96)] InputScaleBias AlphaScaleBias;

            [FieldOffset(104)] public bool bAlphaBoolEnabled;

            ///<summary>Alpha Bool Blend</summary>
            [FieldOffset(112)] InputAlphaBoolBlend AlphaBoolBlend;

            [FieldOffset(200)] public Name AlphaCurveName;

            ///<summary>Alpha Scale Bias Clamp</summary>
            [FieldOffset(212)] InputScaleBiasClamp AlphaScaleBiasClamp;

        }
}
