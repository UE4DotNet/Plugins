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
        ///<summary>Parameters that apply to a destructible actor.</summary>
        [StructLayout( LayoutKind.Explicit, Size=136 )]
        public unsafe struct DestructibleParameters {
            ///<summary>Parameters that pertain to chunk damage.  See DestructibleDamageParameters.</summary>
            [FieldOffset(0)] DestructibleDamageParameters DamageParameters;

            ///<summary>Parameters that pertain to chunk debris-level settings.  See DestructibleDebrisParameters.</summary>
            [FieldOffset(28)] DestructibleDebrisParameters DebrisParameters;

            ///<summary>Parameters that are less-often used.  See DestructibleAdvancedParameters.</summary>
            [FieldOffset(72)] DestructibleAdvancedParameters AdvancedParameters;

            ///<summary>Special hierarchy depths for various behaviors.</summary>
            [FieldOffset(88)] DestructibleSpecialHierarchyDepths SpecialHierarchyDepths;

            [FieldOffset(112)] byte DepthParameters; //TODO: array TArray DepthParameters

            ///<summary>A collection of flags defined in DestructibleParametersFlag.</summary>
            [FieldOffset(128)] DestructibleParametersFlag Flags;

        }
}
