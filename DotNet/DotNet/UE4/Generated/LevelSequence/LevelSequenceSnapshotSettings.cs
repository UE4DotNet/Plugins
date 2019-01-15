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


namespace UE4.LevelSequence{
        ///<summary>Level Sequence Snapshot Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct LevelSequenceSnapshotSettings {
            [FieldOffset(0)] public byte ZeroPadAmount;

            ///<summary>Playback framerate</summary>
            [FieldOffset(4)] FrameRate FrameRate;

        }
}
