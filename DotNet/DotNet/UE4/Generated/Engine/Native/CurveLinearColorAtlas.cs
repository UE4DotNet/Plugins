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
    [StructLayout( LayoutKind.Explicit, Size=720 )]
    internal unsafe struct CurveLinearColorAtlas_fields {
        [FieldOffset(656)] public bool bIsDirty;
        [FieldOffset(680)] byte TextureSize; //TODO: numeric uint32 TextureSize
        [FieldOffset(684)] byte GradientPixelSize; //TODO: numeric uint32 GradientPixelSize
        [FieldOffset(688)] public NativeArray GradientCurves;
    }
    internal unsafe struct CurveLinearColorAtlas_methods {
        internal struct GetCurveIndex_method {
            static internal IntPtr GetCurveIndex_ptr;
            static GetCurveIndex_method() {
                GetCurveIndex_ptr = Main.GetMethodUFunction(CurveLinearColorAtlas.StaticClass, "GetCurveIndex");
            }

            internal static unsafe (int, bool) Invoke(IntPtr obj, CurveLinearColor InCurve) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InCurve;
                Main.GetProcessEvent(obj, GetCurveIndex_ptr, new IntPtr(p)); ;
                return (*((int*)(b+8)),*((bool*)(b+12)));
            }
        }
        internal struct GetCurvePosition_method {
            static internal IntPtr GetCurvePosition_ptr;
            static GetCurvePosition_method() {
                GetCurvePosition_ptr = Main.GetMethodUFunction(CurveLinearColorAtlas.StaticClass, "GetCurvePosition");
            }

            internal static unsafe (float, bool) Invoke(IntPtr obj, CurveLinearColor InCurve) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InCurve;
                Main.GetProcessEvent(obj, GetCurvePosition_ptr, new IntPtr(p)); ;
                return (*((float*)(b+8)),*((bool*)(b+12)));
            }
        }
    }
    internal unsafe struct CurveLinearColorAtlas_events {
    }
}
