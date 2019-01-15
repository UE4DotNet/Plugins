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
    [StructLayout( LayoutKind.Explicit, Size=320 )]
    internal unsafe struct AIPerceptionSystem_fields {
        [FieldOffset(144)] public NativeArray Senses;
        [FieldOffset(160)] public float PerceptionAgingRate;
    }
    internal unsafe struct AIPerceptionSystem_methods {
        internal struct GetSenseClassForStimulus_method {
            static internal IntPtr GetSenseClassForStimulus_ptr;
            static GetSenseClassForStimulus_method() {
                GetSenseClassForStimulus_ptr = Main.GetMethodUFunction(AIPerceptionSystem.StaticClass, "GetSenseClassForStimulus");
            }

            internal static unsafe SubclassOf<AISense> Invoke(UObject WorldContextObject, AIStimulus Stimulus) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((AIStimulus*)(b+8)) = Stimulus;
                Main.GetProcessEvent(AIPerceptionSystem.DefaultObject, GetSenseClassForStimulus_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+80));
            }
        }
        internal struct RegisterPerceptionStimuliSource_method {
            static internal IntPtr RegisterPerceptionStimuliSource_ptr;
            static RegisterPerceptionStimuliSource_method() {
                RegisterPerceptionStimuliSource_ptr = Main.GetMethodUFunction(AIPerceptionSystem.StaticClass, "RegisterPerceptionStimuliSource");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, SubclassOf<AISense> Sense, Actor Target) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = Sense;
                *((IntPtr*)(b+16)) = Target;
                Main.GetProcessEvent(AIPerceptionSystem.DefaultObject, RegisterPerceptionStimuliSource_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct ReportEvent_method {
            static internal IntPtr ReportEvent_ptr;
            static ReportEvent_method() {
                ReportEvent_ptr = Main.GetMethodUFunction(AIPerceptionSystem.StaticClass, "ReportEvent");
            }

            internal static unsafe void Invoke(IntPtr obj, AISenseEvent PerceptionEvent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PerceptionEvent;
                Main.GetProcessEvent(obj, ReportEvent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ReportPerceptionEvent_method {
            static internal IntPtr ReportPerceptionEvent_ptr;
            static ReportPerceptionEvent_method() {
                ReportPerceptionEvent_ptr = Main.GetMethodUFunction(AIPerceptionSystem.StaticClass, "ReportPerceptionEvent");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, AISenseEvent PerceptionEvent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PerceptionEvent;
                Main.GetProcessEvent(AIPerceptionSystem.DefaultObject, ReportPerceptionEvent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AIPerceptionSystem_events {
    }
}
