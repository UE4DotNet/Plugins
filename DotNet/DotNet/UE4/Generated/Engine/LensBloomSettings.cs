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
        ///<summary>Lens Bloom Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=184 )]
        public unsafe struct LensBloomSettings {
            ///<summary>Bloom gaussian sum method specific settings.</summary>
            [FieldOffset(0)] GaussianSumBloomSettings GaussianSum;

            ///<summary>Bloom convolution method specific settings.</summary>
            [FieldOffset(136)] ConvolutionBloomSettings Convolution;

            [FieldOffset(176)] public byte Method;

        }
}
