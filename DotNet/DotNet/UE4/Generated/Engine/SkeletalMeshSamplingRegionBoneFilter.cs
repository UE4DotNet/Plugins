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
        ///<summary>Filter to include or exclude bones and their associated triangles from a sampling region.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct SkeletalMeshSamplingRegionBoneFilter {
            [FieldOffset(0)] public Name BoneName;

            [FieldOffset(12)] public bool bIncludeOrExclude;

            [FieldOffset(12)] public bool bApplyToChildren;

        }
}
