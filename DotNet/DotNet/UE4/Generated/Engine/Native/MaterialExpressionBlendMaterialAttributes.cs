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
    [StructLayout( LayoutKind.Explicit, Size=368 )]
    internal unsafe struct MaterialExpressionBlendMaterialAttributes_fields {
        [FieldOffset(176)] public MaterialAttributesInput A;
        [FieldOffset(240)] public MaterialAttributesInput B;
        [FieldOffset(304)] public ExpressionInput Alpha;
        [FieldOffset(360)] public byte PixelAttributeBlendType;
        [FieldOffset(361)] public byte VertexAttributeBlendType;
    }
    internal unsafe struct MaterialExpressionBlendMaterialAttributes_methods {
    }
    internal unsafe struct MaterialExpressionBlendMaterialAttributes_events {
    }
}
