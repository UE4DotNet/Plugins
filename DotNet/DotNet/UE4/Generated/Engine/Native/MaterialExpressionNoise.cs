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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=328 )]
    internal unsafe struct MaterialExpressionNoise_fields {
        [FieldOffset(176)] public ExpressionInput Position;
        [FieldOffset(232)] public ExpressionInput FilterWidth;
        [FieldOffset(288)] public float Scale;
        [FieldOffset(292)] public int Quality;
        [FieldOffset(296)] public byte NoiseFunction;
        [FieldOffset(300)] public bool bTurbulence;
        [FieldOffset(304)] public int Levels;
        [FieldOffset(308)] public float OutputMin;
        [FieldOffset(312)] public float OutputMax;
        [FieldOffset(316)] public float LevelScale;
        [FieldOffset(320)] public bool bTiling;
        [FieldOffset(324)] byte RepeatSize; //TODO: numeric uint32 RepeatSize
    }
    internal unsafe struct MaterialExpressionNoise_methods {
    }
    internal unsafe struct MaterialExpressionNoise_events {
    }
}
