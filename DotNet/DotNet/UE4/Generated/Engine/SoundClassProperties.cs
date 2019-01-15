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
        ///<summary>Structure containing configurable properties of a sound class.</summary>
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct SoundClassProperties {
            [FieldOffset(0)] public float Volume;

            [FieldOffset(4)] public float Pitch;

            [FieldOffset(8)] public float StereoBleed;

            [FieldOffset(12)] public float LFEBleed;

            [FieldOffset(16)] public float VoiceCenterChannelVolume;

            [FieldOffset(20)] public float RadioFilterVolume;

            [FieldOffset(24)] public float RadioFilterVolumeThreshold;

            [FieldOffset(28)] public bool bApplyEffects;

            [FieldOffset(28)] public bool bAlwaysPlay;

            [FieldOffset(28)] public bool bIsUISound;

            [FieldOffset(28)] public bool bIsMusic;

            [FieldOffset(28)] public bool bReverb;

            [FieldOffset(32)] public float Default2DReverbSendAmount;

            [FieldOffset(36)] public bool bCenterChannelOnly;

            [FieldOffset(36)] public bool bApplyAmbientVolumes;

            [FieldOffset(40)] public byte OutputTarget;

        }
}
