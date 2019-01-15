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
        ///<summary>Movie Scene 3DPath Section Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=224 )]
        public unsafe struct MovieScene3DPathSectionTemplate {
            ///<summary>The object binding ID of the path we should attach to</summary>
            [FieldOffset(32)] MovieSceneObjectBindingID PathBindingID;

            ///<summary>The timing curve</summary>
            [FieldOffset(56)] MovieSceneFloatChannel TimingCurve;

            [FieldOffset(216)] byte FrontAxisEnum; //TODO: enum MovieScene3DPathSection_Axis FrontAxisEnum

            [FieldOffset(217)] byte UpAxisEnum; //TODO: enum MovieScene3DPathSection_Axis UpAxisEnum

            [FieldOffset(220)] public bool bFollow;

            [FieldOffset(220)] public bool bReverse;

            [FieldOffset(220)] public bool bForceUpright;

        }
}
