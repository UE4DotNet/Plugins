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
        ///<summary>Anim Phys Planar Limit</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct AnimPhysPlanarLimit {
            ///<summary>When using a driving bone, the plane transform will be relative to the bone transform</summary>
            [FieldOffset(0)] BoneReference DrivingBone;

            ///<summary>
            ///Transform of the plane, this is either in component-space if no DrivinBone is specified
            ///or in bone-space if a driving bone is present.
            ///</summary>
            [FieldOffset(32)] Transform PlaneTransform;

        }
}
