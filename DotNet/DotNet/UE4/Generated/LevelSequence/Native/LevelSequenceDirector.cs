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


namespace UE4.LevelSequence.Native {
    [StructLayout( LayoutKind.Explicit, Size=64 )]
    internal unsafe struct LevelSequenceDirector_fields {
        [FieldOffset(56)]  public IntPtr  Player;
    }
    internal unsafe struct LevelSequenceDirector_methods {
    }
    internal unsafe struct LevelSequenceDirector_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnCreated_event {
            private static DelegateHolder<NativeFuncDelegate> OnCreated_link;
            private static unsafe void OnCreated_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<LevelSequenceDirector>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnCreated();
            }
            internal static void Setup() {
                OnCreated_link = new DelegateHolder<NativeFuncDelegate>(OnCreated_process_event);
                var uf = Main.GetUFunction("OnCreated");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnCreated_link.Delegate));
            }
        }
    }
}
