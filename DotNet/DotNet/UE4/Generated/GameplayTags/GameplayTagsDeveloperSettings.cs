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
using UE4.GameplayTags.Native;

namespace UE4.GameplayTags {
    ///<summary>Gameplay Tags Developer Settings</summary>
    public unsafe partial class GameplayTagsDeveloperSettings : UObject  {
         //TODO: string FString DeveloperConfigName
        static GameplayTagsDeveloperSettings() {
            StaticClass = Main.GetClass("GameplayTagsDeveloperSettings");
        }
        internal unsafe GameplayTagsDeveloperSettings_fields* GameplayTagsDeveloperSettings_ptr => (GameplayTagsDeveloperSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTagsDeveloperSettings(IntPtr p) => UObject.Make<GameplayTagsDeveloperSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTagsDeveloperSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTagsDeveloperSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
