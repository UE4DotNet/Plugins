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
    [StructLayout( LayoutKind.Explicit, Size=1040 )]
    internal unsafe struct ViewportWorldInteraction_fields {
        [FieldOffset(312)] public NativeArray Interactors;
        [FieldOffset(328)]  public IntPtr  ViewportTransformer;
        [FieldOffset(552)]  public IntPtr  TransformGizmoActor;
        [FieldOffset(632)]  public IntPtr  SnapGridActor;
        [FieldOffset(640)]  public IntPtr  SnapGridMeshComponent;
        [FieldOffset(648)]  public IntPtr  SnapGridMID;
        [FieldOffset(928)]  public IntPtr  DefaultMouseCursorInteractor;
        [FieldOffset(944)] public NativeArray ActorsToExcludeFromHitTest;
        [FieldOffset(1008)]  public IntPtr  AssetContainer;
    }
    internal unsafe struct ViewportWorldInteraction_methods {
    }
    internal unsafe struct ViewportWorldInteraction_events {
    }
}
