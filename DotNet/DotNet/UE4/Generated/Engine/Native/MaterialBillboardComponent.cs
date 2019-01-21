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
    [StructLayout( LayoutKind.Explicit, Size=1520 )]
    internal unsafe struct MaterialBillboardComponent_fields {
        [FieldOffset(1504)] public NativeArray Elements;
    }
    internal unsafe struct MaterialBillboardComponent_methods {
        internal struct AddElement_method {
            static internal IntPtr AddElement_ptr;
            static AddElement_method() {
                AddElement_ptr = Main.GetMethodUFunction(MaterialBillboardComponent.StaticClass, "AddElement");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface Material, CurveFloat DistanceToOpacityCurve, bool bSizeIsInScreenSpace, float BaseSizeX, float BaseSizeY, CurveFloat DistanceToSizeCurve) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                *((IntPtr*)(b+8)) = DistanceToOpacityCurve;
                *((bool*)(b+16)) = bSizeIsInScreenSpace;
                *((float*)(b+20)) = BaseSizeX;
                *((float*)(b+24)) = BaseSizeY;
                *((IntPtr*)(b+32)) = DistanceToSizeCurve;
                Main.GetProcessEvent(obj, AddElement_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetElements_method {
            static internal IntPtr SetElements_ptr;
            static SetElements_method() {
                SetElements_ptr = Main.GetMethodUFunction(MaterialBillboardComponent.StaticClass, "SetElements");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewElements /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray NewElements
                Main.GetProcessEvent(obj, SetElements_ptr, new IntPtr(p)); ;
                 //TODO: array TArray NewElements
            }
        }
    }
    internal unsafe struct MaterialBillboardComponent_events {
    }
}
