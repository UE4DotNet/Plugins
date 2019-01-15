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


namespace UE4.AlembicLibrary{
        ///<summary>Abc Sampling Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct AbcSamplingSettings {
            [FieldOffset(0)] byte SamplingType; //TODO: enum EAlembicSamplingType SamplingType

            [FieldOffset(4)] public int FrameSteps;

            [FieldOffset(8)] public float TimeSteps;

            [FieldOffset(12)] public int FrameStart;

            [FieldOffset(16)] public int FrameEnd;

            [FieldOffset(20)] public bool bSkipEmpty;

        }
}
