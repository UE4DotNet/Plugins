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
    [StructLayout( LayoutKind.Explicit, Size=1256 )]
    internal unsafe struct GameMode_fields {
        [FieldOffset(1176)] public Name MatchState;
        [FieldOffset(1188)] public bool bDelayedStart;
        [FieldOffset(1192)] public int NumSpectators;
        [FieldOffset(1196)] public int NumPlayers;
        [FieldOffset(1200)] public int NumBots;
        [FieldOffset(1204)] public float MinRespawnDelay;
        [FieldOffset(1208)] public int NumTravellingPlayers;
        [FieldOffset(1216)] public IntPtr EngineMessageClass;
        [FieldOffset(1224)] public NativeArray InactivePlayerArray;
        [FieldOffset(1240)] public float InactivePlayerStateLifeSpan;
        [FieldOffset(1244)] public int MaxInactivePlayers;
        [FieldOffset(1248)] public bool bHandleDedicatedServerReplays;
    }
    internal unsafe struct GameMode_methods {
        internal struct AbortMatch_method {
            static internal IntPtr AbortMatch_ptr;
            static AbortMatch_method() {
                AbortMatch_ptr = Main.GetMethodUFunction(GameMode.StaticClass, "AbortMatch");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, AbortMatch_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EndMatch_method {
            static internal IntPtr EndMatch_ptr;
            static EndMatch_method() {
                EndMatch_ptr = Main.GetMethodUFunction(GameMode.StaticClass, "EndMatch");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EndMatch_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetMatchState_method {
            static internal IntPtr GetMatchState_ptr;
            static GetMatchState_method() {
                GetMatchState_ptr = Main.GetMethodUFunction(GameMode.StaticClass, "GetMatchState");
            }

            internal static unsafe Name Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMatchState_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct HasMatchEnded_method {
            static internal IntPtr HasMatchEnded_ptr;
            static HasMatchEnded_method() {
                HasMatchEnded_ptr = Main.GetMethodUFunction(GameMode.StaticClass, "HasMatchEnded");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasMatchEnded_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsMatchInProgress_method {
            static internal IntPtr IsMatchInProgress_ptr;
            static IsMatchInProgress_method() {
                IsMatchInProgress_ptr = Main.GetMethodUFunction(GameMode.StaticClass, "IsMatchInProgress");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsMatchInProgress_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct RestartGame_method {
            static internal IntPtr RestartGame_ptr;
            static RestartGame_method() {
                RestartGame_ptr = Main.GetMethodUFunction(GameMode.StaticClass, "RestartGame");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RestartGame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Say_method {
            static internal IntPtr Say_ptr;
            static Say_method() {
                Say_ptr = Main.GetMethodUFunction(GameMode.StaticClass, "Say");
            }

            internal static unsafe void Invoke(IntPtr obj, string Msg) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var Msg_handle = GCHandle.Alloc(Msg, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Msg_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Msg.Length;
                *(int*)(b+IntPtr.Size+4+0) = Msg.Length;
                Main.GetProcessEvent(obj, Say_ptr, new IntPtr(p)); ;
                Msg_handle.Free();
            }
        }
        internal struct StartMatch_method {
            static internal IntPtr StartMatch_ptr;
            static StartMatch_method() {
                StartMatch_ptr = Main.GetMethodUFunction(GameMode.StaticClass, "StartMatch");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StartMatch_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct GameMode_events {
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        internal unsafe struct K2_OnSetMatchState_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnSetMatchState_link;
            private static unsafe void K2_OnSetMatchState_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameMode>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnSetMatchState(*(Name*)(b+0));
            }
            internal static void Setup() {
                K2_OnSetMatchState_link = new DelegateHolder<NativeFuncDelegate>(K2_OnSetMatchState_process_event);
                var uf = Main.GetUFunction("K2_OnSetMatchState");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnSetMatchState_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReadyToEndMatch_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> ReadyToEndMatch_link;
            private static unsafe void ReadyToEndMatch_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameMode>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_ReadyToEndMatch(*(bool*)result);
            }
            internal static void Setup() {
                ReadyToEndMatch_link = new DelegateHolder<NativeFuncDelegate>(ReadyToEndMatch_process_event);
                var uf = Main.GetUFunction("ReadyToEndMatch");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReadyToEndMatch_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReadyToStartMatch_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> ReadyToStartMatch_link;
            private static unsafe void ReadyToStartMatch_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameMode>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_ReadyToStartMatch(*(bool*)result);
            }
            internal static void Setup() {
                ReadyToStartMatch_link = new DelegateHolder<NativeFuncDelegate>(ReadyToStartMatch_process_event);
                var uf = Main.GetUFunction("ReadyToStartMatch");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReadyToStartMatch_link.Delegate));
            }
        }
    }
}
