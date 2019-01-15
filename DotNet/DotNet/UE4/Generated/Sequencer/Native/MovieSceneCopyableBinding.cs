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

using UE4.MovieScene;

namespace UE4.Sequencer.Native {
    [StructLayout( LayoutKind.Explicit, Size=384 )]
    internal unsafe struct MovieSceneCopyableBinding_fields {
        [FieldOffset(56)]  public IntPtr  SpawnableObjectTemplate;
        [FieldOffset(64)] public NativeArray Tracks;
        [FieldOffset(80)] public MovieSceneBinding Binding;
        [FieldOffset(144)] public MovieSceneSpawnable Spawnable;
        [FieldOffset(304)] public MovieScenePossessable Possessable;
    }
    internal unsafe struct MovieSceneCopyableBinding_methods {
    }
    internal unsafe struct MovieSceneCopyableBinding_events {
    }
}
