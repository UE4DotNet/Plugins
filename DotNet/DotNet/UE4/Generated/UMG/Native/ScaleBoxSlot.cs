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
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct ScaleBoxSlot_fields {
        [FieldOffset(72)] public Margin Padding;
        [FieldOffset(88)] public byte HorizontalAlignment;
        [FieldOffset(89)] public byte VerticalAlignment;
    }
    internal unsafe struct ScaleBoxSlot_methods {
        internal struct SetHorizontalAlignment_method {
            static internal IntPtr SetHorizontalAlignment_ptr;
            static SetHorizontalAlignment_method() {
                SetHorizontalAlignment_ptr = Main.GetMethodUFunction(ScaleBoxSlot.StaticClass, "SetHorizontalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InHorizontalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InHorizontalAlignment;
                Main.GetProcessEvent(obj, SetHorizontalAlignment_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPadding_method {
            static internal IntPtr SetPadding_ptr;
            static SetPadding_method() {
                SetPadding_ptr = Main.GetMethodUFunction(ScaleBoxSlot.StaticClass, "SetPadding");
            }

            internal static unsafe void Invoke(IntPtr obj, Margin InPadding) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Margin*)(b+0)) = InPadding;
                Main.GetProcessEvent(obj, SetPadding_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVerticalAlignment_method {
            static internal IntPtr SetVerticalAlignment_ptr;
            static SetVerticalAlignment_method() {
                SetVerticalAlignment_ptr = Main.GetMethodUFunction(ScaleBoxSlot.StaticClass, "SetVerticalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InVerticalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InVerticalAlignment;
                Main.GetProcessEvent(obj, SetVerticalAlignment_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ScaleBoxSlot_events {
    }
}
