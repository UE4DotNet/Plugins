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

using UE4.Engine;

namespace UE4.AnimationModifiers.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct AnimationModifier_fields {
        [FieldOffset(72)] public FGuid RevisionGuid;
        [FieldOffset(88)] public FGuid AppliedGuid;
        [FieldOffset(104)] public int StoredNativeRevision;
    }
    internal unsafe struct AnimationModifier_methods {
    }
    internal unsafe struct AnimationModifier_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnApply_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnApply_link;
            private static unsafe void OnApply_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<AnimationModifier>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnApply(UObject.Make<AnimSequence>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                OnApply_link = new DelegateHolder<NativeFuncDelegate>(OnApply_process_event);
                var uf = Main.GetUFunction("OnApply");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnApply_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnRevert_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnRevert_link;
            private static unsafe void OnRevert_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<AnimationModifier>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnRevert(UObject.Make<AnimSequence>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                OnRevert_link = new DelegateHolder<NativeFuncDelegate>(OnRevert_process_event);
                var uf = Main.GetUFunction("OnRevert");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnRevert_link.Delegate));
            }
        }
    }
}
