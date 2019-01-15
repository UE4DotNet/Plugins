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
    [StructLayout( LayoutKind.Explicit, Size=312 )]
    internal unsafe struct MovieSceneSection_fields {
        [FieldOffset(112)] public MovieSceneSectionEvalOptions EvalOptions;
        [FieldOffset(120)] public MovieSceneEasingSettings Easing;
        [FieldOffset(192)] public MovieSceneFrameRange SectionRange;
        [FieldOffset(224)] public MovieSceneTimecodeSource TimecodeSource;
        [FieldOffset(248)] public FrameNumber PreRollFrames;
        [FieldOffset(252)] public FrameNumber PostRollFrames;
        [FieldOffset(256)] public int RowIndex;
        [FieldOffset(260)] public int OverlapPriority;
        [FieldOffset(264)] public bool bIsActive;
        [FieldOffset(264)] public bool bIsLocked;
        [FieldOffset(288)] public bool bSupportsInfiniteRange;
        [FieldOffset(289)] public OptionalMovieSceneBlendType BlendType;
    }
    internal unsafe struct MovieSceneSection_methods {
    }
    internal unsafe struct MovieSceneSection_events {
    }
}
