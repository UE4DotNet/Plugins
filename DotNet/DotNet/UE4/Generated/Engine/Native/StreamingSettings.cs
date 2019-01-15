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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct StreamingSettings_fields {
        [FieldOffset(80)] public bool AsyncLoadingThreadEnabled;
        [FieldOffset(80)] public bool WarnIfTimeLimitExceeded;
        [FieldOffset(84)] public float TimeLimitExceededMultiplier;
        [FieldOffset(88)] public float TimeLimitExceededMinTime;
        [FieldOffset(92)] public int MinBulkDataSizeForAsyncLoading;
        [FieldOffset(96)] public bool UseBackgroundLevelStreaming;
        [FieldOffset(96)] public bool AsyncLoadingUseFullTimeLimit;
        [FieldOffset(100)] public float AsyncLoadingTimeLimit;
        [FieldOffset(104)] public float PriorityAsyncLoadingExtraTime;
        [FieldOffset(108)] public float LevelStreamingActorsUpdateTimeLimit;
        [FieldOffset(112)] public float PriorityLevelStreamingActorsUpdateExtraTime;
        [FieldOffset(116)] public int LevelStreamingComponentsRegistrationGranularity;
        [FieldOffset(120)] public float LevelStreamingUnregisterComponentsTimeLimit;
        [FieldOffset(124)] public int LevelStreamingComponentsUnregistrationGranularity;
        [FieldOffset(128)] public bool EventDrivenLoaderEnabled;
    }
    internal unsafe struct StreamingSettings_methods {
    }
    internal unsafe struct StreamingSettings_events {
    }
}
