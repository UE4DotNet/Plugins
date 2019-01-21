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
        ///<summary>Simple controller that replaces or adds to the translation/rotation of a single bone.</summary>
        [StructLayout( LayoutKind.Explicit, Size=440 )]
        public unsafe struct AnimNode_SpringBone {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(336)] BoneReference SpringBone;

            [FieldOffset(360)] public bool bLimitDisplacement;

            [FieldOffset(364)] public float MaxDisplacement;

            [FieldOffset(368)] public float SpringStiffness;

            [FieldOffset(372)] public float SpringDamping;

            [FieldOffset(376)] public float ErrorResetThresh;

            [FieldOffset(381)] public bool bTranslateX;

            [FieldOffset(382)] public bool bTranslateY;

            [FieldOffset(383)] public bool bTranslateZ;

            [FieldOffset(384)] public bool bRotateX;

            [FieldOffset(385)] public bool bRotateY;

            [FieldOffset(386)] public bool bRotateZ;

        }
}
