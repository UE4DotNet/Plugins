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
        ///<summary>Movie Scene Fade Section Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=216 )]
        public unsafe struct MovieSceneFadeSectionTemplate {
            ///<summary>Fade Curve</summary>
            [FieldOffset(32)] MovieSceneFloatChannel FadeCurve;

            ///<summary>Fade Color</summary>
            [FieldOffset(192)] LinearColor FadeColor;

            [FieldOffset(208)] public bool bFadeAudio;

        }
}
