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
    [StructLayout( LayoutKind.Explicit, Size=360 )]
    internal unsafe struct MaterialExpressionSobol_fields {
        [FieldOffset(176)] public ExpressionInput Cell;
        [FieldOffset(232)] public ExpressionInput Index;
        [FieldOffset(288)] public ExpressionInput Seed;
        [FieldOffset(344)] byte ConstIndex; //TODO: numeric uint32 ConstIndex
        [FieldOffset(348)] public Vector2D ConstSeed;
    }
    internal unsafe struct MaterialExpressionSobol_methods {
    }
    internal unsafe struct MaterialExpressionSobol_events {
    }
}
