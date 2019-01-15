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


namespace UE4.AudioMixer.Native {
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct SubmixEffectDynamicsProcessorPreset_fields {
        [FieldOffset(160)] public SubmixEffectDynamicsProcessorSettings Settings;
    }
    internal unsafe struct SubmixEffectDynamicsProcessorPreset_methods {
        internal struct SetSettings_method {
            static internal IntPtr SetSettings_ptr;
            static SetSettings_method() {
                SetSettings_ptr = Main.GetMethodUFunction(SubmixEffectDynamicsProcessorPreset.StaticClass, "SetSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, SubmixEffectDynamicsProcessorSettings InSettings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SubmixEffectDynamicsProcessorSettings*)(b+0)) = InSettings;
                Main.GetProcessEvent(obj, SetSettings_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SubmixEffectDynamicsProcessorPreset_events {
    }
}
