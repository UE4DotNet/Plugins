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
    [StructLayout( LayoutKind.Explicit, Size=424 )]
    internal unsafe struct CurveVector_fields {
        [FieldOffset(88)] public RichCurve FloatCurves;
    }
    internal unsafe struct CurveVector_methods {
        internal struct GetVectorValue_method {
            static internal IntPtr GetVectorValue_ptr;
            static GetVectorValue_method() {
                GetVectorValue_ptr = Main.GetMethodUFunction(CurveVector.StaticClass, "GetVectorValue");
            }

            internal static unsafe Vector Invoke(IntPtr obj, float InTime) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InTime;
                Main.GetProcessEvent(obj, GetVectorValue_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
    }
    internal unsafe struct CurveVector_events {
    }
}
