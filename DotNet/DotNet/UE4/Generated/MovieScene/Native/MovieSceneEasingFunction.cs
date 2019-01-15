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


namespace UE4.MovieScene.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MovieSceneEasingFunction_fields {
    }
    internal unsafe struct MovieSceneEasingFunction_methods {
    }
    internal unsafe struct MovieSceneEasingFunction_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnEvaluate_event {
            private static DelegateHolder<NativeFuncDelegate> OnEvaluate_link;
            private static unsafe void OnEvaluate_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<MovieSceneEasingFunction>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnEvaluate(*(float*)(b+0), *(float*)(b+4));
            }
            internal static void Setup() {
                OnEvaluate_link = new DelegateHolder<NativeFuncDelegate>(OnEvaluate_process_event);
                var uf = Main.GetUFunction("OnEvaluate");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnEvaluate_link.Delegate));
            }
        }
    }
}
