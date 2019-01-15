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

namespace UE4.ActorSequence.Native {
    [StructLayout( LayoutKind.Explicit, Size=344 )]
    internal unsafe struct ActorSequenceComponent_fields {
        [FieldOffset(256)] public bool bAutoPlay;
        [FieldOffset(264)] public MovieSceneSequencePlaybackSettings PlaybackSettings;
        [FieldOffset(328)]  public IntPtr  Sequence;
        [FieldOffset(336)]  public IntPtr  SequencePlayer;
    }
    internal unsafe struct ActorSequenceComponent_methods {
    }
    internal unsafe struct ActorSequenceComponent_events {
    }
}
