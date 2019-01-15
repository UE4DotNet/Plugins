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
    ///<summary>End Match Callback Proxy</summary>
    public unsafe partial class EndMatchCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>End a match that is in progress while it is the current player's turn</summary>
        public static EndMatchCallbackProxy EndMatch(UObject WorldContextObject, PlayerController PlayerController, byte MatchActor /*TODO: interface TScriptInterface */, string MatchID, byte LocalPlayerOutcome, byte OtherPlayersOutcome)  => 
            EndMatchCallbackProxy_methods.EndMatch_method.Invoke(WorldContextObject, PlayerController, MatchActor, MatchID, LocalPlayerOutcome, OtherPlayersOutcome);
         //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
         //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
        static EndMatchCallbackProxy() {
            StaticClass = Main.GetClass("EndMatchCallbackProxy");
        }
        internal unsafe EndMatchCallbackProxy_fields* EndMatchCallbackProxy_ptr => (EndMatchCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EndMatchCallbackProxy(IntPtr p) => UObject.Make<EndMatchCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EndMatchCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EndMatchCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
