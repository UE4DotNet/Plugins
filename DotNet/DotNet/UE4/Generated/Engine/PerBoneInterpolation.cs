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
        ///<summary>Per Bone Interpolation</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct PerBoneInterpolation {
            ///<summary>Bone Reference</summary>
            [FieldOffset(0)] BoneReference BoneReference;

            [FieldOffset(24)] public float InterpolationSpeedPerSec;

        }
}
