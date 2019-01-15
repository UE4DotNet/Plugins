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
        ///<summary>Translation Change</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct TranslationChange {
            [FieldOffset(0)] byte Version; //TODO: string FString Version

            ///<summary>Date of this change //, meta=(DisplayName = "Date & Time"))</summary>
            [FieldOffset(16)] FDateTime DateAndTime;

            [FieldOffset(24)] byte Source; //TODO: string FString Source

            [FieldOffset(40)] byte Translation; //TODO: string FString Translation

        }
}
