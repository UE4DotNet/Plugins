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
    ///<summary>Leaderboard Query Callback Proxy</summary>
    public unsafe partial class LeaderboardQueryCallbackProxy : UObject  {

        ///<summary>Queries a leaderboard for an integer value</summary>
        public static LeaderboardQueryCallbackProxy CreateProxyObjectForIntQuery(PlayerController PlayerController, Name StatName)  => 
            LeaderboardQueryCallbackProxy_methods.CreateProxyObjectForIntQuery_method.Invoke(PlayerController, StatName);
         //TODO: multicast delegate FLeaderboardQueryResult OnSuccess
         //TODO: multicast delegate FLeaderboardQueryResult OnFailure
        static LeaderboardQueryCallbackProxy() {
            StaticClass = Main.GetClass("LeaderboardQueryCallbackProxy");
        }
        internal unsafe LeaderboardQueryCallbackProxy_fields* LeaderboardQueryCallbackProxy_ptr => (LeaderboardQueryCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LeaderboardQueryCallbackProxy(IntPtr p) => UObject.Make<LeaderboardQueryCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LeaderboardQueryCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LeaderboardQueryCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
