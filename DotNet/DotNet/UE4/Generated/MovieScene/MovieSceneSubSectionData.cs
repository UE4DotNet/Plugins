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
        ///<summary>Data that represents a single sub-section</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct MovieSceneSubSectionData {
            [FieldOffset(0)] byte Section; //TODO: weak object TWeakObjectPtr<UMovieSceneSubSection> Section

            ///<summary>The object binding that the sub section belongs to (usually zero)</summary>
            [FieldOffset(8)] FGuid ObjectBindingId;

            [FieldOffset(24)] byte Flags; //TODO: enum ESectionEvaluationFlags Flags

        }
}
