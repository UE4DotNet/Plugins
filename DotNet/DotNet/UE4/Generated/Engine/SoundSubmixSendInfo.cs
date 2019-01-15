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
        ///<summary>Class used to send audio to submixes from USoundBase</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct SoundSubmixSendInfo {
            [FieldOffset(0)] public float SendLevel;

            [FieldOffset(8)] 
            private IntPtr  SoundSubmix_field;
            ///<summary>The submix to send the audio to</summary>
            public SoundSubmix SoundSubmix {
                get {return SoundSubmix_field;}
                set {SoundSubmix_field = value;}
            }

        }
}
