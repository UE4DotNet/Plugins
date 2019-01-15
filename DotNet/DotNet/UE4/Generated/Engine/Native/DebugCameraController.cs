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
    [StructLayout( LayoutKind.Explicit, Size=1952 )]
    internal unsafe struct DebugCameraController_fields {
        [FieldOffset(1880)] public bool bShowSelectedInfo;
        [FieldOffset(1880)] public bool bIsFrozenRendering;
        [FieldOffset(1888)]  public IntPtr  DrawFrustum;
        [FieldOffset(1928)] public float SpeedScale;
        [FieldOffset(1932)] public float InitialMaxSpeed;
        [FieldOffset(1936)] public float InitialAccel;
        [FieldOffset(1940)] public float InitialDecel;
    }
    internal unsafe struct DebugCameraController_methods {
        internal struct GetSelectedActor_method {
            static internal IntPtr GetSelectedActor_ptr;
            static GetSelectedActor_method() {
                GetSelectedActor_ptr = Main.GetMethodUFunction(DebugCameraController.StaticClass, "GetSelectedActor");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSelectedActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetPawnMovementSpeedScale_method {
            static internal IntPtr SetPawnMovementSpeedScale_ptr;
            static SetPawnMovementSpeedScale_method() {
                SetPawnMovementSpeedScale_ptr = Main.GetMethodUFunction(DebugCameraController.StaticClass, "SetPawnMovementSpeedScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewSpeedScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewSpeedScale;
                Main.GetProcessEvent(obj, SetPawnMovementSpeedScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ToggleDisplay_method {
            static internal IntPtr ToggleDisplay_ptr;
            static ToggleDisplay_method() {
                ToggleDisplay_ptr = Main.GetMethodUFunction(DebugCameraController.StaticClass, "ToggleDisplay");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ToggleDisplay_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct DebugCameraController_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveOnActivate_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveOnActivate_link;
            private static unsafe void ReceiveOnActivate_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<DebugCameraController>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveOnActivate(UObject.Make<PlayerController>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveOnActivate_link = new DelegateHolder<NativeFuncDelegate>(ReceiveOnActivate_process_event);
                var uf = Main.GetUFunction("ReceiveOnActivate");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveOnActivate_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        internal unsafe struct ReceiveOnActorSelected_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveOnActorSelected_link;
            private static unsafe void ReceiveOnActorSelected_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<DebugCameraController>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveOnActorSelected(UObject.Make<Actor>(*(IntPtr*)(b+0)), *(Vector*)(b+8), *(Vector*)(b+20), *(HitResult*)(b+32));
            }
            internal static void Setup() {
                ReceiveOnActorSelected_link = new DelegateHolder<NativeFuncDelegate>(ReceiveOnActorSelected_process_event);
                var uf = Main.GetUFunction("ReceiveOnActorSelected");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveOnActorSelected_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveOnDeactivate_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveOnDeactivate_link;
            private static unsafe void ReceiveOnDeactivate_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<DebugCameraController>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveOnDeactivate(UObject.Make<PlayerController>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveOnDeactivate_link = new DelegateHolder<NativeFuncDelegate>(ReceiveOnDeactivate_process_event);
                var uf = Main.GetUFunction("ReceiveOnDeactivate");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveOnDeactivate_link.Delegate));
            }
        }
    }
}
