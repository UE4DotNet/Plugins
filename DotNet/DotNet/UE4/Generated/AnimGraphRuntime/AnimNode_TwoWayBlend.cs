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
        ///<summary>This represents a baked transition</summary>
        [StructLayout( LayoutKind.Explicit, Size=296 )]
        public unsafe struct AnimNode_TwoWayBlend {
            ///<summary>A</summary>
            [FieldOffset(56)] PoseLink A;

            ///<summary>B</summary>
            [FieldOffset(80)] PoseLink B;

            [FieldOffset(104)] byte AlphaInputType; //TODO: enum EAnimAlphaInputType AlphaInputType

            [FieldOffset(108)] public float Alpha;

            ///<summary>Alpha Scale Bias</summary>
            [FieldOffset(112)] InputScaleBias AlphaScaleBias;

            [FieldOffset(120)] public bool bAlphaBoolEnabled;

            ///<summary>Alpha Bool Blend</summary>
            [FieldOffset(128)] InputAlphaBoolBlend AlphaBoolBlend;

            [FieldOffset(216)] public Name AlphaCurveName;

            ///<summary>Alpha Scale Bias Clamp</summary>
            [FieldOffset(228)] InputScaleBiasClamp AlphaScaleBiasClamp;

            [FieldOffset(288)] public float InternalBlendAlpha;

            [FieldOffset(292)] public bool bAIsRelevant;

            [FieldOffset(293)] public bool bBIsRelevant;

            [FieldOffset(294)] public bool bResetChildOnActivation;

        }
}
