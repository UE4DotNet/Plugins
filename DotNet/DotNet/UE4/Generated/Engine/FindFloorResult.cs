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
        ///<summary>Data about the floor for walking movement, used by CharacterMovementComponent.</summary>
        [StructLayout( LayoutKind.Explicit, Size=156 )]
        public unsafe struct FindFloorResult {
            [FieldOffset(0)] public bool bBlockingHit;

            [FieldOffset(0)] public bool bWalkableFloor;

            [FieldOffset(0)] public bool bLineTrace;

            [FieldOffset(4)] public float FloorDist;

            [FieldOffset(8)] public float LineDist;

            ///<summary>Hit result of the test that found a floor. Includes more specific data about the point of impact and surface normal at that point.</summary>
            [FieldOffset(12)] HitResult HitResult;

        }
}
