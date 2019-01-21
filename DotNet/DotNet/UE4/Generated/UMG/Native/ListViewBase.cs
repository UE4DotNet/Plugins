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
    [StructLayout( LayoutKind.Explicit, Size=672 )]
    internal unsafe struct ListViewBase_fields {
        [FieldOffset(400)] public IntPtr EntryWidgetClass;
        [FieldOffset(408)] byte BP_OnEntryGenerated; //TODO: multicast delegate FOnListEntryGeneratedDynamic BP_OnEntryGenerated
        [FieldOffset(424)] byte BP_OnEntryReleased; //TODO: multicast delegate FOnListEntryReleasedDynamic BP_OnEntryReleased
        [FieldOffset(444)] public int NumDesignerPreviewEntries;
    }
    internal unsafe struct ListViewBase_methods {
        internal struct GetDisplayedEntryWidgets_method {
            static internal IntPtr GetDisplayedEntryWidgets_ptr;
            static GetDisplayedEntryWidgets_method() {
                GetDisplayedEntryWidgets_ptr = Main.GetMethodUFunction(ListViewBase.StaticClass, "GetDisplayedEntryWidgets");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ReturnValue /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ReturnValue
                Main.GetProcessEvent(obj, GetDisplayedEntryWidgets_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
            }
        }
        internal struct RegenerateAllEntries_method {
            static internal IntPtr RegenerateAllEntries_ptr;
            static RegenerateAllEntries_method() {
                RegenerateAllEntries_ptr = Main.GetMethodUFunction(ListViewBase.StaticClass, "RegenerateAllEntries");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RegenerateAllEntries_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScrollToBottom_method {
            static internal IntPtr ScrollToBottom_ptr;
            static ScrollToBottom_method() {
                ScrollToBottom_ptr = Main.GetMethodUFunction(ListViewBase.StaticClass, "ScrollToBottom");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ScrollToBottom_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScrollToTop_method {
            static internal IntPtr ScrollToTop_ptr;
            static ScrollToTop_method() {
                ScrollToTop_ptr = Main.GetMethodUFunction(ListViewBase.StaticClass, "ScrollToTop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ScrollToTop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ListViewBase_events {
    }
}
