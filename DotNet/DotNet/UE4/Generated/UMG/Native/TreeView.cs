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
    [StructLayout( LayoutKind.Explicit, Size=1056 )]
    internal unsafe struct TreeView_fields {
        [FieldOffset(976)] byte BP_OnGetItemChildren; //TODO: delegate FOnGetItemChildrenDynamic BP_OnGetItemChildren
        [FieldOffset(1000)] byte BP_OnItemExpansionChanged; //TODO: multicast delegate FOnItemExpansionChangedDynamic BP_OnItemExpansionChanged
    }
    internal unsafe struct TreeView_methods {
        internal struct CollapseAll_method {
            static internal IntPtr CollapseAll_ptr;
            static CollapseAll_method() {
                CollapseAll_ptr = Main.GetMethodUFunction(TreeView.StaticClass, "CollapseAll");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CollapseAll_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ExpandAll_method {
            static internal IntPtr ExpandAll_ptr;
            static ExpandAll_method() {
                ExpandAll_ptr = Main.GetMethodUFunction(TreeView.StaticClass, "ExpandAll");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ExpandAll_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetItemExpansion_method {
            static internal IntPtr SetItemExpansion_ptr;
            static SetItemExpansion_method() {
                SetItemExpansion_ptr = Main.GetMethodUFunction(TreeView.StaticClass, "SetItemExpansion");
            }

            internal static unsafe void Invoke(IntPtr obj, UObject Item, bool bExpandItem) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Item;
                *((bool*)(b+8)) = bExpandItem;
                Main.GetProcessEvent(obj, SetItemExpansion_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct TreeView_events {
    }
}
