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
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct PawnAction_BlueprintBase_fields {
    }
    internal unsafe struct PawnAction_BlueprintBase_methods {
    }
    internal unsafe struct PawnAction_BlueprintBase_events {
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ActionFinished_event {
            private static DelegateHolder<NativeFuncDelegate> ActionFinished_link;
            private static unsafe void ActionFinished_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PawnAction_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ActionFinished(UObject.Make<Pawn>(*(IntPtr*)(b+0)), *(b+8));
            }
            internal static void Setup() {
                ActionFinished_link = new DelegateHolder<NativeFuncDelegate>(ActionFinished_process_event);
                var uf = Main.GetUFunction("ActionFinished");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ActionFinished_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ActionPause_event {
            private static DelegateHolder<NativeFuncDelegate> ActionPause_link;
            private static unsafe void ActionPause_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PawnAction_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ActionPause(UObject.Make<Pawn>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ActionPause_link = new DelegateHolder<NativeFuncDelegate>(ActionPause_process_event);
                var uf = Main.GetUFunction("ActionPause");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ActionPause_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ActionResume_event {
            private static DelegateHolder<NativeFuncDelegate> ActionResume_link;
            private static unsafe void ActionResume_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PawnAction_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ActionResume(UObject.Make<Pawn>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ActionResume_link = new DelegateHolder<NativeFuncDelegate>(ActionResume_process_event);
                var uf = Main.GetUFunction("ActionResume");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ActionResume_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ActionStart_event {
            private static DelegateHolder<NativeFuncDelegate> ActionStart_link;
            private static unsafe void ActionStart_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PawnAction_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ActionStart(UObject.Make<Pawn>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ActionStart_link = new DelegateHolder<NativeFuncDelegate>(ActionStart_process_event);
                var uf = Main.GetUFunction("ActionStart");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ActionStart_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ActionTick_event {
            private static DelegateHolder<NativeFuncDelegate> ActionTick_link;
            private static unsafe void ActionTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PawnAction_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ActionTick(UObject.Make<Pawn>(*(IntPtr*)(b+0)), *(float*)(b+8));
            }
            internal static void Setup() {
                ActionTick_link = new DelegateHolder<NativeFuncDelegate>(ActionTick_process_event);
                var uf = Main.GetUFunction("ActionTick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ActionTick_link.Delegate));
            }
        }
    }
}
