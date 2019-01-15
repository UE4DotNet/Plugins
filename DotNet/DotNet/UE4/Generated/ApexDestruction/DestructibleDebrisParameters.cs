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


namespace UE4.ApexDestruction{
        ///<summary>Parameters that pertain to chunk debris-level settings.</summary>
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct DestructibleDebrisParameters {
            [FieldOffset(0)] public float DebrisLifetimeMin;

            [FieldOffset(4)] public float DebrisLifetimeMax;

            [FieldOffset(8)] public float DebrisMaxSeparationMin;

            [FieldOffset(12)] public float DebrisMaxSeparationMax;

            ///<summary>"Debris chunks" (see debrisDepth, above) will be destroyed if they leave this box.</summary>
            ///<remarks>
            ///The box translates with the destructible actor's initial position, but does not
            ///rotate or scale.
            ///</remarks>
            [FieldOffset(16)] Box ValidBounds;

        }
}
