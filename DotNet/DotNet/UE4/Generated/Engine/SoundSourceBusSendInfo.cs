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
        ///<summary>Sound Source Bus Send Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct SoundSourceBusSendInfo {
            [FieldOffset(0)] public float SendLevel;

            [FieldOffset(8)] 
            private IntPtr  SoundSourceBus_field;
            ///<summary>The source bus to send the audio to</summary>
            public SoundSourceBus SoundSourceBus {
                get {return SoundSourceBus_field;}
                set {SoundSourceBus_field = value;}
            }

        }
}
