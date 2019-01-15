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
        ///<summary>A small structure holding data for grouping subtracks. (For UI drawing purposes)</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct SubTrackGroup {
            [FieldOffset(0)] byte GroupName; //TODO: string FString GroupName

            [FieldOffset(16)] byte TrackIndices; //TODO: array TArray TrackIndices

            [FieldOffset(32)] public bool bIsCollapsed;

            [FieldOffset(32)] public bool bIsSelected;

        }
}
