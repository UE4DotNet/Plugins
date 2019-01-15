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
    [StructLayout( LayoutKind.Explicit, Size=2000 )]
    internal unsafe struct InputKeySelector_fields {
        [FieldOffset(384)] public ButtonStyle WidgetStyle;
        [FieldOffset(1152)] public TextBlockStyle TextStyle;
        [FieldOffset(1704)] public InputChord SelectedKey;
        [FieldOffset(1848)] public Margin Margin;
        [FieldOffset(1880)] byte KeySelectionText; //TODO: text FText KeySelectionText
        [FieldOffset(1904)] byte NoKeySpecifiedText; //TODO: text FText NoKeySpecifiedText
        [FieldOffset(1928)] public bool bAllowModifierKeys;
        [FieldOffset(1929)] public bool bAllowGamepadKeys;
        [FieldOffset(1936)] public NativeArray EscapeKeys;
        [FieldOffset(1952)] byte OnKeySelected; //TODO: multicast delegate FOnKeySelected OnKeySelected
        [FieldOffset(1968)] byte OnIsSelectingKeyChanged; //TODO: multicast delegate FOnIsSelectingKeyChanged OnIsSelectingKeyChanged
    }
    internal unsafe struct InputKeySelector_methods {
        internal struct GetIsSelectingKey_method {
            static internal IntPtr GetIsSelectingKey_ptr;
            static GetIsSelectingKey_method() {
                GetIsSelectingKey_ptr = Main.GetMethodUFunction(InputKeySelector.StaticClass, "GetIsSelectingKey");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetIsSelectingKey_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetAllowGamepadKeys_method {
            static internal IntPtr SetAllowGamepadKeys_ptr;
            static SetAllowGamepadKeys_method() {
                SetAllowGamepadKeys_ptr = Main.GetMethodUFunction(InputKeySelector.StaticClass, "SetAllowGamepadKeys");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAllowGamepadKeys) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAllowGamepadKeys;
                Main.GetProcessEvent(obj, SetAllowGamepadKeys_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAllowModifierKeys_method {
            static internal IntPtr SetAllowModifierKeys_ptr;
            static SetAllowModifierKeys_method() {
                SetAllowModifierKeys_ptr = Main.GetMethodUFunction(InputKeySelector.StaticClass, "SetAllowModifierKeys");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAllowModifierKeys) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAllowModifierKeys;
                Main.GetProcessEvent(obj, SetAllowModifierKeys_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEscapeKeys_method {
            static internal IntPtr SetEscapeKeys_ptr;
            static SetEscapeKeys_method() {
                SetEscapeKeys_ptr = Main.GetMethodUFunction(InputKeySelector.StaticClass, "SetEscapeKeys");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InKeys /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InKeys
                Main.GetProcessEvent(obj, SetEscapeKeys_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InKeys
            }
        }
        internal struct SetKeySelectionText_method {
            static internal IntPtr SetKeySelectionText_ptr;
            static SetKeySelectionText_method() {
                SetKeySelectionText_ptr = Main.GetMethodUFunction(InputKeySelector.StaticClass, "SetKeySelectionText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InKeySelectionText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InKeySelectionText
                Main.GetProcessEvent(obj, SetKeySelectionText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InKeySelectionText
            }
        }
        internal struct SetNoKeySpecifiedText_method {
            static internal IntPtr SetNoKeySpecifiedText_ptr;
            static SetNoKeySpecifiedText_method() {
                SetNoKeySpecifiedText_ptr = Main.GetMethodUFunction(InputKeySelector.StaticClass, "SetNoKeySpecifiedText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InNoKeySpecifiedText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InNoKeySpecifiedText
                Main.GetProcessEvent(obj, SetNoKeySpecifiedText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InNoKeySpecifiedText
            }
        }
        internal struct SetSelectedKey_method {
            static internal IntPtr SetSelectedKey_ptr;
            static SetSelectedKey_method() {
                SetSelectedKey_ptr = Main.GetMethodUFunction(InputKeySelector.StaticClass, "SetSelectedKey");
            }

            internal static unsafe void Invoke(IntPtr obj, InputChord InSelectedKey) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InputChord*)(b+0)) = InSelectedKey;
                Main.GetProcessEvent(obj, SetSelectedKey_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTextBlockVisibility_method {
            static internal IntPtr SetTextBlockVisibility_ptr;
            static SetTextBlockVisibility_method() {
                SetTextBlockVisibility_ptr = Main.GetMethodUFunction(InputKeySelector.StaticClass, "SetTextBlockVisibility");
            }

            internal static unsafe void Invoke(IntPtr obj, ESlateVisibility InVisibility) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)InVisibility;
                Main.GetProcessEvent(obj, SetTextBlockVisibility_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct InputKeySelector_events {
    }
}
