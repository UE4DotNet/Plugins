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


namespace UE4.Engine{
        ///<summary>Container for Animation Update Rate parameters.</summary>
        ///<remarks>They are shared for all components of an Actor, so they can be updated in sync.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=136 )]
        public unsafe struct AnimUpdateRateParameters {
            [FieldOffset(1)] byte ShiftBucket; //TODO: enum EUpdateRateShiftBucket ShiftBucket

            [FieldOffset(2)] public bool bInterpolateSkippedFrames;

            [FieldOffset(2)] public bool bShouldUseLodMap;

            [FieldOffset(2)] public bool bShouldUseMinLod;

            [FieldOffset(2)] public bool bSkipUpdate;

            [FieldOffset(2)] public bool bSkipEvaluation;

            [FieldOffset(4)] public int UpdateRate;

            [FieldOffset(8)] public int EvaluationRate;

            [FieldOffset(12)] public float TickedPoseOffestTime;

            [FieldOffset(16)] public float AdditionalTime;

            [FieldOffset(24)] public int BaseNonRenderedUpdateRate;

            [FieldOffset(28)] public int MaxEvalRateForInterpolation;

            [FieldOffset(32)] byte BaseVisibleDistanceFactorThesholds; //TODO: array TArray BaseVisibleDistanceFactorThesholds

            [FieldOffset(48)] byte LODToFrameSkipMap; //TODO: map TMap LODToFrameSkipMap

            [FieldOffset(128)] public int SkippedUpdateFrames;

            [FieldOffset(132)] public int SkippedEvalFrames;

        }
}
