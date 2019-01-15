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


namespace UE4.WindowsTargetPlatform.Native {
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct WindowsTargetSettings_fields {
        [FieldOffset(56)] byte Compiler; //TODO: enum ECompilerVersion Compiler
        [FieldOffset(64)] public NativeArray TargetedRHIs;
        [FieldOffset(80)] byte MinimumOSVersion; //TODO: enum EMinimumSupportedOS MinimumOSVersion
        [FieldOffset(88)] byte AudioDevice; //TODO: string FString AudioDevice
        [FieldOffset(104)] public int AudioSampleRate;
        [FieldOffset(108)] public int AudioCallbackBufferFrameSize;
        [FieldOffset(112)] public int AudioNumBuffersToEnqueue;
        [FieldOffset(116)] public int AudioMaxChannels;
        [FieldOffset(120)] public int AudioNumSourceWorkers;
        [FieldOffset(128)] byte SpatializationPlugin; //TODO: string FString SpatializationPlugin
        [FieldOffset(144)] byte ReverbPlugin; //TODO: string FString ReverbPlugin
        [FieldOffset(160)] byte OcclusionPlugin; //TODO: string FString OcclusionPlugin
    }
    internal unsafe struct WindowsTargetSettings_methods {
    }
    internal unsafe struct WindowsTargetSettings_events {
    }
}
