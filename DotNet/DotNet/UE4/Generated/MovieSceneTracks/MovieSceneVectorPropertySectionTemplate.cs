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
        ///<summary>Movie Scene Vector Property Section Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=736 )]
        public unsafe struct MovieSceneVectorPropertySectionTemplate {
            ///<summary>Component Curves</summary>
            [FieldOffset(88)] MovieSceneFloatChannel ComponentCurves;

            [FieldOffset(728)] public int NumChannelsUsed;

            [FieldOffset(732)] byte BlendType; //TODO: enum EMovieSceneBlendType BlendType

        }
}
