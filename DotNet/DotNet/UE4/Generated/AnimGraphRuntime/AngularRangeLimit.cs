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
        ///<summary>Angular Range Limit</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct AngularRangeLimit {
            ///<summary>Limit Min</summary>
            [FieldOffset(0)] Vector LimitMin;

            ///<summary>Limit Max</summary>
            [FieldOffset(12)] Vector LimitMax;

            ///<summary>Bone</summary>
            [FieldOffset(24)] BoneReference Bone;

        }
}
