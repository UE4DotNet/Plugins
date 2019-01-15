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


namespace UE4.OnlineSubsystem{
        ///<summary>Micro-transaction restored purchase information</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct InAppPurchaseRestoreInfo {
            [FieldOffset(0)] byte Identifier; //TODO: string FString Identifier

            [FieldOffset(16)] byte ReceiptData; //TODO: string FString ReceiptData

            [FieldOffset(32)] byte TransactionIdentifier; //TODO: string FString TransactionIdentifier

        }
}
