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
        ///<summary>Trail Controller</summary>
        [StructLayout( LayoutKind.Explicit, Size=784 )]
        public unsafe struct AnimNode_Trail {
            ///<summary>Reference to the active bone in the hierarchy to modify.</summary>
            [FieldOffset(336)] BoneReference TrailBone;

            [FieldOffset(360)] public int ChainLength;

            [FieldOffset(364)] public byte ChainBoneAxis;

            [FieldOffset(365)] public bool bInvertChainBoneAxis;

            [FieldOffset(365)] public bool bLimitStretch;

            [FieldOffset(365)] public bool bLimitRotation;

            [FieldOffset(365)] public bool bUsePlanarLimit;

            [FieldOffset(365)] public bool bActorSpaceFakeVel;

            [FieldOffset(365)] public bool bReorientParentToChild;

            [FieldOffset(365)] public bool bEnableDebug;

            [FieldOffset(366)] public bool bShowBaseMotion;

            [FieldOffset(366)] public bool bShowTrailLocation;

            [FieldOffset(366)] public bool bShowLimit;

            [FieldOffset(368)] public float DebugLifeTime;

            [FieldOffset(376)] byte UnwindingSize; //TODO: numeric uint32 UnwindingSize

            [FieldOffset(380)] public float RelaxationSpeedScale;

            ///<summary>How quickly we 'relax' the bones to their animated positions. Time 0 will map to top root joint, time 1 will map to the bottom joint.</summary>
            [FieldOffset(384)] RuntimeFloatCurve TrailRelaxationSpeed;

            ///<summary>Relaxation Speed Scale Input Processor</summary>
            [FieldOffset(504)] InputScaleBiasClamp RelaxationSpeedScaleInputProcessor;

            [FieldOffset(552)] byte RotationLimits; //TODO: array TArray RotationLimits

            [FieldOffset(568)] byte RotationOffsets; //TODO: array TArray RotationOffsets

            [FieldOffset(584)] byte PlanarLimits; //TODO: array TArray PlanarLimits

            [FieldOffset(600)] public float StretchLimit;

            ///<summary>'Fake' velocity applied to bones.</summary>
            [FieldOffset(604)] Vector FakeVelocity;

            ///<summary>Base Joint to calculate velocity from. If none, it will use Component's World Transform. .</summary>
            [FieldOffset(616)] BoneReference BaseJoint;

            [FieldOffset(644)] public float LastBoneRotationAnimAlphaBlend;

        }
}
