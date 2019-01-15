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
    public unsafe partial class TurnBasedBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>out</summary>
        public static bool GetIsMyTurn(UObject WorldContextObject, PlayerController PlayerController, string MatchID)  => 
            TurnBasedBlueprintLibrary_methods.GetIsMyTurn_method.Invoke(WorldContextObject, PlayerController, MatchID);

        ///<summary>out</summary>
        public static int GetMyPlayerIndex(UObject WorldContextObject, PlayerController PlayerController, string MatchID)  => 
            TurnBasedBlueprintLibrary_methods.GetMyPlayerIndex_method.Invoke(WorldContextObject, PlayerController, MatchID);

        ///<summary>out</summary>
        public static string GetPlayerDisplayName(UObject WorldContextObject, PlayerController PlayerController, string MatchID, int PlayerIndex)  => 
            TurnBasedBlueprintLibrary_methods.GetPlayerDisplayName_method.Invoke(WorldContextObject, PlayerController, MatchID, PlayerIndex);

        ///<summary>Register Turn Based Match Interface Object</summary>
        public static void RegisterTurnBasedMatchInterfaceObject(UObject WorldContextObject, PlayerController PlayerController, UObject UObject)  => 
            TurnBasedBlueprintLibrary_methods.RegisterTurnBasedMatchInterfaceObject_method.Invoke(WorldContextObject, PlayerController, UObject);
        static TurnBasedBlueprintLibrary() {
            StaticClass = Main.GetClass("TurnBasedBlueprintLibrary");
        }
        internal unsafe TurnBasedBlueprintLibrary_fields* TurnBasedBlueprintLibrary_ptr => (TurnBasedBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TurnBasedBlueprintLibrary(IntPtr p) => UObject.Make<TurnBasedBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TurnBasedBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TurnBasedBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
