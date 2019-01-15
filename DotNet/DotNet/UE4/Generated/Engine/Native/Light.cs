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
    [StructLayout( LayoutKind.Explicit, Size=1024 )]
    internal unsafe struct Light_fields {
        [FieldOffset(1008)]  public IntPtr  LightComponent;
        [FieldOffset(1016)] public bool bEnabled;
    }
    internal unsafe struct Light_methods {
        internal struct GetBrightness_method {
            static internal IntPtr GetBrightness_ptr;
            static GetBrightness_method() {
                GetBrightness_ptr = Main.GetMethodUFunction(Light.StaticClass, "GetBrightness");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBrightness_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetLightColor_method {
            static internal IntPtr GetLightColor_ptr;
            static GetLightColor_method() {
                GetLightColor_ptr = Main.GetMethodUFunction(Light.StaticClass, "GetLightColor");
            }

            internal static unsafe LinearColor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLightColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+0));
            }
        }
        internal struct IsEnabled_method {
            static internal IntPtr IsEnabled_ptr;
            static IsEnabled_method() {
                IsEnabled_ptr = Main.GetMethodUFunction(Light.StaticClass, "IsEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetAffectTranslucentLighting_method {
            static internal IntPtr SetAffectTranslucentLighting_ptr;
            static SetAffectTranslucentLighting_method() {
                SetAffectTranslucentLighting_ptr = Main.GetMethodUFunction(Light.StaticClass, "SetAffectTranslucentLighting");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetAffectTranslucentLighting_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBrightness_method {
            static internal IntPtr SetBrightness_ptr;
            static SetBrightness_method() {
                SetBrightness_ptr = Main.GetMethodUFunction(Light.StaticClass, "SetBrightness");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewBrightness) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewBrightness;
                Main.GetProcessEvent(obj, SetBrightness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCastShadows_method {
            static internal IntPtr SetCastShadows_ptr;
            static SetCastShadows_method() {
                SetCastShadows_ptr = Main.GetMethodUFunction(Light.StaticClass, "SetCastShadows");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetCastShadows_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEnabled_method {
            static internal IntPtr SetEnabled_ptr;
            static SetEnabled_method() {
                SetEnabled_ptr = Main.GetMethodUFunction(Light.StaticClass, "SetEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bSetEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bSetEnabled;
                Main.GetProcessEvent(obj, SetEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLightColor_method {
            static internal IntPtr SetLightColor_ptr;
            static SetLightColor_method() {
                SetLightColor_ptr = Main.GetMethodUFunction(Light.StaticClass, "SetLightColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewLightColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewLightColor;
                Main.GetProcessEvent(obj, SetLightColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLightFunctionFadeDistance_method {
            static internal IntPtr SetLightFunctionFadeDistance_ptr;
            static SetLightFunctionFadeDistance_method() {
                SetLightFunctionFadeDistance_ptr = Main.GetMethodUFunction(Light.StaticClass, "SetLightFunctionFadeDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewLightFunctionFadeDistance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewLightFunctionFadeDistance;
                Main.GetProcessEvent(obj, SetLightFunctionFadeDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLightFunctionMaterial_method {
            static internal IntPtr SetLightFunctionMaterial_ptr;
            static SetLightFunctionMaterial_method() {
                SetLightFunctionMaterial_ptr = Main.GetMethodUFunction(Light.StaticClass, "SetLightFunctionMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface NewLightFunctionMaterial) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewLightFunctionMaterial;
                Main.GetProcessEvent(obj, SetLightFunctionMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLightFunctionScale_method {
            static internal IntPtr SetLightFunctionScale_ptr;
            static SetLightFunctionScale_method() {
                SetLightFunctionScale_ptr = Main.GetMethodUFunction(Light.StaticClass, "SetLightFunctionScale");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewLightFunctionScale) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLightFunctionScale;
                Main.GetProcessEvent(obj, SetLightFunctionScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ToggleEnabled_method {
            static internal IntPtr ToggleEnabled_ptr;
            static ToggleEnabled_method() {
                ToggleEnabled_ptr = Main.GetMethodUFunction(Light.StaticClass, "ToggleEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ToggleEnabled_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Light_events {
    }
}
