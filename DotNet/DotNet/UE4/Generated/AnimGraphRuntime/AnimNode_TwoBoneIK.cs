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
        ///<summary>Simple 2 Bone IK Controller.</summary>
        [StructLayout( LayoutKind.Explicit, Size=752 )]
        public unsafe struct AnimNode_TwoBoneIK {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(336)] BoneReference IKBone;

            [FieldOffset(360)] public bool bAllowStretching;

            [FieldOffset(364)] public float StartStretchRatio;

            [FieldOffset(368)] public float MaxStretchScale;

            [FieldOffset(380)] public bool bTakeRotationFromEffectorSpace;

            [FieldOffset(380)] public bool bMaintainEffectorRelRot;

            [FieldOffset(384)] public byte EffectorLocationSpace;

            ///<summary>Effector Location. Target Location to reach.</summary>
            [FieldOffset(400)] Vector EffectorLocation;

            ///<summary>Effector Target</summary>
            [FieldOffset(416)] BoneSocketTarget EffectorTarget;

            [FieldOffset(528)] public byte JointTargetLocationSpace;

            ///<summary>Joint Target Location. Location used to orient Joint bone. *</summary>
            [FieldOffset(532)] Vector JointTargetLocation;

            ///<summary>Joint Target</summary>
            [FieldOffset(560)] BoneSocketTarget JointTarget;

            [FieldOffset(672)] public bool bAllowTwist;

            ///<summary>Specify which axis it's aligned. Used when removing twist</summary>
            [FieldOffset(676)] Axis TwistAxis;

        }
}
