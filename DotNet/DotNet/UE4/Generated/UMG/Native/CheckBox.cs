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
    [StructLayout( LayoutKind.Explicit, Size=2312 )]
    internal unsafe struct CheckBox_fields {
        [FieldOffset(408)] byte CheckedState; //TODO: enum ECheckBoxState CheckedState
        [FieldOffset(412)] byte CheckedStateDelegate; //TODO: delegate FGetCheckBoxState CheckedStateDelegate
        [FieldOffset(432)] public CheckBoxStyle WidgetStyle;
        [FieldOffset(2200)] public byte HorizontalAlignment;
        [FieldOffset(2264)] public bool IsFocusable;
        [FieldOffset(2272)] byte OnCheckStateChanged; //TODO: multicast delegate FOnCheckBoxComponentStateChanged OnCheckStateChanged
    }
    internal unsafe struct CheckBox_methods {
        internal struct GetCheckedState_method {
            static internal IntPtr GetCheckedState_ptr;
            static GetCheckedState_method() {
                GetCheckedState_ptr = Main.GetMethodUFunction(CheckBox.StaticClass, "GetCheckedState");
            }

            internal static unsafe ECheckBoxState Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCheckedState_ptr, new IntPtr(p)); ;
                return *((ECheckBoxState*)(b+0));
            }
        }
        internal struct IsChecked_method {
            static internal IntPtr IsChecked_ptr;
            static IsChecked_method() {
                IsChecked_ptr = Main.GetMethodUFunction(CheckBox.StaticClass, "IsChecked");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsChecked_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPressed_method {
            static internal IntPtr IsPressed_ptr;
            static IsPressed_method() {
                IsPressed_ptr = Main.GetMethodUFunction(CheckBox.StaticClass, "IsPressed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPressed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetCheckedState_method {
            static internal IntPtr SetCheckedState_ptr;
            static SetCheckedState_method() {
                SetCheckedState_ptr = Main.GetMethodUFunction(CheckBox.StaticClass, "SetCheckedState");
            }

            internal static unsafe void Invoke(IntPtr obj, ECheckBoxState InCheckedState) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)InCheckedState;
                Main.GetProcessEvent(obj, SetCheckedState_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsChecked_method {
            static internal IntPtr SetIsChecked_ptr;
            static SetIsChecked_method() {
                SetIsChecked_ptr = Main.GetMethodUFunction(CheckBox.StaticClass, "SetIsChecked");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InIsChecked) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InIsChecked;
                Main.GetProcessEvent(obj, SetIsChecked_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CheckBox_events {
    }
}
