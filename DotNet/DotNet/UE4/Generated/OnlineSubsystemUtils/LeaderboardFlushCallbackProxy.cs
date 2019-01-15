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
    ///<summary>Leaderboard Flush Callback Proxy</summary>
    public unsafe partial class LeaderboardFlushCallbackProxy : UObject  {

        ///<summary>Called to perform the query internally</summary>
        public static LeaderboardFlushCallbackProxy CreateProxyObjectForFlush(PlayerController PlayerController, Name SessionName)  => 
            LeaderboardFlushCallbackProxy_methods.CreateProxyObjectForFlush_method.Invoke(PlayerController, SessionName);
         //TODO: multicast delegate FOnLeaderboardFlushed OnSuccess
         //TODO: multicast delegate FOnLeaderboardFlushed OnFailure
        static LeaderboardFlushCallbackProxy() {
            StaticClass = Main.GetClass("LeaderboardFlushCallbackProxy");
        }
        internal unsafe LeaderboardFlushCallbackProxy_fields* LeaderboardFlushCallbackProxy_ptr => (LeaderboardFlushCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LeaderboardFlushCallbackProxy(IntPtr p) => UObject.Make<LeaderboardFlushCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LeaderboardFlushCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LeaderboardFlushCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
