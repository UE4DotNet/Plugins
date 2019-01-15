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
using UE4.Kismet.Native;

namespace UE4.Kismet {
    ///<summary>FBlueprintPaletteFavorites</summary>
    public unsafe partial class BlueprintPaletteFavorites : UObject  {
         //TODO: array not UObject TArray CustomFavorites
         //TODO: array not UObject TArray CurrentFavorites
         //TODO: string FString CurrentProfile
        static BlueprintPaletteFavorites() {
            StaticClass = Main.GetClass("BlueprintPaletteFavorites");
        }
        internal unsafe BlueprintPaletteFavorites_fields* BlueprintPaletteFavorites_ptr => (BlueprintPaletteFavorites_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintPaletteFavorites(IntPtr p) => UObject.Make<BlueprintPaletteFavorites>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintPaletteFavorites DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintPaletteFavorites New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
