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
        ///<summary>Movie Scene Camera Anim Section Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct MovieSceneCameraAnimSectionData {
            [FieldOffset(0)] 
            private IntPtr  CameraAnim_field;
            ///<summary>The camera anim to play</summary>
            public CameraAnim CameraAnim {
                get {return CameraAnim_field;}
                set {CameraAnim_field = value;}
            }

            [FieldOffset(8)] public float PlayRate;

            [FieldOffset(12)] public float PlayScale;

            [FieldOffset(16)] public float BlendInTime;

            [FieldOffset(20)] public float BlendOutTime;

            [FieldOffset(24)] public bool bLooping;

        }
}
