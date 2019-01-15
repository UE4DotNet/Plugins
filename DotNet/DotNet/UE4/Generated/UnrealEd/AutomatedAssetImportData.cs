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
    public unsafe partial class AutomatedAssetImportData : UObject  {
         //TODO: string FString GroupName
         //TODO: array not UObject TArray Filenames
         //TODO: string FString DestinationPath
         //TODO: string FString FactoryName
        public bool bReplaceExisting {
            get {return Main.GetGetBoolPropertyByName(this, "bReplaceExisting"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplaceExisting", value); }
        }
        public bool bSkipReadOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipReadOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipReadOnly", value); }
        }
        ///<summary>Pointer to the factory currently being sued</summary>
        public unsafe Factory Factory {
            get {return AutomatedAssetImportData_ptr->Factory;}
            set {AutomatedAssetImportData_ptr->Factory = value;}
        }
         //TODO: string FString LevelToLoad
        static AutomatedAssetImportData() {
            StaticClass = Main.GetClass("AutomatedAssetImportData");
        }
        internal unsafe AutomatedAssetImportData_fields* AutomatedAssetImportData_ptr => (AutomatedAssetImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AutomatedAssetImportData(IntPtr p) => UObject.Make<AutomatedAssetImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AutomatedAssetImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AutomatedAssetImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
