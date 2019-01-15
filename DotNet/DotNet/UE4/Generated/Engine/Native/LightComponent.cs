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
    [StructLayout( LayoutKind.Explicit, Size=960 )]
    internal unsafe struct LightComponent_fields {
        [FieldOffset(696)] public float Temperature;
        [FieldOffset(700)] public float MaxDrawDistance;
        [FieldOffset(704)] public float MaxDistanceFadeRange;
        [FieldOffset(708)] public bool bUseTemperature;
        [FieldOffset(724)] public float SpecularScale;
        [FieldOffset(728)] public float ShadowResolutionScale;
        [FieldOffset(732)] public float ShadowBias;
        [FieldOffset(736)] public float ShadowSharpen;
        [FieldOffset(740)] public float ContactShadowLength;
        [FieldOffset(744)] public bool ContactShadowLengthInWS;
        [FieldOffset(744)] public bool CastTranslucentShadows;
        [FieldOffset(744)] public bool bCastShadowsFromCinematicObjectsOnly;
        [FieldOffset(744)] public bool bAffectDynamicIndirectLighting;
        [FieldOffset(744)] public bool bForceCachedShadowsForMovablePrimitives;
        [FieldOffset(748)] public LightingChannels LightingChannels;
        [FieldOffset(752)]  public IntPtr  LightFunctionMaterial;
        [FieldOffset(760)] public Vector LightFunctionScale;
        [FieldOffset(776)]  public IntPtr  IESTexture;
        [FieldOffset(784)] public bool bUseIESBrightness;
        [FieldOffset(788)] public float IESBrightnessScale;
        [FieldOffset(792)] public float LightFunctionFadeDistance;
        [FieldOffset(796)] public float DisabledBrightness;
        [FieldOffset(800)] public bool bEnableLightShaftBloom;
        [FieldOffset(804)] public float BloomScale;
        [FieldOffset(808)] public float BloomThreshold;
        [FieldOffset(812)] public Color BloomTint;
        [FieldOffset(816)] public bool bUseRayTracedDistanceFieldShadows;
        [FieldOffset(820)] public float RayStartOffsetDepthScale;
    }
    internal unsafe struct LightComponent_methods {
        internal struct SetAffectDynamicIndirectLighting_method {
            static internal IntPtr SetAffectDynamicIndirectLighting_ptr;
            static SetAffectDynamicIndirectLighting_method() {
                SetAffectDynamicIndirectLighting_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetAffectDynamicIndirectLighting");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetAffectDynamicIndirectLighting_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAffectTranslucentLighting_method {
            static internal IntPtr SetAffectTranslucentLighting_ptr;
            static SetAffectTranslucentLighting_method() {
                SetAffectTranslucentLighting_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetAffectTranslucentLighting");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetAffectTranslucentLighting_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBloomScale_method {
            static internal IntPtr SetBloomScale_ptr;
            static SetBloomScale_method() {
                SetBloomScale_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetBloomScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetBloomScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBloomThreshold_method {
            static internal IntPtr SetBloomThreshold_ptr;
            static SetBloomThreshold_method() {
                SetBloomThreshold_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetBloomThreshold");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetBloomThreshold_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBloomTint_method {
            static internal IntPtr SetBloomTint_ptr;
            static SetBloomTint_method() {
                SetBloomTint_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetBloomTint");
            }

            internal static unsafe void Invoke(IntPtr obj, Color NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Color*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetBloomTint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEnableLightShaftBloom_method {
            static internal IntPtr SetEnableLightShaftBloom_ptr;
            static SetEnableLightShaftBloom_method() {
                SetEnableLightShaftBloom_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetEnableLightShaftBloom");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetEnableLightShaftBloom_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetForceCachedShadowsForMovablePrimitives_method {
            static internal IntPtr SetForceCachedShadowsForMovablePrimitives_ptr;
            static SetForceCachedShadowsForMovablePrimitives_method() {
                SetForceCachedShadowsForMovablePrimitives_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetForceCachedShadowsForMovablePrimitives");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetForceCachedShadowsForMovablePrimitives_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIESTexture_method {
            static internal IntPtr SetIESTexture_ptr;
            static SetIESTexture_method() {
                SetIESTexture_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetIESTexture");
            }

            internal static unsafe void Invoke(IntPtr obj, TextureLightProfile NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetIESTexture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIndirectLightingIntensity_method {
            static internal IntPtr SetIndirectLightingIntensity_ptr;
            static SetIndirectLightingIntensity_method() {
                SetIndirectLightingIntensity_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetIndirectLightingIntensity");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewIntensity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewIntensity;
                Main.GetProcessEvent(obj, SetIndirectLightingIntensity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIntensity_method {
            static internal IntPtr SetIntensity_ptr;
            static SetIntensity_method() {
                SetIntensity_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetIntensity");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewIntensity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewIntensity;
                Main.GetProcessEvent(obj, SetIntensity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLightColor_method {
            static internal IntPtr SetLightColor_ptr;
            static SetLightColor_method() {
                SetLightColor_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetLightColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewLightColor, bool bSRGB) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewLightColor;
                *((bool*)(b+16)) = bSRGB;
                Main.GetProcessEvent(obj, SetLightColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLightFunctionDisabledBrightness_method {
            static internal IntPtr SetLightFunctionDisabledBrightness_ptr;
            static SetLightFunctionDisabledBrightness_method() {
                SetLightFunctionDisabledBrightness_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetLightFunctionDisabledBrightness");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetLightFunctionDisabledBrightness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLightFunctionFadeDistance_method {
            static internal IntPtr SetLightFunctionFadeDistance_ptr;
            static SetLightFunctionFadeDistance_method() {
                SetLightFunctionFadeDistance_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetLightFunctionFadeDistance");
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
                SetLightFunctionMaterial_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetLightFunctionMaterial");
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
                SetLightFunctionScale_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetLightFunctionScale");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewLightFunctionScale) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLightFunctionScale;
                Main.GetProcessEvent(obj, SetLightFunctionScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShadowBias_method {
            static internal IntPtr SetShadowBias_ptr;
            static SetShadowBias_method() {
                SetShadowBias_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetShadowBias");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetShadowBias_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTemperature_method {
            static internal IntPtr SetTemperature_ptr;
            static SetTemperature_method() {
                SetTemperature_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetTemperature");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewTemperature) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewTemperature;
                Main.GetProcessEvent(obj, SetTemperature_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTransmission_method {
            static internal IntPtr SetTransmission_ptr;
            static SetTransmission_method() {
                SetTransmission_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetTransmission");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetTransmission_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumetricScatteringIntensity_method {
            static internal IntPtr SetVolumetricScatteringIntensity_ptr;
            static SetVolumetricScatteringIntensity_method() {
                SetVolumetricScatteringIntensity_ptr = Main.GetMethodUFunction(LightComponent.StaticClass, "SetVolumetricScatteringIntensity");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewIntensity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewIntensity;
                Main.GetProcessEvent(obj, SetVolumetricScatteringIntensity_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct LightComponent_events {
    }
}
