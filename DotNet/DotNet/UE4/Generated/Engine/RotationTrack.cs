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
        ///<summary>Keyframe rotation data for one track.  Rot(i) occurs at Time(i).  Rot.Num() always equals Time.Num().</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct RotationTrack {
            [FieldOffset(0)] byte RotKeys; //TODO: array TArray RotKeys

            [FieldOffset(16)] byte Times; //TODO: array TArray Times

        }
}
