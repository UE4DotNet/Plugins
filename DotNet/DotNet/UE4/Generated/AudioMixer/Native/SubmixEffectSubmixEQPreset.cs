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
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct SubmixEffectSubmixEQPreset_fields {
        [FieldOffset(136)] public SubmixEffectSubmixEQSettings Settings;
    }
    internal unsafe struct SubmixEffectSubmixEQPreset_methods {
        internal struct SetSettings_method {
            static internal IntPtr SetSettings_ptr;
            static SetSettings_method() {
                SetSettings_ptr = Main.GetMethodUFunction(SubmixEffectSubmixEQPreset.StaticClass, "SetSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, SubmixEffectSubmixEQSettings InSettings) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((SubmixEffectSubmixEQSettings*)(b+0)) = InSettings;
                Main.GetProcessEvent(obj, SetSettings_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SubmixEffectSubmixEQPreset_events {
    }
}
