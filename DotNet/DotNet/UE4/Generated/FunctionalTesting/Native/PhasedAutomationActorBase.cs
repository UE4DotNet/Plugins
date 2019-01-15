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


namespace UE4.FunctionalTesting.Native {
    [StructLayout( LayoutKind.Explicit, Size=1008 )]
    internal unsafe struct PhasedAutomationActorBase_fields {
    }
    internal unsafe struct PhasedAutomationActorBase_methods {
    }
    internal unsafe struct PhasedAutomationActorBase_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnFunctionalTestingBegin_event {
            private static DelegateHolder<NativeFuncDelegate> OnFunctionalTestingBegin_link;
            private static unsafe void OnFunctionalTestingBegin_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PhasedAutomationActorBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnFunctionalTestingBegin();
            }
            internal static void Setup() {
                OnFunctionalTestingBegin_link = new DelegateHolder<NativeFuncDelegate>(OnFunctionalTestingBegin_process_event);
                var uf = Main.GetUFunction("OnFunctionalTestingBegin");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnFunctionalTestingBegin_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnFunctionalTestingComplete_event {
            private static DelegateHolder<NativeFuncDelegate> OnFunctionalTestingComplete_link;
            private static unsafe void OnFunctionalTestingComplete_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PhasedAutomationActorBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnFunctionalTestingComplete();
            }
            internal static void Setup() {
                OnFunctionalTestingComplete_link = new DelegateHolder<NativeFuncDelegate>(OnFunctionalTestingComplete_process_event);
                var uf = Main.GetUFunction("OnFunctionalTestingComplete");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnFunctionalTestingComplete_link.Delegate));
            }
        }
    }
}
