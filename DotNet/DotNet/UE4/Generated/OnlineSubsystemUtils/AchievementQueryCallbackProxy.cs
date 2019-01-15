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
    ///<summary>Achievement Query Callback Proxy</summary>
    public unsafe partial class AchievementQueryCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>Fetches and caches achievement descriptions from the default online subsystem</summary>
        public static AchievementQueryCallbackProxy CacheAchievementDescriptions(UObject WorldContextObject, PlayerController PlayerController)  => 
            AchievementQueryCallbackProxy_methods.CacheAchievementDescriptions_method.Invoke(WorldContextObject, PlayerController);

        ///<summary>Fetches and caches achievement progress from the default online subsystem</summary>
        public static AchievementQueryCallbackProxy CacheAchievements(UObject WorldContextObject, PlayerController PlayerController)  => 
            AchievementQueryCallbackProxy_methods.CacheAchievements_method.Invoke(WorldContextObject, PlayerController);
         //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
         //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
        static AchievementQueryCallbackProxy() {
            StaticClass = Main.GetClass("AchievementQueryCallbackProxy");
        }
        internal unsafe AchievementQueryCallbackProxy_fields* AchievementQueryCallbackProxy_ptr => (AchievementQueryCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AchievementQueryCallbackProxy(IntPtr p) => UObject.Make<AchievementQueryCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AchievementQueryCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AchievementQueryCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
