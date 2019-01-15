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
        ///<summary>Angular Drive</summary>
        [StructLayout( LayoutKind.Explicit, Size=76 )]
        public unsafe struct AngularDriveConstraint {
            ///<summary>Controls the twist (roll) constraint drive between current orientation/velocity and target orientation/velocity. This is available as long as the twist limit is set to free or limited.</summary>
            [FieldOffset(0)] ConstraintDrive TwistDrive;

            ///<summary>Controls the cone constraint drive between current orientation/velocity and target orientation/velocity. This is available as long as there is at least one swing limit set to free or limited.</summary>
            [FieldOffset(16)] ConstraintDrive SwingDrive;

            ///<summary>Controls the SLERP (spherical lerp) drive between current orientation/velocity and target orientation/velocity. NOTE: This is only available when all three angular limits are either free or limited. Locking any angular limit will turn off the drive implicitly.</summary>
            [FieldOffset(32)] ConstraintDrive SlerpDrive;

            ///<summary>Target orientation relative to the the body reference frame.</summary>
            [FieldOffset(48)] Rotator OrientationTarget;

            ///<summary>Target angular velocity relative to the body reference frame.</summary>
            [FieldOffset(60)] Vector AngularVelocityTarget;

            [FieldOffset(72)] public byte AngularDriveMode;

        }
}
