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


namespace UE4.Transient.Native {
    [StructLayout( LayoutKind.Explicit, Size=1032 )]
    internal unsafe struct REINST_FirstPersonProjectile_C_4_fields {
        [FieldOffset(1024)]  public IntPtr  StaticMesh1;
    }
    internal unsafe struct REINST_FirstPersonProjectile_C_4_methods {
    }
    internal unsafe struct REINST_FirstPersonProjectile_C_4_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct UserConstructionScript_event {
            private static DelegateHolder<NativeFuncDelegate> UserConstructionScript_link;
            private static unsafe void UserConstructionScript_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<REINST_FirstPersonProjectile_C_4>(context);
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
