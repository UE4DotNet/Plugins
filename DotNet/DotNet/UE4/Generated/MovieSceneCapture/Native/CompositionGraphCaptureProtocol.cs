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


namespace UE4.MovieSceneCapture.Native {
    [StructLayout( LayoutKind.Explicit, Size=216 )]
    internal unsafe struct CompositionGraphCaptureProtocol_fields {
        [FieldOffset(104)] public CompositionGraphCapturePasses IncludeRenderPasses;
        [FieldOffset(120)] public bool bCaptureFramesInHDR;
        [FieldOffset(124)] public int HDRCompressionQuality;
        [FieldOffset(128)] public byte CaptureGamut;
        [FieldOffset(136)] public SoftObjectPath PostProcessingMaterial;
        [FieldOffset(168)] public bool bDisableScreenPercentage;
        [FieldOffset(176)]  public IntPtr  PostProcessingMaterialPtr;
    }
    internal unsafe struct CompositionGraphCaptureProtocol_methods {
    }
    internal unsafe struct CompositionGraphCaptureProtocol_events {
    }
}
