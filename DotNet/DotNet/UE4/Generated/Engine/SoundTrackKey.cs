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
        ///<summary>Information for one sound in the track.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct SoundTrackKey {
            [FieldOffset(0)] public float Time;

            [FieldOffset(4)] public float Volume;

            [FieldOffset(8)] public float Pitch;

            [FieldOffset(16)] 
            private IntPtr  Sound_field;
            ///<summary>Sound</summary>
            public SoundBase Sound {
                get {return Sound_field;}
                set {Sound_field = value;}
            }

        }
}
