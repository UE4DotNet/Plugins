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
        [StructLayout( LayoutKind.Explicit, Size=776 )]
        public unsafe struct AnimNode_SplineIK {
            ///<summary>Name of root bone from which the spline extends *</summary>
            [FieldOffset(360)] BoneReference StartBone;

            ///<summary>Name of bone at the end of the spline chain. Bones after this will not be altered by the controller.</summary>
            [FieldOffset(384)] BoneReference EndBone;

            [FieldOffset(408)] byte BoneAxis; //TODO: enum ESplineBoneAxis BoneAxis

            [FieldOffset(409)] public bool bAutoCalculateSpline;

            [FieldOffset(412)] public int PointCount;

            [FieldOffset(416)] byte ControlPoints; //TODO: array TArray ControlPoints

            [FieldOffset(432)] public float Roll;

            [FieldOffset(436)] public float TwistStart;

            [FieldOffset(440)] public float TwistEnd;

            ///<summary>How to interpolate twist along the length of the spline</summary>
            [FieldOffset(448)] AlphaBlend TwistBlend;

            [FieldOffset(504)] public float Stretch;

            [FieldOffset(508)] public float Offset;

            ///<summary>Spline we maintain internally</summary>
            [FieldOffset(624)] SplineCurves BoneSpline;

            [FieldOffset(720)] public float OriginalSplineLength;

            [FieldOffset(728)] byte CachedBoneReferences; //TODO: array TArray CachedBoneReferences

            [FieldOffset(744)] byte CachedBoneLengths; //TODO: array TArray CachedBoneLengths

            [FieldOffset(760)] byte CachedOffsetRotations; //TODO: array TArray CachedOffsetRotations

        }
}
