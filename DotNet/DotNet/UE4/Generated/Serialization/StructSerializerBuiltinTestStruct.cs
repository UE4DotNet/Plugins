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
        ///<summary>Test structure for properties of various built-in types.</summary>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct StructSerializerBuiltinTestStruct {
            ///<summary>Guid</summary>
            [FieldOffset(0)] FGuid FGuid;

            [FieldOffset(16)] public Name Name;

            [FieldOffset(32)] byte String; //TODO: string FString String

            ///<summary>Rotator</summary>
            [FieldOffset(48)] Rotator Rotator;

            [FieldOffset(64)] byte Text; //TODO: text FText Text

            ///<summary>Vector</summary>
            [FieldOffset(88)] Vector Vector;

        }
}
