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
    ///<summary>A beacon host used for taking reservations for an existing game session</summary>
    public unsafe partial class LeaderboardBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Writes an integer value to the specified leaderboard</summary>
        public static bool WriteLeaderboardInteger(PlayerController PlayerController, Name StatName, int StatValue)  => 
            LeaderboardBlueprintLibrary_methods.WriteLeaderboardInteger_method.Invoke(PlayerController, StatName, StatValue);
        static LeaderboardBlueprintLibrary() {
            StaticClass = Main.GetClass("LeaderboardBlueprintLibrary");
        }
        internal unsafe LeaderboardBlueprintLibrary_fields* LeaderboardBlueprintLibrary_ptr => (LeaderboardBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LeaderboardBlueprintLibrary(IntPtr p) => UObject.Make<LeaderboardBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LeaderboardBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LeaderboardBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
