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
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct GameInstance_fields {
        [FieldOffset(72)] public NativeArray LocalPlayers;
        [FieldOffset(88)]  public IntPtr  OnlineSession;
        [FieldOffset(96)] public NativeArray ReferencedObjects;
    }
    internal unsafe struct GameInstance_methods {
    }
    internal unsafe struct GameInstance_events {
        [StructLayout( LayoutKind.Explicit, Size=2 )]
        internal unsafe struct HandleNetworkError_event {
            private static DelegateHolder<NativeFuncDelegate> HandleNetworkError_link;
            private static unsafe void HandleNetworkError_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_HandleNetworkError(*(b+0), *(bool*)(b+1));
            }
            internal static void Setup() {
                HandleNetworkError_link = new DelegateHolder<NativeFuncDelegate>(HandleNetworkError_process_event);
                var uf = Main.GetUFunction("HandleNetworkError");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(HandleNetworkError_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct HandleTravelError_event {
            private static DelegateHolder<NativeFuncDelegate> HandleTravelError_link;
            private static unsafe void HandleTravelError_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_HandleTravelError(*(b+0));
            }
            internal static void Setup() {
                HandleTravelError_link = new DelegateHolder<NativeFuncDelegate>(HandleTravelError_process_event);
                var uf = Main.GetUFunction("HandleTravelError");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(HandleTravelError_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveInit_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveInit_link;
            private static unsafe void ReceiveInit_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveInit();
            }
            internal static void Setup() {
                ReceiveInit_link = new DelegateHolder<NativeFuncDelegate>(ReceiveInit_process_event);
                var uf = Main.GetUFunction("ReceiveInit");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveInit_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct ReceiveShutdown_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveShutdown_link;
            private static unsafe void ReceiveShutdown_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveShutdown();
            }
            internal static void Setup() {
                ReceiveShutdown_link = new DelegateHolder<NativeFuncDelegate>(ReceiveShutdown_process_event);
                var uf = Main.GetUFunction("ReceiveShutdown");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveShutdown_link.Delegate));
            }
        }
    }
}
