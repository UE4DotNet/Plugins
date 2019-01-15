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
    internal unsafe struct GridPanel_fields {
        [FieldOffset(408)] public NativeArray ColumnFill;
        [FieldOffset(424)] public NativeArray RowFill;
    }
    internal unsafe struct GridPanel_methods {
        internal struct AddChildToGrid_method {
            static internal IntPtr AddChildToGrid_ptr;
            static AddChildToGrid_method() {
                AddChildToGrid_ptr = Main.GetMethodUFunction(GridPanel.StaticClass, "AddChildToGrid");
            }

            internal static unsafe GridSlot Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, AddChildToGrid_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SetColumnFill_method {
            static internal IntPtr SetColumnFill_ptr;
            static SetColumnFill_method() {
                SetColumnFill_ptr = Main.GetMethodUFunction(GridPanel.StaticClass, "SetColumnFill");
            }

            internal static unsafe void Invoke(IntPtr obj, int ColumnIndex, float Coefficient) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ColumnIndex;
                *((float*)(b+4)) = Coefficient;
                Main.GetProcessEvent(obj, SetColumnFill_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRowFill_method {
            static internal IntPtr SetRowFill_ptr;
            static SetRowFill_method() {
                SetRowFill_ptr = Main.GetMethodUFunction(GridPanel.StaticClass, "SetRowFill");
            }

            internal static unsafe void Invoke(IntPtr obj, int ColumnIndex, float Coefficient) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ColumnIndex;
                *((float*)(b+4)) = Coefficient;
                Main.GetProcessEvent(obj, SetRowFill_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct GridPanel_events {
    }
}
