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
    [StructLayout( LayoutKind.Explicit, Size=1408 )]
    internal unsafe struct CameraAnim_fields {
        [FieldOffset(56)]  public IntPtr  CameraInterpGroup;
        [FieldOffset(64)]  public IntPtr  PreviewInterpGroup;
        [FieldOffset(72)] public float AnimLength;
        [FieldOffset(76)] public Box BoundingBox;
        [FieldOffset(104)] public bool bRelativeToInitialTransform;
        [FieldOffset(104)] public bool bRelativeToInitialFOV;
        [FieldOffset(108)] public float BaseFOV;
        [FieldOffset(112)] public PostProcessSettings BasePostProcessSettings;
        [FieldOffset(1392)] public float BasePostProcessBlendWeight;
    }
    internal unsafe struct CameraAnim_methods {
    }
    internal unsafe struct CameraAnim_events {
    }
}
