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


namespace UE4.TranslationEditor{
        ///<summary>Translation Context Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct TranslationContextInfo {
            [FieldOffset(0)] byte Key; //TODO: string FString Key

            [FieldOffset(16)] byte Context; //TODO: string FString Context

            [FieldOffset(32)] byte Changes; //TODO: array TArray Changes

        }
}
