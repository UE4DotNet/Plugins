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


namespace UE4.ViewportInteraction.Native {
    [StructLayout( LayoutKind.Explicit, Size=240 )]
    internal unsafe struct ViewportInteractionAssetContainer_fields {
        [FieldOffset(64)]  public IntPtr  GizmoHandleSelectedSound;
        [FieldOffset(72)]  public IntPtr  GizmoHandleDropSound;
        [FieldOffset(80)]  public IntPtr  SelectionChangeSound;
        [FieldOffset(88)]  public IntPtr  SelectionDropSound;
        [FieldOffset(96)]  public IntPtr  SelectionStartDragSound;
        [FieldOffset(104)]  public IntPtr  GridSnapSound;
        [FieldOffset(112)]  public IntPtr  ActorSnapSound;
        [FieldOffset(120)]  public IntPtr  UndoSound;
        [FieldOffset(128)]  public IntPtr  RedoSound;
        [FieldOffset(136)]  public IntPtr  GridMesh;
        [FieldOffset(144)]  public IntPtr  TranslationHandleMesh;
        [FieldOffset(152)]  public IntPtr  UniformScaleHandleMesh;
        [FieldOffset(160)]  public IntPtr  ScaleHandleMesh;
        [FieldOffset(168)]  public IntPtr  PlaneTranslationHandleMesh;
        [FieldOffset(176)]  public IntPtr  RotationHandleMesh;
        [FieldOffset(184)]  public IntPtr  RotationHandleSelectedMesh;
        [FieldOffset(192)]  public IntPtr  StartRotationIndicatorMesh;
        [FieldOffset(200)]  public IntPtr  CurrentRotationIndicatorMesh;
        [FieldOffset(208)]  public IntPtr  FreeRotationHandleMesh;
        [FieldOffset(216)]  public IntPtr  GridMaterial;
        [FieldOffset(224)]  public IntPtr  TransformGizmoMaterial;
        [FieldOffset(232)]  public IntPtr  TranslucentTransformGizmoMaterial;
    }
    internal unsafe struct ViewportInteractionAssetContainer_methods {
    }
    internal unsafe struct ViewportInteractionAssetContainer_events {
    }
}
