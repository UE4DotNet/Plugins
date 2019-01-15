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
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct BTService_BlueprintBase_fields {
        [FieldOffset(136)]  public IntPtr  AIOwner;
        [FieldOffset(144)]  public IntPtr  ActorOwner;
        [FieldOffset(168)] public bool bShowPropertyDetails;
        [FieldOffset(168)] public bool bShowEventDetails;
    }
    internal unsafe struct BTService_BlueprintBase_methods {
        internal struct IsServiceActive_method {
            static internal IntPtr IsServiceActive_ptr;
            static IsServiceActive_method() {
                IsServiceActive_ptr = Main.GetMethodUFunction(BTService_BlueprintBase.StaticClass, "IsServiceActive");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsServiceActive_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct BTService_BlueprintBase_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveActivation_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActivation_link;
            private static unsafe void ReceiveActivation_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTService_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActivation(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveActivation_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActivation_process_event);
                var uf = Main.GetUFunction("ReceiveActivation");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActivation_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveActivationAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveActivationAI_link;
            private static unsafe void ReceiveActivationAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTService_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveActivationAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                ReceiveActivationAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveActivationAI_process_event);
                var uf = Main.GetUFunction("ReceiveActivationAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveActivationAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveDeactivation_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveDeactivation_link;
            private static unsafe void ReceiveDeactivation_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTService_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveDeactivation(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveDeactivation_link = new DelegateHolder<NativeFuncDelegate>(ReceiveDeactivation_process_event);
                var uf = Main.GetUFunction("ReceiveDeactivation");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveDeactivation_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveDeactivationAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveDeactivationAI_link;
            private static unsafe void ReceiveDeactivationAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTService_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveDeactivationAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                ReceiveDeactivationAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveDeactivationAI_process_event);
                var uf = Main.GetUFunction("ReceiveDeactivationAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveDeactivationAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveSearchStart_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveSearchStart_link;
            private static unsafe void ReceiveSearchStart_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTService_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveSearchStart(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveSearchStart_link = new DelegateHolder<NativeFuncDelegate>(ReceiveSearchStart_process_event);
                var uf = Main.GetUFunction("ReceiveSearchStart");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveSearchStart_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveSearchStartAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveSearchStartAI_link;
            private static unsafe void ReceiveSearchStartAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTService_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveSearchStartAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                ReceiveSearchStartAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveSearchStartAI_process_event);
                var uf = Main.GetUFunction("ReceiveSearchStartAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveSearchStartAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveTick_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveTick_link;
            private static unsafe void ReceiveTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTService_BlueprintBase>(context);
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
                var obj = UObject.Make<BTService_BlueprintBase>(context);
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
