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
    [StructLayout( LayoutKind.Explicit, Size=440 )]
    internal unsafe struct WrapBox_fields {
        [FieldOffset(408)] public Vector2D InnerSlotPadding;
        [FieldOffset(416)] public float WrapWidth;
        [FieldOffset(420)] public bool bExplicitWrapWidth;
    }
    internal unsafe struct WrapBox_methods {
        internal struct AddChildWrapBox_method {
            static internal IntPtr AddChildWrapBox_ptr;
            static AddChildWrapBox_method() {
                AddChildWrapBox_ptr = Main.GetMethodUFunction(WrapBox.StaticClass, "AddChildWrapBox");
            }

            internal static unsafe WrapBoxSlot Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, AddChildWrapBox_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SetInnerSlotPadding_method {
            static internal IntPtr SetInnerSlotPadding_ptr;
            static SetInnerSlotPadding_method() {
                SetInnerSlotPadding_ptr = Main.GetMethodUFunction(WrapBox.StaticClass, "SetInnerSlotPadding");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D InPadding) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InPadding;
                Main.GetProcessEvent(obj, SetInnerSlotPadding_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct WrapBox_events {
    }
}
