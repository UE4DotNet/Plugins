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
        ///<summary>Abstract Base class for all tick functions.</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct TickFunction {
            [FieldOffset(8)] public byte TickGroup;

            [FieldOffset(9)] public byte EndTickGroup;

            [FieldOffset(12)] public bool bTickEvenWhenPaused;

            [FieldOffset(12)] public bool bCanEverTick;

            [FieldOffset(12)] public bool bStartWithTickEnabled;

            [FieldOffset(12)] public bool bAllowTickOnDedicatedServer;

            [FieldOffset(64)] public float TickInterval;

        }
}
