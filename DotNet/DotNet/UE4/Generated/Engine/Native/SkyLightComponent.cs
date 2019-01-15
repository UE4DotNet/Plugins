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
    [StructLayout( LayoutKind.Explicit, Size=1136 )]
    internal unsafe struct SkyLightComponent_fields {
        [FieldOffset(696)] public byte SourceType;
        [FieldOffset(704)]  public IntPtr  Cubemap;
        [FieldOffset(712)] public float SourceCubemapAngle;
        [FieldOffset(716)] public int CubemapResolution;
        [FieldOffset(720)] public float SkyDistanceThreshold;
        [FieldOffset(724)] public bool bCaptureEmissiveOnly;
        [FieldOffset(725)] public bool bLowerHemisphereIsBlack;
        [FieldOffset(728)] public LinearColor LowerHemisphereColor;
        [FieldOffset(744)] public float OcclusionMaxDistance;
        [FieldOffset(748)] public float Contrast;
        [FieldOffset(752)] public float OcclusionExponent;
        [FieldOffset(756)] public float MinOcclusion;
        [FieldOffset(760)] public Color OcclusionTint;
        [FieldOffset(764)] public byte OcclusionCombineMode;
        [FieldOffset(936)]  public IntPtr  BlendDestinationCubemap;
    }
    internal unsafe struct SkyLightComponent_methods {
        internal struct RecaptureSky_method {
            static internal IntPtr RecaptureSky_ptr;
            static RecaptureSky_method() {
                RecaptureSky_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "RecaptureSky");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RecaptureSky_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCubemap_method {
            static internal IntPtr SetCubemap_ptr;
            static SetCubemap_method() {
                SetCubemap_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetCubemap");
            }

            internal static unsafe void Invoke(IntPtr obj, TextureCube NewCubemap) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewCubemap;
                Main.GetProcessEvent(obj, SetCubemap_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCubemapBlend_method {
            static internal IntPtr SetCubemapBlend_ptr;
            static SetCubemapBlend_method() {
                SetCubemapBlend_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetCubemapBlend");
            }

            internal static unsafe void Invoke(IntPtr obj, TextureCube SourceCubemap, TextureCube DestinationCubemap, float InBlendFraction) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SourceCubemap;
                *((IntPtr*)(b+8)) = DestinationCubemap;
                *((float*)(b+16)) = InBlendFraction;
                Main.GetProcessEvent(obj, SetCubemapBlend_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIndirectLightingIntensity_method {
            static internal IntPtr SetIndirectLightingIntensity_ptr;
            static SetIndirectLightingIntensity_method() {
                SetIndirectLightingIntensity_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetIndirectLightingIntensity");
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
                SetIntensity_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetIntensity");
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
                SetLightColor_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetLightColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewLightColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewLightColor;
                Main.GetProcessEvent(obj, SetLightColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLowerHemisphereColor_method {
            static internal IntPtr SetLowerHemisphereColor_ptr;
            static SetLowerHemisphereColor_method() {
                SetLowerHemisphereColor_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetLowerHemisphereColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InLowerHemisphereColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InLowerHemisphereColor;
                Main.GetProcessEvent(obj, SetLowerHemisphereColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinOcclusion_method {
            static internal IntPtr SetMinOcclusion_ptr;
            static SetMinOcclusion_method() {
                SetMinOcclusion_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetMinOcclusion");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMinOcclusion) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMinOcclusion;
                Main.GetProcessEvent(obj, SetMinOcclusion_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOcclusionContrast_method {
            static internal IntPtr SetOcclusionContrast_ptr;
            static SetOcclusionContrast_method() {
                SetOcclusionContrast_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetOcclusionContrast");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOcclusionContrast) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOcclusionContrast;
                Main.GetProcessEvent(obj, SetOcclusionContrast_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOcclusionExponent_method {
            static internal IntPtr SetOcclusionExponent_ptr;
            static SetOcclusionExponent_method() {
                SetOcclusionExponent_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetOcclusionExponent");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOcclusionExponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOcclusionExponent;
                Main.GetProcessEvent(obj, SetOcclusionExponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOcclusionTint_method {
            static internal IntPtr SetOcclusionTint_ptr;
            static SetOcclusionTint_method() {
                SetOcclusionTint_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetOcclusionTint");
            }

            internal static unsafe void Invoke(IntPtr obj, Color InTint) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Color*)(b+0)) = InTint;
                Main.GetProcessEvent(obj, SetOcclusionTint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumetricScatteringIntensity_method {
            static internal IntPtr SetVolumetricScatteringIntensity_ptr;
            static SetVolumetricScatteringIntensity_method() {
                SetVolumetricScatteringIntensity_ptr = Main.GetMethodUFunction(SkyLightComponent.StaticClass, "SetVolumetricScatteringIntensity");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewIntensity) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewIntensity;
                Main.GetProcessEvent(obj, SetVolumetricScatteringIntensity_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SkyLightComponent_events {
    }
}
