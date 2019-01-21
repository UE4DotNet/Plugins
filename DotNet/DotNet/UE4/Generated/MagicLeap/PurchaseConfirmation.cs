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
        ///<summary>Purchase Confirmation</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct PurchaseConfirmation {
            [FieldOffset(16)] byte PackageName; //TODO: string FString PackageName

            [FieldOffset(72)] byte Type; //TODO: enum PurchaseType Type

        }
}
