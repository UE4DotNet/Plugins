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
    ///<summary>Library of synchronous achievement calls</summary>
    public unsafe partial class AchievementBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>out</summary>
        public static (bool, byte /*TODO: text FText*/, byte /*TODO: text FText*/, byte /*TODO: text FText*/, bool) GetCachedAchievementDescription(UObject WorldContextObject, PlayerController PlayerController, Name AchievementID)  => 
            AchievementBlueprintLibrary_methods.GetCachedAchievementDescription_method.Invoke(WorldContextObject, PlayerController, AchievementID);

        ///<summary>out</summary>
        public static (bool, float) GetCachedAchievementProgress(UObject WorldContextObject, PlayerController PlayerController, Name AchievementID)  => 
            AchievementBlueprintLibrary_methods.GetCachedAchievementProgress_method.Invoke(WorldContextObject, PlayerController, AchievementID);
        static AchievementBlueprintLibrary() {
            StaticClass = Main.GetClass("AchievementBlueprintLibrary");
        }
        internal unsafe AchievementBlueprintLibrary_fields* AchievementBlueprintLibrary_ptr => (AchievementBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AchievementBlueprintLibrary(IntPtr p) => UObject.Make<AchievementBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AchievementBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AchievementBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
