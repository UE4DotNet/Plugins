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
    internal unsafe struct MaterialExpressionClamp_fields {
        [FieldOffset(176)] public ExpressionInput Input;
        [FieldOffset(232)] public ExpressionInput Min;
        [FieldOffset(288)] public ExpressionInput Max;
        [FieldOffset(344)] public byte ClampMode;
        [FieldOffset(348)] public float MinDefault;
        [FieldOffset(352)] public float MaxDefault;
    }
    internal unsafe struct MaterialExpressionClamp_methods {
    }
    internal unsafe struct MaterialExpressionClamp_events {
    }
}
