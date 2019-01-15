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
        ///<summary>Remove FBranchingPoint when VER_UE4_MONTAGE_BRANCHING_POINT_REMOVAL is removed.</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct BranchingPoint {
            [FieldOffset(48)] public Name EventName;

            [FieldOffset(64)] public float TriggerTimeOffset;

        }
}
