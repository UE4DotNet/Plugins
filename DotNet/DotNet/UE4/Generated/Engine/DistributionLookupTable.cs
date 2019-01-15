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
        ///<summary>Lookup table for distributions.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct DistributionLookupTable {
            [FieldOffset(0)] public byte Op;

            [FieldOffset(1)] public byte EntryCount;

            [FieldOffset(2)] public byte EntryStride;

            [FieldOffset(3)] public byte SubEntryStride;

            [FieldOffset(4)] public float TimeScale;

            [FieldOffset(8)] public float TimeBias;

            [FieldOffset(16)] byte Values; //TODO: array TArray Values

            [FieldOffset(32)] public byte LockFlag;

        }
}
