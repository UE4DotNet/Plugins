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
    internal unsafe struct HorizontalBox_fields {
    }
    internal unsafe struct HorizontalBox_methods {
        internal struct AddChildToHorizontalBox_method {
            static internal IntPtr AddChildToHorizontalBox_ptr;
            static AddChildToHorizontalBox_method() {
                AddChildToHorizontalBox_ptr = Main.GetMethodUFunction(HorizontalBox.StaticClass, "AddChildToHorizontalBox");
            }

            internal static unsafe HorizontalBoxSlot Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, AddChildToHorizontalBox_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
    }
    internal unsafe struct HorizontalBox_events {
    }
}
