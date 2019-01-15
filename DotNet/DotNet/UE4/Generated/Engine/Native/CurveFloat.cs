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
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct CurveFloat_fields {
        [FieldOffset(88)] public RichCurve FloatCurve;
        [FieldOffset(200)] public bool bIsEventCurve;
    }
    internal unsafe struct CurveFloat_methods {
        internal struct GetFloatValue_method {
            static internal IntPtr GetFloatValue_ptr;
            static GetFloatValue_method() {
                GetFloatValue_ptr = Main.GetMethodUFunction(CurveFloat.StaticClass, "GetFloatValue");
            }

            internal static unsafe float Invoke(IntPtr obj, float InTime) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InTime;
                Main.GetProcessEvent(obj, GetFloatValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
    }
    internal unsafe struct CurveFloat_events {
    }
}
