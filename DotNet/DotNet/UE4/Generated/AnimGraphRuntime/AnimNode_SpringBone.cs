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
        [StructLayout( LayoutKind.Explicit, Size=464 )]
        public unsafe struct AnimNode_SpringBone {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(360)] BoneReference SpringBone;

            [FieldOffset(384)] public bool bLimitDisplacement;

            [FieldOffset(388)] public float MaxDisplacement;

            [FieldOffset(392)] public float SpringStiffness;

            [FieldOffset(396)] public float SpringDamping;

            [FieldOffset(400)] public float ErrorResetThresh;

            [FieldOffset(405)] public bool bTranslateX;

            [FieldOffset(406)] public bool bTranslateY;

            [FieldOffset(407)] public bool bTranslateZ;

            [FieldOffset(408)] public bool bRotateX;

            [FieldOffset(409)] public bool bRotateY;

            [FieldOffset(410)] public bool bRotateZ;

        }
}
