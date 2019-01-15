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
    ///<summary>In App Purchase Query Callback Proxy</summary>
    public unsafe partial class InAppPurchaseQueryCallbackProxy : UObject  {

        ///<summary>Queries a InAppPurchase for an integer value</summary>
        public static InAppPurchaseQueryCallbackProxy CreateProxyObjectForInAppPurchaseQuery(PlayerController PlayerController, byte ProductIdentifiers /*TODO: array TArray */)  => 
            InAppPurchaseQueryCallbackProxy_methods.CreateProxyObjectForInAppPurchaseQuery_method.Invoke(PlayerController, ProductIdentifiers);
         //TODO: multicast delegate FInAppPurchaseQueryResult OnSuccess
         //TODO: multicast delegate FInAppPurchaseQueryResult OnFailure
        static InAppPurchaseQueryCallbackProxy() {
            StaticClass = Main.GetClass("InAppPurchaseQueryCallbackProxy");
        }
        internal unsafe InAppPurchaseQueryCallbackProxy_fields* InAppPurchaseQueryCallbackProxy_ptr => (InAppPurchaseQueryCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InAppPurchaseQueryCallbackProxy(IntPtr p) => UObject.Make<InAppPurchaseQueryCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InAppPurchaseQueryCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InAppPurchaseQueryCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
