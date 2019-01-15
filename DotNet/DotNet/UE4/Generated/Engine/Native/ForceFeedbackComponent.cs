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
    internal unsafe struct ForceFeedbackComponent_fields {
        [FieldOffset(624)]  public IntPtr  ForceFeedbackEffect;
        [FieldOffset(632)] public bool bAutoDestroy;
        [FieldOffset(632)] public bool bStopWhenOwnerDestroyed;
        [FieldOffset(632)] public bool bLooping;
        [FieldOffset(632)] public bool bIgnoreTimeDilation;
        [FieldOffset(632)] public bool bOverrideAttenuation;
        [FieldOffset(636)] public float IntensityMultiplier;
        [FieldOffset(640)]  public IntPtr  AttenuationSettings;
        [FieldOffset(648)] public ForceFeedbackAttenuationSettings AttenuationOverrides;
        [FieldOffset(808)] byte OnForceFeedbackFinished; //TODO: multicast delegate FOnForceFeedbackFinished OnForceFeedbackFinished
    }
    internal unsafe struct ForceFeedbackComponent_methods {
        internal struct AdjustAttenuation_method {
            static internal IntPtr AdjustAttenuation_ptr;
            static AdjustAttenuation_method() {
                AdjustAttenuation_ptr = Main.GetMethodUFunction(ForceFeedbackComponent.StaticClass, "AdjustAttenuation");
            }

            internal static unsafe void Invoke(IntPtr obj, ForceFeedbackAttenuationSettings InAttenuationSettings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((ForceFeedbackAttenuationSettings*)(b+0)) = InAttenuationSettings;
                Main.GetProcessEvent(obj, AdjustAttenuation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BP_GetAttenuationSettingsToApply_method {
            static internal IntPtr BP_GetAttenuationSettingsToApply_ptr;
            static BP_GetAttenuationSettingsToApply_method() {
                BP_GetAttenuationSettingsToApply_ptr = Main.GetMethodUFunction(ForceFeedbackComponent.StaticClass, "BP_GetAttenuationSettingsToApply");
            }

            internal static unsafe (ForceFeedbackAttenuationSettings, bool) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_GetAttenuationSettingsToApply_ptr, new IntPtr(p)); ;
                return (*((ForceFeedbackAttenuationSettings*)(b+0)),*((bool*)(b+160)));
            }
        }
        internal struct Play_method {
            static internal IntPtr Play_ptr;
            static Play_method() {
                Play_ptr = Main.GetMethodUFunction(ForceFeedbackComponent.StaticClass, "Play");
            }

            internal static unsafe void Invoke(IntPtr obj, float StartTime) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = StartTime;
                Main.GetProcessEvent(obj, Play_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetForceFeedbackEffect_method {
            static internal IntPtr SetForceFeedbackEffect_ptr;
            static SetForceFeedbackEffect_method() {
                SetForceFeedbackEffect_ptr = Main.GetMethodUFunction(ForceFeedbackComponent.StaticClass, "SetForceFeedbackEffect");
            }

            internal static unsafe void Invoke(IntPtr obj, ForceFeedbackEffect NewForceFeedbackEffect) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewForceFeedbackEffect;
                Main.GetProcessEvent(obj, SetForceFeedbackEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIntensityMultiplier_method {
            static internal IntPtr SetIntensityMultiplier_ptr;
            static SetIntensityMultiplier_method() {
                SetIntensityMultiplier_ptr = Main.GetMethodUFunction(ForceFeedbackComponent.StaticClass, "SetIntensityMultiplier");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewIntensityMultiplier) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewIntensityMultiplier;
                Main.GetProcessEvent(obj, SetIntensityMultiplier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(ForceFeedbackComponent.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ForceFeedbackComponent_events {
    }
}
