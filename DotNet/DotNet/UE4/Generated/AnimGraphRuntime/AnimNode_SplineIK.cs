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
        ///<summary>Anim Node Spline IK</summary>
        [StructLayout( LayoutKind.Explicit, Size=752 )]
        public unsafe struct AnimNode_SplineIK {
            ///<summary>Name of root bone from which the spline extends *</summary>
            [FieldOffset(336)] BoneReference StartBone;

            ///<summary>Name of bone at the end of the spline chain. Bones after this will not be altered by the controller.</summary>
            [FieldOffset(360)] BoneReference EndBone;

            [FieldOffset(384)] byte BoneAxis; //TODO: enum ESplineBoneAxis BoneAxis

            [FieldOffset(385)] public bool bAutoCalculateSpline;

            [FieldOffset(388)] public int PointCount;

            [FieldOffset(392)] byte ControlPoints; //TODO: array TArray ControlPoints

            [FieldOffset(408)] public float Roll;

            [FieldOffset(412)] public float TwistStart;

            [FieldOffset(416)] public float TwistEnd;

            ///<summary>How to interpolate twist along the length of the spline</summary>
            [FieldOffset(424)] AlphaBlend TwistBlend;

            [FieldOffset(480)] public float Stretch;

            [FieldOffset(484)] public float Offset;

            ///<summary>Spline we maintain internally</summary>
            [FieldOffset(600)] SplineCurves BoneSpline;

            [FieldOffset(696)] public float OriginalSplineLength;

            [FieldOffset(704)] byte CachedBoneReferences; //TODO: array TArray CachedBoneReferences

            [FieldOffset(720)] byte CachedBoneLengths; //TODO: array TArray CachedBoneLengths

            [FieldOffset(736)] byte CachedOffsetRotations; //TODO: array TArray CachedOffsetRotations

        }
}
