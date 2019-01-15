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

namespace UE4.MovieSceneTracks{
        ///<summary>Movie Scene Color Section Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=736 )]
        public unsafe struct MovieSceneColorSectionTemplate {
            ///<summary>Curve data as RGBA</summary>
            [FieldOffset(88)] MovieSceneFloatChannel Curves;

            [FieldOffset(728)] byte BlendType; //TODO: enum EMovieSceneBlendType BlendType

        }
}
