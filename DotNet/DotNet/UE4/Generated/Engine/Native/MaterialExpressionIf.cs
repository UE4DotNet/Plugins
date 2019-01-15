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
    [StructLayout( LayoutKind.Explicit, Size=472 )]
    internal unsafe struct MaterialExpressionIf_fields {
        [FieldOffset(176)] public ExpressionInput A;
        [FieldOffset(232)] public ExpressionInput B;
        [FieldOffset(288)] public ExpressionInput AGreaterThanB;
        [FieldOffset(344)] public ExpressionInput AEqualsB;
        [FieldOffset(400)] public ExpressionInput ALessThanB;
        [FieldOffset(456)] public float EqualsThreshold;
        [FieldOffset(460)] public float ConstB;
    }
    internal unsafe struct MaterialExpressionIf_methods {
    }
    internal unsafe struct MaterialExpressionIf_events {
    }
}
