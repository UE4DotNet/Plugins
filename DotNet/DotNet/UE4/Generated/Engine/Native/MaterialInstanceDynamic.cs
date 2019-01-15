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
    [StructLayout( LayoutKind.Explicit, Size=832 )]
    internal unsafe struct MaterialInstanceDynamic_fields {
    }
    internal unsafe struct MaterialInstanceDynamic_methods {
        internal struct CopyParameterOverrides_method {
            static internal IntPtr CopyParameterOverrides_ptr;
            static CopyParameterOverrides_method() {
                CopyParameterOverrides_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "CopyParameterOverrides");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInstance MaterialInstance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MaterialInstance;
                Main.GetProcessEvent(obj, CopyParameterOverrides_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_CopyMaterialInstanceParameters_method {
            static internal IntPtr K2_CopyMaterialInstanceParameters_ptr;
            static K2_CopyMaterialInstanceParameters_method() {
                K2_CopyMaterialInstanceParameters_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "K2_CopyMaterialInstanceParameters");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface Source, bool bQuickParametersOnly) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Source;
                *((bool*)(b+8)) = bQuickParametersOnly;
                Main.GetProcessEvent(obj, K2_CopyMaterialInstanceParameters_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_GetScalarParameterValue_method {
            static internal IntPtr K2_GetScalarParameterValue_ptr;
            static K2_GetScalarParameterValue_method() {
                K2_GetScalarParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "K2_GetScalarParameterValue");
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
                K2_GetTextureParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "K2_GetTextureParameterValue");
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
                K2_GetVectorParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "K2_GetVectorParameterValue");
            }

            internal static unsafe LinearColor Invoke(IntPtr obj, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                Main.GetProcessEvent(obj, K2_GetVectorParameterValue_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+12));
            }
        }
        internal struct K2_InterpolateMaterialInstanceParams_method {
            static internal IntPtr K2_InterpolateMaterialInstanceParams_ptr;
            static K2_InterpolateMaterialInstanceParams_method() {
                K2_InterpolateMaterialInstanceParams_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "K2_InterpolateMaterialInstanceParams");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInstance SourceA, MaterialInstance SourceB, float Alpha) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceA;
                *((IntPtr*)(b+8)) = SourceB;
                *((float*)(b+16)) = Alpha;
                Main.GetProcessEvent(obj, K2_InterpolateMaterialInstanceParams_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScalarParameterValue_method {
            static internal IntPtr SetScalarParameterValue_ptr;
            static SetScalarParameterValue_method() {
                SetScalarParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "SetScalarParameterValue");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, float Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((float*)(b+12)) = Value;
                Main.GetProcessEvent(obj, SetScalarParameterValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTextureParameterValue_method {
            static internal IntPtr SetTextureParameterValue_ptr;
            static SetTextureParameterValue_method() {
                SetTextureParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "SetTextureParameterValue");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, Texture Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((IntPtr*)(b+16)) = Value;
                Main.GetProcessEvent(obj, SetTextureParameterValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVectorParameterValue_method {
            static internal IntPtr SetVectorParameterValue_ptr;
            static SetVectorParameterValue_method() {
                SetVectorParameterValue_ptr = Main.GetMethodUFunction(MaterialInstanceDynamic.StaticClass, "SetVectorParameterValue");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, LinearColor Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((LinearColor*)(b+12)) = Value;
                Main.GetProcessEvent(obj, SetVectorParameterValue_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MaterialInstanceDynamic_events {
    }
}
