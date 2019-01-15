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
        [StructLayout( LayoutKind.Explicit, Size=480 )]
        public unsafe struct AnimNode_BoneDrivenController {
            ///<summary>Bone to use as controller input</summary>
            [FieldOffset(360)] BoneReference SourceBone;

            [FieldOffset(384)] public byte SourceComponent;

            [FieldOffset(392)] 
            private IntPtr  DrivingCurve_field;
            ///<summary>Curve used to map from the source attribute to the driven attributes if present (otherwise the Multiplier will be used)</summary>
            public CurveFloat DrivingCurve {
                get {return DrivingCurve_field;}
                set {DrivingCurve_field = value;}
            }

            [FieldOffset(400)] public float Multiplier;

            [FieldOffset(404)] public bool bUseRange;

            [FieldOffset(408)] public float RangeMin;

            [FieldOffset(412)] public float RangeMax;

            [FieldOffset(416)] public float RemappedMin;

            [FieldOffset(420)] public float RemappedMax;

            [FieldOffset(424)] byte DestinationMode; //TODO: enum EDrivenDestinationMode DestinationMode

            [FieldOffset(428)] public Name ParameterName;

            ///<summary>Bone to drive using controller input</summary>
            [FieldOffset(440)] BoneReference TargetBone;

            [FieldOffset(468)] public bool bAffectTargetTranslationX;

            [FieldOffset(468)] public bool bAffectTargetTranslationY;

            [FieldOffset(468)] public bool bAffectTargetTranslationZ;

            [FieldOffset(468)] public bool bAffectTargetRotationX;

            [FieldOffset(468)] public bool bAffectTargetRotationY;

            [FieldOffset(468)] public bool bAffectTargetRotationZ;

            [FieldOffset(468)] public bool bAffectTargetScaleX;

            [FieldOffset(468)] public bool bAffectTargetScaleY;

            [FieldOffset(469)] public bool bAffectTargetScaleZ;

            [FieldOffset(472)] byte ModificationMode; //TODO: enum EDrivenBoneModificationMode ModificationMode

        }
}
