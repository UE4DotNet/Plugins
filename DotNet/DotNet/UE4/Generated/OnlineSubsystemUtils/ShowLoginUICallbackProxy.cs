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
    ///<summary>Show Login UICallback Proxy</summary>
    public unsafe partial class ShowLoginUICallbackProxy : BlueprintAsyncActionBase  {

        ///<summary>Shows the login UI for the currently active online subsystem, if the subsystem supports a login UI.</summary>
        public static ShowLoginUICallbackProxy ShowExternalLoginUI(UObject WorldContextObject, PlayerController InPlayerController)  => 
            ShowLoginUICallbackProxy_methods.ShowExternalLoginUI_method.Invoke(WorldContextObject, InPlayerController);
         //TODO: multicast delegate FOnlineShowLoginUIResult OnSuccess
         //TODO: multicast delegate FOnlineShowLoginUIResult OnFailure
        static ShowLoginUICallbackProxy() {
            StaticClass = Main.GetClass("ShowLoginUICallbackProxy");
        }
        internal unsafe ShowLoginUICallbackProxy_fields* ShowLoginUICallbackProxy_ptr => (ShowLoginUICallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ShowLoginUICallbackProxy(IntPtr p) => UObject.Make<ShowLoginUICallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ShowLoginUICallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ShowLoginUICallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
