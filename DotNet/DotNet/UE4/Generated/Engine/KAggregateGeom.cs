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
        ///<summary>Container for an aggregate of collision shapes</summary>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct KAggregateGeom {
            [FieldOffset(0)] byte SphereElems; //TODO: array TArray SphereElems

            [FieldOffset(16)] byte BoxElems; //TODO: array TArray BoxElems

            [FieldOffset(32)] byte SphylElems; //TODO: array TArray SphylElems

            [FieldOffset(48)] byte ConvexElems; //TODO: array TArray ConvexElems

            [FieldOffset(64)] byte TaperedCapsuleElems; //TODO: array TArray TaperedCapsuleElems

        }
}
