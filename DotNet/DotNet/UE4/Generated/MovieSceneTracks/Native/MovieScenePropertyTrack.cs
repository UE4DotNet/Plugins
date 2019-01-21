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
    [StructLayout( LayoutKind.Explicit, Size=216 )]
    internal unsafe struct MovieScenePropertyTrack_fields {
        [FieldOffset(160)] public Name UniqueTrackName;
        [FieldOffset(172)] public Name PropertyName;
        [FieldOffset(184)] byte PropertyPath; //TODO: string FString PropertyPath
        [FieldOffset(200)] public NativeArray Sections;
    }
    internal unsafe struct MovieScenePropertyTrack_methods {
    }
    internal unsafe struct MovieScenePropertyTrack_events {
    }
}
