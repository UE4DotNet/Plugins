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
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct MovieScenePropertyTrack_fields {
        [FieldOffset(152)] public Name UniqueTrackName;
        [FieldOffset(164)] public Name PropertyName;
        [FieldOffset(176)] byte PropertyPath; //TODO: string FString PropertyPath
        [FieldOffset(192)] public NativeArray Sections;
    }
    internal unsafe struct MovieScenePropertyTrack_methods {
    }
    internal unsafe struct MovieScenePropertyTrack_events {
    }
}
