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


namespace UE4.AnimGraphRuntime{
        ///<summary>Constraint setup struct, holds data required to build a physics constraint</summary>
        [StructLayout( LayoutKind.Explicit, Size=92 )]
        public unsafe struct AnimPhysConstraintSetup {
            [FieldOffset(0)] byte LinearXLimitType; //TODO: enum AnimPhysLinearConstraintType LinearXLimitType

            [FieldOffset(1)] byte LinearYLimitType; //TODO: enum AnimPhysLinearConstraintType LinearYLimitType

            [FieldOffset(2)] byte LinearZLimitType; //TODO: enum AnimPhysLinearConstraintType LinearZLimitType

            ///<summary>Minimum linear movement per-axis (Set zero here and in the max limit to lock)</summary>
            [FieldOffset(4)] Vector LinearAxesMin;

            ///<summary>Maximum linear movement per-axis (Set zero here and in the min limit to lock)</summary>
            [FieldOffset(16)] Vector LinearAxesMax;

            [FieldOffset(28)] byte AngularConstraintType; //TODO: enum AnimPhysAngularConstraintType AngularConstraintType

            [FieldOffset(29)] byte TwistAxis; //TODO: enum AnimPhysTwistAxis TwistAxis

            [FieldOffset(32)] public float ConeAngle;

            ///<summary>Angular Limits Min</summary>
            [FieldOffset(48)] Vector AngularLimitsMin;

            ///<summary>Angular Limits Max</summary>
            [FieldOffset(60)] Vector AngularLimitsMax;

            [FieldOffset(72)] byte AngularTargetAxis; //TODO: enum AnimPhysTwistAxis AngularTargetAxis

            ///<summary>Target direction to face for body1 (in body0 local space)</summary>
            [FieldOffset(76)] Vector AngularTarget;

            [FieldOffset(88)] public bool bLinearFullyLocked;

        }
}
