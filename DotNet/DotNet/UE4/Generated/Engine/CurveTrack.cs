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
        ///Key frame curve data for one track
        ///CurveName: Morph Target Name
        ///</summary>
        ///<remarks>CurveWeights: List of weights for each frame</remarks>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct CurveTrack {
            [FieldOffset(0)] public Name CurveName;

            [FieldOffset(16)] byte CurveWeights; //TODO: array TArray CurveWeights

        }
}
