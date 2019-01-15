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
    [StructLayout( LayoutKind.Explicit, Size=1152 )]
    internal unsafe struct AudioVolume_fields {
        [FieldOffset(1072)] public float Priority;
        [FieldOffset(1076)] public bool bEnabled;
        [FieldOffset(1080)] public ReverbSettings Settings;
        [FieldOffset(1112)] public InteriorSettings AmbientZoneSettings;
    }
    internal unsafe struct AudioVolume_methods {
        internal struct SetEnabled_method {
            static internal IntPtr SetEnabled_ptr;
            static SetEnabled_method() {
                SetEnabled_ptr = Main.GetMethodUFunction(AudioVolume.StaticClass, "SetEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewEnabled;
                Main.GetProcessEvent(obj, SetEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInteriorSettings_method {
            static internal IntPtr SetInteriorSettings_ptr;
            static SetInteriorSettings_method() {
                SetInteriorSettings_ptr = Main.GetMethodUFunction(AudioVolume.StaticClass, "SetInteriorSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, InteriorSettings NewInteriorSettings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((InteriorSettings*)(b+0)) = NewInteriorSettings;
                Main.GetProcessEvent(obj, SetInteriorSettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPriority_method {
            static internal IntPtr SetPriority_ptr;
            static SetPriority_method() {
                SetPriority_ptr = Main.GetMethodUFunction(AudioVolume.StaticClass, "SetPriority");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPriority) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPriority;
                Main.GetProcessEvent(obj, SetPriority_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetReverbSettings_method {
            static internal IntPtr SetReverbSettings_ptr;
            static SetReverbSettings_method() {
                SetReverbSettings_ptr = Main.GetMethodUFunction(AudioVolume.StaticClass, "SetReverbSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, ReverbSettings NewReverbSettings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((ReverbSettings*)(b+0)) = NewReverbSettings;
                Main.GetProcessEvent(obj, SetReverbSettings_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AudioVolume_events {
    }
}
