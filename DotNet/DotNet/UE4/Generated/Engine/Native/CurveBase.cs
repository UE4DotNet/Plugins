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
    [StructLayout( LayoutKind.Explicit, Size=88 )]
    internal unsafe struct CurveBase_fields {
        [FieldOffset(64)]  public IntPtr  AssetImportData;
    }
    internal unsafe struct CurveBase_methods {
        internal struct GetTimeRange_method {
            static internal IntPtr GetTimeRange_ptr;
            static GetTimeRange_method() {
                GetTimeRange_ptr = Main.GetMethodUFunction(CurveBase.StaticClass, "GetTimeRange");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTimeRange_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)));
            }
        }
        internal struct GetValueRange_method {
            static internal IntPtr GetValueRange_ptr;
            static GetValueRange_method() {
                GetValueRange_ptr = Main.GetMethodUFunction(CurveBase.StaticClass, "GetValueRange");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetValueRange_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)));
            }
        }
    }
    internal unsafe struct CurveBase_events {
    }
}
