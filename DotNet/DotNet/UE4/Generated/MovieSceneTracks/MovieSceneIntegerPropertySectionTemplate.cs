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
        ///<summary>Movie Scene Integer Property Section Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=240 )]
        public unsafe struct MovieSceneIntegerPropertySectionTemplate {
            ///<summary>Integer Curve</summary>
            [FieldOffset(88)] MovieSceneIntegerChannel IntegerCurve;

            [FieldOffset(232)] byte BlendType; //TODO: enum EMovieSceneBlendType BlendType

        }
}
