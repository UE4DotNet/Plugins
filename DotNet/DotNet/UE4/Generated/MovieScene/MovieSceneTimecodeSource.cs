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


namespace UE4.MovieScene{
        ///<summary>Movie Scene Timecode Source</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct MovieSceneTimecodeSource {
            ///<summary>The global timecode at which this target is based (ie. the timecode at the beginning of the movie scene section when it was recorded)</summary>
            [FieldOffset(0)] Timecode Timecode;

            ///<summary>The delta from the original placement of this target</summary>
            [FieldOffset(20)] FrameNumber DeltaFrame;

        }
}
