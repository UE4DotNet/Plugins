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


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=360 )]
    internal unsafe struct RaycastComponent_fields {
    }
    internal unsafe struct RaycastComponent_methods {
        internal struct RequestRaycast_method {
            static internal IntPtr RequestRaycast_ptr;
            static RequestRaycast_method() {
                RequestRaycast_ptr = Main.GetMethodUFunction(RaycastComponent.StaticClass, "RequestRaycast");
            }

            internal static unsafe bool Invoke(IntPtr obj, RaycastQueryParams RequestParams, byte ResultDelegate /*TODO: delegate FRaycastResultDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((RaycastQueryParams*)(b+0)) = RequestParams;
                throw new NotImplementedException(); //TODO: delegate FRaycastResultDelegate ResultDelegate
                Main.GetProcessEvent(obj, RequestRaycast_ptr, new IntPtr(p)); ;
                 //TODO: delegate FRaycastResultDelegate ResultDelegate
                return *((bool*)(b+76));
            }
        }
    }
    internal unsafe struct RaycastComponent_events {
    }
}
