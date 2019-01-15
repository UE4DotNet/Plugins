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
        ///<summary>Anim Phys Spherical Limit</summary>
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct AnimPhysSphericalLimit {
            ///<summary>Bone to attach the sphere to</summary>
            [FieldOffset(0)] BoneReference DrivingBone;

            ///<summary>Local offset for the sphere, if no driving bone is set this is in node space, otherwise bone space</summary>
            [FieldOffset(24)] Vector SphereLocalOffset;

            [FieldOffset(36)] public float LimitRadius;

            [FieldOffset(40)] byte LimitType; //TODO: enum ESphericalLimitType LimitType

        }
}
