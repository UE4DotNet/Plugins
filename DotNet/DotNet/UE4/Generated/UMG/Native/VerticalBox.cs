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
    [StructLayout( LayoutKind.Explicit, Size=424 )]
    internal unsafe struct VerticalBox_fields {
    }
    internal unsafe struct VerticalBox_methods {
        internal struct AddChildToVerticalBox_method {
            static internal IntPtr AddChildToVerticalBox_ptr;
            static AddChildToVerticalBox_method() {
                AddChildToVerticalBox_ptr = Main.GetMethodUFunction(VerticalBox.StaticClass, "AddChildToVerticalBox");
            }

            internal static unsafe VerticalBoxSlot Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, AddChildToVerticalBox_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
    }
    internal unsafe struct VerticalBox_events {
    }
}
