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
        ///<summary>Anim Node Apply Additive</summary>
        [StructLayout( LayoutKind.Explicit, Size=288 )]
        public unsafe struct AnimNode_ApplyAdditive {
            ///<summary>Base</summary>
            [FieldOffset(56)] PoseLink Base;

            ///<summary>Additive</summary>
            [FieldOffset(80)] PoseLink Additive;

            [FieldOffset(104)] public float Alpha;

            ///<summary>Alpha Scale Bias</summary>
            [FieldOffset(108)] InputScaleBias AlphaScaleBias;

            [FieldOffset(116)] public int LODThreshold;

            [FieldOffset(120)] public float ActualAlpha;

            [FieldOffset(124)] byte AlphaInputType; //TODO: enum EAnimAlphaInputType AlphaInputType

            [FieldOffset(125)] public bool bAlphaBoolEnabled;

            ///<summary>Alpha Bool Blend</summary>
            [FieldOffset(128)] InputAlphaBoolBlend AlphaBoolBlend;

            [FieldOffset(216)] public Name AlphaCurveName;

            ///<summary>Alpha Scale Bias Clamp</summary>
            [FieldOffset(228)] InputScaleBiasClamp AlphaScaleBiasClamp;

        }
}
