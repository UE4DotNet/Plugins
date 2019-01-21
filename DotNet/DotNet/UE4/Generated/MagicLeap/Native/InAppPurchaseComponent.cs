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


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=376 )]
    internal unsafe struct InAppPurchaseComponent_fields {
        [FieldOffset(264)] byte InAppPurchaseLogMessage; //TODO: multicast delegate FInAppPurchaseLogMessage InAppPurchaseLogMessage
        [FieldOffset(280)] byte GetItemsDetailsSuccess; //TODO: multicast delegate FGetItemsDetailsSuccess GetItemsDetailsSuccess
        [FieldOffset(296)] byte GetItemsDetailsFailure; //TODO: multicast delegate FGetItemsDetailsFailure GetItemsDetailsFailure
        [FieldOffset(312)] byte PurchaseConfirmationSuccess; //TODO: multicast delegate FPurchaseConfirmationSuccess PurchaseConfirmationSuccess
        [FieldOffset(328)] byte PurchaseConfirmationFailure; //TODO: multicast delegate FPurchaseConfirmationFailure PurchaseConfirmationFailure
        [FieldOffset(344)] byte GetPurchaseHistorySuccess; //TODO: multicast delegate FGetPurchaseHistorySuccess GetPurchaseHistorySuccess
        [FieldOffset(360)] byte GetPurchaseHistoryFailure; //TODO: multicast delegate FGetPurchaseHistoryFailure GetPurchaseHistoryFailure
    }
    internal unsafe struct InAppPurchaseComponent_methods {
        internal struct TryGetItemsDetailsAsync_method {
            static internal IntPtr TryGetItemsDetailsAsync_ptr;
            static TryGetItemsDetailsAsync_method() {
                TryGetItemsDetailsAsync_ptr = Main.GetMethodUFunction(InAppPurchaseComponent.StaticClass, "TryGetItemsDetailsAsync");
            }

            internal static unsafe bool Invoke(IntPtr obj, byte ItemIDs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ItemIDs
                Main.GetProcessEvent(obj, TryGetItemsDetailsAsync_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ItemIDs
                return *((bool*)(b+16));
            }
        }
        internal struct TryGetPurchaseHistoryAsync_method {
            static internal IntPtr TryGetPurchaseHistoryAsync_ptr;
            static TryGetPurchaseHistoryAsync_method() {
                TryGetPurchaseHistoryAsync_ptr = Main.GetMethodUFunction(InAppPurchaseComponent.StaticClass, "TryGetPurchaseHistoryAsync");
            }

            internal static unsafe bool Invoke(IntPtr obj, int InNumPages) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InNumPages;
                Main.GetProcessEvent(obj, TryGetPurchaseHistoryAsync_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct TryPurchaseItemAsync_method {
            static internal IntPtr TryPurchaseItemAsync_ptr;
            static TryPurchaseItemAsync_method() {
                TryPurchaseItemAsync_ptr = Main.GetMethodUFunction(InAppPurchaseComponent.StaticClass, "TryPurchaseItemAsync");
            }

            internal static unsafe bool Invoke(IntPtr obj, PurchaseItemDetails ItemDetails) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PurchaseItemDetails*)(b+0)) = ItemDetails;
                Main.GetProcessEvent(obj, TryPurchaseItemAsync_ptr, new IntPtr(p)); ;
                return *((bool*)(b+64));
            }
        }
    }
    internal unsafe struct InAppPurchaseComponent_events {
    }
}
