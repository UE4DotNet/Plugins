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
        ///<summary>Parameters that pertain to chunk damage.</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct DestructibleDamageParameters {
            [FieldOffset(0)] public float DamageThreshold;

            [FieldOffset(4)] public float DamageSpread;

            [FieldOffset(8)] public bool bEnableImpactDamage;

            [FieldOffset(12)] public float ImpactDamage;

            [FieldOffset(16)] public int DefaultImpactDamageDepth;

            [FieldOffset(20)] public bool bCustomImpactResistance;

            [FieldOffset(24)] public float ImpactResistance;

        }
}
