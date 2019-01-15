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
        [StructLayout( LayoutKind.Explicit, Size=736 )]
        public unsafe struct AnimNode_Trail {
            ///<summary>Reference to the active bone in the hierarchy to modify.</summary>
            [FieldOffset(360)] BoneReference TrailBone;

            [FieldOffset(384)] public int ChainLength;

            [FieldOffset(388)] public byte ChainBoneAxis;

            [FieldOffset(389)] public bool bInvertChainBoneAxis;

            ///<summary>How quickly we 'relax' the bones to their animated positions. Time 0 will map to top root joint, time 1 will map to the bottom joint.</summary>
            [FieldOffset(400)] RuntimeFloatCurve TrailRelaxationSpeed;

            [FieldOffset(520)] public float RelaxationSpeedScale;

            ///<summary>Relaxation Speed Scale Input Processor</summary>
            [FieldOffset(524)] InputScaleBiasClamp RelaxationSpeedScaleInputProcessor;

            [FieldOffset(584)] public bool bLimitStretch;

            [FieldOffset(588)] public float StretchLimit;

            ///<summary>'Fake' velocity applied to bones.</summary>
            [FieldOffset(592)] Vector FakeVelocity;

            [FieldOffset(604)] public bool bActorSpaceFakeVel;

            ///<summary>Base Joint to calculate velocity from. If none, it will use Component's World Transform. .</summary>
            [FieldOffset(608)] BoneReference BaseJoint;

        }
}
