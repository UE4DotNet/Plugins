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
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct AISense_Damage_fields {
        [FieldOffset(152)] public NativeArray RegisteredEvents;
    }
    internal unsafe struct AISense_Damage_methods {
        internal struct ReportDamageEvent_method {
            static internal IntPtr ReportDamageEvent_ptr;
            static ReportDamageEvent_method() {
                ReportDamageEvent_ptr = Main.GetMethodUFunction(AISense_Damage.StaticClass, "ReportDamageEvent");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Actor DamagedActor, Actor Instigator, float DamageAmount, Vector EventLocation, Vector HitLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = DamagedActor;
                *((IntPtr*)(b+16)) = Instigator;
                *((float*)(b+24)) = DamageAmount;
                *((Vector*)(b+28)) = EventLocation;
                *((Vector*)(b+40)) = HitLocation;
                Main.GetProcessEvent(AISense_Damage.DefaultObject, ReportDamageEvent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AISense_Damage_events {
    }
}
