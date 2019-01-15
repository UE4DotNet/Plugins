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
        ///<summary>Color Grading Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=336 )]
        public unsafe struct ColorGradingSettings {
            ///<summary>Global</summary>
            [FieldOffset(0)] ColorGradePerRangeSettings Global;

            ///<summary>Shadows</summary>
            [FieldOffset(80)] ColorGradePerRangeSettings Shadows;

            ///<summary>Midtones</summary>
            [FieldOffset(160)] ColorGradePerRangeSettings Midtones;

            ///<summary>Highlights</summary>
            [FieldOffset(240)] ColorGradePerRangeSettings Highlights;

            [FieldOffset(320)] public float ShadowsMax;

            [FieldOffset(324)] public float HighlightsMin;

        }
}
