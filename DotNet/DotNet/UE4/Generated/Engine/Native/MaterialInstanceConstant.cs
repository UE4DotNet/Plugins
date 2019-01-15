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
    [StructLayout( LayoutKind.Explicit, Size=768 )]
    internal unsafe struct MaterialInstanceConstant_fields {
        [FieldOffset(752)] public FGuid ParameterStateId;
    }
    internal unsafe struct MaterialInstanceConstant_methods {
        internal struct K2_GetScalarParameterValue_method {
            static internal IntPtr K2_GetScalarParameterValue_ptr;
            static K2_GetScalarParameterValue_method() {
                K2_GetScalarParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceConstant.StaticClass, "K2_GetScalarParameterValue");
            }

            internal static unsafe float Invoke(IntPtr obj, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                Main.GetProcessEvent(obj, K2_GetScalarParameterValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct K2_GetTextureParameterValue_method {
            static internal IntPtr K2_GetTextureParameterValue_ptr;
            static K2_GetTextureParameterValue_method() {
                K2_GetTextureParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceConstant.StaticClass, "K2_GetTextureParameterValue");
            }

            internal static unsafe Texture Invoke(IntPtr obj, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                Main.GetProcessEvent(obj, K2_GetTextureParameterValue_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct K2_GetVectorParameterValue_method {
            static internal IntPtr K2_GetVectorParameterValue_ptr;
            static K2_GetVectorParameterValue_method() {
                K2_GetVectorParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceConstant.StaticClass, "K2_GetVectorParameterValue");
            }

            internal static unsafe LinearColor Invoke(IntPtr obj, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                Main.GetProcessEvent(obj, K2_GetVectorParameterValue_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+12));
            }
        }
    }
    internal unsafe struct MaterialInstanceConstant_events {
    }
}
