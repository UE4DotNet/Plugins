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
        ///<summary>Parameters that are less-often used.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct DestructibleAdvancedParameters {
            [FieldOffset(0)] public float DamageCap;

            [FieldOffset(4)] public float ImpactVelocityThreshold;

            [FieldOffset(8)] public float MaxChunkSpeed;

            [FieldOffset(12)] public float FractureImpulseScale;

        }
}
