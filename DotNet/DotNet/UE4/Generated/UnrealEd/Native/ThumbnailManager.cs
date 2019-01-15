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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=288 )]
    internal unsafe struct ThumbnailManager_fields {
        [FieldOffset(56)] public NativeArray RenderableThumbnailTypes;
        [FieldOffset(160)] public ThumbnailRenderingInfo NotSupported;
        [FieldOffset(208)]  public IntPtr  EditorCube;
        [FieldOffset(216)]  public IntPtr  EditorSphere;
        [FieldOffset(224)]  public IntPtr  EditorCylinder;
        [FieldOffset(232)]  public IntPtr  EditorPlane;
        [FieldOffset(240)]  public IntPtr  EditorSkySphere;
        [FieldOffset(248)]  public IntPtr  FloorPlaneMaterial;
        [FieldOffset(256)]  public IntPtr  AmbientCubemap;
        [FieldOffset(264)]  public IntPtr  CheckerboardTexture;
        [FieldOffset(272)] byte ThumbnailManagerClassName; //TODO: string FString ThumbnailManagerClassName
    }
    internal unsafe struct ThumbnailManager_methods {
    }
    internal unsafe struct ThumbnailManager_events {
    }
}
