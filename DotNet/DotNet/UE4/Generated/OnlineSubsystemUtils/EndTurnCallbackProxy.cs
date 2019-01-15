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
    ///<summary>End Turn Callback Proxy</summary>
    public unsafe partial class EndTurnCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Ends the turn for the current player</summary>
        public static EndTurnCallbackProxy EndTurn(UObject WorldContextObject, PlayerController PlayerController, string MatchID, byte TurnBasedMatchInterface /*TODO: interface TScriptInterface */)  => 
            EndTurnCallbackProxy_methods.EndTurn_method.Invoke(WorldContextObject, PlayerController, MatchID, TurnBasedMatchInterface);
         //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
         //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
        static EndTurnCallbackProxy() {
            StaticClass = Main.GetClass("EndTurnCallbackProxy");
        }
        internal unsafe EndTurnCallbackProxy_fields* EndTurnCallbackProxy_ptr => (EndTurnCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EndTurnCallbackProxy(IntPtr p) => UObject.Make<EndTurnCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EndTurnCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EndTurnCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
