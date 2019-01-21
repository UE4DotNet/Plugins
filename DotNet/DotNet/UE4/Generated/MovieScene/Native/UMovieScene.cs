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


namespace UE4.MovieScene.Native {
    [StructLayout( LayoutKind.Explicit, Size=720 )]
    internal unsafe struct UMovieScene_fields {
        [FieldOffset(112)] public MovieSceneTimecodeSource TimecodeSource;
        [FieldOffset(136)] public NativeArray Spawnables;
        [FieldOffset(152)] public NativeArray Possessables;
        [FieldOffset(168)] public NativeArray ObjectBindings;
        [FieldOffset(184)] public NativeArray MasterTracks;
        [FieldOffset(200)]  public IntPtr  CameraCutTrack;
        [FieldOffset(208)] public MovieSceneFrameRange SelectionRange;
        [FieldOffset(240)] public MovieSceneFrameRange PlaybackRange;
        [FieldOffset(272)] public FrameRate TickResolution;
        [FieldOffset(280)] public FrameRate DisplayRate;
        [FieldOffset(288)] byte EvaluationType; //TODO: enum EMovieSceneEvaluationType EvaluationType
        [FieldOffset(289)] byte ClockSource; //TODO: enum EUpdateClockSource ClockSource
        [FieldOffset(290)] public bool bReadOnly;
        [FieldOffset(291)] public bool bPlaybackRangeLocked;
        [FieldOffset(296)] byte ObjectsToDisplayNames; //TODO: map TMap ObjectsToDisplayNames
        [FieldOffset(376)] byte ObjectsToLabels; //TODO: map TMap ObjectsToLabels
        [FieldOffset(456)] public MovieSceneEditorData EditorData;
        [FieldOffset(680)] public NativeArray RootFolders;
    }
    internal unsafe struct UMovieScene_methods {
    }
    internal unsafe struct UMovieScene_events {
    }
}
