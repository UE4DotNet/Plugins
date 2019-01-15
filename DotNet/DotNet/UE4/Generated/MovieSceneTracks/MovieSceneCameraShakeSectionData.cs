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

using UE4.Engine;

namespace UE4.MovieSceneTracks{
        ///<summary>Movie Scene Camera Shake Section Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct MovieSceneCameraShakeSectionData {
            ///<summary>Class of the camera shake to play</summary>
            public SubclassOf<CameraShake> ShakeClass {
                get {return ShakeClass_class; }
                set {ShakeClass_class = value; }
            }
            [FieldOffset(0)] private IntPtr ShakeClass_class;

            [FieldOffset(8)] public float PlayScale;

            [FieldOffset(12)] public byte PlaySpace;

            ///<summary>User Defined Play Space</summary>
            [FieldOffset(16)] Rotator UserDefinedPlaySpace;

        }
}
