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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Hierarchical LODSettings</summary>
    public unsafe partial class HierarchicalLODSettings : DeveloperSettings  {
        public bool bForceSettingsInAllMaps {
            get {return Main.GetGetBoolPropertyByName(this, "bForceSettingsInAllMaps"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceSettingsInAllMaps", value); }
        }
         //TODO: soft class TSoftClassPtr<UHierarchicalLODSetup>  DefaultSetup
         //TODO: array not UObject TArray DirectoriesForHLODCommandlet
         //TODO: array not UObject TArray MapsToBuild
        public bool bInvalidateHLODClusters {
            get {return Main.GetGetBoolPropertyByName(this, "bInvalidateHLODClusters"); }
            set {Main.SetGetBoolPropertyByName(this, "bInvalidateHLODClusters", value); }
        }
        public bool bDeleteHLODAssets {
            get {return Main.GetGetBoolPropertyByName(this, "bDeleteHLODAssets"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeleteHLODAssets", value); }
        }
         //TODO: soft object TSoftObjectPtr<UMaterialInterface> BaseMaterial
        static HierarchicalLODSettings() {
            StaticClass = Main.GetClass("HierarchicalLODSettings");
        }
        internal unsafe HierarchicalLODSettings_fields* HierarchicalLODSettings_ptr => (HierarchicalLODSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HierarchicalLODSettings(IntPtr p) => UObject.Make<HierarchicalLODSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HierarchicalLODSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HierarchicalLODSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
