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
    [StructLayout( LayoutKind.Explicit, Size=192 )]
    internal unsafe struct AISense_Blueprint_fields {
        [FieldOffset(152)] public IntPtr ListenerDataType;
        [FieldOffset(160)] public NativeArray ListenerContainer;
        [FieldOffset(176)] public NativeArray UnprocessedEvents;
    }
    internal unsafe struct AISense_Blueprint_methods {
        internal struct GetAllListenerActors_method {
            static internal IntPtr GetAllListenerActors_ptr;
            static GetAllListenerActors_method() {
                GetAllListenerActors_ptr = Main.GetMethodUFunction(AISense_Blueprint.StaticClass, "GetAllListenerActors");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAllListenerActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ListenerActors
                return UObject.ToUObjectCollection<Actor>(b+0);
            }
        }
        internal struct GetAllListenerComponents_method {
            static internal IntPtr GetAllListenerComponents_ptr;
            static GetAllListenerComponents_method() {
                GetAllListenerComponents_ptr = Main.GetMethodUFunction(AISense_Blueprint.StaticClass, "GetAllListenerComponents");
            }

            internal static unsafe IReadOnlyCollection<AIPerceptionComponent> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAllListenerComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ListenerComponents
                return UObject.ToUObjectCollection<AIPerceptionComponent>(b+0);
            }
        }
    }
    internal unsafe struct AISense_Blueprint_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct K2_OnNewPawn_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnNewPawn_link;
            private static unsafe void K2_OnNewPawn_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AISense_Blueprint>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnNewPawn(UObject.Make<Pawn>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                K2_OnNewPawn_link = new DelegateHolder<NativeFuncDelegate>(K2_OnNewPawn_process_event);
                var uf = Main.GetUFunction("K2_OnNewPawn");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnNewPawn_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct OnListenerRegistered_event {
            private static DelegateHolder<NativeFuncDelegate> OnListenerRegistered_link;
            private static unsafe void OnListenerRegistered_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AISense_Blueprint>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnListenerRegistered(UObject.Make<Actor>(*(IntPtr*)(b+0)), UObject.Make<AIPerceptionComponent>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                OnListenerRegistered_link = new DelegateHolder<NativeFuncDelegate>(OnListenerRegistered_process_event);
                var uf = Main.GetUFunction("OnListenerRegistered");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnListenerRegistered_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct OnListenerUnregistered_event {
            private static DelegateHolder<NativeFuncDelegate> OnListenerUnregistered_link;
            private static unsafe void OnListenerUnregistered_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AISense_Blueprint>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnListenerUnregistered(UObject.Make<Actor>(*(IntPtr*)(b+0)), UObject.Make<AIPerceptionComponent>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                OnListenerUnregistered_link = new DelegateHolder<NativeFuncDelegate>(OnListenerUnregistered_process_event);
                var uf = Main.GetUFunction("OnListenerUnregistered");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnListenerUnregistered_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct OnListenerUpdated_event {
            private static DelegateHolder<NativeFuncDelegate> OnListenerUpdated_link;
            private static unsafe void OnListenerUpdated_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AISense_Blueprint>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnListenerUpdated(UObject.Make<Actor>(*(IntPtr*)(b+0)), UObject.Make<AIPerceptionComponent>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                OnListenerUpdated_link = new DelegateHolder<NativeFuncDelegate>(OnListenerUpdated_process_event);
                var uf = Main.GetUFunction("OnListenerUpdated");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnListenerUpdated_link.Delegate));
            }
        }
        //TODO: event_native: event with array parameterOnUpdate
    }
}
