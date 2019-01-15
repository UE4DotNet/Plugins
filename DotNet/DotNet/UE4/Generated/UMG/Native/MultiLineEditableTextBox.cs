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
    [StructLayout( LayoutKind.Explicit, Size=3648 )]
    internal unsafe struct MultiLineEditableTextBox_fields {
        [FieldOffset(416)] byte Text; //TODO: text FText Text
        [FieldOffset(440)] byte HintText; //TODO: text FText HintText
        [FieldOffset(464)] byte HintTextDelegate; //TODO: delegate FGetText HintTextDelegate
        [FieldOffset(488)] public EditableTextBoxStyle WidgetStyle;
        [FieldOffset(2856)] public TextBlockStyle TextStyle;
        [FieldOffset(3408)] public bool bIsReadOnly;
        [FieldOffset(3409)] public bool AllowContextMenu;
        [FieldOffset(3410)] public VirtualKeyboardOptions VirtualKeyboardOptions;
        [FieldOffset(3411)] byte VirtualKeyboardDismissAction; //TODO: enum EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
        [FieldOffset(3576)] byte OnTextChanged; //TODO: multicast delegate FOnMultiLineEditableTextBoxChangedEvent OnTextChanged
        [FieldOffset(3592)] byte OnTextCommitted; //TODO: multicast delegate FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted
    }
    internal unsafe struct MultiLineEditableTextBox_methods {
        internal struct GetText_method {
            static internal IntPtr GetText_ptr;
            static GetText_method() {
                GetText_ptr = Main.GetMethodUFunction(MultiLineEditableTextBox.StaticClass, "GetText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct SetError_method {
            static internal IntPtr SetError_ptr;
            static SetError_method() {
                SetError_ptr = Main.GetMethodUFunction(MultiLineEditableTextBox.StaticClass, "SetError");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InError /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InError
                Main.GetProcessEvent(obj, SetError_ptr, new IntPtr(p)); ;
                 //TODO: text FText InError
            }
        }
        internal struct SetIsReadOnly_method {
            static internal IntPtr SetIsReadOnly_ptr;
            static SetIsReadOnly_method() {
                SetIsReadOnly_ptr = Main.GetMethodUFunction(MultiLineEditableTextBox.StaticClass, "SetIsReadOnly");
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
                SetText_ptr = Main.GetMethodUFunction(MultiLineEditableTextBox.StaticClass, "SetText");
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
    internal unsafe struct MultiLineEditableTextBox_events {
    }
}
