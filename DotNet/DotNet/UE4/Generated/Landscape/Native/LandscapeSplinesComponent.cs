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
    [StructLayout( LayoutKind.Explicit, Size=1840 )]
    internal unsafe struct LandscapeSplinesComponent_fields {
        [FieldOffset(1520)] public float SplineResolution;
        [FieldOffset(1524)] public Color SplineColor;
        [FieldOffset(1528)]  public IntPtr  ControlPointSprite;
        [FieldOffset(1536)]  public IntPtr  SplineEditorMesh;
        [FieldOffset(1544)] public bool bShowSplineEditorMesh;
        [FieldOffset(1552)] public NativeArray ControlPoints;
        [FieldOffset(1568)] public NativeArray Segments;
        [FieldOffset(1584)] byte ForeignWorldSplineDataMap; //TODO: map TMap ForeignWorldSplineDataMap
        [FieldOffset(1824)] public NativeArray CookedForeignMeshComponents;
    }
    internal unsafe struct LandscapeSplinesComponent_methods {
    }
    internal unsafe struct LandscapeSplinesComponent_events {
    }
}
