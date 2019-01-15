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
        ///<summary>Test structure for all supported types.</summary>
        [StructLayout( LayoutKind.Explicit, Size=480 )]
        public unsafe struct StructSerializerTestStruct {
            ///<summary>Numerics</summary>
            [FieldOffset(0)] StructSerializerNumericTestStruct Numerics;

            ///<summary>Booleans</summary>
            [FieldOffset(48)] StructSerializerBooleanTestStruct Booleans;

            ///<summary>Objects</summary>
            [FieldOffset(56)] StructSerializerObjectTestStruct Objects;

            ///<summary>Builtins</summary>
            [FieldOffset(72)] StructSerializerBuiltinTestStruct Builtins;

            ///<summary>Arrays</summary>
            [FieldOffset(176)] StructSerializerArrayTestStruct Arrays;

            ///<summary>Maps</summary>
            [FieldOffset(240)] StructSerializerMapTestStruct Maps;

        }
}
