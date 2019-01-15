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
        ///<summary>Container for properties of a physics constraint that can be easily swapped at runtime. This is useful for switching different setups when going from ragdoll to standup for example</summary>
        [StructLayout( LayoutKind.Explicit, Size=260 )]
        public unsafe struct ConstraintProfileProperties {
            [FieldOffset(0)] public float ProjectionLinearTolerance;

            [FieldOffset(4)] public float ProjectionAngularTolerance;

            [FieldOffset(8)] public float LinearBreakThreshold;

            [FieldOffset(12)] public float AngularBreakThreshold;

            ///<summary>Linear Limit</summary>
            [FieldOffset(16)] LinearConstraint LinearLimit;

            ///<summary>Cone Limit</summary>
            [FieldOffset(44)] ConeConstraint ConeLimit;

            ///<summary>Twist Limit</summary>
            [FieldOffset(76)] TwistConstraint TwistLimit;

            ///<summary>Linear Drive</summary>
            [FieldOffset(104)] LinearDriveConstraint LinearDrive;

            ///<summary>Angular Drive</summary>
            [FieldOffset(180)] AngularDriveConstraint AngularDrive;

            [FieldOffset(256)] public bool bDisableCollision;

            [FieldOffset(256)] public bool bParentDominates;

            [FieldOffset(256)] public bool bEnableProjection;

            [FieldOffset(256)] public bool bAngularBreakable;

            [FieldOffset(256)] public bool bLinearBreakable;

        }
}
