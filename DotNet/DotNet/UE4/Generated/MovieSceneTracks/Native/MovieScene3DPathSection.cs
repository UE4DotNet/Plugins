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
    [StructLayout( LayoutKind.Explicit, Size=520 )]
    internal unsafe struct MovieScene3DPathSection_fields {
        [FieldOffset(352)] public MovieSceneFloatChannel TimingCurve;
        [FieldOffset(512)] byte FrontAxisEnum; //TODO: enum MovieScene3DPathSection_Axis FrontAxisEnum
        [FieldOffset(513)] byte UpAxisEnum; //TODO: enum MovieScene3DPathSection_Axis UpAxisEnum
        [FieldOffset(516)] public bool bFollow;
        [FieldOffset(516)] public bool bReverse;
        [FieldOffset(516)] public bool bForceUpright;
    }
    internal unsafe struct MovieScene3DPathSection_methods {
    }
    internal unsafe struct MovieScene3DPathSection_events {
    }
}
