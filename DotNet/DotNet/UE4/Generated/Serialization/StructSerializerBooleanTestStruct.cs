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
        ///<summary>Test structure for boolean properties.</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct StructSerializerBooleanTestStruct {
            [FieldOffset(0)] public bool BoolFalse;

            [FieldOffset(1)] public bool BoolTrue;

            [FieldOffset(4)] byte Bitfield; //TODO: numeric uint32 Bitfield

        }
}
