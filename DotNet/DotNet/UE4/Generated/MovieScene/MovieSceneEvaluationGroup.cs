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
        ///<summary>Holds segment pointers for all segments that are active for a given range of the sequence</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct MovieSceneEvaluationGroup {
            [FieldOffset(0)] byte LUTIndices; //TODO: array TArray LUTIndices

            [FieldOffset(16)] byte SegmentPtrLUT; //TODO: array TArray SegmentPtrLUT

        }
}
