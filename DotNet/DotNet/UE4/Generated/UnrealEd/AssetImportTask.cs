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

namespace UE4.UnrealEd {
    ///<summary>Contains data for a group of assets to import</summary>
    public unsafe partial class AssetImportTask : UObject  {
         //TODO: string FString Filename
         //TODO: string FString DestinationPath
         //TODO: string FString DestinationName
        public bool bReplaceExisting {
            get {return Main.GetGetBoolPropertyByName(this, "bReplaceExisting"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplaceExisting", value); }
        }
        public bool bAutomated {
            get {return Main.GetGetBoolPropertyByName(this, "bAutomated"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutomated", value); }
        }
        public bool bSave {
            get {return Main.GetGetBoolPropertyByName(this, "bSave"); }
            set {Main.SetGetBoolPropertyByName(this, "bSave", value); }
        }
        ///<summary>Import options specific to the type of asset</summary>
        public unsafe UObject Options {
            get {return AssetImportTask_ptr->Options;}
            set {AssetImportTask_ptr->Options = value;}
        }
         //TODO: array not UObject TArray ImportedObjectPaths
        static AssetImportTask() {
            StaticClass = Main.GetClass("AssetImportTask");
        }
        internal unsafe AssetImportTask_fields* AssetImportTask_ptr => (AssetImportTask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetImportTask(IntPtr p) => UObject.Make<AssetImportTask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetImportTask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetImportTask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
