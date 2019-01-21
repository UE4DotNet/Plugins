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


namespace UE4.MovieSceneTracks.Native {
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct MovieSceneEventTrack_fields {
        [FieldOffset(160)] public bool bFireEventsWhenForwards;
        [FieldOffset(160)] public bool bFireEventsWhenBackwards;
        [FieldOffset(164)] byte EventPosition; //TODO: enum EFireEventsAtPosition EventPosition
        [FieldOffset(168)] public NativeArray EventReceivers;
        [FieldOffset(184)] public NativeArray Sections;
    }
    internal unsafe struct MovieSceneEventTrack_methods {
    }
    internal unsafe struct MovieSceneEventTrack_events {
    }
}
