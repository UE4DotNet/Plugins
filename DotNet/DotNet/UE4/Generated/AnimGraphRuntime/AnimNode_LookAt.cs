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
        [StructLayout( LayoutKind.Explicit, Size=880 )]
        public unsafe struct AnimNode_LookAt {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(360)] BoneReference BoneToModify;

            ///<summary>Target socket to look at. Used if LookAtBone is empty. - You can use  LookAtLocation if you need offset from this point. That location will be used in their local space. *</summary>
            [FieldOffset(432)] BoneSocketTarget LookAtTarget;

            ///<summary>Target Offset. It's in world space if LookAtBone is empty or it is based on LookAtBone or LookAtSocket in their local space</summary>
            [FieldOffset(544)] Vector LookAtLocation;

            ///<summary>Look at Axis</summary>
            [FieldOffset(572)] Axis LookAt_Axis;

            [FieldOffset(588)] public bool bUseLookUpAxis;

            ///<summary>Look Up Axis</summary>
            [FieldOffset(604)] Axis LookUp_Axis;

            [FieldOffset(620)] public float LookAtClamp;

            [FieldOffset(624)] public byte InterpolationType;

            [FieldOffset(628)] public float InterpolationTime;

            [FieldOffset(632)] public float InterpolationTriggerThreashold;

        }
}
