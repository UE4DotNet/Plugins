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
    [StructLayout( LayoutKind.Explicit, Size=312 )]
    internal unsafe struct VOIPTalker_fields {
        [FieldOffset(256)] public VoiceSettings Settings;
    }
    internal unsafe struct VOIPTalker_methods {
        internal struct CreateTalkerForPlayer_method {
            static internal IntPtr CreateTalkerForPlayer_ptr;
            static CreateTalkerForPlayer_method() {
                CreateTalkerForPlayer_ptr = Main.GetMethodUFunction(VOIPTalker.StaticClass, "CreateTalkerForPlayer");
            }

            internal static unsafe VOIPTalker Invoke(PlayerState OwningState) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OwningState;
                Main.GetProcessEvent(VOIPTalker.DefaultObject, CreateTalkerForPlayer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetVoiceLevel_method {
            static internal IntPtr GetVoiceLevel_ptr;
            static GetVoiceLevel_method() {
                GetVoiceLevel_ptr = Main.GetMethodUFunction(VOIPTalker.StaticClass, "GetVoiceLevel");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVoiceLevel_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct RegisterWithPlayerState_method {
            static internal IntPtr RegisterWithPlayerState_ptr;
            static RegisterWithPlayerState_method() {
                RegisterWithPlayerState_ptr = Main.GetMethodUFunction(VOIPTalker.StaticClass, "RegisterWithPlayerState");
            }

            internal static unsafe void Invoke(IntPtr obj, PlayerState OwningState) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = OwningState;
                Main.GetProcessEvent(obj, RegisterWithPlayerState_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct VOIPTalker_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct BPOnTalkingBegin_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> BPOnTalkingBegin_link;
            private static unsafe void BPOnTalkingBegin_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<VOIPTalker>(context);
                var b = (byte*) theStack->Locals;
                obj.on_BPOnTalkingBegin(UObject.Make<AudioComponent>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                BPOnTalkingBegin_link = new DelegateHolder<NativeFuncDelegate>(BPOnTalkingBegin_process_event);
                var uf = Main.GetUFunction("BPOnTalkingBegin");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BPOnTalkingBegin_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct BPOnTalkingEnd_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> BPOnTalkingEnd_link;
            private static unsafe void BPOnTalkingEnd_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<VOIPTalker>(context);
                var b = (byte*) theStack->Locals;
                obj.on_BPOnTalkingEnd();
            }
            internal static void Setup() {
                BPOnTalkingEnd_link = new DelegateHolder<NativeFuncDelegate>(BPOnTalkingEnd_process_event);
                var uf = Main.GetUFunction("BPOnTalkingEnd");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BPOnTalkingEnd_link.Delegate));
            }
        }
    }
}
