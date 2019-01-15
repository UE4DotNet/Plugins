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
        ///<summary>Linear Drive</summary>
        [StructLayout( LayoutKind.Explicit, Size=76 )]
        public unsafe struct LinearDriveConstraint {
            ///<summary>Target position the linear drive.</summary>
            [FieldOffset(0)] Vector PositionTarget;

            ///<summary>Target velocity the linear drive.</summary>
            [FieldOffset(12)] Vector VelocityTarget;

            ///<summary>XDrive</summary>
            [FieldOffset(24)] ConstraintDrive XDrive;

            ///<summary>YDrive</summary>
            [FieldOffset(40)] ConstraintDrive YDrive;

            ///<summary>ZDrive</summary>
            [FieldOffset(56)] ConstraintDrive ZDrive;

            [FieldOffset(72)] public bool bEnablePositionDrive;

        }
}
