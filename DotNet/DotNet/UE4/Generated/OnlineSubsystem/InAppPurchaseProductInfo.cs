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
        ///<summary>Micro-transaction purchase information</summary>
        [StructLayout( LayoutKind.Explicit, Size=168 )]
        public unsafe struct InAppPurchaseProductInfo {
            [FieldOffset(0)] byte Identifier; //TODO: string FString Identifier

            [FieldOffset(16)] byte TransactionIdentifier; //TODO: string FString TransactionIdentifier

            [FieldOffset(32)] byte DisplayName; //TODO: string FString DisplayName

            [FieldOffset(48)] byte DisplayDescription; //TODO: string FString DisplayDescription

            [FieldOffset(64)] byte DisplayPrice; //TODO: string FString DisplayPrice

            [FieldOffset(80)] public float RawPrice;

            [FieldOffset(88)] byte CurrencyCode; //TODO: string FString CurrencyCode

            [FieldOffset(104)] byte CurrencySymbol; //TODO: string FString CurrencySymbol

            [FieldOffset(120)] byte DecimalSeparator; //TODO: string FString DecimalSeparator

            [FieldOffset(136)] byte GroupingSeparator; //TODO: string FString GroupingSeparator

            [FieldOffset(152)] byte ReceiptData; //TODO: string FString ReceiptData

        }
}
