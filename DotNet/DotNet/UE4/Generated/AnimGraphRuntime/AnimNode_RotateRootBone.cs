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
        ///<summary>@TODO: Comment</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct AnimNode_RotateRootBone {
            ///<summary>Base Pose</summary>
            [FieldOffset(56)] PoseLink BasePose;

            [FieldOffset(80)] public float Pitch;

            [FieldOffset(84)] public float Yaw;

            ///<summary>Pitch Scale Bias Clamp</summary>
            [FieldOffset(88)] InputScaleBiasClamp PitchScaleBiasClamp;

            ///<summary>Yaw Scale Bias Clamp</summary>
            [FieldOffset(136)] InputScaleBiasClamp YawScaleBiasClamp;

            ///<summary>Mesh to Component</summary>
            [FieldOffset(184)] Rotator MeshToComponent;

            [FieldOffset(196)] public float ActualPitch;

            [FieldOffset(200)] public float ActualYaw;

        }
}
