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


namespace UE4.OnlineSubsystem.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct TurnBasedMatchInterface_fields {
    }
    internal unsafe struct TurnBasedMatchInterface_methods {
    }
    internal unsafe struct TurnBasedMatchInterface_events {
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct OnMatchEnded_event {
            private static DelegateHolder<NativeFuncDelegate> OnMatchEnded_link;
            private static unsafe void OnMatchEnded_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<TurnBasedMatchInterface>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMatchEnded(FString.Get(b+0));
            }
            internal static void Setup() {
                OnMatchEnded_link = new DelegateHolder<NativeFuncDelegate>(OnMatchEnded_process_event);
                var uf = Main.GetUFunction("OnMatchEnded");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMatchEnded_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct OnMatchReceivedTurn_event {
            private static DelegateHolder<NativeFuncDelegate> OnMatchReceivedTurn_link;
            private static unsafe void OnMatchReceivedTurn_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<TurnBasedMatchInterface>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMatchReceivedTurn(FString.Get(b+0), *(bool*)(b+16));
            }
            internal static void Setup() {
                OnMatchReceivedTurn_link = new DelegateHolder<NativeFuncDelegate>(OnMatchReceivedTurn_process_event);
                var uf = Main.GetUFunction("OnMatchReceivedTurn");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMatchReceivedTurn_link.Delegate));
            }
        }
    }
}
