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
    internal unsafe struct ExponentialHeightFogComponent_fields {
        [FieldOffset(624)] public float FogDensity;
        [FieldOffset(628)] public LinearColor FogInscatteringColor;
        [FieldOffset(648)]  public IntPtr  InscatteringColorCubemap;
        [FieldOffset(656)] public float InscatteringColorCubemapAngle;
        [FieldOffset(660)] public LinearColor InscatteringTextureTint;
        [FieldOffset(676)] public float FullyDirectionalInscatteringColorDistance;
        [FieldOffset(680)] public float NonDirectionalInscatteringColorDistance;
        [FieldOffset(684)] public float DirectionalInscatteringExponent;
        [FieldOffset(688)] public float DirectionalInscatteringStartDistance;
        [FieldOffset(692)] public LinearColor DirectionalInscatteringColor;
        [FieldOffset(708)] public float FogHeightFalloff;
        [FieldOffset(712)] public float FogMaxOpacity;
        [FieldOffset(716)] public float StartDistance;
        [FieldOffset(720)] public float FogCutoffDistance;
        [FieldOffset(724)] public bool bEnableVolumetricFog;
        [FieldOffset(728)] public float VolumetricFogScatteringDistribution;
        [FieldOffset(732)] public Color VolumetricFogAlbedo;
        [FieldOffset(736)] public LinearColor VolumetricFogEmissive;
        [FieldOffset(752)] public float VolumetricFogExtinctionScale;
        [FieldOffset(756)] public float VolumetricFogDistance;
        [FieldOffset(760)] public float VolumetricFogStaticLightingScatteringIntensity;
        [FieldOffset(764)] public bool bOverrideLightColorsWithFogInscatteringColors;
    }
    internal unsafe struct ExponentialHeightFogComponent_methods {
        internal struct SetDirectionalInscatteringColor_method {
            static internal IntPtr SetDirectionalInscatteringColor_ptr;
            static SetDirectionalInscatteringColor_method() {
                SetDirectionalInscatteringColor_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetDirectionalInscatteringColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetDirectionalInscatteringColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDirectionalInscatteringExponent_method {
            static internal IntPtr SetDirectionalInscatteringExponent_ptr;
            static SetDirectionalInscatteringExponent_method() {
                SetDirectionalInscatteringExponent_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetDirectionalInscatteringExponent");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetDirectionalInscatteringExponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDirectionalInscatteringStartDistance_method {
            static internal IntPtr SetDirectionalInscatteringStartDistance_ptr;
            static SetDirectionalInscatteringStartDistance_method() {
                SetDirectionalInscatteringStartDistance_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetDirectionalInscatteringStartDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetDirectionalInscatteringStartDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFogCutoffDistance_method {
            static internal IntPtr SetFogCutoffDistance_ptr;
            static SetFogCutoffDistance_method() {
                SetFogCutoffDistance_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetFogCutoffDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetFogCutoffDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFogDensity_method {
            static internal IntPtr SetFogDensity_ptr;
            static SetFogDensity_method() {
                SetFogDensity_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetFogDensity");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetFogDensity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFogHeightFalloff_method {
            static internal IntPtr SetFogHeightFalloff_ptr;
            static SetFogHeightFalloff_method() {
                SetFogHeightFalloff_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetFogHeightFalloff");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetFogHeightFalloff_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFogInscatteringColor_method {
            static internal IntPtr SetFogInscatteringColor_ptr;
            static SetFogInscatteringColor_method() {
                SetFogInscatteringColor_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetFogInscatteringColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetFogInscatteringColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFogMaxOpacity_method {
            static internal IntPtr SetFogMaxOpacity_ptr;
            static SetFogMaxOpacity_method() {
                SetFogMaxOpacity_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetFogMaxOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetFogMaxOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFullyDirectionalInscatteringColorDistance_method {
            static internal IntPtr SetFullyDirectionalInscatteringColorDistance_ptr;
            static SetFullyDirectionalInscatteringColorDistance_method() {
                SetFullyDirectionalInscatteringColorDistance_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetFullyDirectionalInscatteringColorDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetFullyDirectionalInscatteringColorDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInscatteringColorCubemap_method {
            static internal IntPtr SetInscatteringColorCubemap_ptr;
            static SetInscatteringColorCubemap_method() {
                SetInscatteringColorCubemap_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetInscatteringColorCubemap");
            }

            internal static unsafe void Invoke(IntPtr obj, TextureCube Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetInscatteringColorCubemap_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInscatteringColorCubemapAngle_method {
            static internal IntPtr SetInscatteringColorCubemapAngle_ptr;
            static SetInscatteringColorCubemapAngle_method() {
                SetInscatteringColorCubemapAngle_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetInscatteringColorCubemapAngle");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetInscatteringColorCubemapAngle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInscatteringTextureTint_method {
            static internal IntPtr SetInscatteringTextureTint_ptr;
            static SetInscatteringTextureTint_method() {
                SetInscatteringTextureTint_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetInscatteringTextureTint");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor Value) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetInscatteringTextureTint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNonDirectionalInscatteringColorDistance_method {
            static internal IntPtr SetNonDirectionalInscatteringColorDistance_ptr;
            static SetNonDirectionalInscatteringColorDistance_method() {
                SetNonDirectionalInscatteringColorDistance_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetNonDirectionalInscatteringColorDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetNonDirectionalInscatteringColorDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartDistance_method {
            static internal IntPtr SetStartDistance_ptr;
            static SetStartDistance_method() {
                SetStartDistance_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetStartDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetStartDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumetricFog_method {
            static internal IntPtr SetVolumetricFog_ptr;
            static SetVolumetricFog_method() {
                SetVolumetricFog_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetVolumetricFog");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetVolumetricFog_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumetricFogAlbedo_method {
            static internal IntPtr SetVolumetricFogAlbedo_ptr;
            static SetVolumetricFogAlbedo_method() {
                SetVolumetricFogAlbedo_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetVolumetricFogAlbedo");
            }

            internal static unsafe void Invoke(IntPtr obj, Color NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Color*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetVolumetricFogAlbedo_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumetricFogDistance_method {
            static internal IntPtr SetVolumetricFogDistance_ptr;
            static SetVolumetricFogDistance_method() {
                SetVolumetricFogDistance_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetVolumetricFogDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetVolumetricFogDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumetricFogEmissive_method {
            static internal IntPtr SetVolumetricFogEmissive_ptr;
            static SetVolumetricFogEmissive_method() {
                SetVolumetricFogEmissive_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetVolumetricFogEmissive");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetVolumetricFogEmissive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumetricFogExtinctionScale_method {
            static internal IntPtr SetVolumetricFogExtinctionScale_ptr;
            static SetVolumetricFogExtinctionScale_method() {
                SetVolumetricFogExtinctionScale_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetVolumetricFogExtinctionScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetVolumetricFogExtinctionScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumetricFogScatteringDistribution_method {
            static internal IntPtr SetVolumetricFogScatteringDistribution_ptr;
            static SetVolumetricFogScatteringDistribution_method() {
                SetVolumetricFogScatteringDistribution_ptr = Main.GetMethodUFunction(ExponentialHeightFogComponent.StaticClass, "SetVolumetricFogScatteringDistribution");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetVolumetricFogScatteringDistribution_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ExponentialHeightFogComponent_events {
    }
}
