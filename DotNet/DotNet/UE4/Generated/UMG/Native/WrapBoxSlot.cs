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
    internal unsafe struct WrapBoxSlot_fields {
        [FieldOffset(72)] public Margin Padding;
        [FieldOffset(88)] public bool bFillEmptySpace;
        [FieldOffset(92)] public float FillSpanWhenLessThan;
        [FieldOffset(96)] public byte HorizontalAlignment;
        [FieldOffset(97)] public byte VerticalAlignment;
    }
    internal unsafe struct WrapBoxSlot_methods {
        internal struct SetFillEmptySpace_method {
            static internal IntPtr SetFillEmptySpace_ptr;
            static SetFillEmptySpace_method() {
                SetFillEmptySpace_ptr = Main.GetMethodUFunction(WrapBoxSlot.StaticClass, "SetFillEmptySpace");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InbFillEmptySpace) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InbFillEmptySpace;
                Main.GetProcessEvent(obj, SetFillEmptySpace_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFillSpanWhenLessThan_method {
            static internal IntPtr SetFillSpanWhenLessThan_ptr;
            static SetFillSpanWhenLessThan_method() {
                SetFillSpanWhenLessThan_ptr = Main.GetMethodUFunction(WrapBoxSlot.StaticClass, "SetFillSpanWhenLessThan");
            }

            internal static unsafe void Invoke(IntPtr obj, float InFillSpanWhenLessThan) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InFillSpanWhenLessThan;
                Main.GetProcessEvent(obj, SetFillSpanWhenLessThan_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHorizontalAlignment_method {
            static internal IntPtr SetHorizontalAlignment_ptr;
            static SetHorizontalAlignment_method() {
                SetHorizontalAlignment_ptr = Main.GetMethodUFunction(WrapBoxSlot.StaticClass, "SetHorizontalAlignment");
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
                SetPadding_ptr = Main.GetMethodUFunction(WrapBoxSlot.StaticClass, "SetPadding");
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
                SetVerticalAlignment_ptr = Main.GetMethodUFunction(WrapBoxSlot.StaticClass, "SetVerticalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InVerticalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InVerticalAlignment;
                Main.GetProcessEvent(obj, SetVerticalAlignment_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct WrapBoxSlot_events {
    }
}
