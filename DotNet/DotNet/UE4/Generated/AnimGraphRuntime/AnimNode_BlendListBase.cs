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
        ///<summary>Blend list node; has many children</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct AnimNode_BlendListBase {
            [FieldOffset(56)] byte BlendPose; //TODO: array TArray BlendPose

            [FieldOffset(72)] byte BlendTime; //TODO: array TArray BlendTime

            [FieldOffset(88)] byte BlendType; //TODO: enum EAlphaBlendOption BlendType

            [FieldOffset(96)] 
            private IntPtr  CustomBlendCurve_field;
            ///<summary>Custom Blend Curve</summary>
            public CurveFloat CustomBlendCurve {
                get {return CustomBlendCurve_field;}
                set {CustomBlendCurve_field = value;}
            }

            [FieldOffset(104)] 
            private IntPtr  BlendProfile_field;
            ///<summary>Blend Profile</summary>
            public BlendProfile BlendProfile {
                get {return BlendProfile_field;}
                set {BlendProfile_field = value;}
            }

            [FieldOffset(112)] byte Blends; //TODO: array TArray Blends

            [FieldOffset(128)] byte BlendWeights; //TODO: array TArray BlendWeights

            [FieldOffset(144)] byte RemainingBlendTimes; //TODO: array TArray RemainingBlendTimes

            [FieldOffset(160)] public int LastActiveChildIndex;

            [FieldOffset(168)] byte PerBoneSampleData; //TODO: array TArray PerBoneSampleData

            [FieldOffset(200)] public bool bResetChildOnActivation;

        }
}
