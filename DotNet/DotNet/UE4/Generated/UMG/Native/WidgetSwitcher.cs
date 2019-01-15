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
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct WidgetSwitcher_fields {
        [FieldOffset(408)] public int ActiveWidgetIndex;
    }
    internal unsafe struct WidgetSwitcher_methods {
        internal struct GetActiveWidget_method {
            static internal IntPtr GetActiveWidget_ptr;
            static GetActiveWidget_method() {
                GetActiveWidget_ptr = Main.GetMethodUFunction(WidgetSwitcher.StaticClass, "GetActiveWidget");
            }

            internal static unsafe Widget Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActiveWidget_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetActiveWidgetIndex_method {
            static internal IntPtr GetActiveWidgetIndex_ptr;
            static GetActiveWidgetIndex_method() {
                GetActiveWidgetIndex_ptr = Main.GetMethodUFunction(WidgetSwitcher.StaticClass, "GetActiveWidgetIndex");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetActiveWidgetIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetNumWidgets_method {
            static internal IntPtr GetNumWidgets_ptr;
            static GetNumWidgets_method() {
                GetNumWidgets_ptr = Main.GetMethodUFunction(WidgetSwitcher.StaticClass, "GetNumWidgets");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumWidgets_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetWidgetAtIndex_method {
            static internal IntPtr GetWidgetAtIndex_ptr;
            static GetWidgetAtIndex_method() {
                GetWidgetAtIndex_ptr = Main.GetMethodUFunction(WidgetSwitcher.StaticClass, "GetWidgetAtIndex");
            }

            internal static unsafe Widget Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, GetWidgetAtIndex_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SetActiveWidget_method {
            static internal IntPtr SetActiveWidget_ptr;
            static SetActiveWidget_method() {
                SetActiveWidget_ptr = Main.GetMethodUFunction(WidgetSwitcher.StaticClass, "SetActiveWidget");
            }

            internal static unsafe void Invoke(IntPtr obj, Widget Widget) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Widget;
                Main.GetProcessEvent(obj, SetActiveWidget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetActiveWidgetIndex_method {
            static internal IntPtr SetActiveWidgetIndex_ptr;
            static SetActiveWidgetIndex_method() {
                SetActiveWidgetIndex_ptr = Main.GetMethodUFunction(WidgetSwitcher.StaticClass, "SetActiveWidgetIndex");
            }

            internal static unsafe void Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, SetActiveWidgetIndex_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct WidgetSwitcher_events {
    }
}
