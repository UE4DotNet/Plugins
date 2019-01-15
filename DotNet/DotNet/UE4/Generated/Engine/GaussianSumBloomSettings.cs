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


namespace UE4.Engine{
        ///<summary>Gaussian Sum Bloom Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=132 )]
        public unsafe struct GaussianSumBloomSettings {
            [FieldOffset(0)] public float Intensity;

            [FieldOffset(4)] public float Threshold;

            [FieldOffset(8)] public float SizeScale;

            [FieldOffset(12)] public float Filter1Size;

            [FieldOffset(16)] public float Filter2Size;

            [FieldOffset(20)] public float Filter3Size;

            [FieldOffset(24)] public float Filter4Size;

            [FieldOffset(28)] public float Filter5Size;

            [FieldOffset(32)] public float Filter6Size;

            ///<summary>Bloom1 tint color</summary>
            [FieldOffset(36)] LinearColor Filter1Tint;

            ///<summary>Bloom2 tint color</summary>
            [FieldOffset(52)] LinearColor Filter2Tint;

            ///<summary>Bloom3 tint color</summary>
            [FieldOffset(68)] LinearColor Filter3Tint;

            ///<summary>Bloom4 tint color</summary>
            [FieldOffset(84)] LinearColor Filter4Tint;

            ///<summary>Bloom5 tint color</summary>
            [FieldOffset(100)] LinearColor Filter5Tint;

            ///<summary>Bloom6 tint color</summary>
            [FieldOffset(116)] LinearColor Filter6Tint;

        }
}
