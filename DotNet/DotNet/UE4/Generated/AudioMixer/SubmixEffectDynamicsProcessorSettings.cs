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
        ///<summary>A submix dynamics processor</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct SubmixEffectDynamicsProcessorSettings {
            [FieldOffset(0)] byte DynamicsProcessorType; //TODO: enum ESubmixEffectDynamicsProcessorType DynamicsProcessorType

            [FieldOffset(1)] byte PeakMode; //TODO: enum ESubmixEffectDynamicsPeakMode PeakMode

            [FieldOffset(4)] public float LookAheadMsec;

            [FieldOffset(8)] public float AttackTimeMsec;

            [FieldOffset(12)] public float ReleaseTimeMsec;

            [FieldOffset(16)] public float ThresholdDb;

            [FieldOffset(20)] public float Ratio;

            [FieldOffset(24)] public float KneeBandwidthDb;

            [FieldOffset(28)] public float InputGainDb;

            [FieldOffset(32)] public float OutputGainDb;

            [FieldOffset(36)] public bool bChannelLinked;

            [FieldOffset(36)] public bool bAnalogMode;

        }
}
