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
        ///<summary>This is the runtime version of a bone driven controller, which maps part of the state from one bone to another (e.g., 2 * source.x -> target.z)</summary>
        [StructLayout( LayoutKind.Explicit, Size=456 )]
        public unsafe struct AnimNode_BoneDrivenController {
            ///<summary>Bone to use as controller input</summary>
            [FieldOffset(336)] BoneReference SourceBone;

            [FieldOffset(360)] public byte SourceComponent;

            [FieldOffset(368)] 
            private IntPtr  DrivingCurve_field;
            ///<summary>Curve used to map from the source attribute to the driven attributes if present (otherwise the Multiplier will be used)</summary>
            public CurveFloat DrivingCurve {
                get {return DrivingCurve_field;}
                set {DrivingCurve_field = value;}
            }

            [FieldOffset(376)] public float Multiplier;

            [FieldOffset(380)] public bool bUseRange;

            [FieldOffset(384)] public float RangeMin;

            [FieldOffset(388)] public float RangeMax;

            [FieldOffset(392)] public float RemappedMin;

            [FieldOffset(396)] public float RemappedMax;

            [FieldOffset(400)] byte DestinationMode; //TODO: enum EDrivenDestinationMode DestinationMode

            [FieldOffset(404)] public Name ParameterName;

            ///<summary>Bone to drive using controller input</summary>
            [FieldOffset(416)] BoneReference TargetBone;

            [FieldOffset(444)] public bool bAffectTargetTranslationX;

            [FieldOffset(444)] public bool bAffectTargetTranslationY;

            [FieldOffset(444)] public bool bAffectTargetTranslationZ;

            [FieldOffset(444)] public bool bAffectTargetRotationX;

            [FieldOffset(444)] public bool bAffectTargetRotationY;

            [FieldOffset(444)] public bool bAffectTargetRotationZ;

            [FieldOffset(444)] public bool bAffectTargetScaleX;

            [FieldOffset(444)] public bool bAffectTargetScaleY;

            [FieldOffset(445)] public bool bAffectTargetScaleZ;

            [FieldOffset(448)] byte ModificationMode; //TODO: enum EDrivenBoneModificationMode ModificationMode

        }
}
