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
    [StructLayout( LayoutKind.Explicit, Size=440 )]
    internal unsafe struct MaterialExpressionMaterialAttributeLayers_fields {
        [FieldOffset(176)] public Name ParameterName;
        [FieldOffset(188)] public FGuid ExpressionGUID;
        [FieldOffset(208)] public MaterialAttributesInput Input;
        [FieldOffset(272)] public MaterialLayersFunctions DefaultLayers;
        [FieldOffset(384)] public NativeArray LayerCallers;
        [FieldOffset(400)] public int NumActiveLayerCallers;
        [FieldOffset(408)] public NativeArray BlendCallers;
        [FieldOffset(424)] public int NumActiveBlendCallers;
        [FieldOffset(428)] public bool bIsLayerGraphBuilt;
    }
    internal unsafe struct MaterialExpressionMaterialAttributeLayers_methods {
    }
    internal unsafe struct MaterialExpressionMaterialAttributeLayers_events {
    }
}
