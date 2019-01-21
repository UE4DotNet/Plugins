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
    [StructLayout( LayoutKind.Explicit, Size=1072 )]
    internal unsafe struct DirectionalLightComponent_fields {
        [FieldOffset(952)] public bool bEnableLightShaftOcclusion;
        [FieldOffset(956)] public float OcclusionMaskDarkness;
        [FieldOffset(960)] public float OcclusionDepthRange;
        [FieldOffset(964)] public Vector LightShaftOverrideDirection;
        [FieldOffset(980)] public float DynamicShadowDistanceMovableLight;
        [FieldOffset(984)] public float DynamicShadowDistanceStationaryLight;
        [FieldOffset(988)] public int DynamicShadowCascades;
        [FieldOffset(992)] public float CascadeDistributionExponent;
        [FieldOffset(996)] public float CascadeTransitionFraction;
        [FieldOffset(1000)] public float ShadowDistanceFadeoutFraction;
        [FieldOffset(1004)] public bool bUseInsetShadowsForMovableObjects;
        [FieldOffset(1008)] public int FarShadowCascadeCount;
        [FieldOffset(1012)] public float FarShadowDistance;
        [FieldOffset(1016)] public float DistanceFieldShadowDistance;
        [FieldOffset(1020)] public float LightSourceAngle;
        [FieldOffset(1024)] public float LightSourceSoftAngle;
        [FieldOffset(1028)] public float TraceDistance;
        [FieldOffset(1032)] public LightmassDirectionalLightSettings LightmassSettings;
        [FieldOffset(1048)] public bool bCastModulatedShadows;
        [FieldOffset(1052)] public Color ModulatedShadowColor;
        [FieldOffset(1056)] public bool bUsedAsAtmosphereSunLight;
    }
    internal unsafe struct DirectionalLightComponent_methods {
        internal struct SetCascadeDistributionExponent_method {
            static internal IntPtr SetCascadeDistributionExponent_ptr;
            static SetCascadeDistributionExponent_method() {
                SetCascadeDistributionExponent_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetCascadeDistributionExponent");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetCascadeDistributionExponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCascadeTransitionFraction_method {
            static internal IntPtr SetCascadeTransitionFraction_ptr;
            static SetCascadeTransitionFraction_method() {
                SetCascadeTransitionFraction_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetCascadeTransitionFraction");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetCascadeTransitionFraction_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDynamicShadowCascades_method {
            static internal IntPtr SetDynamicShadowCascades_ptr;
            static SetDynamicShadowCascades_method() {
                SetDynamicShadowCascades_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetDynamicShadowCascades");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetDynamicShadowCascades_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDynamicShadowDistanceMovableLight_method {
            static internal IntPtr SetDynamicShadowDistanceMovableLight_ptr;
            static SetDynamicShadowDistanceMovableLight_method() {
                SetDynamicShadowDistanceMovableLight_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetDynamicShadowDistanceMovableLight");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetDynamicShadowDistanceMovableLight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDynamicShadowDistanceStationaryLight_method {
            static internal IntPtr SetDynamicShadowDistanceStationaryLight_ptr;
            static SetDynamicShadowDistanceStationaryLight_method() {
                SetDynamicShadowDistanceStationaryLight_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetDynamicShadowDistanceStationaryLight");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetDynamicShadowDistanceStationaryLight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEnableLightShaftOcclusion_method {
            static internal IntPtr SetEnableLightShaftOcclusion_ptr;
            static SetEnableLightShaftOcclusion_method() {
                SetEnableLightShaftOcclusion_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetEnableLightShaftOcclusion");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetEnableLightShaftOcclusion_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLightShaftOverrideDirection_method {
            static internal IntPtr SetLightShaftOverrideDirection_ptr;
            static SetLightShaftOverrideDirection_method() {
                SetLightShaftOverrideDirection_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetLightShaftOverrideDirection");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetLightShaftOverrideDirection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOcclusionMaskDarkness_method {
            static internal IntPtr SetOcclusionMaskDarkness_ptr;
            static SetOcclusionMaskDarkness_method() {
                SetOcclusionMaskDarkness_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetOcclusionMaskDarkness");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetOcclusionMaskDarkness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShadowDistanceFadeoutFraction_method {
            static internal IntPtr SetShadowDistanceFadeoutFraction_ptr;
            static SetShadowDistanceFadeoutFraction_method() {
                SetShadowDistanceFadeoutFraction_ptr = Main.GetMethodUFunction(DirectionalLightComponent.StaticClass, "SetShadowDistanceFadeoutFraction");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetShadowDistanceFadeoutFraction_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct DirectionalLightComponent_events {
    }
}
