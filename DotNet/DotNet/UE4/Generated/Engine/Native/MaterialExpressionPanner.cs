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
    internal unsafe struct MaterialExpressionPanner_fields {
        [FieldOffset(176)] public ExpressionInput Coordinate;
        [FieldOffset(232)] public ExpressionInput Time;
        [FieldOffset(288)] public ExpressionInput Speed;
        [FieldOffset(344)] public float SpeedX;
        [FieldOffset(348)] public float SpeedY;
        [FieldOffset(352)] byte ConstCoordinate; //TODO: numeric uint32 ConstCoordinate
        [FieldOffset(356)] public bool bFractionalPart;
    }
    internal unsafe struct MaterialExpressionPanner_methods {
    }
    internal unsafe struct MaterialExpressionPanner_events {
    }
}
