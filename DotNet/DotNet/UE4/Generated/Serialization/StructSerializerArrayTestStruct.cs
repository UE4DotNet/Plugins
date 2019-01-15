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
        ///<summary>Test structure for array properties.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct StructSerializerArrayTestStruct {
            [FieldOffset(0)] byte Int32Array; //TODO: array TArray Int32Array

            [FieldOffset(16)] public int StaticSingleElement;

            [FieldOffset(20)] public int StaticInt32Array;

            [FieldOffset(32)] public float StaticFloatArray;

            [FieldOffset(48)] byte VectorArray; //TODO: array TArray VectorArray

        }
}
