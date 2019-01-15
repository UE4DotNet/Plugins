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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MeshVertexPainterKismetLibrary_fields {
    }
    internal unsafe struct MeshVertexPainterKismetLibrary_methods {
        internal struct PaintVerticesLerpAlongAxis_method {
            static internal IntPtr PaintVerticesLerpAlongAxis_ptr;
            static PaintVerticesLerpAlongAxis_method() {
                PaintVerticesLerpAlongAxis_ptr = Main.GetMethodUFunction(MeshVertexPainterKismetLibrary.StaticClass, "PaintVerticesLerpAlongAxis");
            }

            internal static unsafe void Invoke(StaticMeshComponent StaticMeshComponent, LinearColor StartColor, LinearColor EndColor, EVertexPaintAxis Axis, bool bConvertToSRGB) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = StaticMeshComponent;
                *((LinearColor*)(b+8)) = StartColor;
                *((LinearColor*)(b+24)) = EndColor;
                *(b+40) = (byte)Axis;
                *((bool*)(b+41)) = bConvertToSRGB;
                Main.GetProcessEvent(MeshVertexPainterKismetLibrary.DefaultObject, PaintVerticesLerpAlongAxis_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PaintVerticesSingleColor_method {
            static internal IntPtr PaintVerticesSingleColor_ptr;
            static PaintVerticesSingleColor_method() {
                PaintVerticesSingleColor_ptr = Main.GetMethodUFunction(MeshVertexPainterKismetLibrary.StaticClass, "PaintVerticesSingleColor");
            }

            internal static unsafe void Invoke(StaticMeshComponent StaticMeshComponent, LinearColor FillColor, bool bConvertToSRGB) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = StaticMeshComponent;
                *((LinearColor*)(b+8)) = FillColor;
                *((bool*)(b+24)) = bConvertToSRGB;
                Main.GetProcessEvent(MeshVertexPainterKismetLibrary.DefaultObject, PaintVerticesSingleColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemovePaintedVertices_method {
            static internal IntPtr RemovePaintedVertices_ptr;
            static RemovePaintedVertices_method() {
                RemovePaintedVertices_ptr = Main.GetMethodUFunction(MeshVertexPainterKismetLibrary.StaticClass, "RemovePaintedVertices");
            }

            internal static unsafe void Invoke(StaticMeshComponent StaticMeshComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = StaticMeshComponent;
                Main.GetProcessEvent(MeshVertexPainterKismetLibrary.DefaultObject, RemovePaintedVertices_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MeshVertexPainterKismetLibrary_events {
    }
}
