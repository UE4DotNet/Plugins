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
        ///<summary>Camera cut track evaluation template</summary>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct MovieSceneCameraCutSectionTemplate {
            ///<summary>GUID of the camera we should cut to in this sequence</summary>
            [FieldOffset(32)] MovieSceneObjectBindingID CameraBindingID;

            ///<summary>Cut Transform</summary>
            [FieldOffset(64)] Transform CutTransform;

            [FieldOffset(112)] public bool bHasCutTransform;

        }
}
