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
    [StructLayout( LayoutKind.Explicit, Size=184 )]
    internal unsafe struct BTTask_BlueprintBase_fields {
        [FieldOffset(136)]  public IntPtr  AIOwner;
        [FieldOffset(144)]  public IntPtr  ActorOwner;
        [FieldOffset(176)] public bool bShowPropertyDetails;
    }
    internal unsafe struct BTTask_BlueprintBase_methods {
        internal struct FinishAbort_method {
            static internal IntPtr FinishAbort_ptr;
            static FinishAbort_method() {
                FinishAbort_ptr = Main.GetMethodUFunction(BTTask_BlueprintBase.StaticClass, "FinishAbort");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, FinishAbort_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FinishExecute_method {
            static internal IntPtr FinishExecute_ptr;
            static FinishExecute_method() {
                FinishExecute_ptr = Main.GetMethodUFunction(BTTask_BlueprintBase.StaticClass, "FinishExecute");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bSuccess) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bSuccess;
                Main.GetProcessEvent(obj, FinishExecute_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsTaskAborting_method {
            static internal IntPtr IsTaskAborting_ptr;
            static IsTaskAborting_method() {
                IsTaskAborting_ptr = Main.GetMethodUFunction(BTTask_BlueprintBase.StaticClass, "IsTaskAborting");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsTaskAborting_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsTaskExecuting_method {
            static internal IntPtr IsTaskExecuting_ptr;
            static IsTaskExecuting_method() {
                IsTaskExecuting_ptr = Main.GetMethodUFunction(BTTask_BlueprintBase.StaticClass, "IsTaskExecuting");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsTaskExecuting_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetFinishOnMessage_method {
            static internal IntPtr SetFinishOnMessage_ptr;
            static SetFinishOnMessage_method() {
                SetFinishOnMessage_ptr = Main.GetMethodUFunction(BTTask_BlueprintBase.StaticClass, "SetFinishOnMessage");
            }

            internal static unsafe void Invoke(IntPtr obj, Name MessageName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MessageName;
                Main.GetProcessEvent(obj, SetFinishOnMessage_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFinishOnMessageWithId_method {
            static internal IntPtr SetFinishOnMessageWithId_ptr;
            static SetFinishOnMessageWithId_method() {
                SetFinishOnMessageWithId_ptr = Main.GetMethodUFunction(BTTask_BlueprintBase.StaticClass, "SetFinishOnMessageWithId");
            }

            internal static unsafe void Invoke(IntPtr obj, Name MessageName, int RequestID) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = MessageName;
                *((int*)(b+12)) = RequestID;
                Main.GetProcessEvent(obj, SetFinishOnMessageWithId_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct BTTask_BlueprintBase_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveAbort_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveAbort_link;
            private static unsafe void ReceiveAbort_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTTask_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveAbort(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveAbort_link = new DelegateHolder<NativeFuncDelegate>(ReceiveAbort_process_event);
                var uf = Main.GetUFunction("ReceiveAbort");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveAbort_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveAbortAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveAbortAI_link;
            private static unsafe void ReceiveAbortAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTTask_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveAbortAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                ReceiveAbortAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveAbortAI_process_event);
                var uf = Main.GetUFunction("ReceiveAbortAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveAbortAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveExecute_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveExecute_link;
            private static unsafe void ReceiveExecute_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTTask_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveExecute(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveExecute_link = new DelegateHolder<NativeFuncDelegate>(ReceiveExecute_process_event);
                var uf = Main.GetUFunction("ReceiveExecute");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveExecute_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveExecuteAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveExecuteAI_link;
            private static unsafe void ReceiveExecuteAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTTask_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveExecuteAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                ReceiveExecuteAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveExecuteAI_process_event);
                var uf = Main.GetUFunction("ReceiveExecuteAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveExecuteAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveTick_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveTick_link;
            private static unsafe void ReceiveTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTTask_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveTick(UObject.Make<Actor>(*(IntPtr*)(b+0)), *(float*)(b+8));
            }
            internal static void Setup() {
                ReceiveTick_link = new DelegateHolder<NativeFuncDelegate>(ReceiveTick_process_event);
                var uf = Main.GetUFunction("ReceiveTick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveTick_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct ReceiveTickAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveTickAI_link;
            private static unsafe void ReceiveTickAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTTask_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveTickAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)), *(float*)(b+16));
            }
            internal static void Setup() {
                ReceiveTickAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveTickAI_process_event);
                var uf = Main.GetUFunction("ReceiveTickAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveTickAI_link.Delegate));
            }
        }
    }
}
