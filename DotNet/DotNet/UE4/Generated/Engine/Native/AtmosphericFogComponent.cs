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
    internal unsafe struct AtmosphericFogComponent_fields {
        [FieldOffset(624)] public float SunMultiplier;
        [FieldOffset(628)] public float FogMultiplier;
        [FieldOffset(632)] public float DensityMultiplier;
        [FieldOffset(636)] public float DensityOffset;
        [FieldOffset(640)] public float DistanceScale;
        [FieldOffset(644)] public float AltitudeScale;
        [FieldOffset(648)] public float DistanceOffset;
        [FieldOffset(652)] public float GroundOffset;
        [FieldOffset(656)] public float StartDistance;
        [FieldOffset(660)] public float SunDiscScale;
        [FieldOffset(664)] public float DefaultBrightness;
        [FieldOffset(668)] public Color DefaultLightColor;
        [FieldOffset(672)] public bool bDisableSunDisk;
        [FieldOffset(672)] public bool bDisableGroundScattering;
        [FieldOffset(676)] public AtmospherePrecomputeParameters PrecomputeParams;
    }
    internal unsafe struct AtmosphericFogComponent_methods {
        internal struct DisableGroundScattering_method {
            static internal IntPtr DisableGroundScattering_ptr;
            static DisableGroundScattering_method() {
                DisableGroundScattering_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "DisableGroundScattering");
            }

            internal static unsafe void Invoke(IntPtr obj, bool NewGroundScattering) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = NewGroundScattering;
                Main.GetProcessEvent(obj, DisableGroundScattering_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisableSunDisk_method {
            static internal IntPtr DisableSunDisk_ptr;
            static DisableSunDisk_method() {
                DisableSunDisk_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "DisableSunDisk");
            }

            internal static unsafe void Invoke(IntPtr obj, bool NewSunDisk) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = NewSunDisk;
                Main.GetProcessEvent(obj, DisableSunDisk_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAltitudeScale_method {
            static internal IntPtr SetAltitudeScale_ptr;
            static SetAltitudeScale_method() {
                SetAltitudeScale_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetAltitudeScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewAltitudeScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewAltitudeScale;
                Main.GetProcessEvent(obj, SetAltitudeScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDefaultBrightness_method {
            static internal IntPtr SetDefaultBrightness_ptr;
            static SetDefaultBrightness_method() {
                SetDefaultBrightness_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetDefaultBrightness");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewBrightness) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewBrightness;
                Main.GetProcessEvent(obj, SetDefaultBrightness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDefaultLightColor_method {
            static internal IntPtr SetDefaultLightColor_ptr;
            static SetDefaultLightColor_method() {
                SetDefaultLightColor_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetDefaultLightColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewLightColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewLightColor;
                Main.GetProcessEvent(obj, SetDefaultLightColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDensityMultiplier_method {
            static internal IntPtr SetDensityMultiplier_ptr;
            static SetDensityMultiplier_method() {
                SetDensityMultiplier_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetDensityMultiplier");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewDensityMultiplier) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewDensityMultiplier;
                Main.GetProcessEvent(obj, SetDensityMultiplier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDensityOffset_method {
            static internal IntPtr SetDensityOffset_ptr;
            static SetDensityOffset_method() {
                SetDensityOffset_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetDensityOffset");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewDensityOffset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewDensityOffset;
                Main.GetProcessEvent(obj, SetDensityOffset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDistanceOffset_method {
            static internal IntPtr SetDistanceOffset_ptr;
            static SetDistanceOffset_method() {
                SetDistanceOffset_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetDistanceOffset");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewDistanceOffset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewDistanceOffset;
                Main.GetProcessEvent(obj, SetDistanceOffset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDistanceScale_method {
            static internal IntPtr SetDistanceScale_ptr;
            static SetDistanceScale_method() {
                SetDistanceScale_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetDistanceScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewDistanceScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewDistanceScale;
                Main.GetProcessEvent(obj, SetDistanceScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFogMultiplier_method {
            static internal IntPtr SetFogMultiplier_ptr;
            static SetFogMultiplier_method() {
                SetFogMultiplier_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetFogMultiplier");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewFogMultiplier) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewFogMultiplier;
                Main.GetProcessEvent(obj, SetFogMultiplier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPrecomputeParams_method {
            static internal IntPtr SetPrecomputeParams_ptr;
            static SetPrecomputeParams_method() {
                SetPrecomputeParams_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetPrecomputeParams");
            }

            internal static unsafe void Invoke(IntPtr obj, float DensityHeight, int MaxScatteringOrder, int InscatterAltitudeSampleNum) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = DensityHeight;
                *((int*)(b+4)) = MaxScatteringOrder;
                *((int*)(b+8)) = InscatterAltitudeSampleNum;
                Main.GetProcessEvent(obj, SetPrecomputeParams_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartDistance_method {
            static internal IntPtr SetStartDistance_ptr;
            static SetStartDistance_method() {
                SetStartDistance_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetStartDistance");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewStartDistance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewStartDistance;
                Main.GetProcessEvent(obj, SetStartDistance_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSunMultiplier_method {
            static internal IntPtr SetSunMultiplier_ptr;
            static SetSunMultiplier_method() {
                SetSunMultiplier_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "SetSunMultiplier");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewSunMultiplier) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewSunMultiplier;
                Main.GetProcessEvent(obj, SetSunMultiplier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StartPrecompute_method {
            static internal IntPtr StartPrecompute_ptr;
            static StartPrecompute_method() {
                StartPrecompute_ptr = Main.GetMethodUFunction(AtmosphericFogComponent.StaticClass, "StartPrecompute");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StartPrecompute_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AtmosphericFogComponent_events {
    }
}
