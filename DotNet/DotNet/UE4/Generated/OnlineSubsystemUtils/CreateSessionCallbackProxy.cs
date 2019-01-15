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
    ///<summary>Create Session Callback Proxy</summary>
    public unsafe partial class CreateSessionCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Creates a session with the default online subsystem</summary>
        public static CreateSessionCallbackProxy CreateSession(UObject WorldContextObject, PlayerController PlayerController, int PublicConnections, bool bUseLAN)  => 
            CreateSessionCallbackProxy_methods.CreateSession_method.Invoke(WorldContextObject, PlayerController, PublicConnections, bUseLAN);
         //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
         //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
        static CreateSessionCallbackProxy() {
            StaticClass = Main.GetClass("CreateSessionCallbackProxy");
        }
        internal unsafe CreateSessionCallbackProxy_fields* CreateSessionCallbackProxy_ptr => (CreateSessionCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CreateSessionCallbackProxy(IntPtr p) => UObject.Make<CreateSessionCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CreateSessionCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CreateSessionCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
