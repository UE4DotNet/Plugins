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
        ///<summary>Anim Node CCDIK</summary>
        [StructLayout( LayoutKind.Explicit, Size=560 )]
        public unsafe struct AnimNode_CCDIK {
            ///<summary>Coordinates for target location of tip bone - if EffectorLocationSpace is bone, this is the offset from Target Bone to use as target location</summary>
            [FieldOffset(336)] Vector EffectorLocation;

            [FieldOffset(348)] public byte EffectorLocationSpace;

            ///<summary>If EffectorTransformSpace is a bone, this is the bone to use. *</summary>
            [FieldOffset(352)] BoneSocketTarget EffectorTarget;

            ///<summary>Name of tip bone</summary>
            [FieldOffset(464)] BoneReference TipBone;

            ///<summary>Name of the root bone</summary>
            [FieldOffset(488)] BoneReference RootBone;

            [FieldOffset(512)] public float Precision;

            [FieldOffset(516)] public int MaxIterations;

            [FieldOffset(520)] public bool bStartFromTail;

            [FieldOffset(521)] public bool bEnableRotationLimit;

            [FieldOffset(528)] byte RotationLimitPerJoints; //TODO: array TArray RotationLimitPerJoints

        }
}
