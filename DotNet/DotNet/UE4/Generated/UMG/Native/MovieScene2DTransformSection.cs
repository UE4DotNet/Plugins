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

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=1448 )]
    internal unsafe struct MovieScene2DTransformSection_fields {
        [FieldOffset(312)] public MovieScene2DTransformMask TransformMask;
        [FieldOffset(320)] public MovieSceneFloatChannel Translation;
        [FieldOffset(640)] public MovieSceneFloatChannel Rotation;
        [FieldOffset(800)] public MovieSceneFloatChannel Scale;
        [FieldOffset(1120)] public MovieSceneFloatChannel Shear;
    }
    internal unsafe struct MovieScene2DTransformSection_methods {
    }
    internal unsafe struct MovieScene2DTransformSection_events {
    }
}
