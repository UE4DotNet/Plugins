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
using UE4.AnimationCore;

namespace UE4.AnimGraphRuntime{
        ///<summary>Simple controller that make a bone to look at the point or another bone</summary>
        [StructLayout( LayoutKind.Explicit, Size=848 )]
        public unsafe struct AnimNode_LookAt {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(336)] BoneReference BoneToModify;

            ///<summary>Target socket to look at. Used if LookAtBone is empty. - You can use  LookAtLocation if you need offset from this point. That location will be used in their local space. *</summary>
            [FieldOffset(400)] BoneSocketTarget LookAtTarget;

            ///<summary>Target Offset. It's in world space if LookAtBone is empty or it is based on LookAtBone or LookAtSocket in their local space</summary>
            [FieldOffset(512)] Vector LookAtLocation;

            ///<summary>Look at Axis</summary>
            [FieldOffset(540)] Axis LookAt_Axis;

            [FieldOffset(556)] public bool bUseLookUpAxis;

            ///<summary>Look Up Axis</summary>
            [FieldOffset(572)] Axis LookUp_Axis;

            [FieldOffset(588)] public float LookAtClamp;

            [FieldOffset(592)] public byte InterpolationType;

            [FieldOffset(596)] public float InterpolationTime;

            [FieldOffset(600)] public float InterpolationTriggerThreashold;

        }
}
