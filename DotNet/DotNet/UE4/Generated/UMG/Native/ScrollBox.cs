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
using UE4.Slate;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=2592 )]
    internal unsafe struct ScrollBox_fields {
        [FieldOffset(408)] public ScrollBoxStyle WidgetStyle;
        [FieldOffset(1056)] public ScrollBarStyle WidgetBarStyle;
        [FieldOffset(2520)] public byte Orientation;
        [FieldOffset(2521)] byte ScrollBarVisibility; //TODO: enum ESlateVisibility ScrollBarVisibility
        [FieldOffset(2522)] byte ConsumeMouseWheel; //TODO: enum EConsumeMouseWheel ConsumeMouseWheel
        [FieldOffset(2524)] public Vector2D ScrollbarThickness;
        [FieldOffset(2532)] public bool AlwaysShowScrollbar;
        [FieldOffset(2533)] public bool AllowOverscroll;
        [FieldOffset(2534)] byte NavigationDestination; //TODO: enum EDescendantScrollDestination NavigationDestination
        [FieldOffset(2536)] public float NavigationScrollPadding;
        [FieldOffset(2540)] public bool bAllowRightClickDragScrolling;
        [FieldOffset(2544)] byte OnUserScrolled; //TODO: multicast delegate FOnUserScrolledEvent OnUserScrolled
    }
    internal unsafe struct ScrollBox_methods {
        internal struct GetScrollOffset_method {
            static internal IntPtr GetScrollOffset_ptr;
            static GetScrollOffset_method() {
                GetScrollOffset_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "GetScrollOffset");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScrollOffset_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetViewOffsetFraction_method {
            static internal IntPtr GetViewOffsetFraction_ptr;
            static GetViewOffsetFraction_method() {
                GetViewOffsetFraction_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "GetViewOffsetFraction");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewOffsetFraction_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct ScrollToEnd_method {
            static internal IntPtr ScrollToEnd_ptr;
            static ScrollToEnd_method() {
                ScrollToEnd_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "ScrollToEnd");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ScrollToEnd_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScrollToStart_method {
            static internal IntPtr ScrollToStart_ptr;
            static ScrollToStart_method() {
                ScrollToStart_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "ScrollToStart");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ScrollToStart_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScrollWidgetIntoView_method {
            static internal IntPtr ScrollWidgetIntoView_ptr;
            static ScrollWidgetIntoView_method() {
                ScrollWidgetIntoView_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "ScrollWidgetIntoView");
            }

            internal static unsafe void Invoke(IntPtr obj, Widget WidgetToFind, bool AnimateScroll, EDescendantScrollDestination ScrollDestination) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WidgetToFind;
                *((bool*)(b+8)) = AnimateScroll;
                *(b+9) = (byte)ScrollDestination;
                Main.GetProcessEvent(obj, ScrollWidgetIntoView_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllowOverscroll_method {
            static internal IntPtr SetAllowOverscroll_ptr;
            static SetAllowOverscroll_method() {
                SetAllowOverscroll_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "SetAllowOverscroll");
            }

            internal static unsafe void Invoke(IntPtr obj, bool NewAllowOverscroll) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = NewAllowOverscroll;
                Main.GetProcessEvent(obj, SetAllowOverscroll_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAlwaysShowScrollbar_method {
            static internal IntPtr SetAlwaysShowScrollbar_ptr;
            static SetAlwaysShowScrollbar_method() {
                SetAlwaysShowScrollbar_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "SetAlwaysShowScrollbar");
            }

            internal static unsafe void Invoke(IntPtr obj, bool NewAlwaysShowScrollbar) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = NewAlwaysShowScrollbar;
                Main.GetProcessEvent(obj, SetAlwaysShowScrollbar_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOrientation_method {
            static internal IntPtr SetOrientation_ptr;
            static SetOrientation_method() {
                SetOrientation_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "SetOrientation");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewOrientation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = NewOrientation;
                Main.GetProcessEvent(obj, SetOrientation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScrollbarThickness_method {
            static internal IntPtr SetScrollbarThickness_ptr;
            static SetScrollbarThickness_method() {
                SetScrollbarThickness_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "SetScrollbarThickness");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D NewScrollbarThickness) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = NewScrollbarThickness;
                Main.GetProcessEvent(obj, SetScrollbarThickness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScrollBarVisibility_method {
            static internal IntPtr SetScrollBarVisibility_ptr;
            static SetScrollBarVisibility_method() {
                SetScrollBarVisibility_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "SetScrollBarVisibility");
            }

            internal static unsafe void Invoke(IntPtr obj, ESlateVisibility NewScrollBarVisibility) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)NewScrollBarVisibility;
                Main.GetProcessEvent(obj, SetScrollBarVisibility_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScrollOffset_method {
            static internal IntPtr SetScrollOffset_ptr;
            static SetScrollOffset_method() {
                SetScrollOffset_ptr = Main.GetMethodUFunction(ScrollBox.StaticClass, "SetScrollOffset");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewScrollOffset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewScrollOffset;
                Main.GetProcessEvent(obj, SetScrollOffset_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ScrollBox_events {
    }
}
