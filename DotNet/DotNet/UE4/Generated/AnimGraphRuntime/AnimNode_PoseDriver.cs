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
        ///<summary>RBF based orientation driver</summary>
        [StructLayout( LayoutKind.Explicit, Size=384 )]
        public unsafe struct AnimNode_PoseDriver {
            ///<summary>Bones to use for driving parameters based on their transform</summary>
            [FieldOffset(168)] PoseLink SourcePose;

            [FieldOffset(192)] byte SourceBones; //TODO: array TArray SourceBones

            [FieldOffset(208)] public bool bOnlyDriveSelectedBones;

            [FieldOffset(216)] byte OnlyDriveBones; //TODO: array TArray OnlyDriveBones

            ///<summary>Optional other bone space to use when reading SourceBone transform.</summary>
            ///<remarks>If not specified, we just use local space of SourceBone (ie relative to parent bone)</remarks>
            [FieldOffset(232)] BoneReference EvalSpaceBone;

            ///<summary>Parameters used by RBF solver</summary>
            [FieldOffset(256)] RBFParams RBFParams;

            [FieldOffset(272)] byte DriveSource; //TODO: enum EPoseDriverSource DriveSource

            [FieldOffset(273)] byte DriveOutput; //TODO: enum EPoseDriverOutput DriveOutput

            [FieldOffset(280)] byte PoseTargets; //TODO: array TArray PoseTargets

        }
}
