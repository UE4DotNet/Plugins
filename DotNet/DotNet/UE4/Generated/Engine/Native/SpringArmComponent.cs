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
    [StructLayout( LayoutKind.Explicit, Size=768 )]
    internal unsafe struct SpringArmComponent_fields {
        [FieldOffset(624)] public float TargetArmLength;
        [FieldOffset(628)] public Vector SocketOffset;
        [FieldOffset(640)] public Vector TargetOffset;
        [FieldOffset(652)] public float ProbeSize;
        [FieldOffset(656)] public byte ProbeChannel;
        [FieldOffset(660)] public bool bDoCollisionTest;
        [FieldOffset(660)] public bool bUsePawnControlRotation;
        [FieldOffset(660)] public bool bInheritPitch;
        [FieldOffset(660)] public bool bInheritYaw;
        [FieldOffset(660)] public bool bInheritRoll;
        [FieldOffset(660)] public bool bEnableCameraLag;
        [FieldOffset(660)] public bool bEnableCameraRotationLag;
        [FieldOffset(660)] public bool bUseCameraLagSubstepping;
        [FieldOffset(661)] public bool bDrawDebugLagMarkers;
        [FieldOffset(664)] public float CameraLagSpeed;
        [FieldOffset(668)] public float CameraRotationLagSpeed;
        [FieldOffset(672)] public float CameraLagMaxTimeStep;
        [FieldOffset(676)] public float CameraLagMaxDistance;
    }
    internal unsafe struct SpringArmComponent_methods {
        internal struct GetTargetRotation_method {
            static internal IntPtr GetTargetRotation_ptr;
            static GetTargetRotation_method() {
                GetTargetRotation_ptr = Main.GetMethodUFunction(SpringArmComponent.StaticClass, "GetTargetRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTargetRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct GetUnfixedCameraPosition_method {
            static internal IntPtr GetUnfixedCameraPosition_ptr;
            static GetUnfixedCameraPosition_method() {
                GetUnfixedCameraPosition_ptr = Main.GetMethodUFunction(SpringArmComponent.StaticClass, "GetUnfixedCameraPosition");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetUnfixedCameraPosition_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct IsCollisionFixApplied_method {
            static internal IntPtr IsCollisionFixApplied_ptr;
            static IsCollisionFixApplied_method() {
                IsCollisionFixApplied_ptr = Main.GetMethodUFunction(SpringArmComponent.StaticClass, "IsCollisionFixApplied");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCollisionFixApplied_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct SpringArmComponent_events {
    }
}
