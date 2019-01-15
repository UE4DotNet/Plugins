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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct CompositionGraphCaptureSettings_fields {
        [FieldOffset(56)] public CompositionGraphCapturePasses IncludeRenderPasses;
        [FieldOffset(72)] public bool bCaptureFramesInHDR;
        [FieldOffset(76)] public int HDRCompressionQuality;
        [FieldOffset(80)] public byte CaptureGamut;
        [FieldOffset(88)] public SoftObjectPath PostProcessingMaterial;
        [FieldOffset(120)] public bool bDisableScreenPercentage;
    }
    internal unsafe struct CompositionGraphCaptureSettings_methods {
    }
    internal unsafe struct CompositionGraphCaptureSettings_events {
    }
}
