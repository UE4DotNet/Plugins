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
        ///<summary>Physical Animation Profile</summary>
        [StructLayout( LayoutKind.Explicit, Size=52 )]
        public unsafe struct PhysicalAnimationProfile {
            [FieldOffset(0)] public Name ProfileName;

            ///<summary>Physical animation parameters used to drive animation</summary>
            [FieldOffset(12)] PhysicalAnimationData PhysicalAnimationData;

        }
}
