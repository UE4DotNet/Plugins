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


namespace UE4.MacTargetPlatform.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct MacTargetSettings_fields {
        [FieldOffset(56)] public NativeArray TargetedRHIs;
        [FieldOffset(72)] public byte MaxShaderLanguageVersion;
        [FieldOffset(73)] public bool UseFastIntrinsics;
        [FieldOffset(74)] public bool EnableMathOptimisations;
        [FieldOffset(76)] public int AudioSampleRate;
        [FieldOffset(80)] public int AudioCallbackBufferFrameSize;
        [FieldOffset(84)] public int AudioNumBuffersToEnqueue;
        [FieldOffset(88)] public int AudioMaxChannels;
        [FieldOffset(92)] public int AudioNumSourceWorkers;
        [FieldOffset(96)] byte SpatializationPlugin; //TODO: string FString SpatializationPlugin
        [FieldOffset(112)] byte ReverbPlugin; //TODO: string FString ReverbPlugin
        [FieldOffset(128)] byte OcclusionPlugin; //TODO: string FString OcclusionPlugin
    }
    internal unsafe struct MacTargetSettings_methods {
    }
    internal unsafe struct MacTargetSettings_events {
    }
}
