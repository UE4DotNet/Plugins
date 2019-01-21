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
    [StructLayout( LayoutKind.Explicit, Size=3944 )]
    internal unsafe struct ComboBoxString_fields {
        [FieldOffset(400)] public NativeArray DefaultOptions;
        [FieldOffset(416)] byte SelectedOption; //TODO: string FString SelectedOption
        [FieldOffset(432)] public ComboBoxStyle WidgetStyle;
        [FieldOffset(1640)] public TableRowStyle ItemStyle;
        [FieldOffset(3648)] public Margin ContentPadding;
        [FieldOffset(3664)] public float MaxListHeight;
        [FieldOffset(3668)] public bool HasDownArrow;
        [FieldOffset(3669)] public bool EnableGamepadNavigationMode;
        [FieldOffset(3672)] public SlateFontInfo Font;
        [FieldOffset(3784)] public SlateColor ForegroundColor;
        [FieldOffset(3824)] public bool bIsFocusable;
        [FieldOffset(3828)] byte OnGenerateWidgetEvent; //TODO: delegate FGenerateWidgetForString OnGenerateWidgetEvent
        [FieldOffset(3848)] byte OnSelectionChanged; //TODO: multicast delegate FOnSelectionChangedEvent OnSelectionChanged
        [FieldOffset(3864)] byte OnOpening; //TODO: multicast delegate FOnOpeningEvent OnOpening
    }
    internal unsafe struct ComboBoxString_methods {
        internal struct AddOption_method {
            static internal IntPtr AddOption_ptr;
            static AddOption_method() {
                AddOption_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "AddOption");
            }

            internal static unsafe void Invoke(IntPtr obj, string Option) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Option_handle = GCHandle.Alloc(Option, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Option_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Option.Length;
                *(int*)(b+IntPtr.Size+4+0) = Option.Length;
                Main.GetProcessEvent(obj, AddOption_ptr, new IntPtr(p)); ;
                Option_handle.Free();
            }
        }
        internal struct ClearOptions_method {
            static internal IntPtr ClearOptions_ptr;
            static ClearOptions_method() {
                ClearOptions_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "ClearOptions");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearOptions_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearSelection_method {
            static internal IntPtr ClearSelection_ptr;
            static ClearSelection_method() {
                ClearSelection_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "ClearSelection");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearSelection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FindOptionIndex_method {
            static internal IntPtr FindOptionIndex_ptr;
            static FindOptionIndex_method() {
                FindOptionIndex_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "FindOptionIndex");
            }

            internal static unsafe int Invoke(IntPtr obj, string Option) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Option_handle = GCHandle.Alloc(Option, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Option_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Option.Length;
                *(int*)(b+IntPtr.Size+4+0) = Option.Length;
                Main.GetProcessEvent(obj, FindOptionIndex_ptr, new IntPtr(p)); ;
                Option_handle.Free();
                return *((int*)(b+16));
            }
        }
        internal struct GetOptionAtIndex_method {
            static internal IntPtr GetOptionAtIndex_ptr;
            static GetOptionAtIndex_method() {
                GetOptionAtIndex_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "GetOptionAtIndex");
            }

            internal static unsafe string Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, GetOptionAtIndex_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct GetOptionCount_method {
            static internal IntPtr GetOptionCount_ptr;
            static GetOptionCount_method() {
                GetOptionCount_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "GetOptionCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOptionCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetSelectedOption_method {
            static internal IntPtr GetSelectedOption_ptr;
            static GetSelectedOption_method() {
                GetSelectedOption_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "GetSelectedOption");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSelectedOption_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct RefreshOptions_method {
            static internal IntPtr RefreshOptions_ptr;
            static RefreshOptions_method() {
                RefreshOptions_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "RefreshOptions");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RefreshOptions_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveOption_method {
            static internal IntPtr RemoveOption_ptr;
            static RemoveOption_method() {
                RemoveOption_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "RemoveOption");
            }

            internal static unsafe bool Invoke(IntPtr obj, string Option) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Option_handle = GCHandle.Alloc(Option, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Option_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Option.Length;
                *(int*)(b+IntPtr.Size+4+0) = Option.Length;
                Main.GetProcessEvent(obj, RemoveOption_ptr, new IntPtr(p)); ;
                Option_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct SetSelectedOption_method {
            static internal IntPtr SetSelectedOption_ptr;
            static SetSelectedOption_method() {
                SetSelectedOption_ptr = Main.GetMethodUFunction(ComboBoxString.StaticClass, "SetSelectedOption");
            }

            internal static unsafe void Invoke(IntPtr obj, string Option) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Option_handle = GCHandle.Alloc(Option, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Option_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Option.Length;
                *(int*)(b+IntPtr.Size+4+0) = Option.Length;
                Main.GetProcessEvent(obj, SetSelectedOption_ptr, new IntPtr(p)); ;
                Option_handle.Free();
            }
        }
    }
    internal unsafe struct ComboBoxString_events {
    }
}
