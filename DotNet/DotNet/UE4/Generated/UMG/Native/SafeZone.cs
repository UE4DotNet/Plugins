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
    [StructLayout( LayoutKind.Explicit, Size=456 )]
    internal unsafe struct SafeZone_fields {
        [FieldOffset(408)] public bool PadLeft;
        [FieldOffset(409)] public bool PadRight;
        [FieldOffset(410)] public bool PadTop;
        [FieldOffset(411)] public bool PadBottom;
    }
    internal unsafe struct SafeZone_methods {
        internal struct SetSidesToPad_method {
            static internal IntPtr SetSidesToPad_ptr;
            static SetSidesToPad_method() {
                SetSidesToPad_ptr = Main.GetMethodUFunction(SafeZone.StaticClass, "SetSidesToPad");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InPadLeft, bool InPadRight, bool InPadTop, bool InPadBottom) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InPadLeft;
                *((bool*)(b+1)) = InPadRight;
                *((bool*)(b+2)) = InPadTop;
                *((bool*)(b+3)) = InPadBottom;
                Main.GetProcessEvent(obj, SetSidesToPad_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SafeZone_events {
    }
}
