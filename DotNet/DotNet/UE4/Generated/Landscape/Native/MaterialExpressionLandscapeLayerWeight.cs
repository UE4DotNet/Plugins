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

using UE4.Engine;

namespace UE4.Landscape.Native {
    [StructLayout( LayoutKind.Explicit, Size=336 )]
    internal unsafe struct MaterialExpressionLandscapeLayerWeight_fields {
        [FieldOffset(176)] public ExpressionInput Base;
        [FieldOffset(232)] public ExpressionInput Layer;
        [FieldOffset(288)] public Name ParameterName;
        [FieldOffset(300)] public float PreviewWeight;
        [FieldOffset(304)] public Vector ConstBase;
        [FieldOffset(316)] public FGuid ExpressionGUID;
    }
    internal unsafe struct MaterialExpressionLandscapeLayerWeight_methods {
    }
    internal unsafe struct MaterialExpressionLandscapeLayerWeight_events {
    }
}
