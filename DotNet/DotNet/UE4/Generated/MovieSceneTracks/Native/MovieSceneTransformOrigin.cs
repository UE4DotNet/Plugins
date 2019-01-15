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


namespace UE4.MovieSceneTracks.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MovieSceneTransformOrigin_fields {
    }
    internal unsafe struct MovieSceneTransformOrigin_methods {
    }
    internal unsafe struct MovieSceneTransformOrigin_events {
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        internal unsafe struct BP_GetTransformOrigin_event {
            private static DelegateHolder<NativeFuncDelegate> BP_GetTransformOrigin_link;
            private static unsafe void BP_GetTransformOrigin_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<MovieSceneTransformOrigin>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BP_GetTransformOrigin(*(Transform*)(b+0));
            }
            internal static void Setup() {
                BP_GetTransformOrigin_link = new DelegateHolder<NativeFuncDelegate>(BP_GetTransformOrigin_process_event);
                var uf = Main.GetUFunction("BP_GetTransformOrigin");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BP_GetTransformOrigin_link.Delegate));
            }
        }
    }
}
