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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetMaterialLibrary_fields {
    }
    internal unsafe struct KismetMaterialLibrary_methods {
        internal struct CreateDynamicMaterialInstance_method {
            static internal IntPtr CreateDynamicMaterialInstance_ptr;
            static CreateDynamicMaterialInstance_method() {
                CreateDynamicMaterialInstance_ptr = Main.GetMethodUFunction(KismetMaterialLibrary.StaticClass, "CreateDynamicMaterialInstance");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(UObject WorldContextObject, MaterialInterface Parent, Name OptionalName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Parent;
                *((Name*)(b+16)) = OptionalName;
                Main.GetProcessEvent(KismetMaterialLibrary.DefaultObject, CreateDynamicMaterialInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+32));
            }
        }
        internal struct GetScalarParameterValue_method {
            static internal IntPtr GetScalarParameterValue_ptr;
            static GetScalarParameterValue_method() {
                GetScalarParameterValue_ptr = Main.GetMethodUFunction(KismetMaterialLibrary.StaticClass, "GetScalarParameterValue");
            }

            internal static unsafe float Invoke(UObject WorldContextObject, MaterialParameterCollection Collection, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Collection;
                *((Name*)(b+16)) = ParameterName;
                Main.GetProcessEvent(KismetMaterialLibrary.DefaultObject, GetScalarParameterValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+28));
            }
        }
        internal struct GetVectorParameterValue_method {
            static internal IntPtr GetVectorParameterValue_ptr;
            static GetVectorParameterValue_method() {
                GetVectorParameterValue_ptr = Main.GetMethodUFunction(KismetMaterialLibrary.StaticClass, "GetVectorParameterValue");
            }

            internal static unsafe LinearColor Invoke(UObject WorldContextObject, MaterialParameterCollection Collection, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Collection;
                *((Name*)(b+16)) = ParameterName;
                Main.GetProcessEvent(KismetMaterialLibrary.DefaultObject, GetVectorParameterValue_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+28));
            }
        }
        internal struct SetScalarParameterValue_method {
            static internal IntPtr SetScalarParameterValue_ptr;
            static SetScalarParameterValue_method() {
                SetScalarParameterValue_ptr = Main.GetMethodUFunction(KismetMaterialLibrary.StaticClass, "SetScalarParameterValue");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, MaterialParameterCollection Collection, Name ParameterName, float ParameterValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Collection;
                *((Name*)(b+16)) = ParameterName;
                *((float*)(b+28)) = ParameterValue;
                Main.GetProcessEvent(KismetMaterialLibrary.DefaultObject, SetScalarParameterValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVectorParameterValue_method {
            static internal IntPtr SetVectorParameterValue_ptr;
            static SetVectorParameterValue_method() {
                SetVectorParameterValue_ptr = Main.GetMethodUFunction(KismetMaterialLibrary.StaticClass, "SetVectorParameterValue");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, MaterialParameterCollection Collection, Name ParameterName, LinearColor ParameterValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Collection;
                *((Name*)(b+16)) = ParameterName;
                *((LinearColor*)(b+28)) = ParameterValue;
                Main.GetProcessEvent(KismetMaterialLibrary.DefaultObject, SetVectorParameterValue_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct KismetMaterialLibrary_events {
    }
}
