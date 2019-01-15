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
    ///<summary>Find Turn Based Match Callback Proxy</summary>
    public unsafe partial class FindTurnBasedMatchCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Use the platform matchmaking service (like Game Center) to find a match.</summary>
        public static FindTurnBasedMatchCallbackProxy FindTurnBasedMatch(UObject WorldContextObject, PlayerController PlayerController, byte MatchActor /*TODO: interface TScriptInterface */, int MinPlayers, int MaxPlayers, int PlayerGroup, bool ShowExistingMatches)  => 
            FindTurnBasedMatchCallbackProxy_methods.FindTurnBasedMatch_method.Invoke(WorldContextObject, PlayerController, MatchActor, MinPlayers, MaxPlayers, PlayerGroup, ShowExistingMatches);
         //TODO: multicast delegate FOnlineTurnBasedMatchResult OnSuccess
         //TODO: multicast delegate FOnlineTurnBasedMatchResult OnFailure
        static FindTurnBasedMatchCallbackProxy() {
            StaticClass = Main.GetClass("FindTurnBasedMatchCallbackProxy");
        }
        internal unsafe FindTurnBasedMatchCallbackProxy_fields* FindTurnBasedMatchCallbackProxy_ptr => (FindTurnBasedMatchCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FindTurnBasedMatchCallbackProxy(IntPtr p) => UObject.Make<FindTurnBasedMatchCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FindTurnBasedMatchCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FindTurnBasedMatchCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
