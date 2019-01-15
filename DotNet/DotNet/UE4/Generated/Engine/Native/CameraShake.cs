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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=368 )]
    internal unsafe struct CameraShake_fields {
        [FieldOffset(56)] public bool bSingleInstance;
        [FieldOffset(60)] public float OscillationDuration;
        [FieldOffset(64)] public float OscillationBlendInTime;
        [FieldOffset(68)] public float OscillationBlendOutTime;
        [FieldOffset(72)] public ROscillator RotOscillation;
        [FieldOffset(108)] public VOscillator LocOscillation;
        [FieldOffset(144)] public FOscillator FOVOscillation;
        [FieldOffset(156)] public float AnimPlayRate;
        [FieldOffset(160)] public float AnimScale;
        [FieldOffset(164)] public float AnimBlendInTime;
        [FieldOffset(168)] public float AnimBlendOutTime;
        [FieldOffset(172)] public float RandomAnimSegmentDuration;
        [FieldOffset(176)]  public IntPtr  Anim;
        [FieldOffset(184)] public bool bRandomAnimSegment;
        [FieldOffset(208)]  public IntPtr  CameraOwner;
        [FieldOffset(344)] public float ShakeScale;
        [FieldOffset(348)] public float OscillatorTimeRemaining;
        [FieldOffset(352)]  public IntPtr  AnimInst;
    }
    internal unsafe struct CameraShake_methods {
    }
    internal unsafe struct CameraShake_events {
        [StructLayout( LayoutKind.Explicit, Size=2800 )]
        internal unsafe struct BlueprintUpdateCameraShake_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintUpdateCameraShake_link;
            private static unsafe void BlueprintUpdateCameraShake_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<CameraShake>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintUpdateCameraShake(*(float*)(b+0), *(float*)(b+4), *(MinimalViewInfo*)(b+16), *(MinimalViewInfo*)(b+1408));
            }
            internal static void Setup() {
                BlueprintUpdateCameraShake_link = new DelegateHolder<NativeFuncDelegate>(BlueprintUpdateCameraShake_process_event);
                var uf = Main.GetUFunction("BlueprintUpdateCameraShake");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintUpdateCameraShake_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        internal unsafe struct ReceivePlayShake_event {
            private static DelegateHolder<NativeFuncDelegate> ReceivePlayShake_link;
            private static unsafe void ReceivePlayShake_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<CameraShake>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceivePlayShake(*(float*)(b+0));
            }
            internal static void Setup() {
                ReceivePlayShake_link = new DelegateHolder<NativeFuncDelegate>(ReceivePlayShake_process_event);
                var uf = Main.GetUFunction("ReceivePlayShake");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceivePlayShake_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReceiveStopShake_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveStopShake_link;
            private static unsafe void ReceiveStopShake_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<CameraShake>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveStopShake(*(bool*)(b+0));
            }
            internal static void Setup() {
                ReceiveStopShake_link = new DelegateHolder<NativeFuncDelegate>(ReceiveStopShake_process_event);
                var uf = Main.GetUFunction("ReceiveStopShake");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveStopShake_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct ReceiveIsFinished_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> ReceiveIsFinished_link;
            private static unsafe void ReceiveIsFinished_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<CameraShake>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_ReceiveIsFinished(*(bool*)result);
            }
            internal static void Setup() {
                ReceiveIsFinished_link = new DelegateHolder<NativeFuncDelegate>(ReceiveIsFinished_process_event);
                var uf = Main.GetUFunction("ReceiveIsFinished");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveIsFinished_link.Delegate));
            }
        }
    }
}
