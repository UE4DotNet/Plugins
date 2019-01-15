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


namespace UE4.CoreUObject.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct UObject_fields {
    }
    internal unsafe struct UObject_methods {
    }
    internal unsafe struct UObject_events {
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        internal unsafe struct ExecuteUbergraph_event {
            private static DelegateHolder<NativeFuncDelegate> ExecuteUbergraph_link;
            private static unsafe void ExecuteUbergraph_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UObject>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ExecuteUbergraph(*(int*)(b+0));
            }
            internal static void Setup() {
                ExecuteUbergraph_link = new DelegateHolder<NativeFuncDelegate>(ExecuteUbergraph_process_event);
                var uf = Main.GetUFunction("ExecuteUbergraph");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ExecuteUbergraph_link.Delegate));
            }
        }
    }
}
