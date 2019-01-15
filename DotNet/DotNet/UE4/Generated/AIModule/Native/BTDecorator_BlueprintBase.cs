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
    internal unsafe struct BTDecorator_BlueprintBase_fields {
        [FieldOffset(128)]  public IntPtr  AIOwner;
        [FieldOffset(136)]  public IntPtr  ActorOwner;
        [FieldOffset(144)] public NativeArray ObservedKeyNames;
        [FieldOffset(176)] public bool bShowPropertyDetails;
        [FieldOffset(176)] public bool bCheckConditionOnlyBlackBoardChanges;
        [FieldOffset(176)] public bool bIsObservingBB;
    }
    internal unsafe struct BTDecorator_BlueprintBase_methods {
        internal struct IsDecoratorExecutionActive_method {
            static internal IntPtr IsDecoratorExecutionActive_ptr;
            static IsDecoratorExecutionActive_method() {
                IsDecoratorExecutionActive_ptr = Main.GetMethodUFunction(BTDecorator_BlueprintBase.StaticClass, "IsDecoratorExecutionActive");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsDecoratorExecutionActive_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsDecoratorObserverActive_method {
            static internal IntPtr IsDecoratorObserverActive_ptr;
            static IsDecoratorObserverActive_method() {
                IsDecoratorObserverActive_ptr = Main.GetMethodUFunction(BTDecorator_BlueprintBase.StaticClass, "IsDecoratorObserverActive");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsDecoratorObserverActive_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct BTDecorator_BlueprintBase_events {
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct PerformConditionCheck_event {
            private static DelegateHolder<NativeFuncDelegate> PerformConditionCheck_link;
            private static unsafe void PerformConditionCheck_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_PerformConditionCheck(UObject.Make<Actor>(*(IntPtr*)(b+0)), *(bool*)(b+8));
            }
            internal static void Setup() {
                PerformConditionCheck_link = new DelegateHolder<NativeFuncDelegate>(PerformConditionCheck_process_event);
                var uf = Main.GetUFunction("PerformConditionCheck");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(PerformConditionCheck_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct PerformConditionCheckAI_event {
            private static DelegateHolder<NativeFuncDelegate> PerformConditionCheckAI_link;
            private static unsafe void PerformConditionCheckAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_PerformConditionCheckAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)), *(bool*)(b+16));
            }
            internal static void Setup() {
                PerformConditionCheckAI_link = new DelegateHolder<NativeFuncDelegate>(PerformConditionCheckAI_process_event);
                var uf = Main.GetUFunction("PerformConditionCheckAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(PerformConditionCheckAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveExecutionFinish_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveExecutionFinish_link;
            private static unsafe void ReceiveExecutionFinish_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveExecutionFinish(UObject.Make<Actor>(*(IntPtr*)(b+0)), *(b+8));
            }
            internal static void Setup() {
                ReceiveExecutionFinish_link = new DelegateHolder<NativeFuncDelegate>(ReceiveExecutionFinish_process_event);
                var uf = Main.GetUFunction("ReceiveExecutionFinish");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveExecutionFinish_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct ReceiveExecutionFinishAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveExecutionFinishAI_link;
            private static unsafe void ReceiveExecutionFinishAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveExecutionFinishAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)), *(b+16));
            }
            internal static void Setup() {
                ReceiveExecutionFinishAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveExecutionFinishAI_process_event);
                var uf = Main.GetUFunction("ReceiveExecutionFinishAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveExecutionFinishAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveExecutionStart_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveExecutionStart_link;
            private static unsafe void ReceiveExecutionStart_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveExecutionStart(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveExecutionStart_link = new DelegateHolder<NativeFuncDelegate>(ReceiveExecutionStart_process_event);
                var uf = Main.GetUFunction("ReceiveExecutionStart");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveExecutionStart_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveExecutionStartAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveExecutionStartAI_link;
            private static unsafe void ReceiveExecutionStartAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveExecutionStartAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                ReceiveExecutionStartAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveExecutionStartAI_process_event);
                var uf = Main.GetUFunction("ReceiveExecutionStartAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveExecutionStartAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveObserverActivated_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveObserverActivated_link;
            private static unsafe void ReceiveObserverActivated_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveObserverActivated(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveObserverActivated_link = new DelegateHolder<NativeFuncDelegate>(ReceiveObserverActivated_process_event);
                var uf = Main.GetUFunction("ReceiveObserverActivated");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveObserverActivated_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveObserverActivatedAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveObserverActivatedAI_link;
            private static unsafe void ReceiveObserverActivatedAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveObserverActivatedAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                ReceiveObserverActivatedAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveObserverActivatedAI_process_event);
                var uf = Main.GetUFunction("ReceiveObserverActivatedAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveObserverActivatedAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveObserverDeactivated_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveObserverDeactivated_link;
            private static unsafe void ReceiveObserverDeactivated_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveObserverDeactivated(UObject.Make<Actor>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveObserverDeactivated_link = new DelegateHolder<NativeFuncDelegate>(ReceiveObserverDeactivated_process_event);
                var uf = Main.GetUFunction("ReceiveObserverDeactivated");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveObserverDeactivated_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveObserverDeactivatedAI_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveObserverDeactivatedAI_link;
            private static unsafe void ReceiveObserverDeactivatedAI_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveObserverDeactivatedAI(UObject.Make<AIController>(*(IntPtr*)(b+0)), UObject.Make<Pawn>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                ReceiveObserverDeactivatedAI_link = new DelegateHolder<NativeFuncDelegate>(ReceiveObserverDeactivatedAI_process_event);
                var uf = Main.GetUFunction("ReceiveObserverDeactivatedAI");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveObserverDeactivatedAI_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveTick_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveTick_link;
            private static unsafe void ReceiveTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
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
                var obj = UObject.Make<BTDecorator_BlueprintBase>(context);
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
