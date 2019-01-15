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
    ///<summary>Achievement Write Callback Proxy</summary>
    public unsafe partial class AchievementWriteCallbackProxy : OnlineBlueprintCallProxyBase  {

        ///<summary>
        ///Writes progress about an achievement to the default online subsystem
        ///  AchievementName is the ID of the achievement to update progress on
        ///  Progress is the reported progress toward accomplishing the achievement
        ///</summary>
        ///<remarks>UserTag is not used internally, but it is returned on success or failure</remarks>
        public static AchievementWriteCallbackProxy WriteAchievementProgress(UObject WorldContextObject, PlayerController PlayerController, Name AchievementName, float Progress, int UserTag)  => 
            AchievementWriteCallbackProxy_methods.WriteAchievementProgress_method.Invoke(WorldContextObject, PlayerController, AchievementName, Progress, UserTag);
         //TODO: multicast delegate FAchievementWriteDelegate OnSuccess
         //TODO: multicast delegate FAchievementWriteDelegate OnFailure
        static AchievementWriteCallbackProxy() {
            StaticClass = Main.GetClass("AchievementWriteCallbackProxy");
        }
        internal unsafe AchievementWriteCallbackProxy_fields* AchievementWriteCallbackProxy_ptr => (AchievementWriteCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AchievementWriteCallbackProxy(IntPtr p) => UObject.Make<AchievementWriteCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AchievementWriteCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AchievementWriteCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
