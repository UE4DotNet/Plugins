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


namespace UE4.FirstPerson_AnimBP.Native {
    [StructLayout( LayoutKind.Explicit, Size=960 )]
    internal unsafe struct SKEL_FirstPerson_AnimBP_C_fields {
        [FieldOffset(944)] byte UberGraphFrame; //TODO: struct FPointerToUberGraphFrame UberGraphFrame
        ///<summary>Is Moving</summary>
        [FieldOffset(952)] public bool IsMoving;
        ///<summary>Is in Air</summary>
        [FieldOffset(953)] public bool bIsInAir;
    }
    internal unsafe struct SKEL_FirstPerson_AnimBP_C_methods {
    }
    internal unsafe struct SKEL_FirstPerson_AnimBP_C_events {
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        internal unsafe struct BlueprintUpdateAnimation_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintUpdateAnimation_link;
            private static unsafe void BlueprintUpdateAnimation_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<SKEL_FirstPerson_AnimBP_C>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintUpdateAnimation(*(float*)(b+0));
            }
            internal static void Setup() {
                BlueprintUpdateAnimation_link = new DelegateHolder<NativeFuncDelegate>(BlueprintUpdateAnimation_process_event);
                var uf = Main.GetUFunction("BlueprintUpdateAnimation");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintUpdateAnimation_link.Delegate));
            }
        }
    }
}
