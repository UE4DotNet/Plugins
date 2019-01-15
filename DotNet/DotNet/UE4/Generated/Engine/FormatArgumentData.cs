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
        ///<summary>Used to pass argument/value pairs into FText::Format.</summary>
        ///<remarks>The full C++ struct is located here: Engine\Source\Runtime\Core\Public\Internationalization\Text.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct FormatArgumentData {
            [FieldOffset(0)] byte ArgumentName; //TODO: string FString ArgumentName

            [FieldOffset(16)] public byte ArgumentValueType;

            [FieldOffset(24)] byte ArgumentValue; //TODO: text FText ArgumentValue

            [FieldOffset(48)] public int ArgumentValueInt;

            [FieldOffset(52)] public float ArgumentValueFloat;

            [FieldOffset(56)] byte ArgumentValueGender; //TODO: enum ETextGender ArgumentValueGender

        }
}
