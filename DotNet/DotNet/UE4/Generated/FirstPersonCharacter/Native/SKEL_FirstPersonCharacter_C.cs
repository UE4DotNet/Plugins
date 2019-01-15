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


namespace UE4.FirstPersonCharacter.Native {
    [StructLayout( LayoutKind.Explicit, Size=2216 )]
    internal unsafe struct SKEL_FirstPersonCharacter_C_fields {
        [FieldOffset(2208)] byte UberGraphFrame; //TODO: struct FPointerToUberGraphFrame UberGraphFrame
    }
    internal unsafe struct SKEL_FirstPersonCharacter_C_methods {
    }
    internal unsafe struct SKEL_FirstPersonCharacter_C_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct UserConstructionScript_event {
            private static DelegateHolder<NativeFuncDelegate> UserConstructionScript_link;
            private static unsafe void UserConstructionScript_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<SKEL_FirstPersonCharacter_C>(context);
                var b = (byte*) theStack->Locals;

                obj.on_UserConstructionScript();
            }
            internal static void Setup() {
                UserConstructionScript_link = new DelegateHolder<NativeFuncDelegate>(UserConstructionScript_process_event);
                var uf = Main.GetUFunction("UserConstructionScript");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(UserConstructionScript_link.Delegate));
            }
        }
    }
}
