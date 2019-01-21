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

#pragma warning disable CS0108
using UE4.MagicLeap.Native;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>The CameraCaptureComponent provides access to and maintains state for camera capture functionality.</summary>
    ///<remarks>
    ///The connection to the device's camera is managed internally.  Users of this component
    ///are able to asynchronously capture camera images and footage to file.  Alternatively,
    ///a camera image can be captured directly to texture.  The user need only make the relevant
    ///asynchronous call and then register the appropriate success/fail event handlers for the
    ///operation's completion.
    ///</remarks>
    public unsafe partial class InAppPurchaseComponent : ActorComponent  {

        ///<summary>Attempts to retrieve details for the specified items.</summary>
        ///<remarks>
        ///@brief  This call instigates an items details query which is handled on a separate thread.  The result of this asynchronous
        ///                operation is reported back to the calling blueprint via the FGetItemsDetailsSuccess or FGetItemsDetailsFailure event handlers.
        ///@param  ItemIDs An array of FString objects specifying the names of the items whose details will be queried.
        ///@return False if an items details query is already running, true otherwise.
        ///</remarks>
        public bool TryGetItemsDetailsAsync(byte ItemIDs /*TODO: array TArray */)  => 
            InAppPurchaseComponent_methods.TryGetItemsDetailsAsync_method.Invoke(ObjPointer, ItemIDs);

        ///<summary>Attempts to retrieve the app's purchase history.</summary>
        ///<remarks>
        ///@brief  This call instigates a purchase history request which is handled on a separate thread.  The result of this asynchronous
        ///                operation is reported back to the calling blueprint via the FGetPurchaseHistorySuccess or FGetPurchaseHistoryFailure event handlers.
        ///@param  InNumPages Specifies the number of history pages to retrieve.
        ///@return False if a purchase history query is already running or InNumPages is less than or equal to zero, true otherwise.
        ///</remarks>
        public bool TryGetPurchaseHistoryAsync(int InNumPages)  => 
            InAppPurchaseComponent_methods.TryGetPurchaseHistoryAsync_method.Invoke(ObjPointer, InNumPages);

        ///<summary>Attempts to purchase the specified item.</summary>
        ///<remarks>
        ///@brief  This call instigates a purchase request which is handled on a separate thread.  The result of this asynchronous operation is
        ///                reported back to the calling blueprint via the FPurchaseConfirmationSuccess or FPurchaseConfirmationFailure event handlers.
        ///@param  ItemDetails The details of the item to be purchased.
        ///@return False if a purchase confirmation is already running, true otherwise.
        ///</remarks>
        public bool TryPurchaseItemAsync(PurchaseItemDetails ItemDetails)  => 
            InAppPurchaseComponent_methods.TryPurchaseItemAsync_method.Invoke(ObjPointer, ItemDetails);
         //TODO: multicast delegate FInAppPurchaseLogMessage InAppPurchaseLogMessage
         //TODO: multicast delegate FGetItemsDetailsSuccess GetItemsDetailsSuccess
         //TODO: multicast delegate FGetItemsDetailsFailure GetItemsDetailsFailure
         //TODO: multicast delegate FPurchaseConfirmationSuccess PurchaseConfirmationSuccess
         //TODO: multicast delegate FPurchaseConfirmationFailure PurchaseConfirmationFailure
         //TODO: multicast delegate FGetPurchaseHistorySuccess GetPurchaseHistorySuccess
         //TODO: multicast delegate FGetPurchaseHistoryFailure GetPurchaseHistoryFailure
        static InAppPurchaseComponent() {
            StaticClass = Main.GetClass("InAppPurchaseComponent");
        }
        internal unsafe InAppPurchaseComponent_fields* InAppPurchaseComponent_ptr => (InAppPurchaseComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InAppPurchaseComponent(IntPtr p) => UObject.Make<InAppPurchaseComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InAppPurchaseComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InAppPurchaseComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
