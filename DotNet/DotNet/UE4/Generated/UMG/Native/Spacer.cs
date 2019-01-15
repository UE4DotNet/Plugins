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


namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=408 )]
    internal unsafe struct Spacer_fields {
        [FieldOffset(384)] public Vector2D Size;
    }
    internal unsafe struct Spacer_methods {
        internal struct SetSize_method {
            static internal IntPtr SetSize_ptr;
            static SetSize_method() {
                SetSize_ptr = Main.GetMethodUFunction(Spacer.StaticClass, "SetSize");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InSize;
                Main.GetProcessEvent(obj, SetSize_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Spacer_events {
    }
}
