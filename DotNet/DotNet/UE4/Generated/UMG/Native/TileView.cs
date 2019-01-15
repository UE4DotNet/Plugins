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
    [StructLayout( LayoutKind.Explicit, Size=960 )]
    internal unsafe struct TileView_fields {
        [FieldOffset(928)] public float EntryHeight;
        [FieldOffset(932)] public float EntryWidth;
        [FieldOffset(936)] byte TileAlignment; //TODO: enum EListItemAlignment TileAlignment
        [FieldOffset(937)] public bool bWrapHorizontalNavigation;
    }
    internal unsafe struct TileView_methods {
        internal struct SetEntryHeight_method {
            static internal IntPtr SetEntryHeight_ptr;
            static SetEntryHeight_method() {
                SetEntryHeight_ptr = Main.GetMethodUFunction(TileView.StaticClass, "SetEntryHeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewHeight) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewHeight;
                Main.GetProcessEvent(obj, SetEntryHeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEntryWidth_method {
            static internal IntPtr SetEntryWidth_ptr;
            static SetEntryWidth_method() {
                SetEntryWidth_ptr = Main.GetMethodUFunction(TileView.StaticClass, "SetEntryWidth");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewWidth) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewWidth;
                Main.GetProcessEvent(obj, SetEntryWidth_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct TileView_events {
    }
}
