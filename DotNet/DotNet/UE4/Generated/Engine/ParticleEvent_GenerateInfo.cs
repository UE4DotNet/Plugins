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
        ///<summary>Particle Event Generate Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct ParticleEvent_GenerateInfo {
            [FieldOffset(0)] public byte Type;

            [FieldOffset(4)] public int Frequency;

            [FieldOffset(8)] public int ParticleFrequency;

            [FieldOffset(12)] public bool FirstTimeOnly;

            [FieldOffset(12)] public bool LastTimeOnly;

            [FieldOffset(12)] public bool UseReflectedImpactVector;

            [FieldOffset(12)] public bool bUseOrbitOffset;

            [FieldOffset(16)] public Name CustomName;

            [FieldOffset(32)] byte ParticleModuleEventsToSendToGame; //TODO: array TArray ParticleModuleEventsToSendToGame

        }
}
