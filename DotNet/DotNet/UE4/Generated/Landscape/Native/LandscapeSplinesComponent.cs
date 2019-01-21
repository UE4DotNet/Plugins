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
    [StructLayout( LayoutKind.Explicit, Size=1824 )]
    internal unsafe struct LandscapeSplinesComponent_fields {
        [FieldOffset(1504)] public float SplineResolution;
        [FieldOffset(1508)] public Color SplineColor;
        [FieldOffset(1512)]  public IntPtr  ControlPointSprite;
        [FieldOffset(1520)]  public IntPtr  SplineEditorMesh;
        [FieldOffset(1528)] public bool bShowSplineEditorMesh;
        [FieldOffset(1536)] public NativeArray ControlPoints;
        [FieldOffset(1552)] public NativeArray Segments;
        [FieldOffset(1568)] byte ForeignWorldSplineDataMap; //TODO: map TMap ForeignWorldSplineDataMap
        [FieldOffset(1808)] public NativeArray CookedForeignMeshComponents;
    }
    internal unsafe struct LandscapeSplinesComponent_methods {
        internal struct GetSplineMeshComponents_method {
            static internal IntPtr GetSplineMeshComponents_ptr;
            static GetSplineMeshComponents_method() {
                GetSplineMeshComponents_ptr = Main.GetMethodUFunction(LandscapeSplinesComponent.StaticClass, "GetSplineMeshComponents");
            }

            internal static unsafe IReadOnlyCollection<SplineMeshComponent> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSplineMeshComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<SplineMeshComponent>(b+0);
            }
        }
    }
    internal unsafe struct LandscapeSplinesComponent_events {
    }
}
