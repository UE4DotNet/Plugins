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

namespace UE4.UMG{
        ///<summary>Movie Scene Margin Section Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=736 )]
        public unsafe struct MovieSceneMarginSectionTemplate {
            ///<summary>Top Curve</summary>
            [FieldOffset(88)] MovieSceneFloatChannel TopCurve;

            ///<summary>Left Curve</summary>
            [FieldOffset(248)] MovieSceneFloatChannel LeftCurve;

            ///<summary>Right Curve</summary>
            [FieldOffset(408)] MovieSceneFloatChannel RightCurve;

            ///<summary>Bottom Curve</summary>
            [FieldOffset(568)] MovieSceneFloatChannel BottomCurve;

            [FieldOffset(728)] byte BlendType; //TODO: enum EMovieSceneBlendType BlendType

        }
}
