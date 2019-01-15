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
    [StructLayout( LayoutKind.Explicit, Size=3144 )]
    internal unsafe struct EditableTextBox_fields {
        [FieldOffset(384)] byte Text; //TODO: text FText Text
        [FieldOffset(408)] byte TextDelegate; //TODO: delegate FGetText TextDelegate
        [FieldOffset(432)] public EditableTextBoxStyle WidgetStyle;
        [FieldOffset(2808)] byte HintText; //TODO: text FText HintText
        [FieldOffset(2832)] byte HintTextDelegate; //TODO: delegate FGetText HintTextDelegate
        [FieldOffset(3008)] public bool IsReadOnly;
        [FieldOffset(3009)] public bool IsPassword;
        [FieldOffset(3012)] public float MinimumDesiredWidth;
        [FieldOffset(3032)] public bool IsCaretMovedWhenGainFocus;
        [FieldOffset(3033)] public bool SelectAllTextWhenFocused;
        [FieldOffset(3034)] public bool RevertTextOnEscape;
        [FieldOffset(3035)] public bool ClearKeyboardFocusOnCommit;
        [FieldOffset(3036)] public bool SelectAllTextOnCommit;
        [FieldOffset(3037)] public bool AllowContextMenu;
        [FieldOffset(3038)] public byte KeyboardType;
        [FieldOffset(3039)] public VirtualKeyboardOptions VirtualKeyboardOptions;
        [FieldOffset(3040)] byte VirtualKeyboardDismissAction; //TODO: enum EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
        [FieldOffset(3041)] public byte Justification;
        [FieldOffset(3042)] public ShapedTextOptions ShapedTextOptions;
        [FieldOffset(3048)] byte OnTextChanged; //TODO: multicast delegate FOnEditableTextBoxChangedEvent OnTextChanged
        [FieldOffset(3064)] byte OnTextCommitted; //TODO: multicast delegate FOnEditableTextBoxCommittedEvent OnTextCommitted
    }
    internal unsafe struct EditableTextBox_methods {
        internal struct ClearError_method {
            static internal IntPtr ClearError_ptr;
            static ClearError_method() {
                ClearError_ptr = Main.GetMethodUFunction(EditableTextBox.StaticClass, "ClearError");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearError_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetText_method {
            static internal IntPtr GetText_ptr;
            static GetText_method() {
                GetText_ptr = Main.GetMethodUFunction(EditableTextBox.StaticClass, "GetText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct HasError_method {
            static internal IntPtr HasError_ptr;
            static HasError_method() {
                HasError_ptr = Main.GetMethodUFunction(EditableTextBox.StaticClass, "HasError");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasError_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetError_method {
            static internal IntPtr SetError_ptr;
            static SetError_method() {
                SetError_ptr = Main.GetMethodUFunction(EditableTextBox.StaticClass, "SetError");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InError /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InError
                Main.GetProcessEvent(obj, SetError_ptr, new IntPtr(p)); ;
                 //TODO: text FText InError
            }
        }
        internal struct SetHintText_method {
            static internal IntPtr SetHintText_ptr;
            static SetHintText_method() {
                SetHintText_ptr = Main.GetMethodUFunction(EditableTextBox.StaticClass, "SetHintText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(obj, SetHintText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
            }
        }
        internal struct SetIsPassword_method {
            static internal IntPtr SetIsPassword_ptr;
            static SetIsPassword_method() {
                SetIsPassword_ptr = Main.GetMethodUFunction(EditableTextBox.StaticClass, "SetIsPassword");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bIsPassword) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bIsPassword;
                Main.GetProcessEvent(obj, SetIsPassword_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsReadOnly_method {
            static internal IntPtr SetIsReadOnly_ptr;
            static SetIsReadOnly_method() {
                SetIsReadOnly_ptr = Main.GetMethodUFunction(EditableTextBox.StaticClass, "SetIsReadOnly");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bReadOnly) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bReadOnly;
                Main.GetProcessEvent(obj, SetIsReadOnly_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetText_method {
            static internal IntPtr SetText_ptr;
            static SetText_method() {
                SetText_ptr = Main.GetMethodUFunction(EditableTextBox.StaticClass, "SetText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(obj, SetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
            }
        }
    }
    internal unsafe struct EditableTextBox_events {
    }
}
