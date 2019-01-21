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
    [StructLayout( LayoutKind.Explicit, Size=2064 )]
    internal unsafe struct CameraComponent_fields {
        [FieldOffset(624)] public float FieldOfView;
        [FieldOffset(628)] public float OrthoWidth;
        [FieldOffset(632)] public float OrthoNearClipPlane;
        [FieldOffset(636)] public float OrthoFarClipPlane;
        [FieldOffset(640)] public float AspectRatio;
        [FieldOffset(644)] public bool bConstrainAspectRatio;
        [FieldOffset(644)] public bool bUseFieldOfViewForLOD;
        [FieldOffset(644)] public bool bLockToHmd;
        [FieldOffset(644)] public bool bUsePawnControlRotation;
        [FieldOffset(645)] public byte ProjectionMode;
        [FieldOffset(656)]  public IntPtr  CameraMesh;
        [FieldOffset(720)] public float PostProcessBlendWeight;
        [FieldOffset(768)] public PostProcessSettings PostProcessSettings;
    }
    internal unsafe struct CameraComponent_methods {
        internal struct AddOrUpdateBlendable_method {
            static internal IntPtr AddOrUpdateBlendable_ptr;
            static AddOrUpdateBlendable_method() {
                AddOrUpdateBlendable_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "AddOrUpdateBlendable");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InBlendableObject /*TODO: interface TScriptInterface */, float InWeight) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface InBlendableObject
                *((float*)(b+16)) = InWeight;
                Main.GetProcessEvent(obj, AddOrUpdateBlendable_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface InBlendableObject
            }
        }
        internal struct GetCameraView_method {
            static internal IntPtr GetCameraView_ptr;
            static GetCameraView_method() {
                GetCameraView_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "GetCameraView");
            }

            internal static unsafe MinimalViewInfo Invoke(IntPtr obj, float DeltaTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = DeltaTime;
                Main.GetProcessEvent(obj, GetCameraView_ptr, new IntPtr(p)); ;
                return *((MinimalViewInfo*)(b+16));
            }
        }
        internal struct RemoveBlendable_method {
            static internal IntPtr RemoveBlendable_ptr;
            static RemoveBlendable_method() {
                RemoveBlendable_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "RemoveBlendable");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InBlendableObject /*TODO: interface TScriptInterface */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface InBlendableObject
                Main.GetProcessEvent(obj, RemoveBlendable_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface InBlendableObject
            }
        }
        internal struct SetAspectRatio_method {
            static internal IntPtr SetAspectRatio_ptr;
            static SetAspectRatio_method() {
                SetAspectRatio_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetAspectRatio");
            }

            internal static unsafe void Invoke(IntPtr obj, float InAspectRatio) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InAspectRatio;
                Main.GetProcessEvent(obj, SetAspectRatio_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetConstraintAspectRatio_method {
            static internal IntPtr SetConstraintAspectRatio_ptr;
            static SetConstraintAspectRatio_method() {
                SetConstraintAspectRatio_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetConstraintAspectRatio");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInConstrainAspectRatio) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInConstrainAspectRatio;
                Main.GetProcessEvent(obj, SetConstraintAspectRatio_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFieldOfView_method {
            static internal IntPtr SetFieldOfView_ptr;
            static SetFieldOfView_method() {
                SetFieldOfView_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetFieldOfView");
            }

            internal static unsafe void Invoke(IntPtr obj, float InFieldOfView) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InFieldOfView;
                Main.GetProcessEvent(obj, SetFieldOfView_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOrthoFarClipPlane_method {
            static internal IntPtr SetOrthoFarClipPlane_ptr;
            static SetOrthoFarClipPlane_method() {
                SetOrthoFarClipPlane_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetOrthoFarClipPlane");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOrthoFarClipPlane) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOrthoFarClipPlane;
                Main.GetProcessEvent(obj, SetOrthoFarClipPlane_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOrthoNearClipPlane_method {
            static internal IntPtr SetOrthoNearClipPlane_ptr;
            static SetOrthoNearClipPlane_method() {
                SetOrthoNearClipPlane_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetOrthoNearClipPlane");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOrthoNearClipPlane) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOrthoNearClipPlane;
                Main.GetProcessEvent(obj, SetOrthoNearClipPlane_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOrthoWidth_method {
            static internal IntPtr SetOrthoWidth_ptr;
            static SetOrthoWidth_method() {
                SetOrthoWidth_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetOrthoWidth");
            }

            internal static unsafe void Invoke(IntPtr obj, float InOrthoWidth) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InOrthoWidth;
                Main.GetProcessEvent(obj, SetOrthoWidth_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPostProcessBlendWeight_method {
            static internal IntPtr SetPostProcessBlendWeight_ptr;
            static SetPostProcessBlendWeight_method() {
                SetPostProcessBlendWeight_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetPostProcessBlendWeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float InPostProcessBlendWeight) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InPostProcessBlendWeight;
                Main.GetProcessEvent(obj, SetPostProcessBlendWeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetProjectionMode_method {
            static internal IntPtr SetProjectionMode_ptr;
            static SetProjectionMode_method() {
                SetProjectionMode_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetProjectionMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InProjectionMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InProjectionMode;
                Main.GetProcessEvent(obj, SetProjectionMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUseFieldOfViewForLOD_method {
            static internal IntPtr SetUseFieldOfViewForLOD_ptr;
            static SetUseFieldOfViewForLOD_method() {
                SetUseFieldOfViewForLOD_ptr = Main.GetMethodUFunction(CameraComponent.StaticClass, "SetUseFieldOfViewForLOD");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInUseFieldOfViewForLOD) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInUseFieldOfViewForLOD;
                Main.GetProcessEvent(obj, SetUseFieldOfViewForLOD_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CameraComponent_events {
    }
}
