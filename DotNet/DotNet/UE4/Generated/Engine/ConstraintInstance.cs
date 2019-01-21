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
        [StructLayout( LayoutKind.Explicit, Size=656 )]
        public unsafe struct ConstraintInstance {
            [FieldOffset(24)] public Name JointName;

            [FieldOffset(36)] public Name ConstraintBone1;

            [FieldOffset(48)] public Name ConstraintBone2;

            ///<summary>Location of constraint in Body1 reference frame.</summary>
            [FieldOffset(60)] Vector Pos1;

            ///<summary>Primary (twist) axis in Body1 reference frame.</summary>
            [FieldOffset(72)] Vector PriAxis1;

            ///<summary>Seconday axis in Body1 reference frame. Orthogonal to PriAxis1.</summary>
            [FieldOffset(84)] Vector SecAxis1;

            ///<summary>Location of constraint in Body2 reference frame.</summary>
            [FieldOffset(96)] Vector Pos2;

            ///<summary>Primary (twist) axis in Body2 reference frame.</summary>
            [FieldOffset(108)] Vector PriAxis2;

            ///<summary>Seconday axis in Body2 reference frame. Orthogonal to PriAxis2.</summary>
            [FieldOffset(120)] Vector SecAxis2;

            ///<summary>Specifies the angular offset between the two frames of reference.</summary>
            ///<remarks>
            ///By default limit goes from (-Angle, +Angle)
            ///This allows you to bias the limit for swing1 swing2 and twist.
            ///</remarks>
            [FieldOffset(132)] Rotator AngularRotationOffset;

            [FieldOffset(144)] public bool bScaleLinearLimits;

            ///<summary>Constraint Data (properties easily swapped at runtime based on different constraint profiles)</summary>
            [FieldOffset(152)] ConstraintProfileProperties ProfileInstance;

        }
}
