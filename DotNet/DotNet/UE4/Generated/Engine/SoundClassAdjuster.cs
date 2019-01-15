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
        ///<summary>Elements of data for sound group volume control</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct SoundClassAdjuster {
            [FieldOffset(0)] 
            private IntPtr  SoundClassObject_field;
            ///<summary>The sound class this adjuster affects.</summary>
            public SoundClass SoundClassObject {
                get {return SoundClassObject_field;}
                set {SoundClassObject_field = value;}
            }

            [FieldOffset(8)] public float VolumeAdjuster;

            [FieldOffset(12)] public float PitchAdjuster;

            [FieldOffset(16)] public bool bApplyToChildren;

            [FieldOffset(20)] public float VoiceCenterChannelVolumeAdjuster;

        }
}
