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
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct UniformGridSlot_fields {
        [FieldOffset(72)] public byte HorizontalAlignment;
        [FieldOffset(73)] public byte VerticalAlignment;
        [FieldOffset(76)] public int Row;
        [FieldOffset(80)] public int Column;
    }
    internal unsafe struct UniformGridSlot_methods {
        internal struct SetColumn_method {
            static internal IntPtr SetColumn_ptr;
            static SetColumn_method() {
                SetColumn_ptr = Main.GetMethodUFunction(UniformGridSlot.StaticClass, "SetColumn");
            }

            internal static unsafe void Invoke(IntPtr obj, int InColumn) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InColumn;
                Main.GetProcessEvent(obj, SetColumn_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHorizontalAlignment_method {
            static internal IntPtr SetHorizontalAlignment_ptr;
            static SetHorizontalAlignment_method() {
                SetHorizontalAlignment_ptr = Main.GetMethodUFunction(UniformGridSlot.StaticClass, "SetHorizontalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InHorizontalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InHorizontalAlignment;
                Main.GetProcessEvent(obj, SetHorizontalAlignment_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRow_method {
            static internal IntPtr SetRow_ptr;
            static SetRow_method() {
                SetRow_ptr = Main.GetMethodUFunction(UniformGridSlot.StaticClass, "SetRow");
            }

            internal static unsafe void Invoke(IntPtr obj, int InRow) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InRow;
                Main.GetProcessEvent(obj, SetRow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVerticalAlignment_method {
            static internal IntPtr SetVerticalAlignment_ptr;
            static SetVerticalAlignment_method() {
                SetVerticalAlignment_ptr = Main.GetMethodUFunction(UniformGridSlot.StaticClass, "SetVerticalAlignment");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InVerticalAlignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InVerticalAlignment;
                Main.GetProcessEvent(obj, SetVerticalAlignment_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct UniformGridSlot_events {
    }
}
