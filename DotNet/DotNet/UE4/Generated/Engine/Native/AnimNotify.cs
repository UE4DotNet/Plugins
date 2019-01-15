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
    [StructLayout( LayoutKind.Explicit, Size=72 )]
    internal unsafe struct AnimNotify_fields {
        [FieldOffset(56)] public Color NotifyColor;
    }
    internal unsafe struct AnimNotify_methods {
    }
    internal unsafe struct AnimNotify_events {
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct Received_Notify_event {
            private static DelegateHolder<NativeFuncDelegate> Received_Notify_link;
            private static unsafe void Received_Notify_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<AnimNotify>(context);
                var b = (byte*) theStack->Locals;

                obj.on_Received_Notify(UObject.Make<SkeletalMeshComponent>(*(IntPtr*)(b+0)), UObject.Make<AnimSequenceBase>(*(IntPtr*)(b+8)), *(bool*)(b+16));
            }
            internal static void Setup() {
                Received_Notify_link = new DelegateHolder<NativeFuncDelegate>(Received_Notify_process_event);
                var uf = Main.GetUFunction("Received_Notify");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Received_Notify_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct GetNotifyName_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> GetNotifyName_link;
            private static unsafe void GetNotifyName_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<AnimNotify>(context);
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
