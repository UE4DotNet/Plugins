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
        ///<summary>Movement capabilities, determining available movement options for Pawns and used by AI for reachability tests.</summary>
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        public unsafe struct MovementProperties {
            [FieldOffset(0)] public bool bCanCrouch;

            [FieldOffset(0)] public bool bCanJump;

            [FieldOffset(0)] public bool bCanWalk;

            [FieldOffset(0)] public bool bCanSwim;

            [FieldOffset(0)] public bool bCanFly;

        }
}
