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
        ///<summary>Evaluation data that specifies information about what to evaluate for a given template</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct SectionEvaluationData {
            [FieldOffset(0)] public int ImplIndex;

            ///<summary>A forced time to evaluate this section at</summary>
            [FieldOffset(4)] FrameNumber ForcedTime;

            [FieldOffset(8)] byte Flags; //TODO: enum ESectionEvaluationFlags Flags

        }
}
