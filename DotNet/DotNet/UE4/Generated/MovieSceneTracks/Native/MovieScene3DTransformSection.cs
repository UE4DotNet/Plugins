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

namespace UE4.MovieSceneTracks.Native {
    [StructLayout( LayoutKind.Explicit, Size=1928 )]
    internal unsafe struct MovieScene3DTransformSection_fields {
        [FieldOffset(312)] public MovieSceneTransformMask TransformMask;
        [FieldOffset(320)] public MovieSceneFloatChannel Translation;
        [FieldOffset(800)] public MovieSceneFloatChannel Rotation;
        [FieldOffset(1280)] public MovieSceneFloatChannel Scale;
        [FieldOffset(1760)] public MovieSceneFloatChannel ManualWeight;
        [FieldOffset(1924)] public bool bUseQuaternionInterpolation;
        [FieldOffset(1925)] byte Show3DTrajectory; //TODO: enum EShow3DTrajectory Show3DTrajectory
    }
    internal unsafe struct MovieScene3DTransformSection_methods {
    }
    internal unsafe struct MovieScene3DTransformSection_events {
    }
}
