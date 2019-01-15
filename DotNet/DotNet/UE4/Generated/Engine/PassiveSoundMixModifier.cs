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
        ///<summary>Structure containing information on a SoundMix to activate passively.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct PassiveSoundMixModifier {
            [FieldOffset(0)] 
            private IntPtr  SoundMix_field;
            ///<summary>The SoundMix to activate</summary>
            public SoundMix SoundMix {
                get {return SoundMix_field;}
            }

            [FieldOffset(8)] public float MinVolumeThreshold;

            [FieldOffset(12)] public float MaxVolumeThreshold;

        }
}
