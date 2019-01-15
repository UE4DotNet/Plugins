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


namespace UE4.Engine{
        ///<summary>
        ///This is list of anim segments for this track
        ///For now this is only one TArray, but in the future
        ///</summary>
        ///<remarks>we should define more transition/blending behaviors</remarks>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct AnimTrack {
            [FieldOffset(0)] byte AnimSegments; //TODO: array TArray AnimSegments

        }
}
