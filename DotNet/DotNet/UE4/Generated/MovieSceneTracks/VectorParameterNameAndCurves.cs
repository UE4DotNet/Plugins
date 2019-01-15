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
        ///<summary>Structure representing an animated vector parameter and it's associated animation curve.</summary>
        [StructLayout( LayoutKind.Explicit, Size=496 )]
        public unsafe struct VectorParameterNameAndCurves {
            [FieldOffset(0)] public Name ParameterName;

            ///<summary>The curve which contains the animation data for the x component of the vector parameter.</summary>
            [FieldOffset(16)] MovieSceneFloatChannel XCurve;

            ///<summary>The curve which contains the animation data for the y component of the vector parameter.</summary>
            [FieldOffset(176)] MovieSceneFloatChannel YCurve;

            ///<summary>The curve which contains the animation data for the z component of the vector parameter.</summary>
            [FieldOffset(336)] MovieSceneFloatChannel ZCurve;

        }
}
