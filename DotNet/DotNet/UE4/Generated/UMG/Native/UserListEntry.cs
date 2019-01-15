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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct UserListEntry_fields {
    }
    internal unsafe struct UserListEntry_methods {
    }
    internal unsafe struct UserListEntry_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct BP_OnEntryReleased_event {
            private static DelegateHolder<NativeFuncDelegate> BP_OnEntryReleased_link;
            private static unsafe void BP_OnEntryReleased_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserListEntry>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BP_OnEntryReleased();
            }
            internal static void Setup() {
                BP_OnEntryReleased_link = new DelegateHolder<NativeFuncDelegate>(BP_OnEntryReleased_process_event);
                var uf = Main.GetUFunction("BP_OnEntryReleased");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BP_OnEntryReleased_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct BP_OnItemExpansionChanged_event {
            private static DelegateHolder<NativeFuncDelegate> BP_OnItemExpansionChanged_link;
            private static unsafe void BP_OnItemExpansionChanged_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserListEntry>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BP_OnItemExpansionChanged(*(bool*)(b+0));
            }
            internal static void Setup() {
                BP_OnItemExpansionChanged_link = new DelegateHolder<NativeFuncDelegate>(BP_OnItemExpansionChanged_process_event);
                var uf = Main.GetUFunction("BP_OnItemExpansionChanged");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BP_OnItemExpansionChanged_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct BP_OnItemSelectionChanged_event {
            private static DelegateHolder<NativeFuncDelegate> BP_OnItemSelectionChanged_link;
            private static unsafe void BP_OnItemSelectionChanged_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserListEntry>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BP_OnItemSelectionChanged(*(bool*)(b+0));
            }
            internal static void Setup() {
                BP_OnItemSelectionChanged_link = new DelegateHolder<NativeFuncDelegate>(BP_OnItemSelectionChanged_process_event);
                var uf = Main.GetUFunction("BP_OnItemSelectionChanged");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BP_OnItemSelectionChanged_link.Delegate));
            }
        }
    }
}
