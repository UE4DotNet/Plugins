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
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct InterpTrack_fields {
        [FieldOffset(72)] public NativeArray SubTracks;
        [FieldOffset(88)] public NativeArray SubTrackGroups;
        [FieldOffset(104)] public NativeArray SupportedSubTracks;
        [FieldOffset(120)] public IntPtr TrackInstClass;
        [FieldOffset(128)] public byte ActiveCondition;
        [FieldOffset(136)] byte TrackTitle; //TODO: string FString TrackTitle
        [FieldOffset(152)] public bool bOnePerGroup;
        [FieldOffset(152)] public bool bDirGroupOnly;
        [FieldOffset(152)] public bool bDisableTrack;
        [FieldOffset(152)] public bool bIsSelected;
        [FieldOffset(160)]  public IntPtr  TrackIcon;
        [FieldOffset(168)] public bool bIsAnimControlTrack;
        [FieldOffset(168)] public bool bSubTrackOnly;
        [FieldOffset(168)] public bool bVisible;
        [FieldOffset(168)] public bool bIsRecording;
        [FieldOffset(168)] public bool bIsCollapsed;
    }
    internal unsafe struct InterpTrack_methods {
    }
    internal unsafe struct InterpTrack_events {
    }
}
