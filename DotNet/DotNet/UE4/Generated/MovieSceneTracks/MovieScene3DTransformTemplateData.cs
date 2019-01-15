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
        ///<summary>Movie Scene 3DTransform Template Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=1616 )]
        public unsafe struct MovieScene3DTransformTemplateData {
            ///<summary>Translation Curve</summary>
            [FieldOffset(0)] MovieSceneFloatChannel TranslationCurve;

            ///<summary>Rotation Curve</summary>
            [FieldOffset(480)] MovieSceneFloatChannel RotationCurve;

            ///<summary>Scale Curve</summary>
            [FieldOffset(960)] MovieSceneFloatChannel ScaleCurve;

            ///<summary>Manual Weight</summary>
            [FieldOffset(1440)] MovieSceneFloatChannel ManualWeight;

            [FieldOffset(1600)] byte BlendType; //TODO: enum EMovieSceneBlendType BlendType

            ///<summary>Mask</summary>
            [FieldOffset(1604)] MovieSceneTransformMask Mask;

            [FieldOffset(1608)] public bool bUseQuaternionInterpolation;

        }
}
