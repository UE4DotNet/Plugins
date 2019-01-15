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
        ///<summary>Structure representing an animated scalar parameter and it's associated animation curve.</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct ScalarParameterNameAndCurve {
            [FieldOffset(0)] public Name ParameterName;

            ///<summary>The curve which contains the animation data for the scalar parameter.</summary>
            [FieldOffset(16)] MovieSceneFloatChannel ParameterCurve;

        }
}
