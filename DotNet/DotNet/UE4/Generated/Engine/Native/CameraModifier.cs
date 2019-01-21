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
    [StructLayout( LayoutKind.Explicit, Size=88 )]
    internal unsafe struct CameraModifier_fields {
        [FieldOffset(56)] public bool bDebug;
        [FieldOffset(56)] public bool bExclusive;
        [FieldOffset(60)] public byte Priority;
        [FieldOffset(64)]  public IntPtr  CameraOwner;
        [FieldOffset(72)] public float AlphaInTime;
        [FieldOffset(76)] public float AlphaOutTime;
        [FieldOffset(80)] public float Alpha;
    }
    internal unsafe struct CameraModifier_methods {
        internal struct DisableModifier_method {
            static internal IntPtr DisableModifier_ptr;
            static DisableModifier_method() {
                DisableModifier_ptr = Main.GetMethodUFunction(CameraModifier.StaticClass, "DisableModifier");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bImmediate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bImmediate;
                Main.GetProcessEvent(obj, DisableModifier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableModifier_method {
            static internal IntPtr EnableModifier_ptr;
            static EnableModifier_method() {
                EnableModifier_ptr = Main.GetMethodUFunction(CameraModifier.StaticClass, "EnableModifier");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EnableModifier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetViewTarget_method {
            static internal IntPtr GetViewTarget_ptr;
            static GetViewTarget_method() {
                GetViewTarget_ptr = Main.GetMethodUFunction(CameraModifier.StaticClass, "GetViewTarget");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewTarget_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct IsDisabled_method {
            static internal IntPtr IsDisabled_ptr;
            static IsDisabled_method() {
                IsDisabled_ptr = Main.GetMethodUFunction(CameraModifier.StaticClass, "IsDisabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsDisabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct CameraModifier_events {
        [StructLayout( LayoutKind.Explicit, Size=60 )]
        internal unsafe struct BlueprintModifyCamera_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintModifyCamera_link;
            private static unsafe void BlueprintModifyCamera_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<CameraModifier>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintModifyCamera(*(float*)(b+0), *(Vector*)(b+4), *(Rotator*)(b+16), *(float*)(b+28), *(Vector*)(b+32), *(Rotator*)(b+44), *(float*)(b+56));
            }
            internal static void Setup() {
                BlueprintModifyCamera_link = new DelegateHolder<NativeFuncDelegate>(BlueprintModifyCamera_process_event);
                var uf = Main.GetUFunction("BlueprintModifyCamera");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintModifyCamera_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1296 )]
        internal unsafe struct BlueprintModifyPostProcess_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintModifyPostProcess_link;
            private static unsafe void BlueprintModifyPostProcess_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<CameraModifier>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintModifyPostProcess(*(float*)(b+0), *(float*)(b+4), *(PostProcessSettings*)(b+16));
            }
            internal static void Setup() {
                BlueprintModifyPostProcess_link = new DelegateHolder<NativeFuncDelegate>(BlueprintModifyPostProcess_process_event);
                var uf = Main.GetUFunction("BlueprintModifyPostProcess");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintModifyPostProcess_link.Delegate));
            }
        }
    }
}
