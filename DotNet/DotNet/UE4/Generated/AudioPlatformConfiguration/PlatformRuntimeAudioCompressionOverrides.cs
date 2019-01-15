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


namespace UE4.AudioPlatformConfiguration{
        ///<summary>Platform Runtime Audio Compression Overrides</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct PlatformRuntimeAudioCompressionOverrides {
            [FieldOffset(0)] public bool bOverrideCompressionTimes;

            [FieldOffset(4)] public float DurationThreshold;

            [FieldOffset(8)] public int MaxNumRandomBranches;

            [FieldOffset(12)] public int SoundCueQualityIndex;

        }
}
