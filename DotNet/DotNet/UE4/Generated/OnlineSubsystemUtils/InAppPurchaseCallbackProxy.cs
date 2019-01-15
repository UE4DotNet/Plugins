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
using UE4.OnlineSubsystem;

namespace UE4.OnlineSubsystemUtils {
    ///<summary>In App Purchase Callback Proxy</summary>
    public unsafe partial class InAppPurchaseCallbackProxy : UObject  {

        ///<summary>Kicks off a transaction for the provided product identifier</summary>
        public static InAppPurchaseCallbackProxy CreateProxyObjectForInAppPurchase(PlayerController PlayerController, InAppPurchaseProductRequest ProductRequest)  => 
            InAppPurchaseCallbackProxy_methods.CreateProxyObjectForInAppPurchase_method.Invoke(PlayerController, ProductRequest);
         //TODO: multicast delegate FInAppPurchaseResult OnSuccess
         //TODO: multicast delegate FInAppPurchaseResult OnFailure
        static InAppPurchaseCallbackProxy() {
            StaticClass = Main.GetClass("InAppPurchaseCallbackProxy");
        }
        internal unsafe InAppPurchaseCallbackProxy_fields* InAppPurchaseCallbackProxy_ptr => (InAppPurchaseCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InAppPurchaseCallbackProxy(IntPtr p) => UObject.Make<InAppPurchaseCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InAppPurchaseCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InAppPurchaseCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
