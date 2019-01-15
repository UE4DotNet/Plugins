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
    [StructLayout( LayoutKind.Explicit, Size=304 )]
    internal unsafe struct MaterialExpressionTemporalSobol_fields {
        [FieldOffset(176)] public ExpressionInput Index;
        [FieldOffset(232)] public ExpressionInput Seed;
        [FieldOffset(288)] byte ConstIndex; //TODO: numeric uint32 ConstIndex
        [FieldOffset(292)] public Vector2D ConstSeed;
    }
    internal unsafe struct MaterialExpressionTemporalSobol_methods {
    }
    internal unsafe struct MaterialExpressionTemporalSobol_events {
    }
}
