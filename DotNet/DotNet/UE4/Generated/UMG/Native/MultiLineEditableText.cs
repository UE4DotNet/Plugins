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
    [StructLayout( LayoutKind.Explicit, Size=1264 )]
    internal unsafe struct MultiLineEditableText_fields {
        [FieldOffset(432)] byte Text; //TODO: text FText Text
        [FieldOffset(456)] byte HintText; //TODO: text FText HintText
        [FieldOffset(480)] byte HintTextDelegate; //TODO: delegate FGetText HintTextDelegate
        [FieldOffset(504)] public TextBlockStyle WidgetStyle;
        [FieldOffset(1064)] public bool bIsReadOnly;
        [FieldOffset(1184)] public bool SelectAllTextWhenFocused;
        [FieldOffset(1185)] public bool ClearTextSelectionOnFocusLoss;
        [FieldOffset(1186)] public bool RevertTextOnEscape;
        [FieldOffset(1187)] public bool ClearKeyboardFocusOnCommit;
        [FieldOffset(1188)] public bool AllowContextMenu;
        [FieldOffset(1189)] public VirtualKeyboardOptions VirtualKeyboardOptions;
        [FieldOffset(1190)] byte VirtualKeyboardDismissAction; //TODO: enum EVirtualKeyboardDismissAction VirtualKeyboardDismissAction
        [FieldOffset(1192)] byte OnTextChanged; //TODO: multicast delegate FOnMultiLineEditableTextChangedEvent OnTextChanged
        [FieldOffset(1208)] byte OnTextCommitted; //TODO: multicast delegate FOnMultiLineEditableTextCommittedEvent OnTextCommitted
    }
    internal unsafe struct MultiLineEditableText_methods {
        internal struct GetText_method {
            static internal IntPtr GetText_ptr;
            static GetText_method() {
                GetText_ptr = Main.GetMethodUFunction(MultiLineEditableText.StaticClass, "GetText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct SetIsReadOnly_method {
            static internal IntPtr SetIsReadOnly_ptr;
            static SetIsReadOnly_method() {
                SetIsReadOnly_ptr = Main.GetMethodUFunction(MultiLineEditableText.StaticClass, "SetIsReadOnly");
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
                SetText_ptr = Main.GetMethodUFunction(MultiLineEditableText.StaticClass, "SetText");
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
    internal unsafe struct MultiLineEditableText_events {
    }
}
