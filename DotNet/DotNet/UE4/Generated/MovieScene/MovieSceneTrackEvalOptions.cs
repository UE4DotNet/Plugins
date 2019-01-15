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
        ///<summary>Generic evaluation options for any track</summary>
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        public unsafe struct MovieSceneTrackEvalOptions {
            [FieldOffset(0)] public bool bCanEvaluateNearestSection;

            [FieldOffset(0)] public bool bEvalNearestSection;

            [FieldOffset(0)] public bool bEvaluateInPreroll;

            [FieldOffset(0)] public bool bEvaluateInPostroll;

        }
}
