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

using UE4.SlateCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=1872 )]
    internal unsafe struct ScrollBar_fields {
        [FieldOffset(384)] public ScrollBarStyle WidgetStyle;
        [FieldOffset(1840)] public bool bAlwaysShowScrollbar;
        [FieldOffset(1841)] public byte Orientation;
        [FieldOffset(1844)] public Vector2D Thickness;
    }
    internal unsafe struct ScrollBar_methods {
        internal struct SetState_method {
            static internal IntPtr SetState_ptr;
            static SetState_method() {
                SetState_ptr = Main.GetMethodUFunction(ScrollBar.StaticClass, "SetState");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOffsetFraction, float InThumbSizeFraction) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOffsetFraction;
                *((float*)(b+4)) = InThumbSizeFraction;
                Main.GetProcessEvent(obj, SetState_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ScrollBar_events {
    }
}
