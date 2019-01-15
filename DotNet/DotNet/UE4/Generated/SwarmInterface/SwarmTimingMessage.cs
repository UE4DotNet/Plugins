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


namespace UE4.SwarmInterface{
        ///<summary>Swarm Timing Message</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct SwarmTimingMessage {
            [FieldOffset(0)] public byte State;

            [FieldOffset(4)] public int ThreadNum;

        }
}
