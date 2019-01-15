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
        ///<summary>Debugging node that displays the current value of a bone in a specific space.</summary>
        [StructLayout( LayoutKind.Explicit, Size=424 )]
        public unsafe struct AnimNode_ObserveBone {
            ///<summary>Name of bone to observe.</summary>
            [FieldOffset(360)] BoneReference BoneToObserve;

            [FieldOffset(384)] public byte DisplaySpace;

            [FieldOffset(385)] public bool bRelativeToRefPose;

            ///<summary>Translation of the bone being observed.</summary>
            [FieldOffset(388)] Vector Translation;

            ///<summary>Rotation of the bone being observed.</summary>
            [FieldOffset(400)] Rotator Rotation;

            ///<summary>Scale of the bone being observed.</summary>
            [FieldOffset(412)] Vector Scale;

        }
}
