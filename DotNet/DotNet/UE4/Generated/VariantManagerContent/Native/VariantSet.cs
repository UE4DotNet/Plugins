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


namespace UE4.VariantManagerContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct VariantSet_fields {
        [FieldOffset(56)] byte DisplayText; //TODO: text FText DisplayText
        [FieldOffset(80)] public NativeArray Variants;
    }
    internal unsafe struct VariantSet_methods {
        internal struct GetDisplayText_method {
            static internal IntPtr GetDisplayText_ptr;
            static GetDisplayText_method() {
                GetDisplayText_ptr = Main.GetMethodUFunction(VariantSet.StaticClass, "GetDisplayText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDisplayText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct GetNumVariants_method {
            static internal IntPtr GetNumVariants_ptr;
            static GetNumVariants_method() {
                GetNumVariants_ptr = Main.GetMethodUFunction(VariantSet.StaticClass, "GetNumVariants");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumVariants_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetVariant_method {
            static internal IntPtr GetVariant_ptr;
            static GetVariant_method() {
                GetVariant_ptr = Main.GetMethodUFunction(VariantSet.StaticClass, "GetVariant");
            }

            internal static unsafe Variant Invoke(IntPtr obj, int VariantIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = VariantIndex;
                Main.GetProcessEvent(obj, GetVariant_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SetDisplayText_method {
            static internal IntPtr SetDisplayText_ptr;
            static SetDisplayText_method() {
                SetDisplayText_ptr = Main.GetMethodUFunction(VariantSet.StaticClass, "SetDisplayText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewDisplayText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText NewDisplayText
                Main.GetProcessEvent(obj, SetDisplayText_ptr, new IntPtr(p)); ;
                 //TODO: text FText NewDisplayText
            }
        }
    }
    internal unsafe struct VariantSet_events {
    }
}
