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
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct TimelineTemplate_fields {
        [FieldOffset(56)] public float TimelineLength;
        [FieldOffset(60)] public byte LengthMode;
        [FieldOffset(64)] public bool bAutoPlay;
        [FieldOffset(64)] public bool bLoop;
        [FieldOffset(64)] public bool bReplicated;
        [FieldOffset(64)] public bool bValidatedAsWired;
        [FieldOffset(64)] public bool bIgnoreTimeDilation;
        [FieldOffset(72)] public NativeArray EventTracks;
        [FieldOffset(88)] public NativeArray FloatTracks;
        [FieldOffset(104)] public NativeArray VectorTracks;
        [FieldOffset(120)] public NativeArray LinearColorTracks;
        [FieldOffset(136)] public NativeArray MetaDataArray;
        [FieldOffset(152)] public FGuid TimelineGuid;
    }
    internal unsafe struct TimelineTemplate_methods {
    }
    internal unsafe struct TimelineTemplate_events {
    }
}
