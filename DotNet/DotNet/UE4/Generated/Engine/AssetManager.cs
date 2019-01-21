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
    ///<summary>A singleton UObject that is responsible for loading and unloading PrimaryAssets, and maintaining game-specific asset references</summary>
    ///<remarks>Games should override this class and change the class reference</remarks>
    public unsafe partial class AssetManager : UObject  {
        ///<summary>List of UObjects that are being kept from being GCd, derived from the asset type map. Arrays are currently more efficient than Sets</summary>
        public ObjectArrayField<UObject> ObjectReferenceList{ get {
            if(ObjectReferenceList_store == null) ObjectReferenceList_store = new ObjectArrayField<UObject> (&AssetManager_ptr->ObjectReferenceList);
            return ObjectReferenceList_store;
        } }
        private ObjectArrayField<UObject> ObjectReferenceList_store;

        public bool bIsGlobalAsyncScanEnvironment {
            get {return Main.GetGetBoolPropertyByName(this, "bIsGlobalAsyncScanEnvironment"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsGlobalAsyncScanEnvironment", value); }
        }
        public bool bShouldGuessTypeAndName {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldGuessTypeAndName"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldGuessTypeAndName", value); }
        }
        public bool bShouldUseSynchronousLoad {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldUseSynchronousLoad"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldUseSynchronousLoad", value); }
        }
        public bool bIsLoadingFromPakFiles {
            get {return Main.GetGetBoolPropertyByName(this, "bIsLoadingFromPakFiles"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsLoadingFromPakFiles", value); }
        }
        public bool bShouldAcquireMissingChunksOnLoad {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldAcquireMissingChunksOnLoad"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldAcquireMissingChunksOnLoad", value); }
        }
        public bool bOnlyCookProductionAssets {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyCookProductionAssets"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlyCookProductionAssets", value); }
        }
        public bool bIsBulkScanning {
            get {return Main.GetGetBoolPropertyByName(this, "bIsBulkScanning"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsBulkScanning", value); }
        }
        public bool bIsPrimaryAssetDirectoryCurrent {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPrimaryAssetDirectoryCurrent"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsPrimaryAssetDirectoryCurrent", value); }
        }
        public bool bIsManagementDatabaseCurrent {
            get {return Main.GetGetBoolPropertyByName(this, "bIsManagementDatabaseCurrent"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsManagementDatabaseCurrent", value); }
        }
        public bool bUpdateManagementDatabaseAfterScan {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateManagementDatabaseAfterScan"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateManagementDatabaseAfterScan", value); }
        }
        public bool bIncludeOnlyOnDiskAssets {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeOnlyOnDiskAssets"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeOnlyOnDiskAssets", value); }
        }
        ///<summary>Number of notifications seen in this update</summary>
        public unsafe int NumberOfSpawnedNotifications {
            get {return AssetManager_ptr->NumberOfSpawnedNotifications;}
            set {AssetManager_ptr->NumberOfSpawnedNotifications = value;}
        }
        static AssetManager() {
            StaticClass = Main.GetClass("AssetManager");
        }
        internal unsafe AssetManager_fields* AssetManager_ptr => (AssetManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetManager(IntPtr p) => UObject.Make<AssetManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
