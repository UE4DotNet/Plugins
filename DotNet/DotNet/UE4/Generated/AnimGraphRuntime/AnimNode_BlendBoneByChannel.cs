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
        ///<summary>Anim Node Blend Bone by Channel</summary>
        [StructLayout( LayoutKind.Explicit, Size=168 )]
        public unsafe struct AnimNode_BlendBoneByChannel {
            ///<summary>A</summary>
            [FieldOffset(56)] PoseLink A;

            ///<summary>B</summary>
            [FieldOffset(80)] PoseLink B;

            [FieldOffset(104)] public float Alpha;

            ///<summary>Alpha Scale Bias</summary>
            [FieldOffset(108)] InputScaleBias AlphaScaleBias;

            [FieldOffset(120)] byte BoneDefinitions; //TODO: array TArray BoneDefinitions

            [FieldOffset(136)] public byte TransformsSpace;

            [FieldOffset(140)] public float InternalBlendAlpha;

            [FieldOffset(144)] public bool bBIsRelevant;

            [FieldOffset(152)] byte ValidBoneEntries; //TODO: array TArray ValidBoneEntries

        }
}
