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
    [StructLayout( LayoutKind.Explicit, Size=1016 )]
    internal unsafe struct AmbientSound_fields {
        [FieldOffset(1008)]  public IntPtr  AudioComponent;
    }
    internal unsafe struct AmbientSound_methods {
        internal struct AdjustVolume_method {
            static internal IntPtr AdjustVolume_ptr;
            static AdjustVolume_method() {
                AdjustVolume_ptr = Main.GetMethodUFunction(AmbientSound.StaticClass, "AdjustVolume");
            }

            internal static unsafe void Invoke(IntPtr obj, float AdjustVolumeDuration, float AdjustVolumeLevel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = AdjustVolumeDuration;
                *((float*)(b+4)) = AdjustVolumeLevel;
                Main.GetProcessEvent(obj, AdjustVolume_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FadeIn_method {
            static internal IntPtr FadeIn_ptr;
            static FadeIn_method() {
                FadeIn_ptr = Main.GetMethodUFunction(AmbientSound.StaticClass, "FadeIn");
            }

            internal static unsafe void Invoke(IntPtr obj, float FadeInDuration, float FadeVolumeLevel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = FadeInDuration;
                *((float*)(b+4)) = FadeVolumeLevel;
                Main.GetProcessEvent(obj, FadeIn_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FadeOut_method {
            static internal IntPtr FadeOut_ptr;
            static FadeOut_method() {
                FadeOut_ptr = Main.GetMethodUFunction(AmbientSound.StaticClass, "FadeOut");
            }

            internal static unsafe void Invoke(IntPtr obj, float FadeOutDuration, float FadeVolumeLevel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = FadeOutDuration;
                *((float*)(b+4)) = FadeVolumeLevel;
                Main.GetProcessEvent(obj, FadeOut_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Play_method {
            static internal IntPtr Play_ptr;
            static Play_method() {
                Play_ptr = Main.GetMethodUFunction(AmbientSound.StaticClass, "Play");
            }

            internal static unsafe void Invoke(IntPtr obj, float StartTime) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = StartTime;
                Main.GetProcessEvent(obj, Play_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(AmbientSound.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AmbientSound_events {
    }
}
