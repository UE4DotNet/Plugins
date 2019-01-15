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
        ///<summary>Keyframe position data for one track.  Pos(i) occurs at Time(i).  Pos.Num() always equals Time.Num().</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct AnimNotifyTrack {
            [FieldOffset(0)] public Name TrackName;

            ///<summary>Track Color</summary>
            [FieldOffset(12)] LinearColor TrackColor;

        }
}
