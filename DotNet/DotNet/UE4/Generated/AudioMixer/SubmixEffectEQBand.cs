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


namespace UE4.AudioMixer{
        ///<summary>A multiband EQ submix effect.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct SubmixEffectEQBand {
            [FieldOffset(0)] public float Frequency;

            [FieldOffset(4)] public float Bandwidth;

            [FieldOffset(8)] public float GainDb;

            [FieldOffset(12)] public bool bEnabled;

        }
}
