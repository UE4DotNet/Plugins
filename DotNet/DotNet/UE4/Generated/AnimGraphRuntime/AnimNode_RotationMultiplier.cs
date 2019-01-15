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

using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>Simple controller that multiplies scalar value to the translation/rotation/scale of a single bone.</summary>
        [StructLayout( LayoutKind.Explicit, Size=416 )]
        public unsafe struct AnimNode_RotationMultiplier {
            ///<summary>Name of bone to control. This is the main bone chain to modify from.</summary>
            [FieldOffset(360)] BoneReference TargetBone;

            ///<summary>Source to get transform from</summary>
            [FieldOffset(384)] BoneReference SourceBone;

            [FieldOffset(408)] public float Multiplier;

            [FieldOffset(412)] public byte RotationAxisToRefer;

            [FieldOffset(413)] public bool bIsAdditive;

        }
}
