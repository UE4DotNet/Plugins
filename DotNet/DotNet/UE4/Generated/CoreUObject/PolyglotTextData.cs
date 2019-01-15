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


namespace UE4.CoreUObject{
        ///<summary>Polyglot Text Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct PolyglotTextData {
            [FieldOffset(0)] byte Category; //TODO: enum ELocalizedTextSourceCategory Category

            [FieldOffset(8)] byte NativeCulture; //TODO: string FString NativeCulture

            [FieldOffset(24)] byte Namespace; //TODO: string FString Namespace

            [FieldOffset(40)] byte Key; //TODO: string FString Key

            [FieldOffset(56)] byte NativeString; //TODO: string FString NativeString

            [FieldOffset(72)] byte LocalizedStrings; //TODO: map TMap LocalizedStrings

            [FieldOffset(152)] byte CachedText; //TODO: text FText CachedText

        }
}
