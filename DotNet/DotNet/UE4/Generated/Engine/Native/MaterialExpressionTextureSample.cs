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
    [StructLayout( LayoutKind.Explicit, Size=552 )]
    internal unsafe struct MaterialExpressionTextureSample_fields {
        [FieldOffset(192)] public ExpressionInput Coordinates;
        [FieldOffset(248)] public ExpressionInput TextureObject;
        [FieldOffset(304)] public ExpressionInput MipValue;
        [FieldOffset(360)] public ExpressionInput CoordinatesDX;
        [FieldOffset(416)] public ExpressionInput CoordinatesDY;
        [FieldOffset(472)] public ExpressionInput AutomaticViewMipBiasValue;
        [FieldOffset(528)] public byte MipValueMode;
        [FieldOffset(529)] public byte SamplerSource;
        [FieldOffset(532)] byte ConstCoordinate; //TODO: numeric uint32 ConstCoordinate
        [FieldOffset(536)] public int ConstMipValue;
        [FieldOffset(540)] public bool AutomaticViewMipBias;
    }
    internal unsafe struct MaterialExpressionTextureSample_methods {
    }
    internal unsafe struct MaterialExpressionTextureSample_events {
    }
}
