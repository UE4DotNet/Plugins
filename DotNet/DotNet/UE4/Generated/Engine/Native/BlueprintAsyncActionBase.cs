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
    [StructLayout( LayoutKind.Explicit, Size=64 )]
    internal unsafe struct BlueprintAsyncActionBase_fields {
    }
    internal unsafe struct BlueprintAsyncActionBase_methods {
        internal struct Activate_method {
            static internal IntPtr Activate_ptr;
            static Activate_method() {
                Activate_ptr = Main.GetMethodUFunction(BlueprintAsyncActionBase.StaticClass, "Activate");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Activate_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct BlueprintAsyncActionBase_events {
    }
}
