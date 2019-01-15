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
    ///<summary>Logout Callback Proxy</summary>
    public unsafe partial class LogoutCallbackProxy : BlueprintAsyncActionBase  {

        ///<summary>Logs out of the online service</summary>
        public static LogoutCallbackProxy Logout(UObject WorldContextObject, PlayerController PlayerController)  => 
            LogoutCallbackProxy_methods.Logout_method.Invoke(WorldContextObject, PlayerController);
         //TODO: multicast delegate FOnlineLogoutResult OnSuccess
         //TODO: multicast delegate FOnlineLogoutResult OnFailure
        static LogoutCallbackProxy() {
            StaticClass = Main.GetClass("LogoutCallbackProxy");
        }
        internal unsafe LogoutCallbackProxy_fields* LogoutCallbackProxy_ptr => (LogoutCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LogoutCallbackProxy(IntPtr p) => UObject.Make<LogoutCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LogoutCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LogoutCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
