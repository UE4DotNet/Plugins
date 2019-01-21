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
    [StructLayout( LayoutKind.Explicit, Size=1336 )]
    internal unsafe struct Button_fields {
        [FieldOffset(432)] public ButtonStyle WidgetStyle;
        [FieldOffset(1200)] public LinearColor ColorAndOpacity;
        [FieldOffset(1216)] public LinearColor BackgroundColor;
        [FieldOffset(1232)] public byte ClickMethod;
        [FieldOffset(1233)] public byte TouchMethod;
        [FieldOffset(1234)] public byte PressMethod;
        [FieldOffset(1235)] public bool IsFocusable;
        [FieldOffset(1240)] byte OnClicked; //TODO: multicast delegate FOnButtonClickedEvent OnClicked
        [FieldOffset(1256)] byte OnPressed; //TODO: multicast delegate FOnButtonPressedEvent OnPressed
        [FieldOffset(1272)] byte OnReleased; //TODO: multicast delegate FOnButtonReleasedEvent OnReleased
        [FieldOffset(1288)] byte OnHovered; //TODO: multicast delegate FOnButtonHoverEvent OnHovered
        [FieldOffset(1304)] byte OnUnhovered; //TODO: multicast delegate FOnButtonHoverEvent OnUnhovered
    }
    internal unsafe struct Button_methods {
        internal struct IsPressed_method {
            static internal IntPtr IsPressed_ptr;
            static IsPressed_method() {
                IsPressed_ptr = Main.GetMethodUFunction(Button.StaticClass, "IsPressed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPressed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetBackgroundColor_method {
            static internal IntPtr SetBackgroundColor_ptr;
            static SetBackgroundColor_method() {
                SetBackgroundColor_ptr = Main.GetMethodUFunction(Button.StaticClass, "SetBackgroundColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InBackgroundColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InBackgroundColor;
                Main.GetProcessEvent(obj, SetBackgroundColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetClickMethod_method {
            static internal IntPtr SetClickMethod_ptr;
            static SetClickMethod_method() {
                SetClickMethod_ptr = Main.GetMethodUFunction(Button.StaticClass, "SetClickMethod");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InClickMethod) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InClickMethod;
                Main.GetProcessEvent(obj, SetClickMethod_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetColorAndOpacity_method {
            static internal IntPtr SetColorAndOpacity_ptr;
            static SetColorAndOpacity_method() {
                SetColorAndOpacity_ptr = Main.GetMethodUFunction(Button.StaticClass, "SetColorAndOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InColorAndOpacity) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InColorAndOpacity;
                Main.GetProcessEvent(obj, SetColorAndOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPressMethod_method {
            static internal IntPtr SetPressMethod_ptr;
            static SetPressMethod_method() {
                SetPressMethod_ptr = Main.GetMethodUFunction(Button.StaticClass, "SetPressMethod");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InPressMethod) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InPressMethod;
                Main.GetProcessEvent(obj, SetPressMethod_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStyle_method {
            static internal IntPtr SetStyle_ptr;
            static SetStyle_method() {
                SetStyle_ptr = Main.GetMethodUFunction(Button.StaticClass, "SetStyle");
            }

            internal static unsafe void Invoke(IntPtr obj, ButtonStyle InStyle) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((ButtonStyle*)(b+0)) = InStyle;
                Main.GetProcessEvent(obj, SetStyle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTouchMethod_method {
            static internal IntPtr SetTouchMethod_ptr;
            static SetTouchMethod_method() {
                SetTouchMethod_ptr = Main.GetMethodUFunction(Button.StaticClass, "SetTouchMethod");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InTouchMethod) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InTouchMethod;
                Main.GetProcessEvent(obj, SetTouchMethod_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Button_events {
    }
}
