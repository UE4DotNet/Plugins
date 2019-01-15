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
        ///<summary>Container for a physics representation of an object.</summary>
        [StructLayout( LayoutKind.Explicit, Size=640 )]
        public unsafe struct ConstraintInstance {
            [FieldOffset(20)] public Name JointName;

            [FieldOffset(32)] public Name ConstraintBone1;

            [FieldOffset(44)] public Name ConstraintBone2;

            ///<summary>Location of constraint in Body1 reference frame.</summary>
            [FieldOffset(56)] Vector Pos1;

            ///<summary>Primary (twist) axis in Body1 reference frame.</summary>
            [FieldOffset(68)] Vector PriAxis1;

            ///<summary>Seconday axis in Body1 reference frame. Orthogonal to PriAxis1.</summary>
            [FieldOffset(80)] Vector SecAxis1;

            ///<summary>Location of constraint in Body2 reference frame.</summary>
            [FieldOffset(92)] Vector Pos2;

            ///<summary>Primary (twist) axis in Body2 reference frame.</summary>
            [FieldOffset(104)] Vector PriAxis2;

            ///<summary>Seconday axis in Body2 reference frame. Orthogonal to PriAxis2.</summary>
            [FieldOffset(116)] Vector SecAxis2;

            ///<summary>Specifies the angular offset between the two frames of reference.</summary>
            ///<remarks>
            ///By default limit goes from (-Angle, +Angle)
            ///This allows you to bias the limit for swing1 swing2 and twist.
            ///</remarks>
            [FieldOffset(128)] Rotator AngularRotationOffset;

            [FieldOffset(140)] public bool bScaleLinearLimits;

            ///<summary>Constraint Data (properties easily swapped at runtime based on different constraint profiles)</summary>
            [FieldOffset(148)] ConstraintProfileProperties ProfileInstance;

        }
}
