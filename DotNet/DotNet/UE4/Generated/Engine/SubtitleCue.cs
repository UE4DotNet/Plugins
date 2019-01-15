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
        ///<summary>A line of subtitle text and the time at which it should be displayed.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct SubtitleCue {
            [FieldOffset(0)] byte Text; //TODO: text FText Text

            [FieldOffset(24)] public float Time;

        }
}
