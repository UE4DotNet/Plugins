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
        [StructLayout( LayoutKind.Explicit, Size=280 )]
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

            [FieldOffset(208)] public Name AlphaCurveName;

            ///<summary>Alpha Scale Bias Clamp</summary>
            [FieldOffset(220)] InputScaleBiasClamp AlphaScaleBiasClamp;

            [FieldOffset(268)] public float InternalBlendAlpha;

            [FieldOffset(272)] public bool bAIsRelevant;

            [FieldOffset(273)] public bool bBIsRelevant;

            [FieldOffset(274)] public bool bResetChildOnActivation;

        }
}
