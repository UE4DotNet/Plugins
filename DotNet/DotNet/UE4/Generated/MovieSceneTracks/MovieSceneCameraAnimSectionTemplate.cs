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


namespace UE4.MovieSceneTracks{
        ///<summary>Section template for a camera anim</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct MovieSceneCameraAnimSectionTemplate {
            ///<summary>Source data taken from the section</summary>
            [FieldOffset(32)] MovieSceneCameraAnimSectionData SourceData;

            ///<summary>Cached section start time</summary>
            [FieldOffset(64)] FrameNumber SectionStartTime;

        }
}
