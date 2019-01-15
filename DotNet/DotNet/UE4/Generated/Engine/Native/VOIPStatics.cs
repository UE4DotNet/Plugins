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
    internal unsafe struct VOIPStatics_fields {
    }
    internal unsafe struct VOIPStatics_methods {
        internal struct SetMicThreshold_method {
            static internal IntPtr SetMicThreshold_ptr;
            static SetMicThreshold_method() {
                SetMicThreshold_ptr = Main.GetMethodUFunction(VOIPStatics.StaticClass, "SetMicThreshold");
            }

            internal static unsafe void Invoke(float InThreshold) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InThreshold;
                Main.GetProcessEvent(VOIPStatics.DefaultObject, SetMicThreshold_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct VOIPStatics_events {
    }
}
