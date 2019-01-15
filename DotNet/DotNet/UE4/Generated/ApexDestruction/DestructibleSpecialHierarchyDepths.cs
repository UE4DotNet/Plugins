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


namespace UE4.ApexDestruction{
        ///<summary>Special hierarchy depths for various behaviors.</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct DestructibleSpecialHierarchyDepths {
            [FieldOffset(0)] public int SupportDepth;

            [FieldOffset(4)] public int MinimumFractureDepth;

            [FieldOffset(8)] public bool bEnableDebris;

            [FieldOffset(12)] public int DebrisDepth;

            [FieldOffset(16)] public int EssentialDepth;

        }
}
