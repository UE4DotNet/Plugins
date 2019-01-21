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
    [StructLayout( LayoutKind.Explicit, Size=448 )]
    internal unsafe struct InvalidationBox_fields {
        [FieldOffset(424)] public bool bCanCache;
        [FieldOffset(425)] public bool CacheRelativeTransforms;
    }
    internal unsafe struct InvalidationBox_methods {
        internal struct GetCanCache_method {
            static internal IntPtr GetCanCache_ptr;
            static GetCanCache_method() {
                GetCanCache_ptr = Main.GetMethodUFunction(InvalidationBox.StaticClass, "GetCanCache");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCanCache_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct InvalidateCache_method {
            static internal IntPtr InvalidateCache_ptr;
            static InvalidateCache_method() {
                InvalidateCache_ptr = Main.GetMethodUFunction(InvalidationBox.StaticClass, "InvalidateCache");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, InvalidateCache_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCanCache_method {
            static internal IntPtr SetCanCache_ptr;
            static SetCanCache_method() {
                SetCanCache_ptr = Main.GetMethodUFunction(InvalidationBox.StaticClass, "SetCanCache");
            }

            internal static unsafe void Invoke(IntPtr obj, bool CanCache) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = CanCache;
                Main.GetProcessEvent(obj, SetCanCache_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct InvalidationBox_events {
    }
}
