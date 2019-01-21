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
    [StructLayout( LayoutKind.Explicit, Size=928 )]
    internal unsafe struct LevelSequenceBurnIn_fields {
        [FieldOffset(784)] public LevelSequencePlayerSnapshot FrameInformation;
        [FieldOffset(920)]  public IntPtr  LevelSequenceActor;
    }
    internal unsafe struct LevelSequenceBurnIn_methods {
    }
    internal unsafe struct LevelSequenceBurnIn_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct SetSettings_event {
            private static DelegateHolder<NativeFuncDelegate> SetSettings_link;
            private static unsafe void SetSettings_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<LevelSequenceBurnIn>(context);
                var b = (byte*) theStack->Locals;

                obj.on_SetSettings(UObject.Make<UObject>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                SetSettings_link = new DelegateHolder<NativeFuncDelegate>(SetSettings_process_event);
                var uf = Main.GetUFunction("SetSettings");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(SetSettings_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct GetSettingsClass_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> GetSettingsClass_link;
            private static unsafe void GetSettingsClass_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<LevelSequenceBurnIn>(context);
                var b = (byte*) theStack->Locals;
                *(IntPtr*)result.ToPointer() = obj.on_GetSettingsClass(*(IntPtr*)result);
            }
            internal static void Setup() {
                GetSettingsClass_link = new DelegateHolder<NativeFuncDelegate>(GetSettingsClass_process_event);
                var uf = Main.GetUFunction("GetSettingsClass");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(GetSettingsClass_link.Delegate));
            }
        }
    }
}
