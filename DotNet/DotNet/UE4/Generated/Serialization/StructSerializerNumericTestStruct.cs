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


namespace UE4.Serialization{
        ///<summary>Test structure for numeric properties.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct StructSerializerNumericTestStruct {
            [FieldOffset(0)] public sbyte Int8;

            [FieldOffset(2)] public short Int16;

            [FieldOffset(4)] public int Int32;

            [FieldOffset(8)] public long Int64;

            [FieldOffset(16)] public byte UInt8;

            [FieldOffset(18)] byte UInt16; //TODO: numeric uint16 UInt16

            [FieldOffset(20)] byte UInt32; //TODO: numeric uint32 UInt32

            [FieldOffset(24)] byte UInt64; //TODO: numeric uint64 UInt64

            [FieldOffset(32)] public float Float;

            [FieldOffset(40)] public double Double;

        }
}
