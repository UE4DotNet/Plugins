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
    [StructLayout( LayoutKind.Explicit, Size=704 )]
    internal unsafe struct CurveLinearColorAtlas_fields {
        [FieldOffset(648)] public bool bIsDirty;
        [FieldOffset(672)] byte TextureSize; //TODO: numeric uint32 TextureSize
        [FieldOffset(676)] byte GradientPixelSize; //TODO: numeric uint32 GradientPixelSize
        [FieldOffset(680)] public NativeArray GradientCurves;
    }
    internal unsafe struct CurveLinearColorAtlas_methods {
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
