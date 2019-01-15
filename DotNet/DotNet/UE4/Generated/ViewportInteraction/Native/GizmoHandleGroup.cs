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
    [StructLayout( LayoutKind.Explicit, Size=688 )]
    internal unsafe struct GizmoHandleGroup_fields {
        [FieldOffset(624)]  public IntPtr  GizmoMaterial;
        [FieldOffset(632)]  public IntPtr  TranslucentGizmoMaterial;
        [FieldOffset(640)] public NativeArray Handles;
        [FieldOffset(656)]  public IntPtr  OwningTransformGizmoActor;
        [FieldOffset(664)]  public IntPtr  DragOperationComponent;
    }
    internal unsafe struct GizmoHandleGroup_methods {
    }
    internal unsafe struct GizmoHandleGroup_events {
    }
}
