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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1568 )]
    internal unsafe struct BoxComponent_fields {
        [FieldOffset(1552)] public Vector BoxExtent;
    }
    internal unsafe struct BoxComponent_methods {
        internal struct GetScaledBoxExtent_method {
            static internal IntPtr GetScaledBoxExtent_ptr;
            static GetScaledBoxExtent_method() {
                GetScaledBoxExtent_ptr = Main.GetMethodUFunction(BoxComponent.StaticClass, "GetScaledBoxExtent");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScaledBoxExtent_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetUnscaledBoxExtent_method {
            static internal IntPtr GetUnscaledBoxExtent_ptr;
            static GetUnscaledBoxExtent_method() {
                GetUnscaledBoxExtent_ptr = Main.GetMethodUFunction(BoxComponent.StaticClass, "GetUnscaledBoxExtent");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUnscaledBoxExtent_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct SetBoxExtent_method {
            static internal IntPtr SetBoxExtent_ptr;
            static SetBoxExtent_method() {
                SetBoxExtent_ptr = Main.GetMethodUFunction(BoxComponent.StaticClass, "SetBoxExtent");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector InBoxExtent, bool bUpdateOverlaps) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InBoxExtent;
                *((bool*)(b+12)) = bUpdateOverlaps;
                Main.GetProcessEvent(obj, SetBoxExtent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct BoxComponent_events {
    }
}
