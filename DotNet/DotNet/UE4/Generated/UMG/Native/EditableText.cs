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
    [StructLayout( LayoutKind.Explicit, Size=1440 )]
    internal unsafe struct EditableText_fields {
        [FieldOffset(400)] byte Text; //TODO: text FText Text
        [FieldOffset(424)] byte TextDelegate; //TODO: delegate FGetText TextDelegate
        [FieldOffset(448)] byte HintText; //TODO: text FText HintText
        [FieldOffset(472)] byte HintTextDelegate; //TODO: delegate FGetText HintTextDelegate
        [FieldOffset(496)] public EditableTextStyle WidgetStyle;
        [FieldOffset(1320)] public bool IsReadOnly;
        [FieldOffset(1321)] public bool IsPassword;
        [FieldOffset(1324)] public float MinimumDesiredWidth;
        [FieldOffset(1328)] public bool IsCaretMovedWhenGainFocus;
        [FieldOffset(1329)] public bool SelectAllTextWhenFocused;
        [FieldOffset(1330)] public bool RevertTextOnEscape;
        [FieldOffset(1331)] public bool ClearKeyboardFocusOnCommit;
        [FieldOffset(1332)] public bool SelectAllTextOnCommit;
        [FieldOffset(1333)] public bool AllowContextMenu;
        [FieldOffset(1334)] public byte KeyboardType;
        [FieldOffset(1335)] public VirtualKeyboardOptions VirtualKeyboardOptions;
        [FieldOffset(1336)] byte VirtualKeyboardDismissAction; //TODO: enum EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
        [FieldOffset(1337)] public byte Justification;
        [FieldOffset(1338)] public ShapedTextOptions ShapedTextOptions;
        [FieldOffset(1344)] byte OnTextChanged; //TODO: multicast delegate FOnEditableTextChangedEvent OnTextChanged
        [FieldOffset(1360)] byte OnTextCommitted; //TODO: multicast delegate FOnEditableTextCommittedEvent OnTextCommitted
    }
    internal unsafe struct EditableText_methods {
        internal struct GetText_method {
            static internal IntPtr GetText_ptr;
            static GetText_method() {
                GetText_ptr = Main.GetMethodUFunction(EditableText.StaticClass, "GetText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct SetHintText_method {
            static internal IntPtr SetHintText_ptr;
            static SetHintText_method() {
                SetHintText_ptr = Main.GetMethodUFunction(EditableText.StaticClass, "SetHintText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InHintText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InHintText
                Main.GetProcessEvent(obj, SetHintText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InHintText
            }
        }
        internal struct SetIsPassword_method {
            static internal IntPtr SetIsPassword_ptr;
            static SetIsPassword_method() {
                SetIsPassword_ptr = Main.GetMethodUFunction(EditableText.StaticClass, "SetIsPassword");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InbIsPassword) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InbIsPassword;
                Main.GetProcessEvent(obj, SetIsPassword_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsReadOnly_method {
            static internal IntPtr SetIsReadOnly_ptr;
            static SetIsReadOnly_method() {
                SetIsReadOnly_ptr = Main.GetMethodUFunction(EditableText.StaticClass, "SetIsReadOnly");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InbIsReadyOnly) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InbIsReadyOnly;
                Main.GetProcessEvent(obj, SetIsReadOnly_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetText_method {
            static internal IntPtr SetText_ptr;
            static SetText_method() {
                SetText_ptr = Main.GetMethodUFunction(EditableText.StaticClass, "SetText");
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
    internal unsafe struct EditableText_events {
    }
}
