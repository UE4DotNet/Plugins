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
    ///<summary>Connection Callback Proxy</summary>
    public unsafe partial class ConnectionCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Connects to an online service such as Google Play</summary>
        public static ConnectionCallbackProxy ConnectToService(UObject WorldContextObject, PlayerController PlayerController)  => 
            ConnectionCallbackProxy_methods.ConnectToService_method.Invoke(WorldContextObject, PlayerController);
         //TODO: multicast delegate FOnlineConnectionResult OnSuccess
         //TODO: multicast delegate FOnlineConnectionResult OnFailure
        static ConnectionCallbackProxy() {
            StaticClass = Main.GetClass("ConnectionCallbackProxy");
        }
        internal unsafe ConnectionCallbackProxy_fields* ConnectionCallbackProxy_ptr => (ConnectionCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ConnectionCallbackProxy(IntPtr p) => UObject.Make<ConnectionCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ConnectionCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ConnectionCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
