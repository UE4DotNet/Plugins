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
        ///<summary>Movie scene sequence transform class that transforms from one time-space to another.</summary>
        ///<remarks>
        ///@note The transform can be thought of as the top row of a 2x2 matrix, where the bottom row is the identity:
        ///                    | TimeScale     Offset  |
        ///                    | 0                     1               |
        ///
        ///As such, traditional matrix mathematics can be applied to transform between different sequence's time-spaces.
        ///Transforms apply offset first, then time scale.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct MovieSceneSequenceTransform {
            [FieldOffset(0)] public float TimeScale;

            ///<summary>Scalar frame offset applied before the scale</summary>
            [FieldOffset(4)] FrameTime Offset;

        }
}
