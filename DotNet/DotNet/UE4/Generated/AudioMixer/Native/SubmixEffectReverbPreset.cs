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

using UE4.Engine;

namespace UE4.AudioMixer.Native {
    [StructLayout( LayoutKind.Explicit, Size=216 )]
    internal unsafe struct SubmixEffectReverbPreset_fields {
        [FieldOffset(168)] public SubmixEffectReverbSettings Settings;
    }
    internal unsafe struct SubmixEffectReverbPreset_methods {
        internal struct SetSettings_method {
            static internal IntPtr SetSettings_ptr;
            static SetSettings_method() {
                SetSettings_ptr = Main.GetMethodUFunction(SubmixEffectReverbPreset.StaticClass, "SetSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, SubmixEffectReverbSettings InSettings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SubmixEffectReverbSettings*)(b+0)) = InSettings;
                Main.GetProcessEvent(obj, SetSettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSettingsWithReverbEffect_method {
            static internal IntPtr SetSettingsWithReverbEffect_ptr;
            static SetSettingsWithReverbEffect_method() {
                SetSettingsWithReverbEffect_ptr = Main.GetMethodUFunction(SubmixEffectReverbPreset.StaticClass, "SetSettingsWithReverbEffect");
            }

            internal static unsafe void Invoke(IntPtr obj, ReverbEffect InReverbEffect, float WetLevel) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InReverbEffect;
                *((float*)(b+8)) = WetLevel;
                Main.GetProcessEvent(obj, SetSettingsWithReverbEffect_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SubmixEffectReverbPreset_events {
    }
}
