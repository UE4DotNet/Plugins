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
    internal unsafe struct NativeUserListEntry_fields {
    }
    internal unsafe struct NativeUserListEntry_methods {
        internal struct IsListItemExpanded_method {
            static internal IntPtr IsListItemExpanded_ptr;
            static IsListItemExpanded_method() {
                IsListItemExpanded_ptr = Main.GetMethodUFunction(NativeUserListEntry.StaticClass, "IsListItemExpanded");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsListItemExpanded_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsListItemSelected_method {
            static internal IntPtr IsListItemSelected_ptr;
            static IsListItemSelected_method() {
                IsListItemSelected_ptr = Main.GetMethodUFunction(NativeUserListEntry.StaticClass, "IsListItemSelected");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsListItemSelected_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct NativeUserListEntry_events {
    }
}
