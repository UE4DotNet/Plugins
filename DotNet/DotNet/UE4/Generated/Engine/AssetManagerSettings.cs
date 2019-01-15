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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Settings for the Asset Management framework, which can be used to discover, load, and audit game-specific asset types</summary>
    public unsafe partial class AssetManagerSettings : DeveloperSettings  {
         //TODO: array not UObject TArray PrimaryAssetTypesToScan
         //TODO: array not UObject TArray DirectoriesToExclude
         //TODO: array not UObject TArray PrimaryAssetRules
        public bool bOnlyCookProductionAssets {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyCookProductionAssets"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlyCookProductionAssets", value); }
        }
        public bool bShouldManagerDetermineTypeAndName {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldManagerDetermineTypeAndName"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldManagerDetermineTypeAndName", value); }
        }
        public bool bShouldGuessTypeAndNameInEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldGuessTypeAndNameInEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldGuessTypeAndNameInEditor", value); }
        }
        public bool bShouldAcquireMissingChunksOnLoad {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldAcquireMissingChunksOnLoad"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldAcquireMissingChunksOnLoad", value); }
        }
         //TODO: array not UObject TArray PrimaryAssetIdRedirects
         //TODO: array not UObject TArray PrimaryAssetTypeRedirects
         //TODO: array not UObject TArray AssetPathRedirects
         //TODO: set TSet MetaDataTagsForAssetRegistry
        static AssetManagerSettings() {
            StaticClass = Main.GetClass("AssetManagerSettings");
        }
        internal unsafe AssetManagerSettings_fields* AssetManagerSettings_ptr => (AssetManagerSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetManagerSettings(IntPtr p) => UObject.Make<AssetManagerSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetManagerSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetManagerSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
