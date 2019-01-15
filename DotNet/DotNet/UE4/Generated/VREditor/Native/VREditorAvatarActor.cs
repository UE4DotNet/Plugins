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


namespace UE4.VREditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=1120 )]
    internal unsafe struct VREditorAvatarActor_fields {
        [FieldOffset(1008)]  public IntPtr  HeadMeshComponent;
        [FieldOffset(1016)]  public IntPtr  WorldMovementGridMeshComponent;
        [FieldOffset(1024)]  public IntPtr  WorldMovementGridMID;
        [FieldOffset(1032)] public float WorldMovementGridOpacity;
        [FieldOffset(1036)] public bool bIsDrawingWorldMovementPostProcess;
        [FieldOffset(1040)]  public IntPtr  WorldMovementPostProcessMaterial;
        [FieldOffset(1048)]  public IntPtr  ScaleProgressMeshComponent;
        [FieldOffset(1056)]  public IntPtr  CurrentScaleProgressMeshComponent;
        [FieldOffset(1064)]  public IntPtr  UserScaleIndicatorText;
        [FieldOffset(1072)]  public IntPtr  FixedUserScaleMID;
        [FieldOffset(1080)]  public IntPtr  TranslucentFixedUserScaleMID;
        [FieldOffset(1088)]  public IntPtr  CurrentUserScaleMID;
        [FieldOffset(1096)]  public IntPtr  TranslucentCurrentUserScaleMID;
        [FieldOffset(1104)]  public IntPtr  PostProcessComponent;
        [FieldOffset(1112)]  public IntPtr  VRMode;
    }
    internal unsafe struct VREditorAvatarActor_methods {
    }
    internal unsafe struct VREditorAvatarActor_events {
    }
}
