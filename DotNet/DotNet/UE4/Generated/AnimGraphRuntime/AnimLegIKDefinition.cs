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
        ///<summary>Per foot definitions</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct AnimLegIKDefinition {
            ///<summary>IKFoot Bone</summary>
            [FieldOffset(0)] BoneReference IKFootBone;

            ///<summary>FKFoot Bone</summary>
            [FieldOffset(24)] BoneReference FKFootBone;

            [FieldOffset(48)] public int NumBonesInLimb;

            [FieldOffset(52)] public byte FootBoneForwardAxis;

            [FieldOffset(53)] public byte HingeRotationAxis;

            [FieldOffset(54)] public bool bEnableRotationLimit;

            [FieldOffset(56)] public float MinRotationAngle;

            [FieldOffset(60)] public bool bEnableKneeTwistCorrection;

        }
}
