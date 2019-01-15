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
    [StructLayout( LayoutKind.Explicit, Size=64 )]
    internal unsafe struct AnimNotifyState_fields {
        [FieldOffset(56)] public Color NotifyColor;
    }
    internal unsafe struct AnimNotifyState_methods {
    }
    internal unsafe struct AnimNotifyState_events {
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct Received_NotifyBegin_event {
            private static DelegateHolder<NativeFuncDelegate> Received_NotifyBegin_link;
            private static unsafe void Received_NotifyBegin_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimNotifyState>(context);
                var b = (byte*) theStack->Locals;

                obj.on_Received_NotifyBegin(UObject.Make<SkeletalMeshComponent>(*(IntPtr*)(b+0)), UObject.Make<AnimSequenceBase>(*(IntPtr*)(b+8)), *(float*)(b+16), *(bool*)(b+20));
            }
            internal static void Setup() {
                Received_NotifyBegin_link = new DelegateHolder<NativeFuncDelegate>(Received_NotifyBegin_process_event);
                var uf = Main.GetUFunction("Received_NotifyBegin");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Received_NotifyBegin_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct Received_NotifyEnd_event {
            private static DelegateHolder<NativeFuncDelegate> Received_NotifyEnd_link;
            private static unsafe void Received_NotifyEnd_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimNotifyState>(context);
                var b = (byte*) theStack->Locals;

                obj.on_Received_NotifyEnd(UObject.Make<SkeletalMeshComponent>(*(IntPtr*)(b+0)), UObject.Make<AnimSequenceBase>(*(IntPtr*)(b+8)), *(bool*)(b+16));
            }
            internal static void Setup() {
                Received_NotifyEnd_link = new DelegateHolder<NativeFuncDelegate>(Received_NotifyEnd_process_event);
                var uf = Main.GetUFunction("Received_NotifyEnd");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Received_NotifyEnd_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct Received_NotifyTick_event {
            private static DelegateHolder<NativeFuncDelegate> Received_NotifyTick_link;
            private static unsafe void Received_NotifyTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimNotifyState>(context);
                var b = (byte*) theStack->Locals;

                obj.on_Received_NotifyTick(UObject.Make<SkeletalMeshComponent>(*(IntPtr*)(b+0)), UObject.Make<AnimSequenceBase>(*(IntPtr*)(b+8)), *(float*)(b+16), *(bool*)(b+20));
            }
            internal static void Setup() {
                Received_NotifyTick_link = new DelegateHolder<NativeFuncDelegate>(Received_NotifyTick_process_event);
                var uf = Main.GetUFunction("Received_NotifyTick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Received_NotifyTick_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct GetNotifyName_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> GetNotifyName_link;
            private static unsafe void GetNotifyName_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<AnimNotifyState>(context);
                var b = (byte*) theStack->Locals;
                /*TODO: event_set_return return string*/obj.on_GetNotifyName(FString.Get((byte*)result.ToPointer()));
            }
            internal static void Setup() {
                GetNotifyName_link = new DelegateHolder<NativeFuncDelegate>(GetNotifyName_process_event);
                var uf = Main.GetUFunction("GetNotifyName");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(GetNotifyName_link.Delegate));
            }
        }
    }
}
