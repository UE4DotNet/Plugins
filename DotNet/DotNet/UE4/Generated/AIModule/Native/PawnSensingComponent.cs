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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=328 )]
    internal unsafe struct PawnSensingComponent_fields {
        [FieldOffset(256)] public float HearingThreshold;
        [FieldOffset(260)] public float LOSHearingThreshold;
        [FieldOffset(264)] public float SightRadius;
        [FieldOffset(268)] public float SensingInterval;
        [FieldOffset(272)] public float HearingMaxSoundAge;
        [FieldOffset(276)] public bool bEnableSensingUpdates;
        [FieldOffset(276)] public bool bOnlySensePlayers;
        [FieldOffset(276)] public bool bSeePawns;
        [FieldOffset(276)] public bool bHearNoises;
        [FieldOffset(288)] byte OnSeePawn; //TODO: multicast delegate FSeePawnDelegate OnSeePawn
        [FieldOffset(304)] byte OnHearNoise; //TODO: multicast delegate FHearNoiseDelegate OnHearNoise
        [FieldOffset(320)] public float PeripheralVisionAngle;
        [FieldOffset(324)] public float PeripheralVisionCosine;
    }
    internal unsafe struct PawnSensingComponent_methods {
        internal struct GetPeripheralVisionAngle_method {
            static internal IntPtr GetPeripheralVisionAngle_ptr;
            static GetPeripheralVisionAngle_method() {
                GetPeripheralVisionAngle_ptr = Main.GetMethodUFunction(PawnSensingComponent.StaticClass, "GetPeripheralVisionAngle");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPeripheralVisionAngle_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPeripheralVisionCosine_method {
            static internal IntPtr GetPeripheralVisionCosine_ptr;
            static GetPeripheralVisionCosine_method() {
                GetPeripheralVisionCosine_ptr = Main.GetMethodUFunction(PawnSensingComponent.StaticClass, "GetPeripheralVisionCosine");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPeripheralVisionCosine_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct SetPeripheralVisionAngle_method {
            static internal IntPtr SetPeripheralVisionAngle_ptr;
            static SetPeripheralVisionAngle_method() {
                SetPeripheralVisionAngle_ptr = Main.GetMethodUFunction(PawnSensingComponent.StaticClass, "SetPeripheralVisionAngle");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPeripheralVisionAngle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPeripheralVisionAngle;
                Main.GetProcessEvent(obj, SetPeripheralVisionAngle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSensingInterval_method {
            static internal IntPtr SetSensingInterval_ptr;
            static SetSensingInterval_method() {
                SetSensingInterval_ptr = Main.GetMethodUFunction(PawnSensingComponent.StaticClass, "SetSensingInterval");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewSensingInterval) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewSensingInterval;
                Main.GetProcessEvent(obj, SetSensingInterval_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSensingUpdatesEnabled_method {
            static internal IntPtr SetSensingUpdatesEnabled_ptr;
            static SetSensingUpdatesEnabled_method() {
                SetSensingUpdatesEnabled_ptr = Main.GetMethodUFunction(PawnSensingComponent.StaticClass, "SetSensingUpdatesEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnabled;
                Main.GetProcessEvent(obj, SetSensingUpdatesEnabled_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PawnSensingComponent_events {
    }
}
