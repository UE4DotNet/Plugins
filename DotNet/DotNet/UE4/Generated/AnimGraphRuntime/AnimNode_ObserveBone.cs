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
        [StructLayout( LayoutKind.Explicit, Size=400 )]
        public unsafe struct AnimNode_ObserveBone {
            ///<summary>Name of bone to observe.</summary>
            [FieldOffset(336)] BoneReference BoneToObserve;

            [FieldOffset(360)] public byte DisplaySpace;

            [FieldOffset(361)] public bool bRelativeToRefPose;

            ///<summary>Translation of the bone being observed.</summary>
            [FieldOffset(364)] Vector Translation;

            ///<summary>Rotation of the bone being observed.</summary>
            [FieldOffset(376)] Rotator Rotation;

            ///<summary>Scale of the bone being observed.</summary>
            [FieldOffset(388)] Vector Scale;

        }
}
