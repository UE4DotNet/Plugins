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

using UE4.InputCore;
using UE4.Engine;

namespace UE4.HeadMountedDisplay.Native {
    [StructLayout( LayoutKind.Explicit, Size=1712 )]
    internal unsafe struct MotionControllerComponent_fields {
        [FieldOffset(1520)] public int PlayerIndex;
        [FieldOffset(1528)] public Name MotionSource;
        [FieldOffset(1540)] public bool bDisableLowLatencyUpdate;
        [FieldOffset(1544)] byte CurrentTrackingStatus; //TODO: enum ETrackingStatus CurrentTrackingStatus
        [FieldOffset(1545)] public bool bDisplayDeviceModel;
        [FieldOffset(1548)] public Name DisplayModelSource;
        [FieldOffset(1560)]  public IntPtr  CustomDisplayMesh;
        [FieldOffset(1568)] public NativeArray DisplayMeshMaterialOverrides;
        [FieldOffset(1680)]  public IntPtr  DisplayComponent;
    }
    internal unsafe struct MotionControllerComponent_methods {
        internal struct GetParameterValue_method {
            static internal IntPtr GetParameterValue_ptr;
            static GetParameterValue_method() {
                GetParameterValue_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "GetParameterValue");
            }

            internal static unsafe (bool, float) Invoke(IntPtr obj, Name InName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                Main.GetProcessEvent(obj, GetParameterValue_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+12)),*((float*)(b+16)));
            }
        }
        internal struct GetTrackingSource_method {
            static internal IntPtr GetTrackingSource_ptr;
            static GetTrackingSource_method() {
                GetTrackingSource_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "GetTrackingSource");
            }

            internal static unsafe EControllerHand Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTrackingSource_ptr, new IntPtr(p)); ;
                return *((EControllerHand*)(b+0));
            }
        }
        internal struct IsTracked_method {
            static internal IntPtr IsTracked_ptr;
            static IsTracked_method() {
                IsTracked_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "IsTracked");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsTracked_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetAssociatedPlayerIndex_method {
            static internal IntPtr SetAssociatedPlayerIndex_ptr;
            static SetAssociatedPlayerIndex_method() {
                SetAssociatedPlayerIndex_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "SetAssociatedPlayerIndex");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewPlayer) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewPlayer;
                Main.GetProcessEvent(obj, SetAssociatedPlayerIndex_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCustomDisplayMesh_method {
            static internal IntPtr SetCustomDisplayMesh_ptr;
            static SetCustomDisplayMesh_method() {
                SetCustomDisplayMesh_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "SetCustomDisplayMesh");
            }

            internal static unsafe void Invoke(IntPtr obj, StaticMesh NewDisplayMesh) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewDisplayMesh;
                Main.GetProcessEvent(obj, SetCustomDisplayMesh_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDisplayModelSource_method {
            static internal IntPtr SetDisplayModelSource_ptr;
            static SetDisplayModelSource_method() {
                SetDisplayModelSource_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "SetDisplayModelSource");
            }

            internal static unsafe void Invoke(IntPtr obj, Name NewDisplayModelSource) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = NewDisplayModelSource;
                Main.GetProcessEvent(obj, SetDisplayModelSource_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShowDeviceModel_method {
            static internal IntPtr SetShowDeviceModel_ptr;
            static SetShowDeviceModel_method() {
                SetShowDeviceModel_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "SetShowDeviceModel");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bShowControllerModel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bShowControllerModel;
                Main.GetProcessEvent(obj, SetShowDeviceModel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTrackingMotionSource_method {
            static internal IntPtr SetTrackingMotionSource_ptr;
            static SetTrackingMotionSource_method() {
                SetTrackingMotionSource_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "SetTrackingMotionSource");
            }

            internal static unsafe void Invoke(IntPtr obj, Name NewSource) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = NewSource;
                Main.GetProcessEvent(obj, SetTrackingMotionSource_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTrackingSource_method {
            static internal IntPtr SetTrackingSource_ptr;
            static SetTrackingSource_method() {
                SetTrackingSource_ptr = Main.GetMethodUFunction(MotionControllerComponent.StaticClass, "SetTrackingSource");
            }

            internal static unsafe void Invoke(IntPtr obj, EControllerHand NewSource) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)NewSource;
                Main.GetProcessEvent(obj, SetTrackingSource_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MotionControllerComponent_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnMotionControllerUpdated_event {
            private static DelegateHolder<NativeFuncDelegate> OnMotionControllerUpdated_link;
            private static unsafe void OnMotionControllerUpdated_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<MotionControllerComponent>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMotionControllerUpdated();
            }
            internal static void Setup() {
                OnMotionControllerUpdated_link = new DelegateHolder<NativeFuncDelegate>(OnMotionControllerUpdated_process_event);
                var uf = Main.GetUFunction("OnMotionControllerUpdated");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMotionControllerUpdated_link.Delegate));
            }
        }
    }
}
