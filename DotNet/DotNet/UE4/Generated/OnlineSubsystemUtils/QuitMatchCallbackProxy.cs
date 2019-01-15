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
    ///<summary>Quit Match Callback Proxy</summary>
    public unsafe partial class QuitMatchCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Quits the turn based match</summary>
        public static QuitMatchCallbackProxy QuitMatch(UObject WorldContextObject, PlayerController PlayerController, string MatchID, byte Outcome, int TurnTimeoutInSeconds)  => 
            QuitMatchCallbackProxy_methods.QuitMatch_method.Invoke(WorldContextObject, PlayerController, MatchID, Outcome, TurnTimeoutInSeconds);
         //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
         //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
        static QuitMatchCallbackProxy() {
            StaticClass = Main.GetClass("QuitMatchCallbackProxy");
        }
        internal unsafe QuitMatchCallbackProxy_fields* QuitMatchCallbackProxy_ptr => (QuitMatchCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator QuitMatchCallbackProxy(IntPtr p) => UObject.Make<QuitMatchCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static QuitMatchCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static QuitMatchCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
