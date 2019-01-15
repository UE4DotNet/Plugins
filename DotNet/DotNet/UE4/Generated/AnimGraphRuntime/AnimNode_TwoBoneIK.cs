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
        [StructLayout( LayoutKind.Explicit, Size=784 )]
        public unsafe struct AnimNode_TwoBoneIK {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(360)] BoneReference IKBone;

            [FieldOffset(384)] public bool bAllowStretching;

            [FieldOffset(388)] public float StartStretchRatio;

            [FieldOffset(392)] public float MaxStretchScale;

            [FieldOffset(404)] public bool bTakeRotationFromEffectorSpace;

            [FieldOffset(404)] public bool bMaintainEffectorRelRot;

            [FieldOffset(408)] public byte EffectorLocationSpace;

            ///<summary>Effector Location. Target Location to reach.</summary>
            [FieldOffset(424)] Vector EffectorLocation;

            ///<summary>Effector Target</summary>
            [FieldOffset(448)] BoneSocketTarget EffectorTarget;

            [FieldOffset(560)] public byte JointTargetLocationSpace;

            ///<summary>Joint Target Location. Location used to orient Joint bone. *</summary>
            [FieldOffset(564)] Vector JointTargetLocation;

            ///<summary>Joint Target</summary>
            [FieldOffset(592)] BoneSocketTarget JointTarget;

            [FieldOffset(704)] public bool bAllowTwist;

            ///<summary>Specify which axis it's aligned. Used when removing twist</summary>
            [FieldOffset(708)] Axis TwistAxis;

        }
}
