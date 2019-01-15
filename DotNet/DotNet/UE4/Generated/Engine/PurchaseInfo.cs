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
        ///<summary>Purchase information structure</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct PurchaseInfo {
            [FieldOffset(0)] byte Identifier; //TODO: string FString Identifier

            [FieldOffset(16)] byte DisplayName; //TODO: string FString DisplayName

            [FieldOffset(32)] byte DisplayDescription; //TODO: string FString DisplayDescription

            [FieldOffset(48)] byte DisplayPrice; //TODO: string FString DisplayPrice

        }
}
