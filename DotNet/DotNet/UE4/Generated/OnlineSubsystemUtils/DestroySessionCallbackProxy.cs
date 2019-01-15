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
    ///<summary>Destroy Session Callback Proxy</summary>
    public unsafe partial class DestroySessionCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Destroys a session previously created by the default online subsystem</summary>
        public static DestroySessionCallbackProxy DestroySession(UObject WorldContextObject, PlayerController PlayerController)  => 
            DestroySessionCallbackProxy_methods.DestroySession_method.Invoke(WorldContextObject, PlayerController);
         //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
         //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
        static DestroySessionCallbackProxy() {
            StaticClass = Main.GetClass("DestroySessionCallbackProxy");
        }
        internal unsafe DestroySessionCallbackProxy_fields* DestroySessionCallbackProxy_ptr => (DestroySessionCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DestroySessionCallbackProxy(IntPtr p) => UObject.Make<DestroySessionCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DestroySessionCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DestroySessionCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
