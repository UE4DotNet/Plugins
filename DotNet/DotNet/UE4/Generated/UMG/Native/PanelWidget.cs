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
    internal unsafe struct PanelWidget_fields {
        [FieldOffset(400)] public NativeArray Slots;
    }
    internal unsafe struct PanelWidget_methods {
        internal struct AddChild_method {
            static internal IntPtr AddChild_ptr;
            static AddChild_method() {
                AddChild_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "AddChild");
            }

            internal static unsafe PanelSlot Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, AddChild_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct ClearChildren_method {
            static internal IntPtr ClearChildren_ptr;
            static ClearChildren_method() {
                ClearChildren_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "ClearChildren");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearChildren_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetChildAt_method {
            static internal IntPtr GetChildAt_ptr;
            static GetChildAt_method() {
                GetChildAt_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "GetChildAt");
            }

            internal static unsafe Widget Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, GetChildAt_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetChildIndex_method {
            static internal IntPtr GetChildIndex_ptr;
            static GetChildIndex_method() {
                GetChildIndex_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "GetChildIndex");
            }

            internal static unsafe int Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, GetChildIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetChildrenCount_method {
            static internal IntPtr GetChildrenCount_ptr;
            static GetChildrenCount_method() {
                GetChildrenCount_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "GetChildrenCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetChildrenCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct HasAnyChildren_method {
            static internal IntPtr HasAnyChildren_ptr;
            static HasAnyChildren_method() {
                HasAnyChildren_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "HasAnyChildren");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasAnyChildren_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HasChild_method {
            static internal IntPtr HasChild_ptr;
            static HasChild_method() {
                HasChild_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "HasChild");
            }

            internal static unsafe bool Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, HasChild_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct RemoveChild_method {
            static internal IntPtr RemoveChild_ptr;
            static RemoveChild_method() {
                RemoveChild_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "RemoveChild");
            }

            internal static unsafe bool Invoke(IntPtr obj, Widget Content) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Content;
                Main.GetProcessEvent(obj, RemoveChild_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct RemoveChildAt_method {
            static internal IntPtr RemoveChildAt_ptr;
            static RemoveChildAt_method() {
                RemoveChildAt_ptr = Main.GetMethodUFunction(PanelWidget.StaticClass, "RemoveChildAt");
            }

            internal static unsafe bool Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, RemoveChildAt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
    }
    internal unsafe struct PanelWidget_events {
    }
}
