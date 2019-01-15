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
        ///<summary>Lookup table index for a group of evaluation templates</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct MovieSceneEvaluationGroupLUTIndex {
            [FieldOffset(0)] public int LUTOffset;

            [FieldOffset(4)] public int NumInitPtrs;

            [FieldOffset(8)] public int NumEvalPtrs;

        }
}
