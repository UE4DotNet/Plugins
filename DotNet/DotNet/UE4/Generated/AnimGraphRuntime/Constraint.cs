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
using UE4.AnimationCore;

namespace UE4.AnimGraphRuntime{
        ///<summary>Constraint Set up</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct Constraint {
            ///<summary>Target Bone this is constraint to</summary>
            [FieldOffset(0)] BoneReference TargetBone;

            [FieldOffset(24)] byte OffsetOption; //TODO: enum EConstraintOffsetOption OffsetOption

            [FieldOffset(25)] byte TransformType; //TODO: enum ETransformConstraintType TransformType

            ///<summary>Per axis filter options - applied in their local space not in world space</summary>
            [FieldOffset(26)] FilterOptionPerAxis PerAxis;

        }
}
