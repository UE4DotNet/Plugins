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
        ///<summary>Constraint node to parent or world transform for rotation/translation</summary>
        [StructLayout( LayoutKind.Explicit, Size=528 )]
        public unsafe struct AnimNode_Constraint {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(336)] BoneReference BoneToModify;

            [FieldOffset(360)] byte ConstraintSetup; //TODO: array TArray ConstraintSetup

            [FieldOffset(376)] byte ConstraintWeights; //TODO: array TArray ConstraintWeights

        }
}
