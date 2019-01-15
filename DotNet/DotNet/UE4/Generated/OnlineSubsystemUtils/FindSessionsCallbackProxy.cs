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
    ///<summary>Find Sessions Callback Proxy</summary>
    public unsafe partial class FindSessionsCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Searches for advertised sessions with the default online subsystem</summary>
        public static FindSessionsCallbackProxy FindSessions(UObject WorldContextObject, PlayerController PlayerController, int MaxResults, bool bUseLAN)  => 
            FindSessionsCallbackProxy_methods.FindSessions_method.Invoke(WorldContextObject, PlayerController, MaxResults, bUseLAN);

        ///<summary>Get Current Players</summary>
        public static int GetCurrentPlayers(BlueprintSessionResult Result)  => 
            FindSessionsCallbackProxy_methods.GetCurrentPlayers_method.Invoke(Result);

        ///<summary>Get Max Players</summary>
        public static int GetMaxPlayers(BlueprintSessionResult Result)  => 
            FindSessionsCallbackProxy_methods.GetMaxPlayers_method.Invoke(Result);

        ///<summary>Get Ping in Ms</summary>
        public static int GetPingInMs(BlueprintSessionResult Result)  => 
            FindSessionsCallbackProxy_methods.GetPingInMs_method.Invoke(Result);

        ///<summary>Get Server Name</summary>
        public static string GetServerName(BlueprintSessionResult Result)  => 
            FindSessionsCallbackProxy_methods.GetServerName_method.Invoke(Result);
         //TODO: multicast delegate FBlueprintFindSessionsResultDelegate OnSuccess
         //TODO: multicast delegate FBlueprintFindSessionsResultDelegate OnFailure
        static FindSessionsCallbackProxy() {
            StaticClass = Main.GetClass("FindSessionsCallbackProxy");
        }
        internal unsafe FindSessionsCallbackProxy_fields* FindSessionsCallbackProxy_ptr => (FindSessionsCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FindSessionsCallbackProxy(IntPtr p) => UObject.Make<FindSessionsCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FindSessionsCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FindSessionsCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
