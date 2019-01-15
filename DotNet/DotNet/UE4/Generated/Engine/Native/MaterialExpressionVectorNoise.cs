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
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct MaterialExpressionVectorNoise_fields {
        [FieldOffset(176)] public ExpressionInput Position;
        [FieldOffset(232)] public byte NoiseFunction;
        [FieldOffset(236)] public int Quality;
        [FieldOffset(240)] public bool bTiling;
        [FieldOffset(244)] byte TileSize; //TODO: numeric uint32 TileSize
    }
    internal unsafe struct MaterialExpressionVectorNoise_methods {
    }
    internal unsafe struct MaterialExpressionVectorNoise_events {
    }
}
