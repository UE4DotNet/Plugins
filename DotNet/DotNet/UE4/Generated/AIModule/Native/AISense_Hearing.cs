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

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=256 )]
    internal unsafe struct AISense_Hearing_fields {
        [FieldOffset(152)] public NativeArray NoiseEvents;
        [FieldOffset(168)] public float SpeedOfSoundSq;
    }
    internal unsafe struct AISense_Hearing_methods {
        internal struct ReportNoiseEvent_method {
            static internal IntPtr ReportNoiseEvent_ptr;
            static ReportNoiseEvent_method() {
                ReportNoiseEvent_ptr = Main.GetMethodUFunction(AISense_Hearing.StaticClass, "ReportNoiseEvent");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector NoiseLocation, float Loudness, Actor Instigator, float MaxRange, Name Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = NoiseLocation;
                *((float*)(b+20)) = Loudness;
                *((IntPtr*)(b+24)) = Instigator;
                *((float*)(b+32)) = MaxRange;
                *((Name*)(b+36)) = Tag;
                Main.GetProcessEvent(AISense_Hearing.DefaultObject, ReportNoiseEvent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AISense_Hearing_events {
    }
}
