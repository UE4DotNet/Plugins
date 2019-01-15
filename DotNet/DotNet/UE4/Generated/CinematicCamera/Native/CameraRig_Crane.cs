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


namespace UE4.CinematicCamera.Native {
    [StructLayout( LayoutKind.Explicit, Size=1088 )]
    internal unsafe struct CameraRig_Crane_fields {
        [FieldOffset(1008)] public float CranePitch;
        [FieldOffset(1012)] public float CraneYaw;
        [FieldOffset(1016)] public float CraneArmLength;
        [FieldOffset(1020)] public bool bLockMountPitch;
        [FieldOffset(1021)] public bool bLockMountYaw;
        [FieldOffset(1024)]  public IntPtr  TransformComponent;
        [FieldOffset(1032)]  public IntPtr  CraneYawControl;
        [FieldOffset(1040)]  public IntPtr  CranePitchControl;
        [FieldOffset(1048)]  public IntPtr  CraneCameraMount;
        [FieldOffset(1056)]  public IntPtr  PreviewMesh_CraneArm;
        [FieldOffset(1064)]  public IntPtr  PreviewMesh_CraneBase;
        [FieldOffset(1072)]  public IntPtr  PreviewMesh_CraneMount;
        [FieldOffset(1080)]  public IntPtr  PreviewMesh_CraneCounterWeight;
    }
    internal unsafe struct CameraRig_Crane_methods {
    }
    internal unsafe struct CameraRig_Crane_events {
    }
}
