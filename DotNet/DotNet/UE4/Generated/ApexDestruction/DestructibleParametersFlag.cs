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
        ///<summary>Flags that apply to a destructible actor.</summary>
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        public unsafe struct DestructibleParametersFlag {
            [FieldOffset(0)] public bool bAccumulateDamage;

            [FieldOffset(0)] public bool bAssetDefinedSupport;

            [FieldOffset(0)] public bool bWorldSupport;

            [FieldOffset(0)] public bool bDebrisTimeout;

            [FieldOffset(0)] public bool bDebrisMaxSeparation;

            [FieldOffset(0)] public bool bCrumbleSmallestChunks;

            [FieldOffset(0)] public bool bAccurateRaycasts;

            [FieldOffset(0)] public bool bUseValidBounds;

            [FieldOffset(1)] public bool bFormExtendedStructures;

        }
}
