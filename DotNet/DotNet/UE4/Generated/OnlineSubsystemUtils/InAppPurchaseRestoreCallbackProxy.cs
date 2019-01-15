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
using UE4.OnlineSubsystemUtils.Native;
using UE4.Engine;

namespace UE4.OnlineSubsystemUtils {
    ///<summary>In App Purchase Restore Callback Proxy</summary>
    public unsafe partial class InAppPurchaseRestoreCallbackProxy : UObject  {

        ///<summary>Kicks off a transaction for the provided product identifier</summary>
        public static InAppPurchaseRestoreCallbackProxy CreateProxyObjectForInAppPurchaseRestore(byte ConsumableProductFlags /*TODO: array TArray */, PlayerController PlayerController)  => 
            InAppPurchaseRestoreCallbackProxy_methods.CreateProxyObjectForInAppPurchaseRestore_method.Invoke(ConsumableProductFlags, PlayerController);
         //TODO: multicast delegate FInAppPurchaseRestoreResult OnSuccess
         //TODO: multicast delegate FInAppPurchaseRestoreResult OnFailure
        static InAppPurchaseRestoreCallbackProxy() {
            StaticClass = Main.GetClass("InAppPurchaseRestoreCallbackProxy");
        }
        internal unsafe InAppPurchaseRestoreCallbackProxy_fields* InAppPurchaseRestoreCallbackProxy_ptr => (InAppPurchaseRestoreCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InAppPurchaseRestoreCallbackProxy(IntPtr p) => UObject.Make<InAppPurchaseRestoreCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InAppPurchaseRestoreCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InAppPurchaseRestoreCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
