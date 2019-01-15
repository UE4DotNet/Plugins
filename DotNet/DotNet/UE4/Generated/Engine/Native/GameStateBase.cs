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
    [StructLayout( LayoutKind.Explicit, Size=1080 )]
    internal unsafe struct GameStateBase_fields {
        [FieldOffset(1016)] public IntPtr GameModeClass;
        [FieldOffset(1024)]  public IntPtr  AuthorityGameMode;
        [FieldOffset(1032)] public IntPtr SpectatorClass;
        [FieldOffset(1040)] public NativeArray PlayerArray;
        [FieldOffset(1056)] public bool bReplicatedHasBegunPlay;
        [FieldOffset(1060)] public float ReplicatedWorldTimeSeconds;
        [FieldOffset(1064)] public float ServerWorldTimeSecondsDelta;
        [FieldOffset(1068)] public float ServerWorldTimeSecondsUpdateFrequency;
    }
    internal unsafe struct GameStateBase_methods {
        internal struct GetPlayerRespawnDelay_method {
            static internal IntPtr GetPlayerRespawnDelay_ptr;
            static GetPlayerRespawnDelay_method() {
                GetPlayerRespawnDelay_ptr = Main.GetMethodUFunction(GameStateBase.StaticClass, "GetPlayerRespawnDelay");
            }

            internal static unsafe float Invoke(IntPtr obj, Controller Controller) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                Main.GetProcessEvent(obj, GetPlayerRespawnDelay_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetPlayerStartTime_method {
            static internal IntPtr GetPlayerStartTime_ptr;
            static GetPlayerStartTime_method() {
                GetPlayerStartTime_ptr = Main.GetMethodUFunction(GameStateBase.StaticClass, "GetPlayerStartTime");
            }

            internal static unsafe float Invoke(IntPtr obj, Controller Controller) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                Main.GetProcessEvent(obj, GetPlayerStartTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetServerWorldTimeSeconds_method {
            static internal IntPtr GetServerWorldTimeSeconds_ptr;
            static GetServerWorldTimeSeconds_method() {
                GetServerWorldTimeSeconds_ptr = Main.GetMethodUFunction(GameStateBase.StaticClass, "GetServerWorldTimeSeconds");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetServerWorldTimeSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct HasBegunPlay_method {
            static internal IntPtr HasBegunPlay_ptr;
            static HasBegunPlay_method() {
                HasBegunPlay_ptr = Main.GetMethodUFunction(GameStateBase.StaticClass, "HasBegunPlay");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasBegunPlay_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HasMatchStarted_method {
            static internal IntPtr HasMatchStarted_ptr;
            static HasMatchStarted_method() {
                HasMatchStarted_ptr = Main.GetMethodUFunction(GameStateBase.StaticClass, "HasMatchStarted");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasMatchStarted_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct GameStateBase_events {
    }
}
