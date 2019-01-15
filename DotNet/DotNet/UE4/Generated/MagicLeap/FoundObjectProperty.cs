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


namespace UE4.MagicLeap{
        ///<summary>Key-value pair used for either filters or characteristics of an object.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct FoundObjectProperty {
            [FieldOffset(0)] byte Key; //TODO: string FString Key

            [FieldOffset(16)] byte Value; //TODO: string FString Value

        }
}