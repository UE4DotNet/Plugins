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
    internal unsafe struct CircularThrobber_fields {
        [FieldOffset(384)] public int NumberOfPieces;
        [FieldOffset(388)] public float Period;
        [FieldOffset(392)] public float Radius;
        [FieldOffset(408)] public SlateBrush Image;
        [FieldOffset(568)] public bool bEnableRadius;
    }
    internal unsafe struct CircularThrobber_methods {
        internal struct SetNumberOfPieces_method {
            static internal IntPtr SetNumberOfPieces_ptr;
            static SetNumberOfPieces_method() {
                SetNumberOfPieces_ptr = Main.GetMethodUFunction(CircularThrobber.StaticClass, "SetNumberOfPieces");
            }

            internal static unsafe void Invoke(IntPtr obj, int InNumberOfPieces) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InNumberOfPieces;
                Main.GetProcessEvent(obj, SetNumberOfPieces_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPeriod_method {
            static internal IntPtr SetPeriod_ptr;
            static SetPeriod_method() {
                SetPeriod_ptr = Main.GetMethodUFunction(CircularThrobber.StaticClass, "SetPeriod");
            }

            internal static unsafe void Invoke(IntPtr obj, float InPeriod) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InPeriod;
                Main.GetProcessEvent(obj, SetPeriod_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRadius_method {
            static internal IntPtr SetRadius_ptr;
            static SetRadius_method() {
                SetRadius_ptr = Main.GetMethodUFunction(CircularThrobber.StaticClass, "SetRadius");
            }

            internal static unsafe void Invoke(IntPtr obj, float InRadius) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InRadius;
                Main.GetProcessEvent(obj, SetRadius_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CircularThrobber_events {
    }
}
