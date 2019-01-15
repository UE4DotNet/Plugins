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
        ///<summary>Simple structure to allow overriding asset rules for a specific primary asset. This can be used to set chunks</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct PrimaryAssetRulesOverride {
            ///<summary>Which primary asset to override the rules for</summary>
            [FieldOffset(0)] PrimaryAssetId PrimaryAssetId;

            ///<summary>What to overrides the rules with</summary>
            [FieldOffset(24)] PrimaryAssetRules Rules;

        }
}
