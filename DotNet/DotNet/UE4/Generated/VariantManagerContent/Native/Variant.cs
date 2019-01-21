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

using UE4.Engine;

namespace UE4.VariantManagerContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct Variant_fields {
        [FieldOffset(56)] byte DisplayText; //TODO: text FText DisplayText
        [FieldOffset(80)] public NativeArray ObjectBindings;
    }
    internal unsafe struct Variant_methods {
        internal struct GetActor_method {
            static internal IntPtr GetActor_ptr;
            static GetActor_method() {
                GetActor_ptr = Main.GetMethodUFunction(Variant.StaticClass, "GetActor");
            }

            internal static unsafe Actor Invoke(IntPtr obj, int ActorIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ActorIndex;
                Main.GetProcessEvent(obj, GetActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetDisplayText_method {
            static internal IntPtr GetDisplayText_ptr;
            static GetDisplayText_method() {
                GetDisplayText_ptr = Main.GetMethodUFunction(Variant.StaticClass, "GetDisplayText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDisplayText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct GetNumActors_method {
            static internal IntPtr GetNumActors_ptr;
            static GetNumActors_method() {
                GetNumActors_ptr = Main.GetMethodUFunction(Variant.StaticClass, "GetNumActors");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumActors_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct SetDisplayText_method {
            static internal IntPtr SetDisplayText_ptr;
            static SetDisplayText_method() {
                SetDisplayText_ptr = Main.GetMethodUFunction(Variant.StaticClass, "SetDisplayText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewDisplayText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText NewDisplayText
                Main.GetProcessEvent(obj, SetDisplayText_ptr, new IntPtr(p)); ;
                 //TODO: text FText NewDisplayText
            }
        }
        internal struct SwitchOn_method {
            static internal IntPtr SwitchOn_ptr;
            static SwitchOn_method() {
                SwitchOn_ptr = Main.GetMethodUFunction(Variant.StaticClass, "SwitchOn");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SwitchOn_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Variant_events {
    }
}
