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
    [StructLayout( LayoutKind.Explicit, Size=416 )]
    internal unsafe struct MaterialExpressionSpeedTree_fields {
        [FieldOffset(176)] public ExpressionInput GeometryInput;
        [FieldOffset(232)] public ExpressionInput WindInput;
        [FieldOffset(288)] public ExpressionInput LODInput;
        [FieldOffset(344)] public ExpressionInput ExtraBendWS;
        [FieldOffset(400)] public byte GeometryType;
        [FieldOffset(401)] public byte WindType;
        [FieldOffset(402)] public byte LODType;
        [FieldOffset(404)] public float BillboardThreshold;
        [FieldOffset(408)] public bool bAccurateWindVelocities;
    }
    internal unsafe struct MaterialExpressionSpeedTree_methods {
    }
    internal unsafe struct MaterialExpressionSpeedTree_events {
    }
}
