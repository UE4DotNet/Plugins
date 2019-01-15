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
    [StructLayout( LayoutKind.Explicit, Size=1224 )]
    internal unsafe struct PlayerState_fields {
        [FieldOffset(1016)] public float Score;
        [FieldOffset(1020)] public byte Ping;
        [FieldOffset(1024)] byte PlayerName; //TODO: string FString PlayerName
        [FieldOffset(1056)] public int PlayerId;
        [FieldOffset(1060)] public bool bIsSpectator;
        [FieldOffset(1060)] public bool bOnlySpectator;
        [FieldOffset(1060)] public bool bIsABot;
        [FieldOffset(1060)] public bool bIsInactive;
        [FieldOffset(1060)] public bool bFromPreviousLevel;
        [FieldOffset(1064)] public int StartTime;
        [FieldOffset(1072)] public IntPtr EngineMessageClass;
        [FieldOffset(1088)] byte SavedNetworkAddress; //TODO: string FString SavedNetworkAddress
        [FieldOffset(1104)] public UniqueNetIdRepl UniqueId;
        [FieldOffset(1184)] byte PlayerNamePrivate; //TODO: string FString PlayerNamePrivate
        [FieldOffset(1216)] public bool bShouldUpdateReplicatedPing;
    }
    internal unsafe struct PlayerState_methods {
        internal struct GetPlayerName_method {
            static internal IntPtr GetPlayerName_ptr;
            static GetPlayerName_method() {
                GetPlayerName_ptr = Main.GetMethodUFunction(PlayerState.StaticClass, "GetPlayerName");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayerName_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
    }
    internal unsafe struct PlayerState_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveCopyProperties_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveCopyProperties_link;
            private static unsafe void ReceiveCopyProperties_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PlayerState>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveCopyProperties(UObject.Make<PlayerState>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveCopyProperties_link = new DelegateHolder<NativeFuncDelegate>(ReceiveCopyProperties_process_event);
                var uf = Main.GetUFunction("ReceiveCopyProperties");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveCopyProperties_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveOverrideWith_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveOverrideWith_link;
            private static unsafe void ReceiveOverrideWith_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PlayerState>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveOverrideWith(UObject.Make<PlayerState>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveOverrideWith_link = new DelegateHolder<NativeFuncDelegate>(ReceiveOverrideWith_process_event);
                var uf = Main.GetUFunction("ReceiveOverrideWith");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveOverrideWith_link.Delegate));
            }
        }
    }
}
