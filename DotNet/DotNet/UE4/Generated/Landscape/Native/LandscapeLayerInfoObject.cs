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


namespace UE4.Landscape.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct LandscapeLayerInfoObject_fields {
        [FieldOffset(56)] public Name LayerName;
        [FieldOffset(72)]  public IntPtr  PhysMaterial;
        [FieldOffset(80)] public float Hardness;
        [FieldOffset(84)] public bool bNoWeightBlend;
        [FieldOffset(88)] public bool IsReferencedFromLoadedData;
        [FieldOffset(92)] public LinearColor LayerUsageDebugColor;
    }
    internal unsafe struct LandscapeLayerInfoObject_methods {
    }
    internal unsafe struct LandscapeLayerInfoObject_events {
    }
}
