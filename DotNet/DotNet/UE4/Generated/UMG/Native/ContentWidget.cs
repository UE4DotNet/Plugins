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
    internal unsafe struct ContentWidget_fields {
    }
    internal unsafe struct ContentWidget_methods {
        internal struct GetContent_method {
            static internal IntPtr GetContent_ptr;
            static GetContent_method() {
                GetContent_ptr = Main.GetMethodUFunction(ContentWidget.StaticClass, "GetContent");
            }

            internal static unsafe Widget Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetContent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetContentSlot_method {
            static internal IntPtr GetContentSlot_ptr;
            static GetContentSlot_method() {
                GetContentSlot_ptr = Main.GetMethodUFunction(ContentWidget.StaticClass, "GetContentSlot");
            }

            internal static unsafe PanelSlot Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetContentSlot_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetContent_method {
            static internal IntPtr SetContent_ptr;
            static SetContent_method() {
                SetContent_ptr = Main.GetMethodUFunction(ContentWidget.StaticClass, "SetContent");
            }

            internal static unsafe PanelSlot Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, SetContent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
    }
    internal unsafe struct ContentWidget_events {
    }
}
