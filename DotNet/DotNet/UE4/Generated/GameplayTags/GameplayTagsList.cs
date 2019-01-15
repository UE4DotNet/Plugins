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
    ///<summary>Base class for storing a list of gameplay tags as an ini list. This is used for both the central list and additional lists</summary>
    public unsafe partial class GameplayTagsList : UObject  {
         //TODO: string FString ConfigFileName
         //TODO: array not UObject TArray GameplayTagList
        static GameplayTagsList() {
            StaticClass = Main.GetClass("GameplayTagsList");
        }
        internal unsafe GameplayTagsList_fields* GameplayTagsList_ptr => (GameplayTagsList_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTagsList(IntPtr p) => UObject.Make<GameplayTagsList>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTagsList DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTagsList New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
