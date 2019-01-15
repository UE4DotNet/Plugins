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
        ///<summary>Movie Scene 2DTransform Section Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=1216 )]
        public unsafe struct MovieScene2DTransformSectionTemplate {
            ///<summary>Translation curves</summary>
            [FieldOffset(88)] MovieSceneFloatChannel Translation;

            ///<summary>Rotation curve</summary>
            [FieldOffset(408)] MovieSceneFloatChannel Rotation;

            ///<summary>Scale curves</summary>
            [FieldOffset(568)] MovieSceneFloatChannel Scale;

            ///<summary>Shear curve</summary>
            [FieldOffset(888)] MovieSceneFloatChannel Shear;

            [FieldOffset(1208)] byte BlendType; //TODO: enum EMovieSceneBlendType BlendType

            ///<summary>Mask</summary>
            [FieldOffset(1212)] MovieScene2DTransformMask Mask;

        }
}
