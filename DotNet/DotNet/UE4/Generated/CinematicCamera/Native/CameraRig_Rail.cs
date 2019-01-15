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
    [StructLayout( LayoutKind.Explicit, Size=1080 )]
    internal unsafe struct CameraRig_Rail_fields {
        [FieldOffset(1008)] public float CurrentPositionOnRail;
        [FieldOffset(1012)] public bool bLockOrientationToRail;
        [FieldOffset(1016)]  public IntPtr  TransformComponent;
        [FieldOffset(1024)]  public IntPtr  RailSplineComponent;
        [FieldOffset(1032)]  public IntPtr  RailCameraMount;
        [FieldOffset(1040)]  public IntPtr  PreviewMesh_Rail;
        [FieldOffset(1048)] public NativeArray PreviewRailMeshSegments;
        [FieldOffset(1064)]  public IntPtr  PreviewRailStaticMesh;
        [FieldOffset(1072)]  public IntPtr  PreviewMesh_Mount;
    }
    internal unsafe struct CameraRig_Rail_methods {
    }
    internal unsafe struct CameraRig_Rail_events {
    }
}
