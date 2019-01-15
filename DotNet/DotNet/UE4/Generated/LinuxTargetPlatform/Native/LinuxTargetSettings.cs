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


namespace UE4.LinuxTargetPlatform.Native {
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct LinuxTargetSettings_fields {
        [FieldOffset(56)] byte SpatializationPlugin; //TODO: string FString SpatializationPlugin
        [FieldOffset(72)] byte ReverbPlugin; //TODO: string FString ReverbPlugin
        [FieldOffset(88)] byte OcclusionPlugin; //TODO: string FString OcclusionPlugin
        [FieldOffset(104)] public NativeArray TargetedRHIs;
    }
    internal unsafe struct LinuxTargetSettings_methods {
    }
    internal unsafe struct LinuxTargetSettings_events {
    }
}
