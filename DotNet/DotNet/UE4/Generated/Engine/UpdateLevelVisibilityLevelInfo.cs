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
        ///<summary>This structure is used to pass arguments to ServerUpdateMultipleLevelsVisibility() server RPC function</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct UpdateLevelVisibilityLevelInfo {
            [FieldOffset(0)] public Name PackageName;

            [FieldOffset(12)] public bool bIsVisible;

        }
}
