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


namespace UE4.GeometryCache.Native {
    [StructLayout( LayoutKind.Explicit, Size=1016 )]
    internal unsafe struct GeometryCacheActor_fields {
        [FieldOffset(1008)]  public IntPtr  GeometryCacheComponent;
    }
    internal unsafe struct GeometryCacheActor_methods {
        internal struct GetGeometryCacheComponent_method {
            static internal IntPtr GetGeometryCacheComponent_ptr;
            static GetGeometryCacheComponent_method() {
                GetGeometryCacheComponent_ptr = Main.GetMethodUFunction(GeometryCacheActor.StaticClass, "GetGeometryCacheComponent");
            }

            internal static unsafe GeometryCacheComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetGeometryCacheComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
    }
    internal unsafe struct GeometryCacheActor_events {
    }
}
