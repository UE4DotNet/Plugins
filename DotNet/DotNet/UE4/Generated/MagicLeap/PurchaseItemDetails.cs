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
        ///<summary>Purchase Item Details</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct PurchaseItemDetails {
            [FieldOffset(16)] byte Price; //TODO: string FString Price

            [FieldOffset(32)] byte Name; //TODO: string FString Name

            [FieldOffset(48)] byte Type; //TODO: enum PurchaseType Type

        }
}
