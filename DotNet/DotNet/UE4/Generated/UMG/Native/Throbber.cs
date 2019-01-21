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
    [StructLayout( LayoutKind.Explicit, Size=592 )]
    internal unsafe struct Throbber_fields {
        [FieldOffset(400)] public int NumberOfPieces;
        [FieldOffset(404)] public bool bAnimateHorizontally;
        [FieldOffset(405)] public bool bAnimateVertically;
        [FieldOffset(406)] public bool bAnimateOpacity;
        [FieldOffset(416)] public SlateBrush Image;
    }
    internal unsafe struct Throbber_methods {
        internal struct SetAnimateHorizontally_method {
            static internal IntPtr SetAnimateHorizontally_ptr;
            static SetAnimateHorizontally_method() {
                SetAnimateHorizontally_ptr = Main.GetMethodUFunction(Throbber.StaticClass, "SetAnimateHorizontally");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAnimateHorizontally) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAnimateHorizontally;
                Main.GetProcessEvent(obj, SetAnimateHorizontally_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnimateOpacity_method {
            static internal IntPtr SetAnimateOpacity_ptr;
            static SetAnimateOpacity_method() {
                SetAnimateOpacity_ptr = Main.GetMethodUFunction(Throbber.StaticClass, "SetAnimateOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAnimateOpacity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAnimateOpacity;
                Main.GetProcessEvent(obj, SetAnimateOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnimateVertically_method {
            static internal IntPtr SetAnimateVertically_ptr;
            static SetAnimateVertically_method() {
                SetAnimateVertically_ptr = Main.GetMethodUFunction(Throbber.StaticClass, "SetAnimateVertically");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInAnimateVertically) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInAnimateVertically;
                Main.GetProcessEvent(obj, SetAnimateVertically_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNumberOfPieces_method {
            static internal IntPtr SetNumberOfPieces_ptr;
            static SetNumberOfPieces_method() {
                SetNumberOfPieces_ptr = Main.GetMethodUFunction(Throbber.StaticClass, "SetNumberOfPieces");
            }

            internal static unsafe void Invoke(IntPtr obj, int InNumberOfPieces) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InNumberOfPieces;
                Main.GetProcessEvent(obj, SetNumberOfPieces_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Throbber_events {
    }
}
