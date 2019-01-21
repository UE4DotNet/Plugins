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


namespace UE4.MaterialShaderQualitySettings{
        ///<summary>FMaterialQualityOverrides represents the full set of possible material overrides per quality level.</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct MaterialQualityOverrides {
            [FieldOffset(0)] public bool bDiscardQualityDuringCook;

            [FieldOffset(1)] public bool bEnableOverride;

            [FieldOffset(2)] public bool bForceFullyRough;

            [FieldOffset(3)] public bool bForceNonMetal;

            [FieldOffset(4)] public bool bForceDisableLMDirectionality;

            [FieldOffset(5)] public bool bForceLQReflections;

            [FieldOffset(6)] public bool bDisableMaterialNormalCalculation;

            [FieldOffset(7)] byte MobileCSMQuality; //TODO: enum EMobileCSMQuality MobileCSMQuality

        }
}
