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
    ///<summary>Join Session Callback Proxy</summary>
    public unsafe partial class JoinSessionCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Joins a remote session with the default online subsystem</summary>
        public static JoinSessionCallbackProxy JoinSession(UObject WorldContextObject, PlayerController PlayerController, BlueprintSessionResult SearchResult)  => 
            JoinSessionCallbackProxy_methods.JoinSession_method.Invoke(WorldContextObject, PlayerController, SearchResult);
         //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
         //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
        static JoinSessionCallbackProxy() {
            StaticClass = Main.GetClass("JoinSessionCallbackProxy");
        }
        internal unsafe JoinSessionCallbackProxy_fields* JoinSessionCallbackProxy_ptr => (JoinSessionCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator JoinSessionCallbackProxy(IntPtr p) => UObject.Make<JoinSessionCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static JoinSessionCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static JoinSessionCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
