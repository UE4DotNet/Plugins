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
    [StructLayout( LayoutKind.Explicit, Size=592 )]
    internal unsafe struct CurveLinearColor_fields {
        [FieldOffset(88)] public RichCurve FloatCurves;
        [FieldOffset(536)] public float AdjustHue;
        [FieldOffset(540)] public float AdjustSaturation;
        [FieldOffset(544)] public float AdjustBrightness;
        [FieldOffset(548)] public float AdjustBrightnessCurve;
        [FieldOffset(552)] public float AdjustVibrance;
        [FieldOffset(556)] public float AdjustMinAlpha;
        [FieldOffset(560)] public float AdjustMaxAlpha;
    }
    internal unsafe struct CurveLinearColor_methods {
        internal struct GetLinearColorValue_method {
            static internal IntPtr GetLinearColorValue_ptr;
            static GetLinearColorValue_method() {
                GetLinearColorValue_ptr = Main.GetMethodUFunction(CurveLinearColor.StaticClass, "GetLinearColorValue");
            }

            internal static unsafe LinearColor Invoke(IntPtr obj, float InTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InTime;
                Main.GetProcessEvent(obj, GetLinearColorValue_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+4));
            }
        }
    }
    internal unsafe struct CurveLinearColor_events {
    }
}
