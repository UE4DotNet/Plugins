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
        ///<summary>Particle Random Seed Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct ParticleRandomSeedInfo {
            [FieldOffset(0)] public Name ParameterName;

            [FieldOffset(12)] public bool bGetSeedFromInstance;

            [FieldOffset(12)] public bool bInstanceSeedIsIndex;

            [FieldOffset(12)] public bool bResetSeedOnEmitterLooping;

            [FieldOffset(12)] public bool bRandomlySelectSeedArray;

            [FieldOffset(16)] byte RandomSeeds; //TODO: array TArray RandomSeeds

        }
}
